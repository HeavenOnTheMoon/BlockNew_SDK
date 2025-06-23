using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByLayerFatStorm
{
    public string eventCode;            // 游戏apid + 用户id + 日期时间戳 + 5位顺序号
    public string eventType;            // 事件类型，例如ad_load_success_10001
    public string gameAppBuildVersion;  // 上报事件时候的APP构建版本号（游戏）
    public string boxAppBuildVersion;   // 上报事件时候的APP构建版本号（盒子）
    public decimal revenue;             // 展示收益
    public long clientTimeLong;         // 客户端时间戳-毫秒值（事件产生的时间）
    public string eventJson;            // 事件的json数据

    public ByLayerFatStorm(string eventCode, string eventType, decimal revenue, string eventJson = "")
    {
        this.eventCode = eventCode;
        this.eventType = eventType;
        gameAppBuildVersion = NativePeat.Equality.OilBladeBeg.ToString();
        boxAppBuildVersion = PHFaculty.Instance.BegStorm == null ? "" : PHFaculty.Instance.BegStorm.appBuildVersion;
        this.revenue = revenue;
        clientTimeLong = PHVolt.NetworkSolo();
        this.eventJson = eventJson;
    }
}


public class DauEventLogModel
{
    public string eventName;        // 事件名称
    public long clientTimeLong;     // 客户端时间戳（UTC 0时区）
    public long duration;           // 事件总用时（单位毫秒）
    public long openBatchId;        // 游戏打开时的批次号
    public int eventFiringOrder;    // 事件触发顺序

    public DauEventLogModel(string eventName, long duration)
    {
        this.eventName = eventName;
        clientTimeLong = PHVolt.NetworkSolo();
        this.duration = duration;
        openBatchId = LayerFatPeat.Equality.CoinErectAx;
    }
}


public class UserEventLogModel
{
    public string eventName;        // 事件名称
    public long clientTimeLong;     // 客户端时间戳（UTC 0时区）
    public long openBatchId;        // 游戏打开时的批次号
    public int eventFiringOrder;    // 事件触发顺序
    public string eventJson;        // 事件参数

    public UserEventLogModel(string eventName, string eventJson)
    {
        this.eventName = eventName;
        clientTimeLong = PHVolt.NetworkSolo();
        openBatchId = LayerFatPeat.Equality.CoinErectAx;
        this.eventJson = eventJson;
    }
}