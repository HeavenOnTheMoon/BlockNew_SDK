using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
public class HardyDesignWhenOvertime : MonoBehaviour
{
    public static HardyDesignWhenOvertime Instance;
[UnityEngine.Serialization.FormerlySerializedAs("ChangeClearBlockStage")]    
    public Action FactorVirgoHardyShare;
[UnityEngine.Serialization.FormerlySerializedAs("ClearBlock")]    public Action VirgoHardy;
[UnityEngine.Serialization.FormerlySerializedAs("TargetBlockFly")]    public Action CobaltHardyElk;
[UnityEngine.Serialization.FormerlySerializedAs("WheelReward")]    public Action BowelMortal;
[UnityEngine.Serialization.FormerlySerializedAs("ScratchcardReward")]    public Action IncorrectlyMortal;
[UnityEngine.Serialization.FormerlySerializedAs("SourceReward")]    public Action BackupMortal;
[UnityEngine.Serialization.FormerlySerializedAs("GameFailed")]    public Action WhenLethal;
[UnityEngine.Serialization.FormerlySerializedAs("GameSuccess")]    public Action WhenIceberg;
    //暂存棋子累计奖励
    
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("accumulateCount")]public int PhilosophyExtol;

    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("CurCompleteWord")]public int PryHomelessEpic= 0;
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("CurChapterSch")]public int PryTrafficLop= 0;
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("CurTotalChapter")]public int PryEarlyTraffic= 0;

    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("isHaveScratchCard")]public bool SoCareCompanyScat= false;
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("isHaveScratchReward")]public bool SoCareCompanyMortal= false;
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("isHaveWheel")]public bool SoCareBowel= false;
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("isHaveSource")]public bool SoCareBackup= false;
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("Schedule")]public string Overtime= "";
    private void Awake()
    {
        Instance = this;
    }

    public void BathSewer()
    {
        //accumulateCount++;
        
        //if (accumulateCount == 1 && (Schedule == "GameSuccess" || Schedule == "" || Schedule == "GameFailed"))
        //{
                WhenSpear.Instance.FivePut.gameObject.SetActive(true);
           
            GameStartStep gameStartStep = new GameSchedules(null);
            GameStartStep nextStep = gameStartStep;
            nextStep = new ChangeClearBlockStage(nextStep);
            nextStep = new ClearBlock(nextStep);
            nextStep = new TargetBlockFly(nextStep);
            nextStep = new ScratchcardReward(nextStep);
            nextStep = new WheelReward(nextStep);
            nextStep = new SourceReward(nextStep);
            nextStep = new GameFailed(nextStep);
            nextStep = new GameSuccess(nextStep);
            gameStartStep.Concept();
        //}
    }
    // Start is called before the first frame update
    public void TugWhenStamford()
    {
        
    }

    public void PortCrop(float time, Action finish)
    {
        StartCoroutine(PortCropIE(time, finish));
    }
    public IEnumerator PortCropIE(float time, Action finish)
    {
        yield return new WaitForSeconds(time);
        finish?.Invoke();
    }
}

public class GameStartStep
{
    GameStartStep _FileSave;
    private readonly Action _FinishWeftGood;
    protected GameStartStep(GameStartStep previousStep)
    {
        if(previousStep != null)
            previousStep._FileSave = this;
    }
    protected GameStartStep(GameStartStep previousStep, Action finishCallBack)
    {
        if (previousStep != null)
            previousStep._FileSave = this;
        this._FinishWeftGood = finishCallBack;
    }
    public virtual void Concept()
    {
        
    }
    protected virtual void ConceptMarket()
    {
        _FinishWeftGood?.Invoke();
        AtDirtSave();
    }
    protected void AtDirtSave()
    {
        if (_FileSave != null) 
        {
            _FileSave.Concept();

        }
        else
        {
            Debug.Log("特效进度完成");
            /*if (HardyDesignWhenOvertime.Instance.accumulateCount > 1)
            {
                HardyDesignWhenOvertime.Instance.accumulateCount = 1;
                HardyDesignWhenOvertime.Instance.GetChessReWard();
            }
            else if(HardyDesignWhenOvertime.Instance.accumulateCount == 1)
            {
                HardyDesignWhenOvertime.Instance.accumulateCount--;
            }*/
            /*if(HardyDesignWhenOvertime.Instance.accumulateCount == 0)
                WhenSpear.Instance.MaskObj.gameObject.SetActive(false);*/
            //HardyDesignWhenOvertime.Instance.IsInit = true;
        }
    }
}

public class GameSchedules : GameStartStep
{
    public GameSchedules(GameStartStep nextStep) : base(nextStep)
    {
        
    }
    public override void Concept()
    {
        HardyDesignWhenOvertime.Instance.TugWhenStamford();
        ConceptMarket();
    }

    protected override void ConceptMarket()
    {
        base.ConceptMarket();
        //Debug.Log("SetGameSettings Step Finish");
    }

}

