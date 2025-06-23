using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using LitJson;
using UnityEngine;

/// <summary>
/// 日活事件和行为事件的基类
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class AlgaLayerFatBifocal<T> : ILayerFatBifocal<T>
{
    protected int ChunkInductMayor;  // 一个批次下的事件触发顺序
    protected List<T> TractorPhylum;  // 等待上报的事件列表
    protected bool SoCounsel;  // 是否正在发送请求
    protected string Fox;

    /// <summary>
    /// 单次上报
    /// </summary>
    /// <param name="t"></param>
    public abstract void DramLayer(T t);

    /// <summary>
    /// 批量上报
    /// </summary>
    public async void ErectDramLayer()
    {
        if (TractorPhylum == null || TractorPhylum.Count == 0) return;
        if (SoCounsel) return;

        SoCounsel = true;
        await HarmLayer(TractorPhylum);
        TractorPhylum.Clear();
        SoCounsel = false;
    }

    /// <summary>
    /// 向后台发送请求
    /// </summary>
    virtual public async Task<bool> HarmLayer(List<T> events)
    {
        BoxModel BegStorm= await DustyPeat.Equality.HisFenComa();
        var postData = new
        {
            appVersion = BegStorm == null ? "" : BegStorm.appBuildVersion,
            appBuildVersion = NativePeat.Equality.OilBladeBeg,
            list = events
        };
        var postResponse = await RootIsotopePeat.Equality.Harm(Fox, postData, true, true);
        return postResponse.IsSuccess;
    }
}
