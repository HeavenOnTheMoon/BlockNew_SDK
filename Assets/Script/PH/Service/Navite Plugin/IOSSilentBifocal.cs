using LitJson;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

/// <summary>
/// iOS平台相关的Native接口实现
/// </summary>
public class IOSSilentBifocal : ISilentBifocal
{
    [DllImport("__Internal")]
    private static extern string UnityGetIDFV();

    [DllImport("__Internal")]
    private static extern string UnityGetInstallDate();

    [DllImport("__Internal")]
    private static extern string UnityGetSharedKeychainValue(string key, string service);

    [DllImport("__Internal")]
    private static extern string UnityGetKeychainValue(string key);

    [DllImport("__Internal")]
    private static extern string UnitySaveKeychainValue(string key, string value);


    /// <summary>
    /// 和iOS平台相关的Native接口实现
    /// </summary>
    public Task<string> GetVisitorId()
    {
        // 1、先查询本地存储的visitorId
        DeftStorm savedUserInfo = GetSavedUserInfo();
        if (savedUserInfo!= null && !string.IsNullOrEmpty(savedUserInfo.visitorId))
        {
            return Task.FromResult(savedUserInfo.visitorId);
        }

        // 2、如果获取不到visitorId，则尝试获取IDFV
        string idfvStr = UnityGetIDFV();
        if (!string.IsNullOrEmpty(idfvStr) && !idfvStr.Equals("00000000-0000-0000-0000-000000000000"))
        {
            return Task.FromResult(idfvStr);
        }

        // 3、如果以上方式都获取不到的话，使用UUID作为visitorId
        return Task.FromResult(PHVolt.HisUUID());
    }


    
    public string GetInstallTime()
    {
        return UnityGetInstallDate();
    }

    [DllImport("__Internal")]
    private static extern string UnityGetUserAgent();
    async public Task<string> GetUserAgent()
    {
        if (!string.IsNullOrEmpty(PHMindGazeFaculty.GetString("PH_ua")))
        {
            return PHMindGazeFaculty.GetString("PH_ua");
        }
        UnityGetUserAgent();
        // iOS获取ua是异步获取的，此处等待1s，如果未获取到，则不再等待，返回空
        CancellationTokenSource cts = new CancellationTokenSource(1000); // 1秒超时
        try
        {
            await Task.Run(async () =>
            {
                while (string.IsNullOrEmpty(PHMindGazeFaculty.GetString("PH_ua")))
                {
                    await Task.Delay(100, cts.Token); // 每100ms检查一次，避免高频轮询
                }
            }, cts.Token);
        }
        catch (TaskCanceledException)
        {
            // 超时后返回空
            return PHMindGazeFaculty.GetString("PH_ua");
        }

        // 4. 返回最终结果（可能是新获取的 UA，也可能是空）
        return PHMindGazeFaculty.GetString("PH_ua");
    }

    [DllImport("__Internal")]
    private static extern string UnityGetBuildVersion();
    public int GetAppBuildVer()
    {
        string version = UnityGetBuildVersion();
        return int.Parse(version);
    }

    /// <summary>
    /// 共享区域数据
    /// </summary>
    /// <returns></returns>
    public Task<BoxModel> GetSharedData()
    {
        string key = "com.green.task.app";
        string service = "com.playhive.task.app";
        string referrer = UnityGetSharedKeychainValue(key, service);
        Debug.Log("--- keychain:" + referrer);
        referrer = PHVolt.RouteHeritage(referrer);
        BoxModel referrerModel = null;
        if (!string.IsNullOrEmpty(referrer) && PHVolt.MyMuralRoam(referrer))
        {
            referrerModel = JsonMapper.ToObject<BoxModel>(referrer);
        }
        return Task.FromResult(referrerModel);
    }

    /// <summary>
    /// 设置共享区域数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [DllImport("__Internal")]
    private static extern string UnitySetSharedKeychainValue(string key, string service, string value);
    public string SetSharedData(string value)
    {
        string key = "com.green.task.app";
        string service = "com.playhive.task.app";
        string res = UnitySetSharedKeychainValue(key, service, value);
        return res;
    }

    /// <summary>
    /// 获取存档的用户信息
    /// </summary>
    /// <returns></returns>
    public DeftStorm GetSavedUserInfo()
    {
        string savedKeychain = UnityGetKeychainValue("IOSJSON");
        if (string.IsNullOrEmpty(savedKeychain))
        {
            savedKeychain = PHMindGazeFaculty.GetString("PH_user_info");
        }
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
        UnitySaveKeychainValue("IOSJSON", str);
        PHMindGazeFaculty.SetString("PH_user_info", str);
    }

    public void ClearSavedUserInfo()
    {
        UnitySaveKeychainValue("IOSJSON", "");
        PHMindGazeFaculty.SetString("PH_user_info", "");
    }

    [DllImport("__Internal")]
    private static extern void GenerateDeviceToken();

    private Action<string> riskManagementCallback;
    /// <summary>
    /// 风险控制，获取设备Token
    /// </summary>
    public void RiskManagement(Action<string> callback)
    {
        riskManagementCallback = callback;
        GenerateDeviceToken();
    }

    /// <summary>
    /// 设备Token回调
    /// </summary>
    /// <param name="deviceToken"></param>
    public void OnDeviceTokenReceived(string deviceToken)
    {
        riskManagementCallback?.Invoke(deviceToken);
    }


    [DllImport("__Internal")]
    private static extern string IsVPNConnected();


    public string CheckVPN()
    {
        string res = IsVPNConnected();
        return res;
    }

    [DllImport("__Internal")]
    private static extern string GetScreenLogicalSize();
    public Vector2 GetLogicalSize()
    {
        string size = GetScreenLogicalSize();
        string[] sizes = size.Split('*');
        float width = float.Parse(sizes[0]);
        float height = float.Parse(sizes[1]);
        return new Vector2(width, height);
    }

    [DllImport("__Internal")]
    private static extern void UnityInitSensors();
    [DllImport("__Internal")]
    private static extern string UnityGetAccelerometerstr();
    [DllImport("__Internal")]
    private static extern string UnityGetGyroscopestr();
    [DllImport("__Internal")]
    private static extern string UnityGetMagnetometerstr();
    [DllImport("__Internal")]
    private static extern string UnityGetDeviceAttitudestr();
    public ClementStorm GetSensorsData()
    {
        UnityInitSensors();
        ClementStorm model = new ClementStorm();
        // 加速度计
        string accStr = UnityGetAccelerometerstr();
        Debug.Log("--- 原生代码获取加速计:" + accStr);
        model.accelerometer = accStr;
        // 陀螺仪
        string gyroscope = UnityGetGyroscopestr();
        Debug.Log("--- 原生代码获取陀螺仪:" + gyroscope);
        model.gyroscope = gyroscope;
        // 磁力计
        string magnetometer = UnityGetMagnetometerstr();
        Debug.Log("--- 原生代码获取磁力计:" + magnetometer);
        model.magnetometer = magnetometer;
        // 设备姿态
        string deviceAttitude = UnityGetDeviceAttitudestr();
        Debug.Log("--- 原生代码获取设备姿态:" + deviceAttitude);
        model.equipmentPosture = deviceAttitude;

        return model;
    }
}