public class ChangeClearBlockStage : GameStartStep
{
    public ChangeClearBlockStage(GameStartStep previousStep) : base(previousStep)
    {
    }
    public ChangeClearBlockStage(GameStartStep previousStep, Action finishCallBack) : base(previousStep, finishCallBack)
    {
    }
    
    public override void Concept()
    {
        HardyDesignWhenOvertime.Instance.Overtime = "ChangeClearBlockStage";
        Debug.Log(HardyDesignWhenOvertime.Instance.Overtime);
        HardyDesignWhenOvertime.Instance.FactorVirgoHardyShare = ConceptMarket;
        //直接计算好全部的奖励，这次发不发
        HardyDesignRouteNovelFaculty.Instance.FactorFoeVirgoHardy();
        HardyDesignRouteNovelFaculty.Instance.HisMortalBedroom();

    }
    
    protected override void ConceptMarket()
    {
        AtDirtSave();
    } 
}

public class ClearBlock : GameStartStep
{

    public ClearBlock(GameStartStep previousStep) : base(previousStep)
    {
    }
    public ClearBlock(GameStartStep previousStep, Action finishCallBack) : base(previousStep, finishCallBack)
    {
    }
    
    public override void Concept()
    {
        HardyDesignWhenOvertime.Instance.Overtime = "ClearBlock";
        Debug.Log(HardyDesignWhenOvertime.Instance.Overtime);
        HardyDesignWhenOvertime.Instance.VirgoHardy = ConceptMarket;
        HardyDesignRouteNovelFaculty.Instance.VirgoHardySun();

    }
    
    protected override void ConceptMarket()
    {
        AtDirtSave();
    } 
}

public class TargetBlockFly : GameStartStep
{
    public TargetBlockFly(GameStartStep previousStep) : base(previousStep)
    {
    }
    public TargetBlockFly(GameStartStep previousStep, Action finishCallBack) : base(previousStep, finishCallBack)
    {
    }
    
    public override void Concept()
    {
        HardyDesignWhenOvertime.Instance.Overtime = "TargetBlockFly";
        Debug.Log(HardyDesignWhenOvertime.Instance.Overtime);
        HardyDesignWhenOvertime.Instance.CobaltHardyElk = ConceptMarket;
        if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == 99)
            HardyDesignRouteNovelFaculty.Instance.ElkCobaltHardy();
        else
            HardyDesignWhenOvertime.Instance.CobaltHardyElk?.Invoke();
    }
    
    protected override void ConceptMarket()
    {
        AtDirtSave();
    } 
}


public class ScratchcardReward : GameStartStep
{
    public ScratchcardReward(GameStartStep previousStep) : base(previousStep)
    {
    }
    public ScratchcardReward(GameStartStep previousStep, Action finishCallBack) : base(previousStep, finishCallBack)
    {
    }
    
    public override void Concept()
    {
        HardyDesignWhenOvertime.Instance.Overtime = "ScratchcardReward";
        Debug.Log(HardyDesignWhenOvertime.Instance.Overtime);
        HardyDesignWhenOvertime.Instance.IncorrectlyMortal = ConceptMarket;
        if (HardyDesignWhenOvertime.Instance.SoCareCompanyScat && !BureauVolt.MyRaise() && MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == 99)
        {
            HardyDesignDeftFaculty.instance.FordCompanyScatSpear();
        }
        else if (HardyDesignWhenOvertime.Instance.SoCareCompanyMortal && !BureauVolt.MyRaise() && MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == 99)
        {
            
        }
        else
        {
            HardyDesignWhenOvertime.Instance.IncorrectlyMortal?.Invoke();
        }
        
    }
    
    protected override void ConceptMarket()
    {
        AtDirtSave();
    } 
}

public class WheelReward : GameStartStep
{
    public WheelReward(GameStartStep previousStep) : base(previousStep)
    {
    }
    public WheelReward(GameStartStep previousStep, Action finishCallBack) : base(previousStep, finishCallBack)
    {
    }
    
    public override void Concept()
    {
        HardyDesignWhenOvertime.Instance.Overtime = "WheelReward";
        Debug.Log(HardyDesignWhenOvertime.Instance.Overtime);
        HardyDesignWhenOvertime.Instance.BowelMortal = ConceptMarket;
        if (HardyDesignWhenOvertime.Instance.SoCareBowel && !BureauVolt.MyRaise() && MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == 99)
        {
            HardyDesignDeftFaculty.instance.FordBowelSpear();
        }
        else
        {
            HardyDesignWhenOvertime.Instance.BowelMortal?.Invoke();
        }
        //WordHikeCheckerboardManager.instance.RefreshChallengeWord();
        
    }
    
    protected override void ConceptMarket()
    {
        AtDirtSave();
    } 
}


public class SourceReward : GameStartStep
{
    public SourceReward(GameStartStep previousStep) : base(previousStep)
    {
    }
    public SourceReward(GameStartStep previousStep, Action finishCallBack) : base(previousStep, finishCallBack)
    {
    }
    
