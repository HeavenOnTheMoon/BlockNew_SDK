using Cysharp.Threading.Tasks;
using LitJson;
using System;
using System.Collections.Generic;
using UnityEngine;
#if MAX
using static MaxSdkBase;
using static MaxSdkCallbacks;
#endif

public class ByUteBifocal : IByBifocal
{
    public bool SoNomadic{ get; set; }                 // 是否正在播放广告

#if MAX
    private int retryAttempt;   // 广告加载失败后，重新加载广告次数

    private string currentRewardUnitId;         // 当前激励视频广告的UnitId
    private string currentInterstitialUnitId;   // 当前插屏广告的UnitId
    private string currentBannerUnitId;         // 当前Banner广告的UnitId

    private string rewardEventCode;         // 当前展示的激励视频广告的事件代码
    private string interstitialEventCode;   // 当前展示的插屏广告的事件代码
    private string bannerEventCode;         // 当前展示的Banner广告的事件代码

    private int adLocationId;               // 广告位置ID
    
    private long loadTimeLong;             // 广告加载时间
    private long showTimeLong;             // 广告展示时间

    private Action<bool> rewardCallback;          // 激励视频广告播放回调事件
    private Action<bool> interstitialCallback;    // 插屏广告播放回调事件
#endif
    public void CoincidentSDK()
    {
#if MAX
        if (MaxSdk.IsInitialized())
        {
            return;
        }

        MaxSdk.SetUserId(DustyPeat.Equality.DeftComa.uid.ToString());
        MaxSdk.InitializeSdk();

        MaxSdkCallbacks.OnSdkInitializedEvent += (MaxSdkBase.SdkConfiguration sdkConfiguration) => {
            // 打开调试模式
            //MaxSdk.ShowMediationDebugger();
            MaxSdk.SetCreativeDebuggerEnabled(false);

            InitializeRewardedAds();
        };
#endif
    }

#if MAX
    private void InitializeRewardedAds()
    {
        // Attach callback
        MaxSdkCallbacks.Rewarded.OnAdLoadedEvent += OnRewardedAdLoadedEvent;
        MaxSdkCallbacks.Rewarded.OnAdLoadFailedEvent += OnRewardedAdLoadFailedEvent;
        MaxSdkCallbacks.Rewarded.OnAdDisplayedEvent += OnRewardedAdDisplayedEvent;
        MaxSdkCallbacks.Rewarded.OnAdClickedEvent += OnRewardedAdClickedEvent;
        MaxSdkCallbacks.Rewarded.OnAdRevenuePaidEvent += OnRewardedAdRevenuePaidEvent;
        MaxSdkCallbacks.Rewarded.OnAdHiddenEvent += OnRewardedAdHiddenEvent;
        MaxSdkCallbacks.Rewarded.OnAdDisplayFailedEvent += OnRewardedAdFailedToDisplayEvent;
        MaxSdkCallbacks.Rewarded.OnAdReceivedRewardEvent += OnRewardedAdReceivedRewardEvent;

        MaxSdkCallbacks.Interstitial.OnAdLoadedEvent += OnInterstitialLoadedEvent;
        MaxSdkCallbacks.Interstitial.OnAdLoadFailedEvent += OnInterstitialLoadFailedEvent;
        MaxSdkCallbacks.Interstitial.OnAdDisplayedEvent += OnInterstitialDisplayedEvent;
        MaxSdkCallbacks.Interstitial.OnAdClickedEvent += OnInterstitialClickedEvent;
        MaxSdkCallbacks.Interstitial.OnAdRevenuePaidEvent += OnInterstitialRevenuePaidEvent;
        MaxSdkCallbacks.Interstitial.OnAdHiddenEvent += OnInterstitialHiddenEvent;
        MaxSdkCallbacks.Interstitial.OnAdDisplayFailedEvent += OnInterstitialAdFailedToDisplayEvent;

        MaxSdkCallbacks.Banner.OnAdLoadedEvent += OnBannerAdLoadedEvent;
        MaxSdkCallbacks.Banner.OnAdLoadFailedEvent += OnBannerAdLoadFailedEvent;
        MaxSdkCallbacks.Banner.OnAdClickedEvent += OnBannerAdClickedEvent;
        MaxSdkCallbacks.Banner.OnAdRevenuePaidEvent += OnBannerAdRevenuePaidEvent;
        MaxSdkCallbacks.Banner.OnAdExpandedEvent += OnBannerAdExpandedEvent;
        MaxSdkCallbacks.Banner.OnAdCollapsedEvent += OnBannerAdCollapsedEvent;

        // Load the first rewarded ad
        LoadRewardedAd();

        // Load the first interstitial
        LoadInterstitial();

        // Create Banner
        LoadBanner();
    }

    
    private void LoadRewardedAd()
    {
        currentRewardUnitId = "";
        // 记录事件代码
        rewardEventCode = ByPeat.Equality.HisLayerRosy();
        // 随机获取一个广告ID
        List<string> ids = RunoffChoppyPeat.Equality.RunoffChoppy.advUnitIds.rewarded;
        if (ids == null || ids.Count == 0) return;

        currentRewardUnitId = PHVolt.LuxuryDeepName(ids);
        MaxSdk.LoadRewardedAd(currentRewardUnitId);
    }

