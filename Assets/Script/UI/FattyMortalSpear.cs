using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using LitJson;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FattyMortalSpear : AlgaUISleek
{
[UnityEngine.Serialization.FormerlySerializedAs("AdBtn")]    public Button ByVia;
[UnityEngine.Serialization.FormerlySerializedAs("NormalBtn")]    public Button ExpertVia;
[UnityEngine.Serialization.FormerlySerializedAs("CashText")]    public Text HurlTear;
[UnityEngine.Serialization.FormerlySerializedAs("SchText")]    public TextMeshProUGUI LopTear;
[UnityEngine.Serialization.FormerlySerializedAs("TittleText")]    public Text TowardTear;
[UnityEngine.Serialization.FormerlySerializedAs("LittleSchText")]    public Text MemoryLopTear;
[UnityEngine.Serialization.FormerlySerializedAs("SchImage")]    public Image LopKnife;
[UnityEngine.Serialization.FormerlySerializedAs("SchTwoImage")]    public Image LopHueKnife;
[UnityEngine.Serialization.FormerlySerializedAs("CashImage")]    public Image HurlKnife;
[UnityEngine.Serialization.FormerlySerializedAs("CoinImage")]    public Image LuceKnife;
    // Start is called before the first frame update
    void Start()
    {
        ByVia.onClick.AddListener(ByViaFlute);
        ExpertVia.onClick.AddListener(ExpertViaFlute);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float Seedy= 0;
    public override void Display()
    {
        base.Display();
        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Openboard);
        ByVia.enabled = true;
        ExpertVia.enabled = true;
        var Hear= HardyDesignBackupFaculty.Instance.EarlyAttach[HardyDesignBackupFaculty.Instance.HisGazeUpBulge(DateTime.Now)];
        switch (HardyDesignBackupFaculty.Instance.AttachMortalID)
        {
            case 0 :
                TowardTear.text = "Conscious";
                MemoryLopTear.text = "Brain activated to 25% and you won gold rewards!";
                Seedy = WitComaEka.instance.WhenGaze.SourceRewards.oneQuarter;
                Hear.DamMortal = true;
                break;
            case 1 :
                TowardTear.text = "Clever";
                MemoryLopTear.text = "Brain activated to 50% and you won gold rewards!";
                Seedy = WitComaEka.instance.WhenGaze.SourceRewards.twoQuarter;
                Hear.HueMortal = true;
                break;
            case 2 :
                TowardTear.text = "Brain";
                MemoryLopTear.text = "Brain activated to 75% and you won gold rewards!";
                Seedy = WitComaEka.instance.WhenGaze.SourceRewards.threeQuarter;
                Hear.DutchMortal = true;
                break;
            case 3 :
                TowardTear.text = "Genius";
                MemoryLopTear.text = "Brain activated to 100% and you won gold rewards!";
                Seedy = WitComaEka.instance.WhenGaze.SourceRewards.fourQuarter;
                Hear.SlitMortal = true;
                break;
        }
        HurlKnife.gameObject.SetActive(!BureauVolt.MyRaise());
        LuceKnife.gameObject.SetActive(BureauVolt.MyRaise());
        if (BureauVolt.MyRaise())
            Seedy = 1000;

        HurlTear.text = Seedy.ToString();
        
        float Pul= (float)Hear.Backup / WitComaEka.instance.WhenGaze.SourceRewards.dailyMaxSource;
        LopTear.text = (Pul * 100).ToString("f0") + "%";
        LopKnife.fillAmount = Pul;
        //SchTwoImage.fillAmount = sch;
        HardyDesignBackupFaculty.Instance.EarlyAttach[HardyDesignBackupFaculty.Instance.HisGazeUpBulge(DateTime.Now)] = Hear;
        //MindGazeFaculty.SetString(CChoppy.sv_MentalSourceInfo, JsonMapper.ToJson(info));
        MindGazeFaculty.SetString(CChoppy.Of_AttachBackupComa, JsonMapper.ToJson(HardyDesignBackupFaculty.Instance.EarlyAttach));
       
    }
    public override void Hidding()
    {
        base.Hidding();
        
        HardyDesignWhenOvertime.Instance.BackupMortal?.Invoke();
    }

    private void ByViaFlute()
    {
        ByPeat.Equality.ItemMortalBy(10004, (success) =>
        {
            if (success)
            {
                // 播放成功逻辑处理
                ByVia.enabled = false;
                ExpertVia.enabled = false;
                //广告
                RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_doublereward);
                HarmLayerCloset.HisEquality().DramLayer("1005", HardyDesignBackupFaculty.Instance.AttachMortalID.ToString(), "1");
                //playhive打点
                LayerFatPeat.Equality.DramDeftLayer(10002, "brain_free_rew_10002");
                MarshyFlowerbed(HurlTear, Seedy, () =>
                {
                    HurlTear.text = (Seedy * 2).ToString("f0");
                    if (BureauVolt.MyRaise())
                        HardyDesignWhenGazeFaculty.HisEquality().EonFrom(Seedy * 2);
                    else
                        HardyDesignWhenGazeFaculty.HisEquality().EonMeter(Seedy * 2);
                    SpoonUITrap(GetType().Name);
                });
            }
        });
        
    }

    private void ExpertViaFlute()
    {
        ByPeat.Equality.ItemMusicologistBy(10007, (success) =>
        {
            if (success)
            {
                // 播放成功逻辑处理
                ByVia.enabled = false;
                ExpertVia.enabled = false;
                HarmLayerCloset.HisEquality().DramLayer("1005", HardyDesignBackupFaculty.Instance.AttachMortalID.ToString(), "0");
                if (BureauVolt.MyRaise())
                    HardyDesignWhenGazeFaculty.HisEquality().EonFrom(Seedy);
                else
                    HardyDesignWhenGazeFaculty.HisEquality().EonMeter(Seedy);
            }
        });
        
        
        SpoonUITrap(GetType().Name);
    }
    
    public void MarshyFlowerbed(Text text, float startNum, System.Action finish) 
    {
        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_countup);
        text.transform.DOScale(2f, 0.3f).SetEase(Ease.OutBack).OnComplete(()=> 
        {
            DOTween.To(() => startNum, x => text.text = x.ToString("f0"), startNum * 2, 0.5f).OnComplete(() => 
            {
                text.transform.DOScale(1f, 0.3f).SetDelay(1).OnComplete(()=>
                {
                    finish();
                });
            });
        });
    }
}
