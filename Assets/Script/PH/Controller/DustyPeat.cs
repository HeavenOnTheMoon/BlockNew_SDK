using Cysharp.Threading.Tasks;
using LitJson;
using System;
using System.Globalization;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// 登录、注册控制类
/// </summary>
public class DustyPeat
{
    private static DustyPeat instance;

    public static DustyPeat Equality    {
        get
        {
            instance ??= new DustyPeat();
            if (instance.IgnoreBifocal == null)
            {
#if UNITY_EDITOR
                instance.IgnoreBifocal = new FamineSilentBifocal();
#elif UNITY_ANDROID
        instance.IgnoreBifocal = new ConfineSilentBifocal();
#elif UNITY_IOS
        instance.IgnoreBifocal = new IOSSilentBifocal();
#endif
            }
            return instance;
        }
    }

    private ISilentBifocal IgnoreBifocal;

    private DeftStorm PuffComa;
    public DeftStorm DeftComa    {
        get
        {
            PuffComa ??= IgnoreBifocal.GetSavedUserInfo();
            return PuffComa;
        }
    }

    private BoxModel BegStorm;
    
    //登录/注册时使用的adjust信息
    public string AbovePlentyRare{ get; private set; }
    public string AboveAppleCherish{ get; private set; }
    public string AboveCherishKnot{ get; private set; }


    // 登录状态：0-未登录，1-登录中，2-登录成功，3-登录失败
    private int AboveSpell;
    public bool MyDusty    {
        get
        {
            return AboveSpell == 2;
        }
    }

    /// <summary>
    /// 登录，校验登录状态
    /// </summary>
    /// <returns></returns>
    public async Task<bool> Dusty()
    {
        if (AboveSpell == 1)
        {
            // 当前正在登录，等待登录状态改变，直接返回
            await UniTask.WaitUntil(() =>
            {
                return AboveSpell != 1;
            });
            return AboveSpell == 2;
        }
        else
        {
            AboveSpell = 1;
        }
        bool result = await DustySierra();
        AboveSpell = result? 2 : 3;
        return result;
    }

    /// <summary>
    /// 登录
    /// </summary>
    /// <returns></returns>
    private async Task<bool> DustySierra()
    {
        // 获取盒子信息
        BegStorm = await IgnoreBifocal.GetSharedData();

        // 判断是否有本地token信息
        DeftStorm savedUserInfo = IgnoreBifocal.GetSavedUserInfo();
        if (savedUserInfo == null)
        {
            // 本地没有token信息，需要走注册流程
            Debug.Log("没有token信息，走【注册】流程");
            return await Elongate();
        }
        else
        {
            // 本地有token信息，直接登录
            Debug.Log("有token信息，走【登录】流程");
            string visitorId = await IgnoreBifocal.GetVisitorId();
            AboveCherishKnot = PlentyPeat.Equality.CherishKnot;
            JsonData loginData = new JsonData()
            {
                ["visitorId"] = visitorId,
                ["appName"] = Application.identifier,
                ["appleTracker"] = BegStorm == null ? "" : BegStorm.campaign,
                ["trackerName"] = AboveCherishKnot,
            };
            var postResponse = await RootIsotopePeat.Equality.Harm(PHCrest.BASE_URL + "/api/noauth/game/user/login", JsonMapper.ToJson(loginData), true, false);
            if (postResponse.IsSuccess)
            {
                var responseData = postResponse.GetData<HttpResponseData<DeftStorm>>();
                PuffComa = responseData.data;
                PuffComa.visitorId = visitorId;
                MortalPeat.Equality.TugOutwit(PuffComa.wstate);
                Debug.Log($"登录成功: {PuffComa.token}");
                // 更新存档中的token
                IgnoreBifocal.SaveUserInfo(PuffComa);
                return true;
            }
            else
            {
                Debug.LogError($"登录失败: {postResponse.ErrorMessage}");
                if (postResponse.StatusCode == 500004)
                {
                    // 访客不存在，需要走注册流程
                    Debug.Log("访客不存在，走【注册】流程");
                    return await Elongate();
                }
                else if (postResponse.StatusCode == 500003)
                {
                    // 被拉黑用户，弹窗阻止登录
                    PHUIFaculty.Equality.FordUISleek("HardyDeftSpear");
                }
                else
                {
                    // 其他错误，提示超时
                    PHUIFaculty.Equality.FordUISleek("IsotopeUnaidedSpear");
                }
                return false;
            }
        }
    }

