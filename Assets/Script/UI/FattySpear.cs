using System;
using System.Collections;
using System.Collections.Generic;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FattySpear : AlgaUISleek
{
[UnityEngine.Serialization.FormerlySerializedAs("RewardInfoObjs")]    public List<GameObject> MortalComaClue;
[UnityEngine.Serialization.FormerlySerializedAs("SelectDaySchImage")]    public Image ChorusYamLopKnife;
[UnityEngine.Serialization.FormerlySerializedAs("SpineAni")]    public SkeletonGraphic BeginSun;
[UnityEngine.Serialization.FormerlySerializedAs("SelectDaySchText")]    public Text ChorusYamLopTear;
[UnityEngine.Serialization.FormerlySerializedAs("SelectDaySchDicText")]    public Text ChorusYamLopSayTear;
[UnityEngine.Serialization.FormerlySerializedAs("BlockBtn")]    public Button HardyVia;
[UnityEngine.Serialization.FormerlySerializedAs("MentalWidgetObj")]
    public GameObject AttachLizardPut;
[UnityEngine.Serialization.FormerlySerializedAs("scrollRect")]    public ScrollRect FriendMain;  
    // Start is called before the first frame update
    void Start()
    { 
        HardyVia.onClick.AddListener(HardyViaFlute);
        /*for (int i = 0; i < MentalWidgetObj.transform.childCount; i++)
        {
            MentalWidgetObj.transform.GetChild(i).GetComponent<HardyDesignAttachLizard>().Select = MentalClick;
        }*/

        for (int i = 0; i < MortalComaClue.Count; i++)
        {
            MortalComaClue[i].GetComponent<HardyDesignAttachMortalLizard>().IcelandTear(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int ParrotWin= 19;
    public override void Display()
    {
        base.Display();
        MaidenUpDomain();
        
        ParrotWin = 19;
        AttachFlute(19);
        IcelandUI();
    }
    public override void Hidding()
    {
        base.Hidding();
        

    }

    private void HardyViaFlute()
    {
        SpoonUITrap(GetType().Name);
    }
    public void MaidenUpDomain()
    {
        // 设置verticalNormalizedPosition为0使其滚动到底部
        FriendMain.horizontalNormalizedPosition = 1f;
    }

    private void IcelandUI()
    {
        for (int i = 0; i < AttachLizardPut.transform.childCount; i++)
        {
            AttachLizardPut.transform.GetChild(i).GetComponent<HardyDesignAttachLizard>().Bank(i + 1);
        }
        
        
    }

    private void AttachFlute(int index)
    {
        //0 ~ 19    before ~ Today
        ParrotWin = index;
        var Hear= HardyDesignBackupFaculty.Instance.HisMereAttachComa(index);
        float Pul= (float)Hear.Backup / WitComaEka.instance.WhenGaze.SourceRewards.dailyMaxSource;
        ChorusYamLopTear.text = (Pul * 100).ToString("f0") + "%";
        ChorusYamLopKnife.fillAmount = Pul;
        SkeletonGraphic skeleton = BeginSun.GetComponent<SkeletonGraphic>();
        skeleton.AnimationState.SetEmptyAnimation(0, 0);
        BeginSun.AnimationState.SetAnimation(0, "animation", true);
        if (Pul * 100 > 100)
        {
            BeginSun.AnimationState.SetAnimation(1, "100", true);
        }
        else
        {
            BeginSun.AnimationState.SetAnimation(1, (Pul * 100).ToString("f0"), true);
        }
        skeleton.Update(0); 
        if (Pul < 0.25f)
        {
            ChorusYamLopSayTear.text = "Conscious";
            IcelandMortalComa(0);
        }
        else if(Pul >= 0.25f && Pul < 0.5f)
        {
            ChorusYamLopSayTear.text = "Conscious";
            IcelandMortalComa(1);
        }
        else if(Pul >= 0.5f && Pul < 0.75f)
        {
            ChorusYamLopSayTear.text = "Clever"; 
            IcelandMortalComa(2);
        }
        else if(Pul >= 0.75f && Pul < 1f)
        {
            ChorusYamLopSayTear.text = "Brain";
            IcelandMortalComa(3);
        }
        else
        {
            ChorusYamLopSayTear.text = "Genius";
            IcelandMortalComa(4);
        }
    }

    private void IcelandMortalComa(int index)
    {
        for (int i = 0; i < MortalComaClue.Count; i++)
        {
            MortalComaClue[i].GetComponent<HardyDesignAttachMortalLizard>().IcelandUI(i >= index);
        }
    }
}