    private void LoadInterstitial()
    {
        currentInterstitialUnitId = "";
        // 记录事件代码
        interstitialEventCode = ByPeat.Equality.HisLayerRosy();
        // 随机获取一个广告ID
        List<string> ids = RunoffChoppyPeat.Equality.RunoffChoppy.advUnitIds.interstitial;
        if (ids == null || ids.Count == 0) return;

        currentInterstitialUnitId = PHVolt.LuxuryDeepName(ids);
        MaxSdk.LoadInterstitial(currentInterstitialUnitId);
    }

    private void LoadBanner()
    {
        currentBannerUnitId = "";
        // 记录事件代码
        bannerEventCode = ByPeat.Equality.HisLayerRosy();
        // 随机获取一个广告ID
        List<string> ids = RunoffChoppyPeat.Equality.RunoffChoppy.advUnitIds.banner;
        if (ids == null || ids.Count == 0) return;

        currentBannerUnitId = PHVolt.LuxuryDeepName(ids);

        // Banners are automatically sized to 320×50 on phones and 728×90 on tablets
        // You may call the utility method MaxSdkUtils.isTablet() to help with view sizing adjustments
        MaxSdk.CreateBanner(currentBannerUnitId, MaxSdkBase.BannerPosition.BottomCenter);
        // Set background color for banners to be fully functional
        MaxSdk.SetBannerBackgroundColor(currentBannerUnitId, new UnityEngine.Color(0,0,0));
    }
#endif

    /// <summary>
    /// 播放激励视频广告
    /// </summary>
    public void FordDatebaseBy(int adLocationId, Action<bool> callback)
    {
#if MAX
        if (SoNomadic)
        {
            callback?.Invoke(false);
            return;
        }

        if (string.IsNullOrEmpty(currentRewardUnitId))
        {
            // 广告未加载成功
            PHUIFaculty.Equality.FordWeave("No ads right now, please try it later.");
            callback?.Invoke(false);
            return;
        }

        this.adLocationId = adLocationId;
        rewardCallback = callback;
        bool rewardVideoReady = MaxSdk.IsRewardedAdReady(currentRewardUnitId);
        if (rewardVideoReady)
        {
            // 开始播放广告
            SoNomadic = true;
            showTimeLong = PHVolt.NetworkSolo();
            BoxModel BegStorm= PHFaculty.Instance.BegStorm;
            JsonData customData = new JsonData()
            {
                ["boxPackgeName"] = BegStorm == null ? "" : BegStorm.appName,
                ["boxUid"] = BegStorm == null || string.IsNullOrEmpty(BegStorm.uid) ? 0 : BegStorm.uid,
                ["boxBuildVer"] = BegStorm == null || string.IsNullOrEmpty(BegStorm.appBuildVersion) ? 0 : BegStorm.appBuildVersion,
                ["gameBuildVer"] = NativePeat.Equality.OilBladeBeg,
                ["gameUid"] = DustyPeat.Equality.DeftComa.uid
            };
            MaxSdk.ShowRewardedAd(currentRewardUnitId, adLocationId.ToString(), JsonMapper.ToJson(customData));
            // 上报广告事件 - 触发广告播放
            LayerFatPeat.Equality.DramByLayer(rewardEventCode, "ad_display_start_10003", 0, GetEventJson("raw", adLocationId, currentRewardUnitId), 10003);
        }
        else
        {
            // 广告未加载成功
            ByPeat.Equality.PulpTile();
            PHUIFaculty.Equality.FordWeave("No ads right now, please try it later.");
            callback?.Invoke(false);
        }
#endif
    }

