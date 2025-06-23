using System.Collections.Generic;

//登录服务器返回数据
public class RootData 
{
    public int code { get; set; }
    public string msg { get; set; }
    public RunoffGaze data { get; set; }
}
//用户登录信息
public class ServerUserData
{
    public int code { get; set; }
    public string msg { get; set; }
    public int data { get; set; }
}
//服务器的数据
public class RunoffGaze
{
    public string init { get; set; }
    public string game { get; set; }
    public string version { get; set; }

    public string apple_pie { get; set; }

    public string plan_AB { get; set; }
    public string inter_b2f_count { get; set; }
    public string inter_freq { get; set; }
    public string relax_interval { get; set; }
    public string trial_MaxNum { get; set; }
    public string nextlevel_interval { get; set; }
    public string adjust_init_rate_act { get; set; }
    public string adjust_init_act_position { get; set; }
    public string adjust_init_adrevenue { get; set; }
    public string soho_shop { get; set; }

}
public class Init
{
    public List<SlotItem> slot_group { get; set; }

    public string[] cash_random { get; set; }
    public MultiGroup[] cash_group { get; set; }
    public MultiGroup[] gold_group { get; set; }
    public MultiGroup[] amazon_group { get; set; }
}
public class Game
{
    /// <summary>
    /// 
    /// </summary>
    public WheelDataReward WheelReward { get; set; }
    public ScratchInfo ScratchInfo { get; set; }
    public int CashLimit { get; set; }
    public int CoinLimit { get; set; }
    public int EmptyBlock { get; set; }
    public int TargetBlockMaxCount { get; set; }
    public int TargetBlockMinCount { get; set; }
    public int RateUs { get; set; }
    public int Unlock_classic { get; set; }
    public string Cashmultiple { get; set; }
    public string OnceSource { get; set; }
    public string OnceWeight { get; set; }
    
    public int FinishLimit { get; set; }
    public List <RewardItem> SuccessInfo { get; set; }
    
    public SourceRewardInfo SourceRewards { get; set; }
    public BoxInfo BoxInfo { get; set; }

    public List<RewardItem> BlockReward { get; set; }
    
    public int RewardBlockNumLimit;  // 空格子上生成奖励的数量限制

    public bool ShowAdventure;     // 是否显示Adventure模式
}

public class BoxInfo
{
    public List<RewardItem> BoxReward { get; set; }
    public List<MultiplierBox> MultiplierInfo { get; set; }
}

public class MultiplierBox
{
    public string Multiplier { get; set; }
    public int weight { get; set; }
}

public class ScratchInfo
{
    public int AppearCount { get; set; }
    public List <RewardItem> ScratchRewardInfo { get; set; }
    public List <ScraCount> ScratchCountInfo { get; set; } 
}

public class ScraCount
{
    public int count{ get; set; }
    public int weight{ get; set; }
    public string multi{ get; set; }
}
public class WheelDataReward
{
    /// <summary>
    /// 
    /// </summary>
    public int ShowCount { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List <RewardItem > Reward { get; set; }
}

public class SourceRewardInfo
{
    public int dailyMaxSource { get; set; }
    public int oneQuarter { get; set; }
    public int twoQuarter { get; set; }
    public int threeQuarter { get; set; }
    public int fourQuarter { get; set; }
}

public class RewardItem
{
    /// <summary>
    /// 
    /// </summary>
    public int id { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string type { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string multiple { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int weight { get; set; }
}
public class SlotItem
{
    public int multi { get; set; }
    public int weight { get; set; }
}

public class MultiGroup
{
    public int max { get; set; }
    public int multi { get; set; }
}
