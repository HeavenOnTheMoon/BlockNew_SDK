using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class MortalPeat
{
    private static MortalPeat instance;
    public static MortalPeat Equality    {
        get
        {
            instance ??= new MortalPeat();
            return instance;
        }
    }

    // 金币奖励列表
    private List<int> GirderLuceName;
    private List<int> GirderLuceCopName;

    // 奖励事件发送时间列表，用于控制奖励事件发送频率
    private Dictionary<int, float> GirderPortName;

    private int Thrift= 1; // 发奖状态，0：停止发奖；1：恢复发奖
    public int Outwit    {
        get
        {
            return Thrift;
        }
    }

    public void TugOutwit(int wstate)
    {
        this.Thrift = wstate;
    }

    public List<int> MortalLuceName    {
        get
        {
            GirderLuceName ??= new List<int>(PHMindGazeFaculty.GetIntArray("PH_reward_coin"));
            return GirderLuceName;
        }
    }

    public List<int> MortalLuceCopName    {
        get
        {
            GirderLuceCopName ??= new List<int>(PHMindGazeFaculty.GetIntArray("PH_reward_coin_old"));
            return GirderLuceCopName;
        }
    }

    /// <summary>
    /// 记录奖励上报金币
    /// </summary>
    /// <param name="coin"></param>
    /// <param name="coinOld"></param>
    public void MobMortalLuce(int coin, int coinOld)
    {
        GirderLuceName ??= new List<int>(PHMindGazeFaculty.GetIntArray("PH_reward_coin"));
        GirderLuceCopName ??= new List<int>(PHMindGazeFaculty.GetIntArray("PH_reward_coin_old"));
        GirderLuceName.Add(coin);
        GirderLuceCopName.Add(coinOld);
        PHMindGazeFaculty.SetIntArray("PH_reward_coin", GirderLuceName.ToArray());
        PHMindGazeFaculty.SetIntArray("PH_reward_coin_old", GirderLuceCopName.ToArray());
    }

    /// <summary>
    /// 停止用户发奖状态，0：停止发奖；1：恢复发奖
    /// </summary>
    /// <param name="wstate"></param>
    public async Task<bool> IconOutwit()
    {
        if (Thrift == 1)
        {
            Debug.Log("--- 停止发奖");
            Thrift = 0; // 先设置为0，再发送停止奖励接口，防止接口返回失败导致状态不一致
            // 发送事件
            LayerFatPeat.Equality.DramDeftLayer(10009, "sys_app_main_stop_reward_ads_10009");
            // 上报停止奖励接口
            string Fox= "/api/game/user/wstate";
            var putData = new { wstate = 0 };
            var putResponse = await RootIsotopePeat.Equality.Roe(PHCrest.BASE_URL + Fox, putData, true);
            if (putResponse.IsSuccess)
            {
                Thrift = 0;
                return true;
            }
            else
            {
                // 接口返回失败，恢复状态
                Thrift = 1;
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// 恢复用户发奖状态，0：停止发奖；1：恢复发奖
    /// </summary>
    /// <param name="wstate"></param>
    public async Task<bool> ReasonOutwit()
    {
        if (Thrift == 0 && ByPeat.Equality.ByPulpAction == 1 && PHFaculty.Instance.DiluteAction == 1)
        {
            Debug.Log("--- 恢复发奖");
            Thrift = 1; // 先设置为1，再发送恢复奖励接口，防止接口返回失败导致状态不一致
            // 发送事件
            LayerFatPeat.Equality.DramDeftLayer(10010, "sys_app_main_restart_reward_ads_10010");
            // 上报恢复奖励接口
            string Fox= "/api/game/user/wstate";
            var putData = new { wstate = 1 };
            var putResponse = await RootIsotopePeat.Equality.Roe(PHCrest.BASE_URL + Fox, putData, true);
            if (putResponse.IsSuccess)
            {
                Thrift = 1;
                return true;
            } 
            else
            {
                // 接口返回失败，恢复状态
                Thrift = 0;
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// 检查奖励事件是否可以发送
    /// </summary>
    /// <param name="event_num"></param>
    /// <returns></returns>
    public bool RouteMortalAction(int event_num)
    {
        RunoffChoppyStorm config = RunoffChoppyPeat.Equality.RunoffChoppy;
        // 1、判断配置中是否有该奖励事件，没有则不发奖励
        if (!config.rewardEventLocationList.ContainsKey(event_num))
        {
            return false;
        }
        // 2、判断奖励事件开关
        RewardEventLocationItem configItem = config.rewardEventLocationList[event_num];
        if (configItem.status == 0)
        {
            return false;
        }
        // 3、判断奖励事件是否在冷却时间内，在则不发奖励
        GirderPortName ??= new();
        if (configItem.coolingTime == 0)
        {
            // 无冷却时间，则直接发奖励
            return true;
        }
        long current = PHVolt.Network();
        if (GirderPortName.ContainsKey(event_num))
        {
            if (GirderPortName[event_num] + configItem.coolingTime > current)
            {
                // 冷却时间内，不发奖励
                return false;
            }
            else
            {
                GirderPortName[event_num] = current;
                return true;
            }
        }
        else
        {
            GirderPortName.Add(event_num, current);
            return true;
        }
    }
}
