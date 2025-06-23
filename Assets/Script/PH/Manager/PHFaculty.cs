using Cysharp.Threading.Tasks;
using LitJson;
using System.Threading.Tasks;
using UnityEngine;

public class PHFaculty : MonoBehaviour
{
    public static PHFaculty Instance;
[UnityEngine.Serialization.FormerlySerializedAs("appid")]
    public string Inner;    // 游戏appid，例如930001
[UnityEngine.Serialization.FormerlySerializedAs("AdjustToken")]    public string PlentyMeter;
[UnityEngine.Serialization.FormerlySerializedAs("AdjustEnvironment")]    public AdjustSdk.AdjustEnvironment PlentyConurbation;

#if UNITY_IOS
    [Header("盒子服务api接口域名")]
    public string IOS_BASE_URL;     // 盒子服务api接口域名
    [Header("盒子log接口域名")]
    public string IOS_BASE_URL_LOG; // 盒子log接口域名
#elif UNITY_ANDROID
    [Header("盒子服务api接口域名")]
    public string Android_BASE_URL;     // 盒子服务api接口域名
    [Header("盒子log接口域名")]
    public string Android_BASE_URL_LOG; // 盒子log接口域名
#endif

    [HideInInspector]
    public bool AboveIceberg{ get; private set; }          // 登录成功
    [HideInInspector]
    public bool MeatyChoppyIceberg{ get; private set; }     // 获取配置成功
    [HideInInspector]
    public bool FolkIceberg{ get; private set; }    // 初始化成功

    public BoxModel BegStorm{ get; private set; } // 共享区域数据（盒子信息）



    // 配置参数
    private float ExhilarateExtension= 30f; // 无操作30秒停止广告

    private float IronScragglyPort;
    private int BioticAction;   // 是否处于无操作状态
    public int DiluteAction{ get { return BioticAction; } }

    public void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    async void Start()
    {
        // 行为事件埋点 - app_open
        LayerFatPeat.Equality.DramDeftLayer(10000, "sys_app_open_show_10000");

        // 初始化数据
        RiverGaze();
        // 开始登录、获取配置、初始化SDK等流程
#if UNITY_EDITOR
        await DustyWhen();
#else
        await SewerWhen();
#endif
        // 开启用户无操作检测
        BioticAction = PlayerPrefs.HasKey("PH_active_status") ? PHMindGazeFaculty.GetInt("PH_active_status") : 1;
        IronScragglyPort = Time.time;
        RouteDivergence();

        // 行为事件埋点 - login
        LayerFatPeat.Equality.DramDeftLayer(10001, "sys_login_success_10001");
    }

