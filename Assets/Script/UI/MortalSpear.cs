using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MortalSpear : AlgaUISleek
{
[UnityEngine.Serialization.FormerlySerializedAs("AdBtn")]    public Button ByVia;
[UnityEngine.Serialization.FormerlySerializedAs("NormalBtn")]    public Button ExpertVia;
[UnityEngine.Serialization.FormerlySerializedAs("RewardText")]
    public Text MortalTear;
[UnityEngine.Serialization.FormerlySerializedAs("RewardObjs")]    public GameObject MortalClue;
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
    
    public override void Display()
    {
        base.Display();
        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Openboard);
        IcelandUI();
        ByVia.enabled = true;
        ExpertVia.enabled = true;
    }
    public override void Hidding()
    {
        base.Hidding();
        
        if(HardyDesignWhenOvertime.Instance.Overtime == "ScratchcardReward")
            HardyDesignWhenOvertime.Instance.IncorrectlyMortal?.Invoke();
        if(HardyDesignWhenOvertime.Instance.Overtime == "WheelReward")
            HardyDesignWhenOvertime.Instance.BowelMortal?.Invoke();
    }

    float GirderSeedy;
    string GirderWell;
    private void IcelandUI()
    {
        for (int i = 0; i < MortalClue.transform.childCount; i++)
        {
            MortalClue.transform.GetChild(i).gameObject.SetActive(false);
        }
        GirderSeedy = float.Parse(MindGazeFaculty.GetString(CChoppy.Of_MortalSeedy));
        GirderWell = MindGazeFaculty.GetString(CChoppy.Of_MortalWell);
        if (GirderWell == "cash")
        {
            MortalTear.text = GirderSeedy.ToString("f2");
            FordKnife(GirderSeedy > WitComaEka.instance.WhenGaze.CashLimit ? 2 : 3);
        }
        else
        {
            MortalTear.text = GirderSeedy.ToString("f0");
            FordKnife(GirderSeedy > WitComaEka.instance.WhenGaze.CoinLimit ? 0 : 1);
        }
    }

    private void FordKnife(int index)
    {
        MortalClue.transform.GetChild(index).gameObject.SetActive(true);
    }

    private void ByViaFlute()
    {
        ByVia.enabled = false;
        ExpertVia.enabled = false;
        //广告
        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_doublereward);
        if (HardyDesignWhenOvertime.Instance.Overtime == "ScratchcardReward")
            HarmLayerCloset.HisEquality().DramLayer("1004", "1");
        else
            HarmLayerCloset.HisEquality().DramLayer("1003", "1");
        MarshyFlowerbed(MortalTear, GirderSeedy, () =>
        {
            MortalTear.text = GirderWell == "cash" ? (GirderSeedy * 2).ToString("f2") : (GirderSeedy * 2).ToString("f0");

            if (GirderWell == "cash")
            {
                HardyDesignWhenGazeFaculty.HisEquality().EonMeter(GirderSeedy * 2);
            }
            else
            {
                HardyDesignWhenGazeFaculty.HisEquality().EonFrom(GirderSeedy * 2);
            }
            SpoonUITrap(GetType().Name);
        });
    }

    private void ExpertViaFlute()
    {
        ByVia.enabled = false;
        ExpertVia.enabled = false;
        if(HardyDesignWhenOvertime.Instance.Overtime == "ScratchcardReward")
            HarmLayerCloset.HisEquality().DramLayer("1004", "0");
        else
            HarmLayerCloset.HisEquality().DramLayer("1003", "0");
        if (GirderWell == "cash")
        {
            HardyDesignWhenGazeFaculty.HisEquality().EonMeter(GirderSeedy);
        }
        else
        {
            HardyDesignWhenGazeFaculty.HisEquality().EonFrom(GirderSeedy);
        }
        
        SpoonUITrap(GetType().Name);
    }
    
    public void MarshyFlowerbed(Text text, float startNum, System.Action finish) 
    {
        text.transform.DOScale(2f, 0.3f).SetEase(Ease.OutBack).OnComplete(()=> 
        {
            RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_countup);
            if (GirderWell == "cash")
                DOTween.To(() => startNum, x => text.text = x.ToString("f2"), startNum * 2, 0.5f).OnComplete(() => 
                {
                    text.transform.DOScale(1f, 0.3f).SetDelay(1).OnComplete(()=>
                    {
                        finish();
                    });
                });
            else
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