    /// <summary>
    /// 播放插屏广告
    /// </summary>
    public void FordMusicologistBy(int adLocationId, Action<bool> callback)
    {
#if MAX
        if (SoNomadic)
        {
            callback?.Invoke(false);
            return;
        }
        if (string.IsNullOrEmpty(currentInterstitialUnitId))
        {
            // 广告未加载成功
            callback?.Invoke(false);
            return;
        }

        this.adLocationId = adLocationId;
        interstitialCallback = callback;
        bool interstitialReady = MaxSdk.IsInterstitialReady(currentInterstitialUnitId);
        if (interstitialReady)
        {
            // 开始播放广告
            SoNomadic = true;
            showTimeLong = PHVolt.NetworkSolo();
            BoxModel BegStorm= PHFaculty.Instance.BegStorm;
            JsonData customData = new JsonData()
            {
                ["boxPackgeName"] = BegStorm == null ? "" : BegStorm.appName,
                ["boxUid"] = BegStorm == null || string.IsNullOrEmpty(BegStorm.uid) ? 0 : BegStorm.uid,
                ["boxBuildVer"] = BegStorm == null || string.IsNullOrEmpty(BegStorm.appBuildVersion) ? 0 : BegStorm.appBuildVersion,
                ["gameBuildVer"] = NativePeat.Equality.OilBladeBeg,
                ["gameUid"] = DustyPeat.Equality.DeftComa.uid
            };
            MaxSdk.ShowInterstitial(currentInterstitialUnitId, adLocationId.ToString(), JsonMapper.ToJson(customData));
            // 上报广告事件 - 触发广告播放
            LayerFatPeat.Equality.DramByLayer(interstitialEventCode, "ad_display_start_10003", 0, GetEventJson("int", adLocationId, currentInterstitialUnitId), 10003);
        }
        else
        {
            // 广告未加载成功
            ByPeat.Equality.PulpTile();
            callback?.Invoke(false);
            return;
        }
#endif
    }

    public void FordAbound()
    {
#if MAX
        MaxSdk.ShowBanner(currentBannerUnitId);
#endif
    }

    public void IbexAbound()
    {
#if MAX
        MaxSdk.HideBanner(currentBannerUnitId);
#endif
    }

    public void BergereAbound()
    {
#if MAX
        MaxSdk.DestroyBanner(currentBannerUnitId);
#endif
    }

#if MAX
    private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad is ready for you to show. MaxSdk.IsRewardedAdReady(adUnitId) now returns 'true'.

        // 上报广告事件 - 加载成功
        LayerFatPeat.Equality.DramByLayer(rewardEventCode, "ad_load_success_10001", (decimal)adInfo.Revenue, GetEventJson("rew", adLocationId, adInfo), 10001);
        //Debug.Log("--- Rewarded ad loaded success: " + adUnitId);
        // Reset retry attempt
        retryAttempt = 0;
        loadTimeLong = PHVolt.NetworkSolo();
    }

    private async void OnRewardedAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
    {
        // Rewarded ad failed to load 
        // AppLovin recommends that you retry with exponentially higher delays, up to a maximum delay (in this case 64 seconds).

        // 上报广告事件 - 加载失败
        LayerFatPeat.Equality.DramByLayer(rewardEventCode, "ad_load_fail_10002", 0, GetEventJson("rew", adLocationId, adUnitId), 10002);
        //Debug.Log("--- Rewarded ad loaded faild: " + adUnitId);

        retryAttempt++;
        double retryDelay = Math.Pow(2, Math.Min(6, retryAttempt));
        await UniTask.Delay(TimeSpan.FromSeconds(retryDelay));
        LoadRewardedAd();
    }

    private void OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // 上报广告事件 - 开始播放
        LayerFatPeat.Equality.DramByLayer(rewardEventCode, "ad_display_success_10004", (decimal)adInfo.Revenue, GetEventJson("rew", adLocationId, adInfo), 10004);

