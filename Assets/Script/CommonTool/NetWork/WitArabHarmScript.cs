/**
 * 
 * 网络请求的post对象
 * 
 * ***/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class WitArabHarmScript 
{
    //post请求地址
    public string URL;
    //post的数据表单
    public WWWForm Trap;
    //post成功回调
    public Action<UnityWebRequest> HarmIceberg;
    //post失败回调
    public Action HarmTile;
    public WitArabHarmScript(string url,WWWForm  form,Action<UnityWebRequest> success,Action fail)
    {
        URL = url;
        Trap = form;
        HarmIceberg = success;
        HarmTile = fail;
    }
}
