using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HardyDesignAttachMortalLizard : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("CashText")]    public Text HurlTear;
[UnityEngine.Serialization.FormerlySerializedAs("CashObj")]    public GameObject HurlPut;
[UnityEngine.Serialization.FormerlySerializedAs("ComPleteObj")]    public GameObject BowUnityPut;
[UnityEngine.Serialization.FormerlySerializedAs("UnCompleteObj")]    public GameObject HeHomelessPut;
[UnityEngine.Serialization.FormerlySerializedAs("OkObj")]    public GameObject ItPut;
[UnityEngine.Serialization.FormerlySerializedAs("CoinObj")]    public GameObject LucePut;
[UnityEngine.Serialization.FormerlySerializedAs("CoinText")]    public Text LuceTear;
    public void IcelandTear(int index)
    {
        int Style= 0;
        switch (index)
        {
            case 0:
                Style = WitComaEka.instance.WhenGaze.SourceRewards.oneQuarter;
                break;
            case 1:
                Style = WitComaEka.instance.WhenGaze.SourceRewards.twoQuarter;
                break;
            case 2:
                Style = WitComaEka.instance.WhenGaze.SourceRewards.threeQuarter;
                break;
            case 3:
                Style = WitComaEka.instance.WhenGaze.SourceRewards.fourQuarter;
                break;
        }

        HurlTear.text = Style.ToString();
    }

    public void IcelandUI(bool IsComplete)
    {
        //审核
        if (BureauVolt.MyRaise())
        {
            LucePut.gameObject.SetActive(IsComplete);
            LuceTear.text = "1000";
            HurlPut.gameObject.SetActive(false);
        }
        else
        {
            LucePut.gameObject.SetActive(false);
            HurlPut.gameObject.SetActive(IsComplete);
        }
        //CashObj.gameObject.SetActive(IsComplete);
        BowUnityPut.gameObject.SetActive(!IsComplete);
        HeHomelessPut.gameObject.SetActive(IsComplete);
        ItPut.gameObject.SetActive(!IsComplete);
    }
}