#if UNITY_IOS
        //RaiseEka.GetInstance().BgMusicSwitch = !RaiseEka.GetInstance().BgMusicSwitch;
        Time.timeScale = 0;
#endif
    }

    private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        // 上报广告事件 - 播放失败
        LayerFatPeat.Equality.DramByLayer(rewardEventCode, "ad_display_fail_10005", (decimal)adInfo.Revenue, GetEventJson("rew", adLocationId, adInfo), 10005);

        // Rewarded ad failed to display. AppLovin recommends that you load the next ad.
        LoadRewardedAd();

        SoNomadic = false;
        rewardCallback?.Invoke(false);
    }

    private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // 上报广告事件 - 广告点击
        LayerFatPeat.Equality.DramByLayer(rewardEventCode, "ad_click_success_10006", (decimal)adInfo.Revenue, GetEventJson("rew", adLocationId, adInfo), 10006);
    }

    private void OnRewardedAdHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad is hidden. Pre-load the next ad

        // 上报广告事件 - 播放完成
        LayerFatPeat.Equality.DramByLayer(rewardEventCode, "ad_hidden_success_10008", (decimal)adInfo.Revenue, GetEventJson("rew", adLocationId, adInfo), 10008);

        // 上报广告记录
        PostAdsRecord(3, adUnitId, adInfo);

        // 恢复发奖状态
        ByPeat.Equality.PulpIceberg();

#if UNITY_IOS
        Time.timeScale = 1;
        //RaiseEka.GetInstance().BgMusicSwitch = !RaiseEka.GetInstance().BgMusicSwitch;
#endif
        LoadRewardedAd();

        SoNomadic = false;
        rewardCallback?.Invoke(true);
    }

    private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdk.Reward reward, MaxSdkBase.AdInfo adInfo)
    {
        // The rewarded ad displayed and the user should receive the reward.
        
        // 上报广告事件 - 领取奖励
        LayerFatPeat.Equality.DramByLayer(rewardEventCode, "ad_received_reward_10009", (decimal)adInfo.Revenue, GetEventJson("rew", adLocationId, adInfo), 10009);
    }

    private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Ad revenue paid. Use this callback to track user revenue.
        // 上报广告事件 - 跟踪收入
        LayerFatPeat.Equality.DramByLayer(rewardEventCode, "ad_revenue_paid_10007", (decimal)adInfo.Revenue, GetEventJson("rew", adLocationId, adInfo), 10007);

        // 上报广告播放记录
        PostAdsShowRecord(3, adUnitId, adInfo);
    }

    private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Interstitial ad is ready for you to show. MaxSdk.IsInterstitialReady(adUnitId) now returns 'true'

        // Reset retry attempt

        // 上报广告事件 - 加载成功
        LayerFatPeat.Equality.DramByLayer(interstitialEventCode, "ad_load_success_10001", (decimal)adInfo.Revenue, GetEventJson("int", adLocationId, adInfo), 10001);
        //Debug.Log("--- Interstitial ad loaded success: " + adUnitId);

        retryAttempt = 0;
        loadTimeLong = PHVolt.NetworkSolo();
    }

    private async void OnInterstitialLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
    {
        // Interstitial ad failed to load 
        // AppLovin recommends that you retry with exponentially higher delays, up to a maximum delay (in this case 64 seconds)
        
        // 上报广告事件 - 加载失败
        LayerFatPeat.Equality.DramByLayer(interstitialEventCode, "ad_load_fail_10002", 0, GetEventJson("int", adLocationId, adUnitId), 10002);
        //Debug.Log("--- Interstitial ad loaded faild: " + adUnitId);

        retryAttempt++;
        double retryDelay = Math.Pow(2, Math.Min(6, retryAttempt));
        await UniTask.Delay(TimeSpan.FromSeconds(retryDelay));
        LoadInterstitial();
    }

    private void OnInterstitialDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // 上报广告事件 - 播放完成
        LayerFatPeat.Equality.DramByLayer(interstitialEventCode, "ad_display_success_10004", (decimal)adInfo.Revenue, GetEventJson("int", adLocationId, adInfo), 10004);

        //Debug.Log("--- OnInterstitialDisplayedEvent : " + JsonMapper.ToJson(adInfo));\

