using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerFatPeat
{
    private static LayerFatPeat instance;

    public static LayerFatPeat Equality    {
        get
        {
            if (instance == null)
            {
                instance = new LayerFatPeat();
                instance.BankGaze();
            }
            return instance;
        }
    }

    private void BankGaze()
    {
        CoinErectAx = PHVolt.Network();

        OxLayerFatBifocal = new ByLayerFatBifocal();
        dauLayerFatBifocal = new UrnLayerFatBifocal();
        GirderLayerFatBifocal = new MortalLayerFatBifocal();
        PuffLayerFatBifocal = new DeftLayerFatBifocal();
    }

    public long CoinErectAx{ get; private set; }    // 打开的批次号，每次打开游戏时初始化，取时间戳
    
    private ByLayerFatBifocal OxLayerFatBifocal;            // 广告事件
    private UrnLayerFatBifocal dauLayerFatBifocal;          // 日活事件
    private MortalLayerFatBifocal GirderLayerFatBifocal;    // 奖励事件
    private DeftLayerFatBifocal PuffLayerFatBifocal;        // 用户行为事件


    /// <summary>
    /// 单次上报广告事件
    /// </summary>
    public void DramByLayer(string eventCode, string eventType, decimal revenue, string eventJson, int event_num = -1)
    {
        if (!RouteLayerDramAction(EventLogType.Ad, event_num)) return;

        ByLayerFatStorm model = new ByLayerFatStorm(eventCode, eventType, revenue, eventJson);
        OxLayerFatBifocal.DramLayer(model);
    }

    /// <summary>
    /// 单次上报日活事件
    /// </summary>
    /// <param name="eventName"></param>
    public void DramUrnLayer(int event_num, string eventName, long duration)
    {
        if (!RouteLayerDramAction(EventLogType.Dau, event_num)) return;

        DauEventLogModel model = new DauEventLogModel(eventName, duration);
        dauLayerFatBifocal.DramLayer(model);
    }

    /// <summary>
    /// 单次上报奖励事件
    /// </summary>
    /// <param name="eventCode"></param>
    public void DramMortalLayer(int event_num, string eventCode)
    {
        if (!RouteLayerDramAction(EventLogType.Reward, event_num)) return;

        RewardEventLogModel model = new RewardEventLogModel(eventCode);
        GirderLayerFatBifocal.DramLayer(model);
    }

    /// <summary>
    /// 单次上报用户行为事件
    /// </summary>
    /// <param name="eventName"></param>
    public void DramDeftLayer(int event_num, string eventName, string eventJson = "")
    {
        if (!RouteLayerDramAction(EventLogType.User, event_num)) return;

        UserEventLogModel model = new UserEventLogModel(eventName, eventJson);
        PuffLayerFatBifocal.DramLayer(model);
    }

    /// <summary>
    /// 批量上报用户行为事件
    /// </summary>
    public void ErectDramDeftLayer()
    {
        if (!RouteLayerDramAction(EventLogType.User, -1)) return;

        PuffLayerFatBifocal.ErectDramLayer();
    }

    /// <summary>
    /// 根据后台配置，查看是否可以发送事件
    /// </summary>
    /// <param name="type"></param>
    /// <param name="event_num"></param>
    /// <returns></returns>
    public bool RouteLayerDramAction(EventLogType type, int event_num = -1)
    {
        RunoffChoppyStorm config = RunoffChoppyPeat.Equality.RunoffChoppy;
        if (config == null) return true;

        EventsIsClose eventsIsClose = null;
        switch (type)
        {
            case EventLogType.Ad:
                eventsIsClose = config.advEventsIsClose;
                break;
            case EventLogType.Reward:
                eventsIsClose = config.rewardsEventsIsClose;
                break;
            case EventLogType.User:
                eventsIsClose = config.userEventsIsClose;
                break;
            case EventLogType.Dau:
                eventsIsClose = config.dauEventsIsClose;
                break;
            default:
                break;
        }
        if (eventsIsClose == null) return true;
        
        if (eventsIsClose.status == 0) return false;
        
        if (eventsIsClose.eventListIsClose != null && eventsIsClose.eventListIsClose.Contains(event_num)) return false;

        // 如果是奖励事件，还需要判断每个奖励事件的状态和时间间隔
        if (type == EventLogType.Reward)
        {
            if (!MortalPeat.Equality.RouteMortalAction(event_num))
            {
                return false;
            }
        }

        return true;
    }
}

public enum EventLogType
{
    User,       // 用户行为
    Reward,     // 奖励
    Ad,         // 广告
    Dau         // 日活
}
