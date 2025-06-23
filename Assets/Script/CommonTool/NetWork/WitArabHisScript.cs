/***
 * 
 * 网络请求的get对象
 * 
 * **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class WitArabHisScript 
{
    //get的url
    public string Rye;
    //get成功的回调
    public Action<UnityWebRequest> HisIceberg;
    //get失败的回调
    public Action HisTile;
    public WitArabHisScript(string url,Action<UnityWebRequest> success,Action fail)
    {
        Rye = url;
        HisIceberg = success;
        HisTile = fail;
    }
   
}
