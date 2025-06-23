using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ByFacultyTuneSpear : AlgaUISleek
{
[UnityEngine.Serialization.FormerlySerializedAs("LastPlayTimeCounterText")]    public Text LoopItemPortOctoberTear;
[UnityEngine.Serialization.FormerlySerializedAs("Counter101Text")]    public Text October101Tear;
[UnityEngine.Serialization.FormerlySerializedAs("Counter102Text")]    public Text October102Tear;
[UnityEngine.Serialization.FormerlySerializedAs("Counter103Text")]    public Text October103Tear;
[UnityEngine.Serialization.FormerlySerializedAs("TrialNumText")]    public Text TrackBagTear;
[UnityEngine.Serialization.FormerlySerializedAs("PlayRewardedAdButton")]    public Button ItemDatebaseByProton;
[UnityEngine.Serialization.FormerlySerializedAs("PlayInterstitialAdButton")]    public Button ItemInterstitialByProton;
[UnityEngine.Serialization.FormerlySerializedAs("NoThanksButton")]    public Button ByCougarProton;
[UnityEngine.Serialization.FormerlySerializedAs("TrialNumButton")]    public Button TrackBagProton;
[UnityEngine.Serialization.FormerlySerializedAs("CloseButton")]    public Button SpoonProton;
[UnityEngine.Serialization.FormerlySerializedAs("TimeInterstitialText")]    public Text PortMusicologistTear;
[UnityEngine.Serialization.FormerlySerializedAs("PauseTimeInterstitialButton")]    public Button NeedyPortMusicologistProton;
[UnityEngine.Serialization.FormerlySerializedAs("ResumeTimeInterstitialButton")]    public Button ReasonPortMusicologistProton;

    private void Start()
    {
        InvokeRepeating(nameof(FordOctoberTear), 0, 0.5f);

        SpoonProton.onClick.AddListener(() => {
            SpoonUITrap(GetType().Name);
        });

        ItemDatebaseByProton.onClick.AddListener(() => {
            //ADManager.Instance.playRewardVideo((success) => { }, "10");
        });

        ItemInterstitialByProton.onClick.AddListener(() => {
            //ADManager.Instance.playInterstitialAd(1);
        });

        ByCougarProton.onClick.AddListener(() => {
            //ADManager.Instance.NoThanksAddCount();
        });

        TrackBagProton.onClick.AddListener(() => {
            //ADManager.Instance.UpdateTrialNum(MindGazeFaculty.GetInt(CChoppy.sv_ad_trial_num) + 1);
            TrackBagTear.text = MindGazeFaculty.GetInt(CChoppy.Of_Ox_Filmy_Nor).ToString();
        });

        NeedyPortMusicologistProton.onClick.AddListener(() => {
            //ADManager.Instance.PauseTimeInterstitial();
            FordNeedyPortMusicologist();
        });

        ReasonPortMusicologistProton.onClick.AddListener(() => {
           // ADManager.Instance.ResumeTimeInterstitial();
            FordNeedyPortMusicologist();
        });

    }

    public override void Display()
    {
        base.Display();
        TrackBagTear.text = MindGazeFaculty.GetInt(CChoppy.Of_Ox_Filmy_Nor).ToString();
        FordNeedyPortMusicologist();
    }

    private void FordOctoberTear()
    {
       /* LastPlayTimeCounterText.text = ADManager.Instance.lastPlayTimeCounter.ToString();
        Counter101Text.text = ADManager.Instance.counter101.ToString();
        Counter102Text.text = ADManager.Instance.counter102.ToString();
        Counter103Text.text = ADManager.Instance.counter103.ToString();*/
    }

    private void FordNeedyPortMusicologist()
    {
        //TimeInterstitialText.text = ADManager.Instance.pauseTimeInterstitial ? "已暂停" : "未暂停";
    }
}
