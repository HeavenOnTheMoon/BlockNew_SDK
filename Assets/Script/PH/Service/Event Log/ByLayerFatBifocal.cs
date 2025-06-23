using UnityEngine;

/// <summary>
/// 广告播放日志服务
/// 实时上报
/// </summary>
public class ByLayerFatBifocal : ILayerFatBifocal<ByLayerFatStorm>
{
    private string Fox= PHCrest.BASE_URL_LOG + "/api/game/gameeventadslog";

    public void ErectDramLayer()
    {
        Debug.LogError("广告日志不支持批量上传，请勿调用");
        throw new System.NotImplementedException();
    }

    public void DramLayer(ByLayerFatStorm eventLogModel)
    {
        RootIsotopePeat.Equality.Harm(Fox, eventLogModel, true, true);
    }
}


public enum AdEventType
{
    Loaded,
    LoadFailed,
    Displayed,
    Clicked,
    RevenuePaid,
    Hidden,
    DisplayFailed,
    ReceivedReward,
    StartShow           // 触发广告播放
}