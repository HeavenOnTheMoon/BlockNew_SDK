using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// 日活事件日志服务
/// 批量上报
/// </summary>
public class UrnLayerFatBifocal : AlgaLayerFatBifocal<DauEventLogModel>
{
    public UrnLayerFatBifocal()
    {
        Fox = PHCrest.BASE_URL_LOG + "/api/game/eventpagelog";
        ChunkInductMayor = 0;
        SoCounsel = false;
        TractorPhylum = new List<DauEventLogModel>();
    }

    /// <summary>
    /// 单次上报
    /// 读取后台配置eventSendRule:
    /// 如果是实时上报，直接调用接口
    /// 如果是批量上报，将事件放入等待列表，等待后台定时上报
    /// </summary>
    /// <param name="eventName"></param>
    override public async void DramLayer(DauEventLogModel eventLogModel)
    {
        eventLogModel.eventFiringOrder = ++ChunkInductMayor;

        // 根据配置判断是否实时上报，还是批量上报
        if (RunoffChoppyPeat.Equality.RunoffChoppy == null || RunoffChoppyPeat.Equality.RunoffChoppy.EventSendMethod.dauEvents == 1)
        {
            // 批量上报
            TractorPhylum.Add(eventLogModel);
        }
        else
        {
            bool isSuccess = await HarmLayer(new List<DauEventLogModel>() { eventLogModel });
            if (!isSuccess)
            {
                // 如果实时上报失败，将事件放入等待列表
                TractorPhylum.Add(eventLogModel);
            }
        }
    }
}
