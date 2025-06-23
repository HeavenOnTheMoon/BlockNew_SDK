/**
 * 
 * 常量配置
 * 
 * 
 * **/
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CChoppy
{
    #region 常量字段
    //登录url
    public const string DustyUrl= "/api/client/user/getId?gameCode=";
    //配置url
    public const string ChoppyRye= "/api/client/config?gameCode=";
    //时间戳url
    public const string PortRye= "/api/client/common/current_timestamp?gameCode=";
    //更新AdjustId url
    public const string PlentyRye= "/api/client/user/setAdjustId?gameCode=";
    #endregion

    #region 本地存储的字符串
    /// <summary>
    /// 本地用户id (string)
    /// </summary>
    public const string sv_SedgeUserAx= "sv_LocalUserId";
    /// <summary>
    /// 本地服务器id (string)
    /// </summary>
    public const string Of_SedgeRunoffAx= "sv_LocalServerId";
    /// <summary>
    /// 是否是新用户玩家 (bool)
    /// </summary>
    public const string Of_MyRayBovine= "sv_IsNewPlayer";

    /// <summary>
    /// 签到次数 (int)
    /// </summary>
    public const string Of_RoostWatchHisExtol= "sv_DailyBounsGetCount";
    /// <summary>
    /// 签到最后日期 (int)
    /// </summary>
    public const string Of_RoostWatchPoll= "sv_DailyBounsDate";
    /// <summary>
    /// 新手引导完成的步数
    /// </summary>
    public const string Of_RayDeftSave= "sv_NewUserStep";
    /// <summary>
    /// 金币余额
    /// </summary>
    public const string Of_FromLuce= "sv_GoldCoin";
    /// <summary>
    /// 累计金币总数
    /// </summary>
    public const string Of_InnovationFromLuce= "sv_CumulativeGoldCoin";
    /// <summary>
    /// 钻石/现金余额
    /// </summary>
    public const string Of_Meter= "sv_Token";
    /// <summary>
    /// 累计钻石/现金总数
    /// </summary>
    public const string Of_InnovationMeter= "sv_CumulativeToken";
    /// <summary>
    /// 钻石Amazon
    /// </summary>
    public const string Of_Corset= "sv_Amazon";
    /// <summary>
    /// 累计Amazon总数
    /// </summary>
    public const string Of_InnovationCorset= "sv_CumulativeAmazon";
    /// <summary>
    /// 游戏总时长
    /// </summary>
    public const string Of_EarlyWhenPort= "sv_TotalGameTime";
    /// <summary>
    /// 第一次获得钻石奖励
    /// </summary>
    public const string Of_NightHisMeter= "sv_FirstGetToken";
    /// <summary>
    /// 是否已显示评级弹框
    /// </summary>
    public const string Of_DayFordBuzzSpear= "sv_HasShowRatePanel";
    /// <summary>
    /// 累计Roblox奖券总数
    /// </summary>
    public const string Of_InnovationJewelry= "sv_CumulativeLottery";
    /// <summary>
    /// 已经通过一次的关卡(int array)
    /// </summary>
    public const string Of_RadiateBlurPiston= "sv_AlreadyPassLevels";
    /// <summary>
    /// 新手引导
    /// </summary>
    public const string Of_RayDeftSaveMarket= "sv_NewUserStepFinish";
    public const string Of_Beat_Write_Greet= "sv_task_level_count";
    // 是否第一次使用过slot
    public const string Of_NightBlip= "sv_FirstSlot";
    /// <summary>
    /// adjust adid
    /// </summary>
    public const string Of_PlentyRare= "sv_AdjustAdid";

    /// <summary>
    /// 广告相关 - trial_num
    /// </summary>
    public const string Of_Ox_Filmy_Nor= "sv_ad_trial_num";
    /// <summary>
    /// 看广告总次数
    /// </summary>
    public const string Of_Apply_Ox_Nor= "sv_total_ad_num";

    /// <summary>
    /// 下方方块组数量
    /// </summary>
    public const string Of_HardyGiantExtol= "sv_BlockGroupCount";

    /// <summary>
    /// 当前Level进度
    /// </summary>
    public const string Of_CrudeAx= "sv_LevelId";
    
    /// <summary>
    /// 转盘进度
    /// </summary>
    public const string Of_BowelExtol= "sv_WheelCount";

    /// <summary>
    /// 转盘获取的奖励数
    /// </summary>
    public const string Of_BowelMortal= "sv_WheelReward";

    /// <summary>
    /// 脑力分数
    /// </summary>
    public const string Of_BelowBackupExtol= "sv_TodaySourceCount";

    /// <summary>
    /// 当前关卡分数
    /// </summary>
    public const string Of_PryBackupExtol= "sv_CurSourceCount";
    
    /// <summary>
    /// 挑战模式最高分数
    /// </summary>
    public const string Of_UteBackupExtol= "sv_MaxSourceCount";
    /// <summary>
    /// 奖励类型
    /// </summary>
    public const string Of_MortalWell= "sv_RewardType";
    
    /// <summary>
    /// 奖励数值
    /// </summary>
    public const string Of_MortalSeedy= "sv_RewardValue";
    
    /// <summary>
    /// 累计刷新积木次数
    /// </summary>
    public const string Of_CompanyScatExtol= "sv_ScratchCardCount";
    
    /// <summary>
    /// 棋盘中是否存在刮刮卡方块
    /// </summary>
    public const string Of_FleetCompanyScat= "sv_ExistScratchCard";

    /// <summary>
    /// 放置方块数
    /// </summary>
    public const string Of_QueryHardyExtol= "sv_PlaceBlockCount";

    /// <summary>
    /// combo数
    /// </summary>
    public const string Of_BlockExtol= "sv_ComboCount";

    /// <summary>
    /// 当前游戏方式
    /// </summary>
    public const string Of_PryWhenBoat= "sv_CurGameMode";

    /// <summary>
    /// 脑力分数
    /// </summary>
    public const string Of_AttachBackupComa= "sv_MentalSourceInfo";

    /// <summary>
    /// 游戏结束不同状态
    /// </summary>
    public const string Of_MarketShare= "sv_FinishStage";

    /// <summary>
    /// 是否完成章节
    /// </summary>
    public const string Of_MyHomelessTraffic= "sv_IsCompleteChapter";

    /// <summary>
    /// 方块预设
    /// </summary>
    public const string Of_HardyBeauty= "sv_BlockPreset";

    /// <summary>
    /// 预设出现数量
    /// </summary>
    public const string Of_BeautyExtol= "sv_PresetCount";
    /// <summary>
    /// 逻辑补充次数
    /// </summary>
    public const string Of_BlissAbsolutelyHardy= "sv_LogicCorrectionBlock";

    public const string Of_ScourBlissAbsolutelyHardy= "sv_FloatLogicCorrectionBlock";
    /// <summary>
    /// 震动
    /// </summary>
    public const string Of_MyCabbage= "sv_IsVibrate";

    /// <summary>
    /// setting页面返回
    /// </summary>
    public const string Of_ForeverFind= "sv_SettingHome";

    /// <summary>
    /// 游戏规则
    /// </summary>
    public const string Of_QuiltWhenStay= "sv_GuideGameRule";
    
    /// <summary>
    /// 游戏引导
    /// </summary>
    public const string Of_QuiltWhenLop= "sv_GuideGameSch";

    /// <summary>
    /// 换天
    /// </summary>
    public const string Of_YamEntailLizard= "sv_DayRecordWidget";

    /// <summary>
    /// 是否显示评价弹窗
    /// </summary>
    public const string Of_Worsen= "sv_Rateus";

    /// <summary>
    /// 是否失败过
    /// </summary>
    public const string Of_MyPhrase= "sv_IsRevive";

    /// <summary>
    /// 经典模式是否结束
    /// </summary>
    public const string Of_RedwingTempt= "sv_ClassicBonus";
    
    #endregion

    #region 监听发送的消息

    /// <summary>
    /// 有窗口打开
    /// </summary>
    public static string We_SpiralKiln= "mg_WindowOpen";
    /// <summary>
    /// 窗口关闭
    /// </summary>
    public static string We_SpiralSpoon= "mg_WindowClose";
    /// <summary>
    /// 关卡结算时传值
    /// </summary>
    public static string We_No_Micronutrient= "mg_ui_levelcomplete";
    /// <summary>
    /// 增加金币
    /// </summary>
    public static string We_No_Overrun= "mg_ui_addgold";
    /// <summary>
    /// 增加钻石/现金
    /// </summary>
    public static string We_No_Promptly= "mg_ui_addtoken";
    /// <summary>
    /// 增加钻石/现金
    /// </summary>
    public static string We_No_PromptlyFishery= "mg_ui_addtokenSpecial";
    /// <summary>
    /// 增加amazon
    /// </summary>
    public static string We_No_Avalanche= "mg_ui_addamazon";

    /// <summary>
    /// 游戏暂停/继续
    /// </summary>
    public static string We_WhenGaseous= "mg_GameSuspend";

    /// <summary>
    /// 游戏资源数量变化
    /// </summary>
    public static string We_BathFactor_= "mg_ItemChange_";

    /// <summary>
    /// 更新关卡目标数
    /// </summary>
    public static string We_IcelandCrudeCobalt= "mg_RefreshLevelTarget";
    
    /// <summary>
    /// 刷新分数信息
    /// </summary>
    public static string We_IcelandBackup= "mg_RefreshSource";
    
    /// <summary>
    /// 刮刮卡奖励
    /// </summary>
    public static string We_ThreeMortal= "mg_ScardReward";

    /// <summary>
    /// 转盘
    /// </summary>
    public static string We_BowelUI= "mg_WheelUI";
    
    /// <summary>
    /// 脑力
    /// </summary>
    public static string We_FattyUI= "mg_BrainUI";

    /// <summary>
    /// 关闭引导页面
    /// </summary>
    public static string We_SpoonAndBowQuilt= "mg_CloseAndComGuide";
    
    /// <summary>
    /// 引导判断
    /// </summary>
    public static string We_FactorQuiltWhenStay= "mg_ChangeGuideGameRule";

    #endregion

    #region 动态加载资源的路径

    // 金币图片
    public static string View_FromLuce_Silent= "Art/Tex/UI/jiangli1";
    // 钻石图片
    public static string View_Meter_Silent_Beater= "Art/Tex/UI/jiangli4";
    /// <summary>
    /// 方块路径
    /// </summary>
    public static string View_Hardy= "Prefab/HardyDesignHardyGiant";

    #endregion
}

