using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHCrest
{
#if UNITY_ANDROID
    public static string BASE_URL = PHFaculty.Instance.Android_BASE_URL;  // 用户登录/注册相关接口的基础URL
    public static string BASE_URL_LOG = PHFaculty.Instance.Android_BASE_URL_LOG;  // 用户登录/注册相关接口的基础URL
#elif UNITY_IOS
    // 用户登录/注册相关接口的基础URL
    public static string BASE_URL
    {
        get { return PHFaculty.Instance.IOS_BASE_URL; }
    }  
    // 用户日志相关接口的基础URL
    public static string BASE_URL_LOG
    {
        get { return PHFaculty.Instance.IOS_BASE_URL_LOG; }
    }
#endif

}
