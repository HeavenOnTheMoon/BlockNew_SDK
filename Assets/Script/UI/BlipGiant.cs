using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlipGiant : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("InitGroup")]    public GameObject BankGiant;

    private GameObject AchinglyExaltScript;
    private float UtahGesso= 120f; // 两个item的position.x之差

    // Start is called before the first frame update
    void Start()
    {
        AchinglyExaltScript = BankGiant.transform.Find("SlotCard_1").gameObject;
        float x = UtahGesso * 3;
        int multiCount = WitComaEka.instance.BankGaze.slot_group.Count;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < multiCount; j++)
            {
                GameObject fangkuai = Instantiate(AchinglyExaltScript, BankGiant.transform);
                fangkuai.transform.localPosition = new Vector3(x + UtahGesso * multiCount * i + UtahGesso * j, AchinglyExaltScript.transform.localPosition.y, 0);
                fangkuai.transform.Find("Text").GetComponent<Text>().text = "×" + WitComaEka.instance.BankGaze.slot_group[j].multi;
            }
        }
    }

    public void FolkExalt()
    {
        BankGiant.GetComponent<RectTransform>().localPosition = new Vector3(0, -10, 0);
    }

    public void Snap(int index, Action<int> finish)
    {
        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_OneArmBandit);
        FlowerbedGeneralist.PersuasiveMaiden(BankGiant, -(UtahGesso * 2 + UtahGesso * WitComaEka.instance.BankGaze.slot_group.Count * 3 + UtahGesso * (index + 1)), () =>
        {
            finish?.Invoke(WitComaEka.instance.BankGaze.slot_group[index].multi);
        });
    }
}
