using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class IncorrectlySpear : AlgaUISleek
{
[UnityEngine.Serialization.FormerlySerializedAs("ScrapingCardWidgets")]    public List<HardyDesignOutsiderScatLizard> OutsiderScatPopular;
[UnityEngine.Serialization.FormerlySerializedAs("RewardObj")]    
    public GameObject MortalPut;
[UnityEngine.Serialization.FormerlySerializedAs("RewardRubObj")]    public GameObject MortalRubPut;
[UnityEngine.Serialization.FormerlySerializedAs("RubObj")]    public GameObject WinPut;
[UnityEngine.Serialization.FormerlySerializedAs("HideCoverBtn")]    public Button IbexCoverVia;

    RewardItem _GirderBath;
    int Whip= 0;
    int GirderExtol= 0;
    int[] EarlyMortalPony= new int[16];

    // Start is called before the first frame update
    void Start()
    {
        PreciseCinemaBliss.HisEquality().Elongate(CChoppy.We_ThreeMortal, (messageData) =>
        {
            ThreeMortal();
        });

        IbexCoverVia.onClick.AddListener(IbexCover);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int HeavyExtol= 0;
    public override void Display()
    {
        base.Display();
        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Openboard);
        //MindGazeFaculty.SetInt(CChoppy.sv_ExistScratchCard, 0);
        //MindGazeFaculty.SetInt(CChoppy.sv_ExistScratchCard, 0);
        //RaiseEka.GetInstance().PlayEffect(RaiseWell.UIMusic.WordHikeSound_ScratCardPanel);
        IcelandWinKnife();
        HeavyExtol = 0;
        _GirderBath = HardyDesignDeftFaculty.instance.HisMortalWell(WitComaEka.instance.WhenGaze.ScratchInfo.ScratchRewardInfo);
        Whip = _GirderBath.type == "cash" ? 0 : 1;
        MindGazeFaculty.SetString(CChoppy.Of_MortalWell, _GirderBath.type);
        GirderExtol = HardyDesignDeftFaculty.instance.HisOldSeedy(WitComaEka.instance.WhenGaze.ScratchInfo.ScratchCountInfo);
        TugMortalSeedy(WitComaEka.instance.WhenGaze.ScratchInfo.ScratchCountInfo, WitComaEka.instance.WhenGaze.ScratchInfo.ScratchRewardInfo, Whip);
        IcelandMortal();
        MortalPut.GetComponent<HardyDesignOutsiderScatLizard>().Bank(Whip);
        for (int i = 0; i < OutsiderScatPopular.Count; i++)
        {
            OutsiderScatPopular[i].Bank(EarlyMortalPony[i]);
            OutsiderScatPopular[i].Broker(false);
        }
    }
    
    public override void Hidding()
    {
        base.Hidding();
        for (int i = 0; i < EarlyMortalPony.Length; i++)
        {
            OutsiderScatPopular[i].Broker(false);
        }
    }
    
    
    private void IcelandWinKnife()
    {
        WinPut.GetComponent<HardyDesignWinHueKnifeGeneralist>().BankSeedy();
    }
    
    private void ThreeMortal()
    {
        if (WinPut.GetComponent<HardyDesignWinHueKnifeGeneralist>().SoRyeRarity)
        {
            HeavyExtol++;
            StartCoroutine(Sun());
        }
    }

    IEnumerator Sun()
    {
        yield return new WaitForSeconds(0.3f);
        for (int i = 0; i < EarlyMortalPony.Length; i++)
        {
            if (EarlyMortalPony[i] == Whip)
            {
                OutsiderScatPopular[i].Broker(true);
                yield return new WaitForSeconds(0.3f);
            }
        }
        yield return new WaitForSeconds(0.8f);
        //RaiseEka.GetInstance().PlayEffect(RaiseWell.UIMusic.WordHikeSound_CompleteScratCard);
        FordSpear();

    }
    private void FordSpear()
    {
        KilnUITrap("MortalSpear"); 
        IcelandWinKnife();
        SpoonUITrap(GetType().Name);
    }

    int[] GirderPony;
    private void IcelandMortal()
    {
        GirderPony = new int[]{0,1,2,3,4,5};
        
        
        /*for (int i = 0; i < rewardPool.Length; i++)
        {
            if (rewardPool[i] == type)
            {
                rewardPool[i] = 6;
            }
        }*/
        
        for (int i = 0; i < 16; i++)
        {
            if (i < GirderExtol)
            {
                EarlyMortalPony[i] = Whip;
            }
            else
            {
                EarlyMortalPony[i] = HisMortalWell(Whip); //rewardPool[Random.Range(2, 6)];
            }
            
            //TotalRewardPool[i] = i < rewardCount ? type == 1 ? 1 : 0 : type == 1 ? 0 : 1;
        }

        EarlyMortalPony = HisOldLuxuryHost(EarlyMortalPony);
    }

    private int HisMortalWell(int index)
    {
        int Cement= Random.Range(0, 6);
        if (Cement == index)
        {
            return HisMortalWell(index);
        }
        return Cement;
    }
    
    public int[] HisOldLuxuryHost(int[] num)
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
    
    private int LuxurySeedy(int min, int max)
    {
        return Random.Range(min, max);
    }
    
    public void TugMortalSeedy(List<ScraCount> rewardInfos, List<RewardItem> rewardTwoInfos,int type)
    {
        double Style= 0;
        switch (type)
        {
            case 0 : Style = BlockPuzzleGameUtil.HisHurlExalt() * double.Parse(rewardInfos[0].multi) * double.Parse(rewardTwoInfos[0].multiple); break;
            case 1 : Style = BlockPuzzleGameUtil.HisFromExalt() * double.Parse(rewardInfos[1].multi) * double.Parse(rewardTwoInfos[1].multiple); break;
            
        }
        MindGazeFaculty.SetString(CChoppy.Of_MortalSeedy, Style.ToString());
    }


    private void IbexCover()
    {
        WinPut.GetComponent<HardyDesignWinHueKnifeGeneralist>().MarketSeedy();
    }
}
