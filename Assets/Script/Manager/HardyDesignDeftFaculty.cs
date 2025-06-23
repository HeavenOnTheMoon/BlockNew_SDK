using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;
public class HardyDesignDeftFaculty : MonoBehaviour
{
    public static HardyDesignDeftFaculty instance;

    private bool Vapor= false;

    private void Awake()
    {
        
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }
[UnityEngine.Serialization.FormerlySerializedAs("today")]    public DateTime Fault;
    public void GobiBank()
    {
        Fault = DateTime.Now;
        HarmLayerCloset.HisEquality().DramLayer("1001");
        Application.targetFrameRate = 60;
        bool isNewPlayer = !PlayerPrefs.HasKey(CChoppy.Of_MyRayBovine + "Bool") || MindGazeFaculty.GetBool(CChoppy.Of_MyRayBovine);
        if (isNewPlayer)
        {
            // 新用户
            MindGazeFaculty.SetBool(CChoppy.Of_MyRayBovine, false);
            MindGazeFaculty.SetInt(CChoppy.Of_FleetCompanyScat, 0);
            MindGazeFaculty.SetBool(CChoppy.Of_MyCabbage, true);
            MindGazeFaculty.SetInt(CChoppy.Of_QuiltWhenStay,99);
        }
        //换天清空
        if (MindGazeFaculty.GetInt(CChoppy.Of_YamEntailLizard) == 0 || Fault.Day != MindGazeFaculty.GetInt(CChoppy.Of_YamEntailLizard))
        {
            MindGazeFaculty.SetInt(CChoppy.Of_YamEntailLizard, Fault.Day);
            MindGazeFaculty.SetInt(CChoppy.Of_BelowBackupExtol, 0);
        }
       /* if (MindGazeFaculty.GetInt(CChoppy.sv_GuideGameRule) != 99)
        {
            MindGazeFaculty.SetInt(CChoppy.sv_GuideGameRule, HardyDesignCrudeFaculty.Instance.GetCurLevel() >= 1 ? 99 : 0);
        }*/
            
        HardyDesignBackupFaculty.Instance.IcelandBackupMortal();
        RaiseEka.HisEquality().ItemOf(RaiseWell.SceneMusic.Sound_BGM);

        //UIFaculty.GetInstance().ShowUIForms("WhenSpear");
        if (SceneManager.GetActiveScene().name == "CreatBlockScene")
        {
            UIFaculty.HisEquality().FordUISleek("CruelCrudeSpear");
        }
        else
        {
            if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == 0)
                UIFaculty.HisEquality().FordUISleek("WhenQuiltSpear");
            else
                UIFaculty.HisEquality().FordUISleek("FindSpear");
        }

