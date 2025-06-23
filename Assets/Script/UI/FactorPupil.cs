using DG.Tweening;
using Spine;
using Spine.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactorPupil : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("TopImage")]    public GameObject WaxKnife;
[UnityEngine.Serialization.FormerlySerializedAs("BottomImage")]    public GameObject DomainKnife;
[UnityEngine.Serialization.FormerlySerializedAs("StartSpine")]    public SkeletonGraphic SewerBegin;

    private Action Finish;
    private Action Grammatical;

    // Start is called before the first frame update
    void Start()
    {
        float A = Screen.height;
        WaxKnife.transform.localPosition = new Vector3(0, A / 2, 0);
        DomainKnife.transform.localPosition = new Vector3(0, -A / 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FactorPupilSun(Action finish, Action Otherfinish) 
    {
        this.Finish = finish;
        this.Grammatical = Otherfinish;
        gameObject.SetActive(true);
        StartCoroutine(nameof(ImpactMarket));
        SewerBegin.AnimationState.Complete += OnAnimationComplete;
        SewerBegin.AnimationState.SetAnimation(0, "animation", false);
        
        //RaiseEka.GetInstance().PlayEffect(RaiseWell.UIMusic.Sound_Woodloading);
    }

    private IEnumerator ImpactMarket()
    {
        yield return new WaitForSeconds(1f);
        Finish?.Invoke();
    }

    void OnAnimationComplete(TrackEntry trackEntry)
    {
        Grammatical?.Invoke();
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        SewerBegin.AnimationState.Complete -= OnAnimationComplete;
    }
}
