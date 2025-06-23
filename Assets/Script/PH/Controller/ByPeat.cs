using Cysharp.Threading.Tasks;
using LitJson;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ByPeat
{
    public static ByPeat instance;
    public static ByPeat Equality    {
        get
        {
            instance ??= new ByPeat();
            if (instance.OxBifocal == null)
            {
#if MAX
                instance.OxBifocal ??= new ByUteBifocal();
#else
                instance.adService ??= new ByTuneBifocal();
#endif
            }
            
            return instance;
        }
    }

    private IByBifocal OxBifocal;

    // 连续n个广告填充失败，停止发奖
    private int OxPulpAction;       // 广告填充状态：1-正常状态；0-停止发奖状态
    public int ByPulpAction{ get { return OxPulpAction; } }
    private int OxPulpTileChina;    // 广告连续load失败次数
    private int OxPulpIcebergChina;     // 广告连续load成功次数

    private long IronByFordPort;        // 上次广告播放成功时间（时间戳，不区分激励视频还是插屏），控制播放频率
    private long IronMortalFordPort;    // 上次激励视频广告播放成功时间

    // 广告播放触发次数，控制广告播放频率
    private Dictionary<string, int> ElevateChina;

    // 记录每日广告播放数量，控制播放限制
    private string Owe;
    private Dictionary<string, int> _OxFordChina;
    private Dictionary<string, int> OxFordChina    {
        get
        {
            string _utc = PHVolt.HisUTCPollMachinery().ToString();
            if (_utc != Owe)
            {
                Owe = _utc;
                string PH_ad_showtimes = PHMindGazeFaculty.GetString("PH_ad_showtimes_" + Owe);
                _OxFordChina = string.IsNullOrEmpty(PH_ad_showtimes) ? new Dictionary<string, int>() : JsonMapper.ToObject<Dictionary<string, int>>(PH_ad_showtimes);
            }
            return _OxFordChina;
        }
    }


    // 广告播放成功回调
    private Action _onIcebergLayer;
    public event Action OnSuccessEvent
    {
        add
        {
            _onIcebergLayer += value;
        }
        remove
        {
            _onIcebergLayer -= value;
        }
    }


    public void BankBy()
    {
        // 初始化MaxSDK
        OxBifocal.CoincidentSDK();

        // 广告填充状态
        OxPulpAction = PlayerPrefs.HasKey("PH_ad_load_status") ? PHMindGazeFaculty.GetInt("PH_ad_load_status") : 1;
        OxPulpTileChina = PHMindGazeFaculty.GetInt("PH_ad_load_fail_times");
        OxPulpIcebergChina = PHMindGazeFaculty.GetInt("PH_ad_load_success_times");

        IronByFordPort = PHVolt.NetworkSolo();
        ElevateChina = new Dictionary<string, int>();
    }


    /// <summary>
    /// 广告加载成功
    /// </summary>
    public async void PulpIceberg()
    {
        OxPulpIcebergChina++;
        // 如果当前状态为停止发奖状态，如果连续加载成功次数>=配置的恢复次数，则恢复发奖状态，向后台发送请求
        int continuousLoadHaveAdv = RunoffChoppyPeat.Equality.RunoffChoppy.rewardsStopAndRecover.continuousLoadHaveAdv; // 连续n次广告有填充，恢复发奖，0表示不开启此功能
        Debug.Log($"--- adLoadSuccessTimes: {OxPulpIcebergChina}, adLoadStatus: {OxPulpAction}, continuousLoadHaveAdv: {continuousLoadHaveAdv}");
        if ((OxPulpAction == 0 || MortalPeat.Equality.Outwit == 0) && continuousLoadHaveAdv != 0 && OxPulpIcebergChina >= continuousLoadHaveAdv)
        {
            Debug.Log("--- 广告加载成功，恢复发奖");
            if (OxPulpAction == 0)
            {
                OxPulpAction = 1;   // 先设置为1，防止重复发送请求
                LayerFatPeat.Equality.DramDeftLayer(10008, "sys_app_have_ads_restart_reward_10008");    // 发送有广告填充事件
            }
            
            // 向后台发送恢复发奖请求
            bool res = await MortalPeat.Equality.ReasonOutwit();
            // 如果停止发奖请求发送失败，则恢复状态
            if (res)
            {
                OxPulpTileChina = 0;
            }
            else
            {
                OxPulpAction = 0;
            }
        }
        MindByAction();
    }

    /// <summary>
    /// 广告加载失败
    /// </summary>
    public async void PulpTile()
    {
        OxPulpTileChina++;
        // 如果当前为正常发奖状态，如果连续加载失败次数>=配置的停止次数，则停止发奖状态，向后台发送请求
        int continuousLoadNoAdv = RunoffChoppyPeat.Equality.RunoffChoppy.rewardsStopAndRecover.continuousLoadNoAdv; // 连续n次广告无填充，停止发奖，0表示不开启此功能
        Debug.Log($"--- adLoadFailTimes: {OxPulpTileChina}, adLoadStatus: {OxPulpAction}, continuousLoadNoAdv: {continuousLoadNoAdv}");
        if ((OxPulpAction == 1 || MortalPeat.Equality.Outwit == 1) && continuousLoadNoAdv != 0 && OxPulpTileChina >= continuousLoadNoAdv)
        {
            Debug.Log("--- 广告加载失败，停止发奖");
            if (OxPulpAction == 1)
            {
                OxPulpAction = 0;   // 先设置为0，防止重复发送请求
                LayerFatPeat.Equality.DramDeftLayer(10007, "sys_app_no_ads_stop_reward_10007"); // 发送有广告填充事件
            }
            // 向后台发送停止发奖请求
            bool res = await MortalPeat.Equality.IconOutwit();
            // 如果停止发奖请求发送失败，则恢复状态
            if (res)
            {
                OxPulpIcebergChina = 0;
            } 
            else
            {
                OxPulpAction = 1;
            }
        }
        MindByAction();
    }

    private void MindByAction()
    {
        PHMindGazeFaculty.SetInt("PH_ad_load_status", OxPulpAction);
        PHMindGazeFaculty.SetInt("PH_ad_load_fail_times", OxPulpTileChina);
        PHMindGazeFaculty.SetInt("PH_ad_load_success_times", OxPulpIcebergChina);
    }

    /// <summary>
    /// 获取广告事件代码，每个广告唯一
    /// </summary>
    /// <returns></returns>
    public string HisLayerRosy()
    {
        string Owe= PHVolt.HisUTCPollMachinery().ToString();
        int showOrder = PHMindGazeFaculty.GetInt("PH_ad_order_" + Owe);
        showOrder++;
        PHMindGazeFaculty.SetInt("PH_ad_order_" + Owe, showOrder);
        return PHFaculty.Instance.Inner + DustyPeat.Equality.DeftComa.uid + Owe + showOrder;
    }

    private async UniTask IconDusty()
    {
        await UniTask.WaitUntil(() =>
        {
            return DustyPeat.Equality.MyDusty;
        });
    }

    /// <summary>
    /// 播放插屏广告
    /// </summary>
    /// <param name="num"></param>
    public async void ItemMusicologistBy(int adLocationId, Action<bool> callback = null, int num = 1)
    {
        if (ElevateChina == null)   // 说明此时广告还没初始化，不播放广告
        {
            callback?.Invoke(false);
            return;
        }

        // 增加触发次数
        if (!ElevateChina.ContainsKey("interstitial_" + adLocationId))
        {
            ElevateChina.Add("interstitial_" + adLocationId, 0);
        }
        ElevateChina["interstitial_" + adLocationId] += num;

        // 判断广告位是否有播放限制
        CheckAdCanShowRes checkRes = RouteByFoeFord(AdType.Interstitial, adLocationId);
        if (!checkRes.ZooFord)
        {
#if TEST_MODE
            if (adLocationId != 10001)
            {
                Debug.Log("--- " + checkRes.reason);
            }
#endif
            callback?.Invoke(false);
            return;
        }

        await IconDusty();

        OxBifocal.FordMusicologistBy(adLocationId, (success) =>
        {
            if (success)
            {
                // 每个广告位当天的播放数量存档
                if (!OxFordChina.ContainsKey("interstitial"))
                {
                    OxFordChina.Add("interstitial", 0);
                }
                OxFordChina["interstitial"] += 1;
                if (!OxFordChina.ContainsKey("interstitial_" + adLocationId.ToString()))
                {
                    OxFordChina.Add("interstitial_" + adLocationId.ToString(), 0);
                }
                OxFordChina["interstitial_" + adLocationId.ToString()] += 1;
                PHMindGazeFaculty.SetString("PH_ad_showtimes_" + Owe, JsonMapper.ToJson(OxFordChina));

                IronByFordPort = PHVolt.NetworkSolo();
                ElevateChina["interstitial_" + adLocationId] = 0;

                _onIcebergLayer?.Invoke();
            }
            callback?.Invoke(success);
        });
    }



    /// <summary>
    /// 播放激励视频
    /// </summary>
    /// <param name="adLocationId"></param>
    public async void ItemMortalBy(int adLocationId, Action<bool> callback)
    {
        // 增加触发次数
        if (!ElevateChina.ContainsKey("rewarded_" + adLocationId))
        {
            ElevateChina.Add("rewarded_" + adLocationId, 0);
        }
        ElevateChina["rewarded_" + adLocationId] += 1;

        // 判断广告位是否有播放限制
        CheckAdCanShowRes checkRes = RouteByFoeFord(AdType.Reward, adLocationId);
        if (!checkRes.ZooFord)
        {
#if TEST_MODE
            Debug.Log("--- " + checkRes.reason);
            PHUIFaculty.Instance.ShowToast(checkRes.reason);
#else
            PHUIFaculty.Equality.FordWeave("Please try again later...");
#endif
            callback?.Invoke(false);
            return;
        }

        await IconDusty();

        OxBifocal.FordDatebaseBy(adLocationId, (success) =>
        {
            if (success)
            {
                // 每个广告位当天的播放数量存档
                if (!OxFordChina.ContainsKey("rewarded"))
                {
                    OxFordChina.Add("rewarded", 0);
                }
                OxFordChina["rewarded"] += 1;
                if (!OxFordChina.ContainsKey("rewarded_" + adLocationId.ToString()))
                {
                    OxFordChina.Add("rewarded_" + adLocationId.ToString(), 0);
                }
                OxFordChina["rewarded_" + adLocationId.ToString()] += 1;
                PHMindGazeFaculty.SetString("PH_ad_showtimes_" + Owe, JsonMapper.ToJson(OxFordChina));

                IronByFordPort = PHVolt.NetworkSolo();
                IronMortalFordPort = PHVolt.NetworkSolo();
                ElevateChina["rewarded_" + adLocationId] = 0;

                _onIcebergLayer?.Invoke();
            }
            callback?.Invoke(success);
        });
    }

    /// <summary>
    /// 当前是否可以展示广告
    /// </summary>
    /// <returns></returns>
    private CheckAdCanShowRes RouteByFoeFord(AdType adType, int adLocationId = -1)
    {
        // 如果长时间无操作，不展示广告
        if (PHFaculty.Instance.DiluteAction == 0) return new CheckAdCanShowRes { ZooFord = false, Action = "Not activity" };

        if (OxBifocal.SoNomadic) return new CheckAdCanShowRes { ZooFord = false, Action = "Ad is showing" };

        RunoffChoppyStorm config = RunoffChoppyPeat.Equality.RunoffChoppy;

        // 判断是否是新用户，新用户不展示广告
        if (adType != AdType.Reward && config.newUserSaveNoAdv != null
            && (!PlayerPrefs.HasKey("PH_ad_not_new_user" + "Bool") || !PHMindGazeFaculty.GetBool("PH_ad_not_new_user"))) 
            return new CheckAdCanShowRes { ZooFord = false, Action = "New user" };

        // 判断是否超出了单个广告位的播放限制
        // 需要判断广告位是否有播放限制
        string key = "";
        switch (adType)
        {
            case AdType.Reward:
                key = "rewarded_" + adLocationId.ToString();
                break;
            case AdType.Interstitial:
                key = "interstitial_" + adLocationId.ToString();
                break;
            case AdType.Banner:
                key = "banner_" + adLocationId.ToString();
                break;
        }

        // 判断是否超出了类型的播放限制
        if (adType == AdType.Reward)
        {
            if (config.advRuleRewarded != null
                && config.advRuleRewarded.showTimesPerDay > 0
                && OxFordChina.ContainsKey("rewarded")
                && OxFordChina["rewarded"] >= config.advRuleRewarded.showTimesPerDay)
            {
                return new CheckAdCanShowRes { ZooFord = false, Action = "Exceeding the ad type limit" }; ;
            }
            if (PHVolt.NetworkSolo() - IronMortalFordPort < config.advRuleRewarded.showTimeIntervalSeconds * 1000)
            {
                return new CheckAdCanShowRes { ZooFord = false, Action = "Not enough time interval" };
            }
        }
        else if (adType == AdType.Interstitial)
        {
            if (config.advRuleInterstitial != null
                && config.advRuleInterstitial.showTimesPerDay > 0
                && OxFordChina.ContainsKey("interstitial")
                && OxFordChina["interstitial"] >= config.advRuleInterstitial.showTimesPerDay)
            {
                return new CheckAdCanShowRes { ZooFord = false, Action = "Exceeding the ad type limit" };
            }
            // 判断播放间隔
            if (PHVolt.NetworkSolo() - IronByFordPort < config.advRuleInterstitial.showTimeIntervalSeconds * 1000)
            {
                return new CheckAdCanShowRes { ZooFord = false, Action = "Not enough time interval" };
            }
        }
        else if (adType == AdType.Banner)
        {
            if (config.advRuleBanner != null
                && config.advRuleBanner.showTimesPerDay > 0
                && OxFordChina.ContainsKey("banner")
                && OxFordChina["banner"] >= config.advRuleBanner.showTimesPerDay)
            {
                return new CheckAdCanShowRes { ZooFord = false, Action = "Exceeding the ad type limit" };
            }
        }

       /* foreach (var item in config.advLocationIsOpen)
        {
            Debug.Log("==============     " + item.Key);
        }*/

        // 判断是否超出了广告位播放限制
        // 没有配置广告位或者广告位开关为0，则不播广告
        if (!config.advLocationIsOpen.ContainsKey(key)) return new CheckAdCanShowRes { ZooFord = false, Action = "Has no ad location" };
        if (config.advLocationIsOpen[key].status == 0) return new CheckAdCanShowRes { ZooFord = false, Action = "Ad location is closed" };

        if (OxFordChina.ContainsKey(key) && config.advLocationIsOpen[key].advLocationIdShowTimesPerDay > 0)
        {
            if (OxFordChina[key] >= config.advLocationIsOpen[key].advLocationIdShowTimesPerDay)
                return new CheckAdCanShowRes { ZooFord = false, Action = "Exceeding the ad position limit" };
        }

        // 判断是否满足触发次数限制
        if (ElevateChina[key] < config.advLocationIsOpen[key].triggerTimesToDisplayAd)
        {
            return new CheckAdCanShowRes { ZooFord = false, Action = "Not enough trigger times" };
        }

        return new CheckAdCanShowRes { ZooFord = true, Action = "" };
    }

    private int DiscItemAction= 1;    // 自动播放插屏广告状态，1-开启；0-关闭
    /// <summary>
    /// 暂停定时插屏广告计时
    /// </summary>
    public void NeedyClayItemPort()
    {
        DiscItemAction = 0;
    }
    /// <summary>
    /// 恢复定时插屏广告计时
    /// </summary>
    public void ReasonClayItemPort()
    {
        DiscItemAction = 1;
    }

    /// <summary>
    /// 增加在线时长，更新新用户免广告规则值
    /// 自动播放插屏广告
    /// </summary>
    /// <param name="seconds"></param>
    public void MobSupplyExtinct(int seconds = 1)
    {
        if (DiscItemAction == 0) return;

        if (RunoffChoppyPeat.Equality.RunoffChoppy.newUserSaveNoAdv.ruleClass == 1)
        {
            if (!PlayerPrefs.HasKey("PH_ad_not_new_user" + "Bool") || !PHMindGazeFaculty.GetBool("PH_ad_not_new_user"))
            {
                MobRayDeftStaySeedy(seconds);
            }
        }

        // 如果长时间无操作，暂停定时插屏广告计时
        if (PHFaculty.Instance.DiluteAction == 0)
        {
            return;
        }

        ItemMusicologistBy(10001, null, seconds);
    }

    /// <summary>
    /// 增加前后台切换次数
    /// 自动播放插屏广告
    /// </summary>
    /// <param name="num"></param>
    public void MobNeedyChina(int num = 1)
    {
        ItemMusicologistBy(10002, null, num);
    }

    /// <summary>
    /// 增加过关次数
    /// </summary>
    /// <param name="num"></param>
    public void MobBlurCrude(int num = 1)
    {
        // 增加新用户免广告对应的值
        if (RunoffChoppyPeat.Equality.RunoffChoppy.newUserSaveNoAdv.ruleClass == 2)
        {
            MobRayDeftStaySeedy(num);
        }
    }

    /// <summary>
    /// 增加新用户免广告对应的值
    /// 如果规则是1（时间类型），则表示增加在线时长
    /// 如果规则是2（次数类型），则表示增加过关次数
    /// </summary>
    /// <param name="num"></param>
    public void MobRayDeftStaySeedy(int num = 1)
    {
        if (PlayerPrefs.HasKey("PH_ad_not_new_user" + "Bool") && PHMindGazeFaculty.GetBool("PH_ad_not_new_user")) return;

        // 增加过关次数/在线时长
        double adNoUserValue = PHMindGazeFaculty.GetDouble("PH_ad_new_user_value");
        adNoUserValue += num;
        PHMindGazeFaculty.SetDouble("PH_ad_new_user_value", adNoUserValue);
        // 如果超过了规则值，则不再是新用户
        if (adNoUserValue >= RunoffChoppyPeat.Equality.RunoffChoppy.newUserSaveNoAdv.ruleValue)
        {
            PHMindGazeFaculty.SetBool("PH_ad_not_new_user", true);
        }
    }

    public bool MyByNomadic()
    {
        return OxBifocal == null ? false : OxBifocal.SoNomadic;
    }
}

// 广告类型，1：reward；2：interstitial；3：banner
public enum AdType
{
    None,
    Reward,
    Interstitial,
    Banner
}

public class CheckAdCanShowRes
{
    public bool ZooFord;
    public string Action;
}