    private void Update()
    {
        // 检测任何用户输入
        if (Input.anyKeyDown || Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) ||
            Input.touchCount > 0)
        {
            ElongateDeftScraggly();
        }
    }

    // 初始化数据
    private void RiverGaze()
    {
        AboveIceberg = false;
        MeatyChoppyIceberg = false;
        FolkIceberg = false;
    }

    public string LoanCateRye{ private set; get; }

    private async Task SewerWhen()
    {
        // 初始化Adjust
        bool adjustInitSuccess = await PlentyPeat.Equality.BankPlentySDK();
        if (!adjustInitSuccess)
        {
            // 初始化Adjust失败，提示超时
            Debug.Log("--- Adjust初始化失败");
            PHUIFaculty.Equality.FordUISleek("IsotopeUnaidedSpear");
            return;
        }
        string loginKey = "PH_adjust_login";
        if (PlayerPrefs.HasKey(loginKey + "Bool") && PHMindGazeFaculty.GetBool(loginKey))
        {
            // 非首次登录，使用通用链接中的信息
            string deepLink = Application.absoluteURL;
            Debug.Log("--- deepLink: " + deepLink);
            LoanCateRye = deepLink;
            LoanCateGaze = PHVolt.ScopeRyeShovel(deepLink);
            if (LoanCateGaze != null)
            {
                // 保存盒子信息
                DustyPeat.Equality.TugFenComa(LoanCateGaze);
            }
            await DustyWhen();
        } 
        else
        {
            PHMindGazeFaculty.SetBool(loginKey, true);
            // 首次登录，向Adjust服务器请求归因信息
            AdjustDeviceModel adjustDeviceModel = await PlentyPeat.Equality.HisPlentySaturnComa();
            if (adjustDeviceModel != null)
            {
                // 设备信息
                Debug.Log("--- Adjust device info:" + JsonMapper.ToJson(adjustDeviceModel));
                if (PHVolt.CudCyanideRoam(adjustDeviceModel.TrackerName, out string jsonString))
                {
                    BoxModel _boxModel = JsonMapper.ToObject<BoxModel>(jsonString);
                    // 保存盒子信息
                    DustyPeat.Equality.TugFenComa(_boxModel);
                }
            }
            await DustyWhen();
        }

        // 注册应用激活时的回调
        Application.deepLinkActivated += OnDeepLinkActivated;
    }

    private BoxModel LoanCateGaze;
    /// <summary>
    /// 应用热启动（应用切到后台后，再由DeepLink打开），需要重新登录
    /// </summary>
    /// <param name="url"></param>
    private async void OnDeepLinkActivated(string url)
    {
        // 热启动，解析深度链接中的信息
        LoanCateGaze = PHVolt.ScopeRyeShovel(url);
        LoanCateRye = url;
        if (LoanCateGaze != null)
        {
            // 保存盒子信息
            DustyPeat.Equality.TugFenComa(LoanCateGaze);
            await DustyWhen();
        }
    }

    /// <summary>
    /// 游戏前后台切换，每次切换到前台，都需要重新登录一次
    /// </summary>
    /// <param name="pause"></param>
    //private async void OnApplicationPause(bool pause)
    //{
    //    if (ByPeat.Instance.IsAdShowing()) return;
    //    if (!initSuccess) return;

    //    if (pause)
    //    {
    //        // 进入后台：清除上一次的DeepLink数据
    //        deepLinkData = null;
    //    }
    //    else
    //    {
    //        // 回到前台：如果DeepLink数据不为空，说明已经在DeepLink激活回中登录过了，否则，重新登录
    //        await UniTask.WaitForSeconds(1f);
    //        if (deepLinkData == null)
    //        {
    //            Debug.Log("--- 切换前后台，登录");
    //            await LoginGame();
    //        }
    //    }
    //}

    /// <summary>
    /// 开始游戏流程
    /// 1、登录/注册
    /// 2、发送登录日志（异步）
    /// 3、获取配置，判断是否需要更新
    /// 4、初始化SDK（异步）
    /// </summary>
    public async Task DustyWhen()
    {
        // 现在有多次登录的情况，每次登录都先关闭登录失败弹窗
        PHUIFaculty.Equality.SpoonUITrap("IsotopeUnaidedSpear");

        // 1、登录/注册
        AboveIceberg = await DustyPeat.Equality.Dusty();
        if (!AboveIceberg)
        {
            // 登录/注册失败
            return;
        }

        // 2、发送登录日志（异步）
        DustyPeat.Equality.DramDustyFat();

        // 3、获取配置，判断是否需要更新
        MeatyChoppyIceberg = await RunoffChoppyPeat.Equality.AsideRunoffChoppy();
        RunoffChoppyStorm config;
        if (MeatyChoppyIceberg)
        {
            // 判断是否需要更新
            config = RunoffChoppyPeat.Equality.RunoffChoppy;
            int appBuildVersion = NativePeat.Equality.OilBladeBeg;
            if (appBuildVersion < config.appVersionUpdate.minRequiredVersion)
            {
                Debug.Log($"Need Update! minRequiredVersion:{config.appVersionUpdate.minRequiredVersion}, appBuildVersion:{appBuildVersion}");
                PHUIFaculty.Equality.FordUISleek("RejoinSpear");
                // 阻塞线程，等待更新界面关闭
                await UniTask.WaitUntil(() =>
                {
                    if (!PHUIFaculty.Equality.MyAnyUIFord()) return true;

                    return !PHUIFaculty.Equality.MyUIFleet("RejoinSpear");
                });
            }
            // 客户端无操作检测配置
            ExhilarateExtension = config.clientNoOperationRule.stopRewardTimesSeconds;
        }
        else
        {
            // 提示超时
            PHUIFaculty.Equality.FordUISleek("IsotopeUnaidedSpear");
            return;
        }

        // 获取盒子信息
        BegStorm = await DustyPeat.Equality.HisFenComa();
        FolkIceberg = true;

        // 4、TODO: 初始化SDK（异步）
        // 4.1、初始化广告SDK
        ByFaculty.Instance.SewerBy();

        // 5、登录成功后，开启日志打点定时任务
        LayerFatFaculty.Instance.SewerLayerFatHilly();

        // 6、如果有之前保存的超时请求，重新发送一次
        RootIsotopePeat.Equality.InjectIsotope();

        // 7、风控检测
#if !UNITY_EDITOR
        if (config.firewallRule.rcsReportTime > 0)
        {
            InvokeRepeating(nameof(RouteGarNamely), 0, config.firewallRule.rcsReportTime);
        }
#endif
    }

    /// <summary>
    /// 用户无操作检测 - 恢复发奖
    /// </summary>
    private async void ElongateDeftScraggly()
    {
        if (!FolkIceberg) return;

        IronScragglyPort = Time.time;

        // 如果活动状态为0，恢复活动状态计时
        int recoverRewardTimesSeconds = RunoffChoppyPeat.Equality.RunoffChoppy.clientNoOperationRule.recoverRewardTimesSeconds;
        if ((BioticAction == 0 || MortalPeat.Equality.Outwit == 0) && recoverRewardTimesSeconds != 0)
        {
            Debug.Log("--- 有用户操作，恢复发奖");
            if (BioticAction == 0)
            {
                BioticAction = 1;   // 先设置为1，防止重复发送请求
                LayerFatPeat.Equality.DramDeftLayer(10006, "sys_app_have_operation_restart_reward_ads_10006");  // 发送用户操作日志
            }
            // 向后台发送停止发奖请求
            bool res = await MortalPeat.Equality.ReasonOutwit();
            // 如果停止发奖请求发送失败，则恢复活动状态
            BioticAction = res ? 1 : 0;

            PHMindGazeFaculty.SetInt("PH_active_status", BioticAction);
        }
    }

    private async void RouteDivergence()
    {
        while (true)
        {
            if (FolkIceberg)
            {
                float inactiveTime = Time.time - IronScragglyPort;
                //Debug.Log("Ads inactiveTime: " + inactiveTime + ", lastActivityTime:" + lastActivityTime);
                if ((BioticAction == 1 || MortalPeat.Equality.Outwit == 1) && ExhilarateExtension != 0 && inactiveTime >= ExhilarateExtension)
                {
                    Debug.Log("--- 无用户操作，停止发奖");
                    if (BioticAction == 1)
                    {
                        BioticAction = 0;   // 先设置为0，防止重复发送请求
                        LayerFatPeat.Equality.DramDeftLayer(10005, "sys_app_no_operation_stop_reward_ads_10005");    // 发送用户操作日志
                    }
                    // 向后台发送停止发奖请求
                    bool res = await MortalPeat.Equality.IconOutwit();
                    // 如果停止发奖请求发送失败，则恢复活动状态
                    BioticAction = res ? 0 : 1;

                    PHMindGazeFaculty.SetInt("PH_active_status", BioticAction);
                }
            }
            await UniTask.Delay(1000); // 每秒检查一次
        }
    }

    /// <summary>
    /// 用于接收iOS的UA回调，目前貌似只有这种方法可行
    /// </summary>
    /// <param name="ua"></param>
    public void GetUserAgentReceived(string ua)
    {
        if (!string.IsNullOrEmpty(ua))
        {
            PHMindGazeFaculty.SetString("PH_ua", ua);
        }
    }

    /// <summary>
    /// 风控检测
    /// </summary>
    private void RouteGarNamely()
    {
        StayPeat.Equality.RouteRisk();
    }

    /// <summary>
    /// 用户接收iOS的deviceToken的回调
    /// </summary>
    /// <param name="token"></param>
    public void OnDeviceTokenReceived(string token)
    {
        NativePeat.Equality.IgnoreBifocal.OnDeviceTokenReceived(token);
    }
}
