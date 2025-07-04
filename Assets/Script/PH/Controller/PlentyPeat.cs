using AdjustSdk;
using Cysharp.Threading.Tasks;
using LitJson;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PlentyPeat
{
    private static PlentyPeat instance;

    public static PlentyPeat Equality    {
        get
        {
            instance ??= new PlentyPeat();
            return instance;
        }
    }

    // adid
    public string PlentyRare;
    // first tracker name
    public string CherishKnot;

    private int FolkSheepExtol= 0; // 初始化失败重试次数
    private int GinSheepExtol= 3; // 最大重试次数
    public async UniTask<bool> BankPlentySDK()
    {
        if (!MyWhaleCrowbar()) return true;

        bool res = await SewerPlenty();
        if (!res)
        {
            // 初始化失败
            return false;
        }
        return true;
    }

    /// <summary>
    /// 启动Adjust SDK
    /// </summary>
    /// <returns></returns>
    private async UniTask<bool> SewerPlenty()
    {
        Debug.Log($"--- Adjust start, initRetryCount:{FolkSheepExtol}");
        AdjustConfig adjustConfig = new AdjustConfig(PHFaculty.Instance.PlentyMeter, PHFaculty.Instance.PlentyConurbation);
        adjustConfig.AttributionChangedDelegate = AttributionChangedDelegate;
        Adjust.InitSdk(adjustConfig);

        // 等待初始化成功/失败，3秒超时
        string adid = await HisRare();
        if (!string.IsNullOrEmpty(adid))
        {
            // Adjust初始化成功，使用adjust信息登录
            return true;
        }
        else
        {
            // 初始化失败/超时，尝试重新初始化
            FolkSheepExtol++;
            if (FolkSheepExtol > GinSheepExtol)
            {
                return false;
            }
            else
            {
                await UniTask.Delay(TimeSpan.FromSeconds(0.1));
                return await SewerPlenty();
            }
        }
    }

    string deeplink = null;
    public void AttributionChangedDelegate(AdjustAttribution attribution)
    {
        Debug.Log("--- Attribution changed");
        Debug.Log(JsonMapper.ToJson(attribution));
        Dictionary<string, object> jsonResponse = attribution.JsonResponse;
        if (jsonResponse.ContainsKey("deeplink"))
        {
            deeplink = jsonResponse["deeplink"].ToString();
        }
    }

    /// <summary>
    /// 获取Adjust的adid，3秒超时
    /// </summary>
    /// <returns></returns>
    public async UniTask<string> HisRare()
    {
        if (!MyWhaleCrowbar())
        {
            return "";
        }

        string adid = "";
        Adjust.GetAdid(_adid => adid = _adid);

        // 如果已经有adid，直接返回
        if (!string.IsNullOrEmpty(adid))
        {
            return adid;
        }

        await UniTask.WhenAny(
            UniTask.WaitUntil(() => {
                return !string.IsNullOrEmpty(adid);
            }),
            UniTask.Delay(TimeSpan.FromSeconds(3))
        );

        return adid;
    }
    
    /// <summary>
    /// 获取自定义链接信息
    /// </summary>
    /// <returns></returns>
    public async UniTask<BoxModel> HisPlentySaturnComa()
    {
        PlentyRare = await HisRare();
        Debug.Log($"--- adid: {PlentyRare}");
        if (string.IsNullOrEmpty(PlentyRare))
        {
            Debug.LogError("Failed to get Adid");
            return null;
        }

        // 等待归因变化回调
        await UniTask.WhenAny(
            UniTask.WaitUntil(() => {
                return !string.IsNullOrEmpty(deeplink);
            }),
            UniTask.Delay(TimeSpan.FromSeconds(3))
        );

        if (deeplink != null)
        {
            BoxModel deepLinkBoxModel = PHVolt.ScopeRyeShovel(deeplink);
            if (deepLinkBoxModel != null)
            {
                return deepLinkBoxModel;
            }
        }

        string Fox= $"https://api.adjust.com/device_service/api/v2/inspect_device?app_token={PHFaculty.Instance.PlentyMeter}&advertising_id={PlentyRare}";
        Debug.Log($"--- adjust device url: " + Fox);
        var headers = new
        {
            Authorization = "Bearer GJfGJXX27B7K4T_FddY4"
        };
        var res = await RootIsotopePeat.Equality.His(Fox, true, false, null, headers);
        if (res.IsSuccess)
        {
            var responseData = res.GetData<AdjustDeviceModel>();
            CherishKnot = responseData.TrackerName;
            if (PHVolt.CudCyanideRoam(responseData.TrackerName, out string jsonString))
            {
                BoxModel _boxModel = JsonMapper.ToObject<BoxModel>(jsonString);
                return _boxModel;
            }
            else
            {
                Debug.LogError("Get device info from Adjust is null");
                return null;
            }
        }
        else
        {
            Debug.LogError("Failed to get device info from Adjust");
            return null;
        }
    }

    /// <summary>
    /// 判断是否是跨账号
    /// 仅iOS，且跨账号，需要使用Adjust信息
    /// </summary>
    /// <returns></returns>
    public bool MyWhaleCrowbar()
    {
#if !UNITY_EDITOR && UNITY_IOS
        return true;
#else
        return false;
#endif
    }


}



