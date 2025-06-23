/**
 * 
 * 网络请求管理器
 * 
 * ***/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class WitArabFaculty : RomeEndocrine<WitArabFaculty>
{
    //get请求列表
    private List<WitArabHisScript> WitArabHisName;
    //post请求列表
    private List<WitArabHarmScript> WitArabHarmName;
    public WitArabFaculty()
    {
        //初始化
        WitArabHisName = new List<WitArabHisScript>();
        WitArabHarmName = new List<WitArabHarmScript>();
    }

    /// <summary>
    /// 获取当前Get请求列表中请求的个数
    /// </summary>
    public int HisWitArabHisNameExtol{
        get { return WitArabHisName.Count; }
    }

    /// <summary>
    /// 获取当前Post请求列表中请求的个数
    /// </summary>
    public int HisWitArabHarmNameExtol    {
        get { return WitArabHarmName.Count; }
    }

    /// <summary>
    /// Get请求
    /// </summary>
    /// <param name="url">Get请求的URL</param>
    /// <param name="success">Get请求成功的回调</param>
    /// <param name="fail">Get请求失败的回调</param>
    public void RootHis(string url,Action<UnityWebRequest> success,Action fail)
    {
        if (string.IsNullOrEmpty(url))
        {
            Debug.Log("HttpGet请求URL地址不能为空");
            return;
        }
        WitArabHisScript o = new WitArabHisScript(url, success, fail);
        //添加到管理列表中
        WitArabHisName.Add(o);
        //开始请求
       StartCoroutine("His", o);
    }

    /// <summary>
    /// Post请求
    /// </summary>
    /// <param name="url">Post请求的URL</param>
    /// <param name="form">Post请求的表单数据</param>
    /// <param name="success">Post请求成功的回调</param>
    /// <param name="fail">Post请求失败的回调</param>
    public void RootHarm(string url,WWWForm form, Action<UnityWebRequest> success,Action fail)
    {
        if (string.IsNullOrEmpty(url))
        {
            Debug.Log("HttpPost请求URL地址不能为空");
            return;
        }
        WitArabHarmScript o = new WitArabHarmScript(url, form, success, fail);
        //添加到post请求管理列表中
        WitArabHarmName.Add(o);
        //开始请求
        StartCoroutine("Harm", o);
    }

    /// <summary>
    /// Get请求的协程
    /// </summary>
    /// <param name="obj">Get请求对象</param>
    /// <returns></returns>
    IEnumerator His(WitArabHisScript obj)
    {
        UnityWebRequest webRequest = UnityWebRequest.Get(obj.Rye);
        webRequest.SendWebRequest();
        while (!webRequest.isDone)
        {
            yield return 1;
        }
        if (webRequest.isDone)
        {
            //从管理列表中移除
            if (WitArabHisName.Contains(obj))
            {
                WitArabHisName.Remove(obj);
            }
        }
        //yield return webRequest.SendWebRequest();
        //异常处理,请求失败
        if (webRequest.isHttpError || webRequest.isNetworkError)
        {
            Debug.Log("请求"+ obj.Rye+"失败，错误："+webRequest.error);
            obj.HisTile();
        }else
        {
            //Debug.Log(webRequest.downloadHandler.text);
            obj.HisIceberg(webRequest);
        }      
        //终止本次协程
        yield break;
    }



    /// <summary>
    /// Post协程
    /// </summary>
    /// <returns></returns>
    IEnumerator Harm(WitArabHarmScript obj)
    {
        //WWWForm form = new WWWForm();
        ////键值对
        //form.AddField("key", "value");
        //form.AddField("name", "mafanwei");
        //form.AddField("blog", "qwe25878");

        UnityWebRequest webRequest = UnityWebRequest.Post(obj.URL, obj.Trap);

        yield return webRequest.SendWebRequest();
        //异常处理
        if (webRequest.isHttpError || webRequest.isNetworkError)
        {
            Debug.Log("Post请求"+obj.URL+"失败，错误："+webRequest.error);
            obj.HarmTile();
        } else
        {
            obj.HarmIceberg(webRequest);
            //Debug.Log(webRequest.downloadHandler.text);
        }

        //从管理列表中移除
        if (WitArabHarmName.Contains(obj))
        {
            WitArabHarmName.Remove(obj);
        }
        //终止本次协程
        yield break;
    }
}
