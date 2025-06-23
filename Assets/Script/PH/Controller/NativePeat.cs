using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using UnityEngine;

public class NativePeat
{
    private static NativePeat instance;

    public static NativePeat Equality    {
        get
        {
            instance ??= new NativePeat();
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

    public ISilentBifocal IgnoreBifocal;


    private int appBladeVer;
    public int OilBladeBeg    {
        get
        {
            if (appBladeVer == 0)
            {
                appBladeVer = IgnoreBifocal.GetAppBuildVer();
            }
            return appBladeVer;
        }
    }

    public string HisDictateRosy()
    {
        return RegionInfo.CurrentRegion.TwoLetterISORegionName;
    }

    /// <summary>
    /// 获取安装时间
    /// </summary>
    /// <returns></returns>
    public string HisUseablePort()
    {
        string installTime = PHMindGazeFaculty.GetString("PH_installTime");
        if (string.IsNullOrEmpty(installTime))
        {
            installTime = IgnoreBifocal.GetInstallTime();
            PHMindGazeFaculty.SetString("PH_installTime", installTime);
        }
        return installTime;
    }


    async public Task<string> HisDeftSetup()
    {
        return await IgnoreBifocal.GetUserAgent();
    }

    /// <summary>
    /// 获取操作系统类型
    /// </summary>
    /// <returns></returns>
    public int HisOs()
    {
        int os = 0;
#if UNITY_ANDROID
        os = 2;
#elif UNITY_IOS
        os = 1;
#endif
        return os;
    }

    public string HisWitWell()
    {
        NetworkReachability internetStatus = Application.internetReachability;
        switch (internetStatus)
        {
            case NetworkReachability.ReachableViaLocalAreaNetwork:
                return "wifi";
            case NetworkReachability.ReachableViaCarrierDataNetwork:
                return "mobile";
            default:
                return "none";
        }
    }

    public string HisEfficacy()
    {
        SystemLanguage language = Application.systemLanguage;
        switch (language)
        {
            case SystemLanguage.Chinese:
                return "zh";
            case SystemLanguage.ChineseSimplified:
                return "zh";
            case SystemLanguage.ChineseTraditional:
                return "zh";
            case SystemLanguage.English:
                return "en";
            case SystemLanguage.French:
                return "fr";
            case SystemLanguage.German:
                return "de";
            case SystemLanguage.Italian:
                return "it";
            case SystemLanguage.Japanese:
                return "ja";
            case SystemLanguage.Korean:
                return "ko";
            case SystemLanguage.Portuguese:
                return "pt";
            case SystemLanguage.Russian:
                return "ru";
            case SystemLanguage.Spanish:
                return "es";
            default:
                return "en";
        }
    }
}