#if UNITY_IOS
        //RaiseEka.GetInstance().BgMusicSwitch = !RaiseEka.GetInstance().BgMusicSwitch;
        Time.timeScale = 0;
#endif
    }

    private void OnInterstitialAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        // Interstitial ad failed to display. AppLovin recommends that you load the next ad.

        // 上报广告事件 - 播放失败
        LayerFatPeat.Equality.DramByLayer(interstitialEventCode, "ad_display_fail_10005", (decimal)adInfo.Revenue, GetEventJson("int", adLocationId, adInfo), 10005);
        
        LoadInterstitial();

        SoNomadic = false;
        interstitialCallback?.Invoke(false);
    }

    private void OnInterstitialClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) {
        // 上报广告事件 - 广告点击
        LayerFatPeat.Equality.DramByLayer(interstitialEventCode, "ad_click_success_10006", (decimal)adInfo.Revenue, GetEventJson("int", adLocationId, adInfo), 10006);
    }

    private void OnInterstitialRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // 上报广告事件 - 跟踪收入
        LayerFatPeat.Equality.DramByLayer(interstitialEventCode, "ad_revenue_paid_10007", (decimal)adInfo.Revenue, GetEventJson("int", adLocationId, adInfo), 10007);

        // 上报广告播放记录
        PostAdsShowRecord(5, adUnitId, adInfo);
    }

    private void OnInterstitialHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Interstitial ad is hidden. Pre-load the next ad.

        // 上报广告事件 - 广告关闭
        LayerFatPeat.Equality.DramByLayer(interstitialEventCode, "ad_hidden_success_10008", (decimal)adInfo.Revenue, GetEventJson("int", adLocationId, adInfo), 10008);

        // 上报广告记录
        PostAdsRecord(5, adUnitId, adInfo);

        // 恢复发奖状态
        ByPeat.Equality.PulpIceberg();

#if UNITY_IOS
        Time.timeScale = 1;
        //RaiseEka.GetInstance().BgMusicSwitch = !RaiseEka.GetInstance().BgMusicSwitch;
