using LitJson;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

/// <summary>
/// 编辑器中的NativeService实现
/// </summary>
public class FamineSilentBifocal : ISilentBifocal
{
    public Task<string> GetVisitorId()
    {
        //编辑器中，如果有本地存档，则返回本地存档的visitorId，否则返回UUID
        DeftStorm savedUserInfo = GetSavedUserInfo();
        return savedUserInfo == null? Task.FromResult(PHVolt.HisUUID()) : Task.FromResult(savedUserInfo.visitorId);
    }

    public Task<string> GetUserAgent()
    {
        return Task.FromResult($"Unity/{Application.unityVersion} ({SystemInfo.deviceModel})");
    }

    public string GetInstallTime()
    {
        DateTime installTime = Directory.GetCreationTime(Application.persistentDataPath);
        return PHVolt.HisMachinery(installTime).ToString();
    }

    public int GetAppBuildVer()
    {
        int appBuildVerLast = 0;    // APP构建版本号
#if UNITY_EDITOR && UNITY_ANDROID
        appBuildVerLast = PlayerSettings.Android.bundleVersionCode;
#elif UNITY_EDITOR && UNITY_IOS
        appBuildVerLast = int.Parse(PlayerSettings.iOS.buildNumber);
#endif
        return appBuildVerLast;
    }

    public Task<BoxModel> GetSharedData()
    {
        return Task.FromResult<BoxModel>(null);
    }

    /// <summary>
    /// 设置共享区域数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public string SetSharedData(string value)
    {
        return "1";
    }

    /// <summary>
    /// 获取存档的用户信息
    /// </summary>
    /// <returns></returns>
    public DeftStorm GetSavedUserInfo()
    {
        string savedKeychain = PHMindGazeFaculty.GetString("PH_user_info");
        if (!string.IsNullOrEmpty(savedKeychain) && PHVolt.MyMuralRoam(savedKeychain))
        {
            DeftStorm userModel = JsonMapper.ToObject<DeftStorm>(savedKeychain);
            if (string.IsNullOrEmpty(userModel.visitorId))
            {
                return null;
            }
            else
            {
                return userModel;
            }
        }
        return null;
    }

    /// <summary>
    /// 保存用户信息到存档
    /// </summary>
    /// <param name="userModel"></param>
    public void SaveUserInfo(DeftStorm userModel)
    {
        string str = JsonMapper.ToJson(userModel);
        PHMindGazeFaculty.SetString("PH_user_info", str);
    }

    public void ClearSavedUserInfo()
    {
        PHMindGazeFaculty.SetString("PH_user_info", "");
    }

    /// <summary>
    /// 风控检测（获取device token）
    /// 异步方法，参数为获取token后的回调
    /// </summary>
    /// <param name="callback"></param>
    public void RiskManagement(Action<string> callback)
    {
        callback(null);
    }

    /// <summary>
    /// 设备Token回调
    /// </summary>
    /// <param name="deviceToken"></param>
    public void OnDeviceTokenReceived(string deviceToken)
    {

    }

    /// <summary>
    /// 检测是否开启VPN
    /// </summary>
    /// <returns>1：未开启；2：开启；</returns>
    public string CheckVPN()
    {
        return "1";
    }

    /// <summary>
    /// 获取逻辑分辨率
    /// </summary>
    /// <returns></returns>
    public Vector2 GetLogicalSize()
    {
        return new Vector2(Screen.width, Screen.height);
    }

    /// <summary>
    /// 获取传感器数据
    /// </summary>
    public ClementStorm GetSensorsData()
    {
        ClementStorm model = new ClementStorm();
        return model;
    }
}