        HardyDesignWhenGazeFaculty.HisEquality().BankWhenGaze();
        Vapor = true;

    }

    #region Wheel

    public void MobBowelLop()
    {
        var oldCount = MindGazeFaculty.GetInt(CChoppy.Of_BowelExtol);
        var newCount = FactorBowelMortal(oldCount);
        MindGazeFaculty.SetInt(CChoppy.Of_BowelExtol, newCount);

        int oldWheelReward = MindGazeFaculty.GetInt(CChoppy.Of_BowelMortal);
        double GirderSeedy= 0;
        if (oldWheelReward < 2)
        {
            // 如果转盘奖励进度之前为0或1，计算奖励
            int GirderExtol= (oldWheelReward + 1) * WitComaEka.instance.WhenGaze.WheelReward.ShowCount;    // 下一次奖励需要的放置积木次数
            if (oldCount < GirderExtol && newCount >= GirderExtol)
            {
                if (WitComaEka.instance.WhenGaze.WheelReward.Reward[0].type == "cash")
                {
                    GirderSeedy = BlockPuzzleGameUtil.HisHurlExalt() * double.Parse(WitComaEka.instance.WhenGaze.WheelReward.Reward[0].multiple);
                }
                else
                {
                    GirderSeedy = BlockPuzzleGameUtil.HisFromExalt() * double.Parse(WitComaEka.instance.WhenGaze.WheelReward.Reward[0].multiple);
                }
                MindGazeFaculty.SetInt(CChoppy.Of_BowelMortal, oldWheelReward + 1);
                WhenSpear.Instance.FivePut.SetActive(true);
                HardyDesignWhenOvertime.Instance.SoCareCompanyMortal = true;
            }
            else
            {
                HardyDesignWhenOvertime.Instance.SoCareCompanyMortal = false;
            }
        }
        else
        {
            HardyDesignWhenOvertime.Instance.SoCareCompanyMortal = false;
        }
        PreciseGaze md = new PreciseGaze(oldWheelReward);
        md.StyleEthnic = GirderSeedy;
        PreciseCinemaBliss.HisEquality().Dram(CChoppy.We_BowelUI, md);
    }

    public void VirgoBowelLop()
    {
        MindGazeFaculty.SetInt(CChoppy.Of_BowelExtol, 0);
        MindGazeFaculty.SetInt(CChoppy.Of_BowelMortal, 0);
        PreciseCinemaBliss.HisEquality().Dram(CChoppy.We_BowelUI, new PreciseGaze(0));
    }

    public int FactorBowelMortal(int oldCount)
    {
        int newCount = oldCount + 1;
        int oldWheelReward = MindGazeFaculty.GetInt(CChoppy.Of_BowelMortal);
        int GirderExtol= (oldWheelReward + 1) * WitComaEka.instance.WhenGaze.WheelReward.ShowCount;
        //可以触发奖励
        if (newCount >= GirderExtol && oldCount < GirderExtol)
        {
            //存在刮刮卡奖励
            if (HardyDesignWhenOvertime.Instance.SoCareCompanyScat)
            {
                //下次操作必定获得奖励
                HardyDesignWhenOvertime.Instance.SoCareBowel = false;
                return newCount - 1;
            }
            else
            {
                HardyDesignWhenOvertime.Instance.SoCareBowel = oldWheelReward == 2;
                return newCount;
            }
        }
        else
        {
            //不足
            HardyDesignWhenOvertime.Instance.SoCareBowel = false;
            return newCount;
        }
    }
    
    public void FordBowelSpear()
    {
        StartCoroutine(Champion(0.6f, (() =>
        {
            UIFaculty.HisEquality().FordUISleek("RoostBowelSpear");
            MindGazeFaculty.SetInt(CChoppy.Of_BowelExtol, MindGazeFaculty.GetInt(CChoppy.Of_BowelExtol) - WitComaEka.instance.WhenGaze.WheelReward.ShowCount);
        })));
        
        //HardyDesignWhenOvertime.Instance.WheelReward?.Invoke();
        //UIFaculty.GetInstance().ShowUIForms("RoostBowelSpear");
    }

    IEnumerator Champion(float time, Action finish)
    {
        yield return new WaitForSeconds(time);
        finish?.Invoke();
    }

    public int HisBowelLop()
    {
        return MindGazeFaculty.GetInt(CChoppy.Of_BowelExtol);
    }

  #endregion

    #region ScratchCard

    public void FordCompanyScatSpear()
    {
        /*HardyDesignRouteNovelFaculty.Instance.ScratchObjs.transform.DOScale(0, 0.3f).SetEase(Ease.InBack).SetDelay(0.2f).OnComplete(() =>
        {
            Destroy(HardyDesignRouteNovelFaculty.Instance.ScratchObjs);
            UIFaculty.GetInstance().ShowUIForms("IncorrectlySpear");
            //HardyDesignRouteNovelFaculty.Instance.ScratchObjs = new GameObject();
        });*/
        for (int k = 0; k < WhenSpear.Instance.HardySP.Count; k++)
        {
            GameObject Item = WhenSpear.Instance.HardySP[k].gameObject;
            if (Item != null)
            {
                //Debug.Log("IncorrectlySpear == " + Item.GetComponent<HardyDesignHardyLizard>().Type);
                if (Item.GetComponent<HardyDesignHardyLizard>().Well == 99)
                    Item.transform.DOScale(0, 0.3f).SetEase(Ease.InBack).SetDelay(0.2f).OnComplete(() =>
                    {
                        Destroy(Item);
                        UIFaculty.HisEquality().FordUISleek("IncorrectlySpear");
                    });
            }
        }
        
    }

  #endregion

    public void WhenIceberg()
    {
        if (MindGazeFaculty.GetString(CChoppy.Of_PryWhenBoat) == "challenge")
        {
            //弹出对应游戏奖励页面，后续刷新棋盘信息
            HardyDesignCrudeFaculty.Instance.MobCrude();
            HardyDesignCrudeFaculty.Instance.HisPryCrudeComa();
            HardyDesignCrudeFaculty.Instance.BankCobalt();
        }
        else
        {
            
        }
        //刷新棋盘
        //HardyDesignRouteNovelFaculty.Instance.RefreshCheckBoard();
    }

    public void WhenLethal()
    {
        if (MindGazeFaculty.GetString(CChoppy.Of_PryWhenBoat) == "challenge")
        {
            HardyDesignWhenOvertime.Instance.PhilosophyExtol = 0;
            MindGazeFaculty.SetString(CChoppy.Of_MarketShare, "failed");
            UIFaculty.HisEquality().FordUISleek("MarketSpear");
        }
        else
        {
            HardyDesignWhenOvertime.Instance.PhilosophyExtol = 0;
            if (MindGazeFaculty.GetInt(CChoppy.Of_PryBackupExtol) == MindGazeFaculty.GetInt(CChoppy.Of_UteBackupExtol))
            {
                MindGazeFaculty.SetString(CChoppy.Of_MarketShare, "bestChallenge");
            }
            else
            {
                MindGazeFaculty.SetString(CChoppy.Of_MarketShare, "Challenge");
            }
            
            UIFaculty.HisEquality().FordUISleek("MarketSpear");
        }
    }

    public MultiplierBox HisMilitarily(List<MultiplierBox> rewardInfos)
    {
        int sum = 0;
        if (sum == 0)
        {
            for (int i = 0; i < rewardInfos.Count; i++)
            {
                sum += rewardInfos[i].weight;
            }
        }

        int rewardRandom = Random.Range(0, 999);
        float Love= 0;
        for (int i = 0; i < rewardInfos.Count; i++)
        {
            Love += rewardInfos[i].weight / (float)sum;
            if (rewardRandom <= Love * 1000)
            {
                return rewardInfos[i];
            }
        }
        return rewardInfos[0];
    }
    
    /// <summary>
    /// 获取奖励类型
    /// </summary>
    /// <param name="rewardInfos"></param>
    /// <returns></returns>
    public RewardItem HisMortalWell(List<RewardItem> rewardInfos)
    {
        if (BureauVolt.MyRaise())
        {
            foreach (RewardItem t in rewardInfos.Where(t => t.type == "coin"))
            {
                return t;
            }
        }
        int sum = 0;
        if (sum == 0)
        {
            for (int i = 0; i < rewardInfos.Count; i++)
            {
                sum += rewardInfos[i].weight;
            }
        }

        int rewardRandom = Random.Range(0, 999);
        float Love= 0;
        for (int i = 0; i < rewardInfos.Count; i++)
        {
            Love += rewardInfos[i].weight / (float)sum;
            if (rewardRandom <= Love * 1000)
            {
                return rewardInfos[i];
            }
        }
        return rewardInfos[0];
    }
    
    public int HisMobExtol(double StartCount, double EndCount, bool isCash)
    {
        double difference = Math.Abs(EndCount - StartCount);
        if (isCash)
        {
            if (difference < WitComaEka.instance.WhenGaze.CashLimit)
            {
                return 1;
            }
            else
            {
                return ((int)(difference / WitComaEka.instance.WhenGaze.CashLimit)) + 1;
            }
        }
        else
        {
            if (difference < 1000)
            {
                return 1;
            }
            else
            {
                return ((int)(difference / 1000)) + 1;
            }
        }
    }
    
    public int HisOldSeedy(List<ScraCount> rewardInfos)
    {
        int sum = 0;
        if (sum == 0)
        {
            for (int i = 0; i < rewardInfos.Count; i++)
            {
                sum += rewardInfos[i].weight;
            }
        }

        int rewardRandom = Random.Range(0, 999);
        float Love= 0;
        for (int i = 0; i < rewardInfos.Count; i++)
        {
            Love += rewardInfos[i].weight / (float)sum;
            if (rewardRandom <= Love * 1000)
            {
                return rewardInfos[i].count;
            }
        }
        return 0;
    }

    public void MarketWhen()
    {
        MindGazeFaculty.SetInt(CChoppy.Of_FleetCompanyScat, 0);
        UIFaculty.HisEquality().SpoonDyStudioUISleek(BureauVolt.WhenKnot());
        HardyDesignBackupFaculty.Instance.VirgoBlock();
        for (int i = HardyDesignHardyFaculty.Instance.HardyGiantVogue.Count - 1; i >= 0; i--)
        {
            HardyDesignHardyFaculty.Instance.ClarityHardy(HardyDesignHardyFaculty.Instance.HardyGiantVogue[i]);
        }
        
    }
    
    public int[] LuxuryWin(int[] num)
    {
        for (int i = 0; i < num.Length; i++)
        {
            var temp = num[i];
            int randomIndex = LuxurySeedy(0, num.Length);
            num[i] = num[randomIndex];
            num[randomIndex] = temp;
        }
        return num;
    }

    public List<T> LuxuryName<T>(List<T> num)
    {
        for (int i = 0; i < num.Count; i++)
        {
            var temp = num[i];
            int randomIndex = LuxurySeedy(0, num.Count);
            num[i] = num[randomIndex];
            num[randomIndex] = temp;
        }
        return num;
    }

    private int LuxurySeedy(int min, int max)
    {
        return Random.Range(min, max);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public bool MyMobSeedy(int index)
    {
        var Cement= LuxurySeedy(0, 1000);
        return (index < Cement);
    }
    
    public void TieBegCabbage()
    {
        if(MindGazeFaculty.GetBool(CChoppy.Of_MyCabbage))
            Vibration.VibratePop();
    }
}