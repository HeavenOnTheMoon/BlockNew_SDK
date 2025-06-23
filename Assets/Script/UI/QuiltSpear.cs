using System;
using System.Collections;
using System.Configuration;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuiltSpear : AlgaUISleek
{
[UnityEngine.Serialization.FormerlySerializedAs("CircleGuidanceObj")]    public GameObject TunnelSpoilagePut;
[UnityEngine.Serialization.FormerlySerializedAs("RectGuidanceObj")]    public GameObject MainSpoilagePut;
[UnityEngine.Serialization.FormerlySerializedAs("GuideText")]    public TextMeshProUGUI QuiltTear;
[UnityEngine.Serialization.FormerlySerializedAs("GuideTwoText")]    public TextMeshProUGUI QuiltHueTear;
[UnityEngine.Serialization.FormerlySerializedAs("MaskBtn")]    public Button FiveVia;
    /*
    public TextMeshProUGUI GuideText;
    public TextMeshProUGUI GuideTwoText;
    public GameObject HandObj;
    public Canvas Canvas;*/
    // Start is called before the first frame update
    void Start()
    {
        FiveVia.onClick.AddListener(() =>
        {
            QuiltTear.transform.parent.gameObject.SetActive(false);
            FiveVia.gameObject.SetActive(false);
            MindGazeFaculty.SetInt(CChoppy.Of_QuiltWhenLop, 1);
            QuiltTear.text = "Cash out in store!";
            //var target = WhenSpear.Instance.SOHOShopButton.gameObject.GetComponent<Image>();

            //CircleGuidanceObj.SetActive(true);
            //CircleGuidanceObj.GetComponent<HardyDesignTunnelSpoilage>().Init(target);
            QuiltHueTear.transform.parent.gameObject.SetActive(true);
            FlowerbedGeneralist.BegFord(QuiltHueTear.transform.parent.parent.gameObject, () =>
            {

            });
        });
        
        PreciseCinemaBliss.HisEquality().Elongate(CChoppy.We_SpoonAndBowQuilt, (messageData) =>
        {
            SpoonSpear();
        }); 
       
    }

    float Heal= 0;
    // Update is called once per frame
    void Update()
    {
        
    }

    int Pul;
    public override void Display()
    {
        base.Display();
        /*
       
        MaskBtn.gameObject.SetActive(false);*/
        QuiltHueTear.transform.parent.gameObject.SetActive(false);
        TunnelSpoilagePut.gameObject.SetActive(false);
        MainSpoilagePut.gameObject.SetActive(false);
        QuiltTear.transform.parent.gameObject.SetActive(false);
        FiveVia.gameObject.SetActive(false);
        Pul = 3;// GuideManager.instance.GetGuideSch(MindGazeFaculty.GetInt(CChoppy.sv_GuideSch));
        //HandObj.gameObject.SetActive(false);
        //还没有开始
        /*if (MindGazeFaculty.GetInt(CChoppy.sv_GuideHomeSch) == 0)
        {
            var target = FindSpear.instance.ClassicBtn.gameObject.GetComponent<Image>();
            StartCoroutine(GuideTimeLate(0.5f, () =>
            {
                CircleGuidanceObj.SetActive(true);
                CircleGuidanceObj.GetComponent<HardyDesignTunnelSpoilage>().Init(target);
                
            },0.5f,(() =>
            {
                /*GuideText.transform.parent.gameObject.SetActive(true);
                GuideText.transform.parent.parent.gameObject.SetActive(true);
                FlowerbedGeneralist.PopShow(GuideText.transform.parent.parent.gameObject, () =>
                {

                });#1#
            })));
        }
        else */
        if(MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenLop) == 0)
        {
            FiveVia.gameObject.SetActive(true);
            QuiltTear.text = "Crush block to get cash!";
            var Seldom= WhenSpear.Instance.HurlTF.transform.parent.gameObject.GetComponent<Image>();
            TunnelSpoilagePut.SetActive(true);
            TunnelSpoilagePut.GetComponent<HardyDesignTunnelSpoilage>().Bank(Seldom);
            QuiltTear.transform.parent.gameObject.SetActive(true);
            FlowerbedGeneralist.BegFord(QuiltTear.transform.parent.parent.gameObject, () =>
            {

            });
        }
    }
    
    public override void Hidding()
    {
        base.Hidding();
    }
    
    IEnumerator QuiltPortCrop(float time, Action finish, float timeTwo = 0, Action finishTow = null)
    {
        yield return new WaitForSeconds(time);
        finish?.Invoke();
        yield return new WaitForSeconds(timeTwo);
        finishTow?.Invoke();
    }

    private void SpoonSpear()
    {
        SpoonUITrap(GetType().Name);
    }
}