    public override void Concept()
    {
        HardyDesignWhenOvertime.Instance.Overtime = "SourceReward";
        Debug.Log(HardyDesignWhenOvertime.Instance.Overtime);
        HardyDesignWhenOvertime.Instance.BackupMortal = ConceptMarket;
        if (HardyDesignWhenOvertime.Instance.SoCareBackup)
        {
            HardyDesignWhenOvertime.Instance.SoCareBackup = false;
            HardyDesignBackupFaculty.Instance.FordBackupSpear();
        }
        else
        {
            HardyDesignWhenOvertime.Instance.BackupMortal?.Invoke();
        }
    }
    
    protected override void ConceptMarket()
    {
        AtDirtSave();
    } 
}

public class GameSuccess : GameStartStep
{
    public GameSuccess(GameStartStep previousStep) : base(previousStep)
    {
    }
    public GameSuccess(GameStartStep previousStep, Action finishCallBack) : base(previousStep, finishCallBack)
    {
    }
    
    public override void Concept()
    {
        if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == 99)
        {
            WhenSpear.Instance.FivePut.gameObject.SetActive(true);
            HardyDesignWhenOvertime.Instance.Overtime = "GameSuccess";
            Debug.Log(HardyDesignWhenOvertime.Instance.Overtime);
            HardyDesignWhenOvertime.Instance.WhenIceberg = ConceptMarket;
            if (MindGazeFaculty.GetString(CChoppy.Of_PryWhenBoat) == "Guide")
            {
            
            }
            else if (MindGazeFaculty.GetString(CChoppy.Of_PryWhenBoat) == "challenge" && HardyDesignCrudeFaculty.Instance.FactorIceberg() 
                || MindGazeFaculty.GetString(CChoppy.Of_PryWhenBoat) == "Classic" && MindGazeFaculty.GetBool(CChoppy.Of_RedwingTempt))
            {
                WhenSpear.Instance.HardyGiantClue.GetComponent<CanvasGroup>().DOFade(0, 0.3f);
                WhenSpear.Instance.DomainMud.GetComponent<CanvasGroup>().DOFade(0, 0.3f);
                double Seedy= 0;
                var Hear= HardyDesignDeftFaculty.instance.HisMortalWell(WitComaEka.instance.WhenGaze.SuccessInfo);
                if (Hear.type == "cash")
                {
                    Seedy = BlockPuzzleGameUtil.HisHurlExalt() * double.Parse(Hear.multiple);
                }
                else
                {
                    Seedy = BlockPuzzleGameUtil.HisFromExalt() * double.Parse(Hear.multiple);
                }
                MindGazeFaculty.SetString("SuccessInfoType", Hear.type);
                MindGazeFaculty.SetDouble("SuccessInfoValue", Seedy);
                WhenSpear.Instance.CrudeIceberg(true, () => 
                {
                    //胜利
                    //Debug.LogError("胜利");
                    HardyDesignWhenOvertime.Instance.Overtime = "";
                    MindGazeFaculty.SetString(CChoppy.Of_MarketShare, "success");
                    // 游戏胜利动画
                    HardyDesignRouteNovelFaculty.Instance.FordWinSun(() =>
                    {
                        UIFaculty.HisEquality().FordUISleek("MarketSpear");
                        HardyDesignDeftFaculty.instance.WhenIceberg();
                    });
                });
            }
            else
            {
                HardyDesignWhenOvertime.Instance.WhenIceberg?.Invoke();
                WhenSpear.Instance.FivePut.gameObject.SetActive(false);
            }
        }
        else
        {
            WhenQuiltSpear.Instance.FivePut.gameObject.SetActive(false);
            PreciseCinemaBliss.HisEquality().Dram(CChoppy.We_FactorQuiltWhenStay);
        }
           
           
    }
    
    protected override void ConceptMarket()
    {
        AtDirtSave();
    } 
}

public class GameFailed : GameStartStep
{
    public GameFailed(GameStartStep previousStep) : base(previousStep)
    {
    }
    public GameFailed(GameStartStep previousStep, Action finishCallBack) : base(previousStep, finishCallBack)
    {
    }
    
    public override void Concept()
    {
        HardyDesignWhenOvertime.Instance.Overtime = "GameFailed";
        Debug.Log(HardyDesignWhenOvertime.Instance.Overtime);
        HardyDesignWhenOvertime.Instance.WhenLethal = ConceptMarket;
        if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == 99)
        {
            HardyDesignHardyFaculty.Instance.FactorFoeQuery();
            HardyDesignHardyFaculty.Instance.FactorLethal();
        }
        else
        {
            HardyDesignWhenOvertime.Instance.WhenLethal?.Invoke();
        }
        
        
    }
    
    protected override void ConceptMarket()
    {
        AtDirtSave();
    } 
}
