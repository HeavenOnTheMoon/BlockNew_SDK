using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPuzzleGameUtil
{
    /// <summary>
    /// 获取multi系数
    /// </summary>
    /// <returns></returns>
    private static double HisExalt(RewardType type, double cumulative, MultiGroup[] multiGroup)
    {
        foreach (MultiGroup item in multiGroup)
        {
            if (item.max > cumulative)
            {
                if (type == RewardType.Cash)
                {
                    float Cement= Random.Range((float.Parse(WitComaEka.instance.BankGaze.cash_random[0])), (float.Parse(WitComaEka.instance.BankGaze.cash_random[1])));
                    return item.multi * (1 + Cement);
                }
                else
                {
                    return item.multi;
                }
            }
        }
        return 1;
    }

    public static double HisFromExalt()
    {
        return HisExalt(RewardType.Gold, MindGazeFaculty.GetDouble(CChoppy.Of_InnovationFromLuce), WitComaEka.instance.BankGaze.gold_group);
    }

    public static double HisHurlExalt()
    {
        return HisExalt(RewardType.Cash, MindGazeFaculty.GetDouble(CChoppy.Of_InnovationMeter), WitComaEka.instance.BankGaze.cash_group);
    }
    public static double HisCorsetExalt()
    {
        return HisExalt(RewardType.Amazon, MindGazeFaculty.GetDouble(CChoppy.Of_InnovationCorset), WitComaEka.instance.BankGaze.amazon_group);
    }
}


/// <summary>
/// 奖励类型
/// </summary>
public enum RewardType { Gold, Cash, Amazon }
