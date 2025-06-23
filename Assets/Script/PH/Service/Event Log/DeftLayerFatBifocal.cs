using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// 用户行为事件日志服务
/// 批量上报
/// </summary>
public class DeftLayerFatBifocal : AlgaLayerFatBifocal<UserEventLogModel>
{
    public DeftLayerFatBifocal()
    {
        Fox = PHCrest.BASE_URL_LOG + "/api/game/eventlog";
        ChunkInductMayor = 0;
        SoCounsel = false;
        TractorPhylum = new List<UserEventLogModel>();
    }

    override public async void DramLayer(UserEventLogModel eventLogModel)
    {
        eventLogModel.eventFiringOrder = ++ChunkInductMayor;
        // 根据配置判断是否实时上报，还是批量上报
        if (RunoffChoppyPeat.Equality.RunoffChoppy == null || RunoffChoppyPeat.Equality.RunoffChoppy.EventSendMethod.userEvents == 1)
        {
            // 批量上报
            TractorPhylum.Add(eventLogModel);
        }
        else
        {
            await HarmLayer(new List<UserEventLogModel>() { eventLogModel });
        }
    }

}