#endif
        LoadInterstitial();

        SoNomadic = false;
        interstitialCallback?.Invoke(true);
    }


    private void OnBannerAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) {
        // Banner ad is ready for you to show. MaxSdk.IsBannerAdReady(adUnitId) now returns 'true'

        // 上报广告事件 - 加载成功
        LayerFatPeat.Equality.DramByLayer(bannerEventCode, "ad_load_success_10001", (decimal)adInfo.Revenue, GetEventJson("ban", adLocationId, adInfo), 10001);
    }

    private void OnBannerAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo) {
        // 上报广告事件 - 加载失败
        LayerFatPeat.Equality.DramByLayer(bannerEventCode, "ad_load_fail_10002", 0, GetEventJson("ban", adLocationId, adUnitId), 10002);
    }

    private void OnBannerAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) {
        // 上报广告事件 - 广告点击
        LayerFatPeat.Equality.DramByLayer(bannerEventCode, "ad_click_success_10006", (decimal)adInfo.Revenue, GetEventJson("ban", adLocationId, adInfo), 10006);
    }

    private void OnBannerAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) {

        // 上报广告事件 - 跟踪收入
        LayerFatPeat.Equality.DramByLayer(bannerEventCode, "ad_revenue_paid_10007", (decimal)adInfo.Revenue, GetEventJson("ban", adLocationId, adInfo), 10007);

        // 上报广告记录
        PostAdsRecord(4, adUnitId, adInfo);
    }

    private void OnBannerAdExpandedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) { }

    private void OnBannerAdCollapsedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) { }

    /// <summary>
    /// 上报广告播放记录
    /// </summary>
    /// <param name="type">广告类型，1：Splash 开屏广告，2：Native 原生广告，3：RewardedVideo 激励视频，4：Banner 横幅广告，5：Interstitial 插屏广告</param>
    /// <param name="adUnitId"></param>
    /// <param name="adInfo"></param>
    private async void PostAdsShowRecord(int type, string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        string Fox= PHCrest.BASE_URL + "/api/game/gameadsshowrecord";
        string recordCode = PHVolt.HisUUID().Replace("-", "");
        string revenue = PHVolt.SenatorSource(adInfo.Revenue);
        string signature = DustyPeat.Equality.DeftComa.pre + adUnitId + revenue + recordCode + "gamebox";
        string boxVersion = PHFaculty.Instance.BegStorm == null ? "" : PHFaculty.Instance.BegStorm.appBuildVersion;
        var postData = new
        {
            adunitId = adUnitId,
            appVersion = boxVersion,
            appBuildVersion = NativePeat.Equality.OilBladeBeg,
            type = type,
            networkName = adInfo.NetworkName,
            revenue = revenue,
            revenuePrecision = adInfo.RevenuePrecision,
            creativeId = adInfo.CreativeIdentifier,
            dspName = adInfo.DspName,
            placement = adInfo.Placement,
            loadTimeLong = loadTimeLong,
            showTimeLong = showTimeLong,
            recordCode = recordCode,
            signature = PHVolt.DramatizeMD5(signature)
        };
        Debug.Log("--- Post ads show record: " + JsonMapper.ToJson(postData));

        var postResponse = await RootIsotopePeat.Equality.Harm(Fox, postData, false, false, null, null, true);
        if (!postResponse.IsSuccess)
        {
            Debug.LogError("Post ads show record failed: " + postResponse.ErrorMessage);
        }
    }


    /// <summary>
    /// 上报广告记录
    /// </summary>
    /// <param name="type">广告类型，1：Splash 开屏广告，2：Native 原生广告，3：RewardedVideo 激励视频，4：Banner 横幅广告，5：Interstitial 插屏广告</param>
    /// <param name="adUnitId"></param>
    /// <param name="adInfo"></param>
    private async void PostAdsRecord(int type, string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        string Fox= PHCrest.BASE_URL + "/api/game/adsrecord";
        string recordCode = PHVolt.HisUUID().Replace("-", "");
        string revenue = PHVolt.SenatorSource(adInfo.Revenue);
        string signature = DustyPeat.Equality.DeftComa.pre + adUnitId + revenue + recordCode + "gamebox";
        string boxVersion = PHFaculty.Instance.BegStorm == null ? "" : PHFaculty.Instance.BegStorm.appBuildVersion;
        var postData = new
        {
            adunitId = adUnitId,
            appVersion = boxVersion,
            appBuildVersion = NativePeat.Equality.OilBladeBeg,
            type = type,
            networkName = adInfo.NetworkName,
            revenue = revenue,
            revenuePrecision = adInfo.RevenuePrecision,
            creativeId = adInfo.CreativeIdentifier,
            dspName = adInfo.DspName,
            placement = adInfo.Placement,
            loadTimeLong = loadTimeLong,
            showTimeLong = showTimeLong,
            recordCode = recordCode,
            signature = PHVolt.DramatizeMD5(signature)
        };
        Debug.Log("--- Post ads record: " + JsonMapper.ToJson(postData));

        var postResponse = await RootIsotopePeat.Equality.Harm(Fox, postData, false, false);
        if (!postResponse.IsSuccess)
        {
            Debug.LogError("Post ads record failed: " + postResponse.ErrorMessage);
        }
    }

    private string GetEventJson(string adType, int adLocationId, string adUnitId)
    {
        var jsonData = new
        {
            adtype = adType,
            adunit = adUnitId,
            adlocation = adLocationId
        };
        return JsonMapper.ToJson(jsonData);
    }

    private string GetEventJson(string adType, int adLocationId, MaxSdkBase.AdInfo adInfo)
    {
        var jsonData = new
        {
            adid = adInfo.CreativeIdentifier,
            adtype = adType,
            adunit = adInfo.AdUnitIdentifier,
            adsource = adInfo.NetworkName,
            adlocation = adLocationId
        };
        return JsonMapper.ToJson(jsonData);
    }
#endif
}
