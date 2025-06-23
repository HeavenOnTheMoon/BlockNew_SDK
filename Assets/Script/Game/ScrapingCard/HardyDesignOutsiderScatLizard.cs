using System.Collections;
using System.Collections.Generic;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class HardyDesignOutsiderScatLizard : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    ///  金币 现金
    /// </summary>
    /// <param name="index"></param>
    public void Bank(int index)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == index);
        }
    }

    int Syrup= 0;
    public void Broker(bool isShow)
    {
        Syrup++;
        transform.GetChild(6).gameObject.SetActive(isShow);
        if (isShow)
        {
            RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_ScratCardCricle);
            SkeletonGraphic skeleton = transform.GetChild(6).gameObject.GetComponent<SkeletonGraphic>();
            skeleton.AnimationState.SetEmptyAnimation(0, 0);
            skeleton.AnimationState.AddAnimation(Syrup, "animation", false, 0);
            skeleton.Update(0); 
        }
    }
}
