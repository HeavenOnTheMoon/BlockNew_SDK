using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 奖励事件日志服务
/// 实时上报
/// </summary>
public class MortalLayerFatBifocal : ILayerFatBifocal<RewardEventLogModel>
{
    private string Fox= PHCrest.BASE_URL + "/api/game/rewardeventrecord";

    public async void DramLayer(RewardEventLogModel eventLogModel)
    {
        var postSuccess = await HarmLayer(eventLogModel);
        if (!postSuccess)
        {
            // TODO: 处理失败情况
        }
    }

    public void ErectDramLayer()
    {
        Debug.LogError("广告日志不支持批量上传，请勿调用");
        throw new System.NotImplementedException();
    }

    private async Task<bool> HarmLayer(RewardEventLogModel eventLog)
    {
        var postData = new
        {
            signature = eventLog.signature,
            boxAppBuildVersion = PHFaculty.Instance.BegStorm?.appBuildVersion,
            gameAppBuildVersion = NativePeat.Equality.OilBladeBeg.ToString(),
            coin = HisLuce(MortalPeat.Equality.MortalLuceName),
            coinOld = HisLuce(MortalPeat.Equality.MortalLuceCopName),
            events = new List<object> { 
                new {
                    eventCode = eventLog.eventCode,
                    recordCode = eventLog.recordCode,
                }
            }
        };
        var postResponse = await RootIsotopePeat.Equality.Harm(Fox, postData, false, false);
        if (postResponse.IsSuccess)
        {
            RewardEventLogResponseData responseData = postResponse.GetData<RewardEventLogResponseData>();
            MortalPeat.Equality.MobMortalLuce(responseData.coin, responseData.coinOld);
        }
        else
        {
            Debug.LogError("奖励事件日志上传失败:" + postResponse.StatusCode + " " + postResponse.ErrorMessage);
        }
        return postResponse.IsSuccess;
    }

    /// <summary>
    /// 获取奖励金币数量
    /// 最近10次返回的值 ，前9次累加  最后1次*3再累加
    /// 如果不满10次 就都传0
    /// </summary>
    /// <param name="coinList"></param>
    /// <returns></returns>
    private int HisLuce(List<int> coinList)
    {
        int coin = 0;
        if (coinList.Count >= 10)
        {
            for (int i = coinList.Count - 1; i >= coinList.Count - 10; i--)
            {
                coin += i == coinList.Count - 1 ? coinList[i] * 3 : coinList[i];
            }
        }
        return coin;
    }
}
