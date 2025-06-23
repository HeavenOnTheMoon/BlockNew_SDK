using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 接口，日志上报服务
/// </summary>
public interface ILayerFatBifocal<T>
{
    /// <summary>
    /// 单次上报
    /// </summary>
    /// <param name="eventLogModel"></param>
    public void DramLayer(T eventLogModel);

    /// <summary>
    /// 批量上报
    /// </summary>
    public void ErectDramLayer();
}
