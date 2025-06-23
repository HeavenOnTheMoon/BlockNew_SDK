using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayPeat
{
    private static StayPeat instance;

    public static StayPeat Equality    {
        get
        {
            instance ??= new StayPeat();
            return instance;
        }
    }

    /// <summary>
    /// 风险检测
    /// </summary>
    public void RouteRisk()
    {
#if UNITY_EDITOR
        // 编辑器下不进行风险检测
        Debug.Log("--- Risk detection in editor");
#elif UNITY_IOS
        // 获取设备Token，等待回调
        NativePeat.Equality.IgnoreBifocal.RiskManagement(EuropeMeterMichigan);
#elif UNITY_ANDROID
        // TODO
#endif
    }

    /// <summary>
    /// 设备token回调，上报用户信息日志
    /// </summary>
    /// <param name="token"></param>
    private void EuropeMeterMichigan(string token)
    {
        Debug.Log("--- Device token: " + token);
        if (string.IsNullOrEmpty(token) || token == "Error" || token == "Unsupported")
        {
            Debug.Log("--- Device token is null or error, please check your device.");
            token = "";
        }

        string vpn = NativePeat.Equality.IgnoreBifocal.CheckVPN();  // 是否开启VPN
        Vector2 Stay= NativePeat.Equality.IgnoreBifocal.GetLogicalSize();
        JsonData Pool= new()
        {
            ["model"] = SystemInfo.deviceModel,
            ["appBuildVerLast"] = NativePeat.Equality.OilBladeBeg,
            ["vpn"] = vpn,
            ["deviceCheckToken"] = token,
            ["sizeWidth"] = (int)Stay.x,
            ["sizeHigh"] = (int)Stay.y,
            ["pixelWidth"] = Screen.width,
            ["pixelHigh"] = Screen.height,
            ["sysVer"] = SystemInfo.operatingSystem,
            ["os"] = NativePeat.Equality.HisOs(),
        };
        // 传感器数据
        ClementStorm sensorsModel = NativePeat.Equality.IgnoreBifocal.GetSensorsData();
        if (sensorsModel != null)
        {
            Pool["accelerometer"] = sensorsModel.accelerometer;
            Pool["gyroscope"] = sensorsModel.gyroscope;
            Pool["magnetometer"] = sensorsModel.magnetometer;
            Pool["equipmentPosture"] = sensorsModel.equipmentPosture;
        }
        string signature = PHVolt.UpOutfitWanSeedyHuddle(Pool);
        Pool["signature"] = PHVolt.DramatizeMD5(DustyPeat.Equality.DeftComa.pre + signature + "gamebox");
        RootIsotopePeat.Equality.Harm(PHCrest.BASE_URL + "/api/game/gameuserinfolog", JsonMapper.ToJson(Pool), true, false);
    }
}
