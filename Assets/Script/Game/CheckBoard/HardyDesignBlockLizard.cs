using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HardyDesignBlockLizard : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Text")]    public Text Tear;
[UnityEngine.Serialization.FormerlySerializedAs("FixObj")]    public GameObject BogPut;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Bank(int index)
    {
        Tear.text = index.ToString();
        
    }

    private void OnEnable()
    {
        BogPut.SetActive(true);
        if (HardyDesignBackupFaculty.Instance.HisBlock() - 1 <= 8)
        {
            switch (HardyDesignBackupFaculty.Instance.HisBlock() - 1)
            {
                case 1: RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Progressive_1); break;
                case 2: RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Progressive_2); break;
                case 3: RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Progressive_3); break;
                case 4: RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Progressive_4); break;
                case 5: RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Progressive_5); break;
                case 6: RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Progressive_6); break;
                case 7: RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Progressive_7); break;
                case 8: RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Progressive_8); break;
            }
        }
        else 
        {
            RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Progressive_8);
        }
    }
}