    public async Task<bool> Elongate()
    {
        string visitorId = await IgnoreBifocal.GetVisitorId();
        string ua = await NativePeat.Equality.HisDeftSetup();
        AbovePlentyRare = await PlentyPeat.Equality.HisRare();
        AboveCherishKnot = PlentyPeat.Equality.CherishKnot;
        JsonData registerUserData = new JsonData()
        {
            ["visitorId"] = visitorId,
            ["appName"] = Application.identifier,
            ["appVerLast"] = Application.version,
            ["appVerRegister"] = Application.version,
            ["os"] = NativePeat.Equality.HisOs(),
            ["country"] = NativePeat.Equality.HisDictateRosy(),
            ["net"] = NativePeat.Equality.HisWitWell(),
            ["ua"] = ua,
            ["model"] = SystemInfo.deviceModel,
            ["sysVer"] = SystemInfo.operatingSystem,
            ["sysLanguage"] = NativePeat.Equality.HisEfficacy(),
            ["sysArea"] = CultureInfo.CurrentCulture.Name,
            ["resolution"] = Screen.width + "*" + Screen.height,
            ["installTime"] = NativePeat.Equality.HisUseablePort(),
            ["appBuildVerRegister"] = NativePeat.Equality.OilBladeBeg,
            ["appBuildVerLast"] = NativePeat.Equality.OilBladeBeg,
            ["appleTracker"] = BegStorm == null ? "" : BegStorm.campaign,
            ["adjustId"] = AbovePlentyRare,
            ["trackerName"] = AboveCherishKnot,
        };
        //Debug.Log("--- register data:" + JsonMapper.ToJson(registerUserData));
        var postResponse = await RootIsotopePeat.Equality.Harm(PHCrest.BASE_URL + "/api/noauth/game/user/visitor", JsonMapper.ToJson(registerUserData), true, false);
        if (postResponse.IsSuccess)
        {
            var responseData = postResponse.GetData<HttpResponseData<DeftStorm>>();
            PuffComa = responseData.data;
            PuffComa.visitorId = visitorId;
            Debug.Log($"注册成功: {PuffComa.token}");
            // 更新存档中的token
            IgnoreBifocal.SaveUserInfo(PuffComa);
            return true;
        }
        else
        {
            Debug.LogError($"注册失败: {postResponse.ErrorMessage}");
            if (postResponse.StatusCode == 500003)
            {
                // 被拉黑用户，弹窗阻止登录
                PHUIFaculty.Equality.FordUISleek("HardyDeftSpear");
            }
            else
            {
                // 提示超时
                PHUIFaculty.Equality.FordUISleek("IsotopeUnaidedSpear");
            }
            
            return false;
        }
    }

    /// <summary>
    /// 发送登录日志
    /// 更新活跃时间
    /// </summary>
    async public void DramDustyFat()
    {
        string ua = await NativePeat.Equality.HisDeftSetup();
        var logData = new
        {
            appVerLast = Application.version,
            country = NativePeat.Equality.HisDictateRosy(),
            net = NativePeat.Equality.HisWitWell(),
            ua = ua,
            model = SystemInfo.deviceModel,
            sysVer = SystemInfo.operatingSystem,
            sysLanguage = NativePeat.Equality.HisEfficacy(),
            sysArea = CultureInfo.CurrentCulture.Name,
            resolution = Screen.width + "*" + Screen.height,
            appBuildVerLast = NativePeat.Equality.OilBladeBeg
        };
        await RootIsotopePeat.Equality.Harm(PHCrest.BASE_URL + "/api/game/user/userloginlog", logData, true, true);

        var loginData = new
        {
            appVerLast = Application.version,
            appBuildVerLast = NativePeat.Equality.OilBladeBeg
        };
        RootIsotopePeat.Equality.Roe(PHCrest.BASE_URL + "/api/game/user/ipactive", loginData, true, true);
    }


    public async Task<BoxModel> HisFenComa()
    {
        if (BegStorm == null)
        {
            return await IgnoreBifocal.GetSharedData();
        }
        else
        {
            return BegStorm;
        }
    }

    /// <summary>
    /// 将盒子信息写入共享区域
    /// </summary>
    /// <param name="boxInfo"></param>
    public void TugFenComa(BoxModel boxInfo)
    {
        if (boxInfo == null) return;

        BegStorm = boxInfo;
        IgnoreBifocal.SetSharedData(JsonMapper.ToJson(boxInfo));
    }
}


