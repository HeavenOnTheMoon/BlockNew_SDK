﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// 消息管理器
/// </summary>
public class PreciseCinemaBliss:RomeEndocrine<PreciseCinemaBliss>
{
    //保存所有消息事件的字典
    //key使用字符串保存消息的名称
    //value使用一个带自定义参数的事件，用来调用所有注册的消息
    private Dictionary<string, Action<PreciseGaze>> ComprehendPrecise;

    /// <summary>
    /// 私有构造函数
    /// </summary>
    private PreciseCinemaBliss()
    {
        BankGaze();
    }

    private void BankGaze()
    {
        //初始化消息字典
        ComprehendPrecise = new Dictionary<string, Action<PreciseGaze>>();
    }

    /// <summary>

    /// 注册消息事件
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="action">消息事件</param>
    public void Elongate(string key, Action<PreciseGaze> action)
    {
        if (!ComprehendPrecise.ContainsKey(key))
        {
            ComprehendPrecise.Add(key, null);
        }
        ComprehendPrecise[key] += action;
    }



    /// <summary>
    /// 注销消息事件
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="action">消息事件</param>
    public void Saddle(string key, Action<PreciseGaze> action)
    {
        if (ComprehendPrecise.ContainsKey(key) && ComprehendPrecise[key] != null)
        {
            ComprehendPrecise[key] -= action;
        }
    }

    /// <summary>
    /// 发送消息
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="data">消息传递数据，可以不传</param>
    public void Dram(string key, PreciseGaze data = null)
    {
        if (ComprehendPrecise.ContainsKey(key) && ComprehendPrecise[key] != null)
        {
            ComprehendPrecise[key](data);
        }
    }

    /// <summary>
    /// 清空所有消息
    /// </summary>
    public void Virgo()
    {
        ComprehendPrecise.Clear();
    }
}
