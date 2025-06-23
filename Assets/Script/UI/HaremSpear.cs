using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
using UnityEditor;
using Spine.Unity;
using TMPro;
using System;

public class HaremSpear : AlgaUISleek
{
[UnityEngine.Serialization.FormerlySerializedAs("SlotBlockList")]    public List<GameObject> BlipHardyName;
[UnityEngine.Serialization.FormerlySerializedAs("BlockList_AD")]    public GameObject HardyName_AD;
[UnityEngine.Serialization.FormerlySerializedAs("BlockList")]    public GameObject HardyName;
[UnityEngine.Serialization.FormerlySerializedAs("TimeScale")]    public float PortHabit= 0;
[UnityEngine.Serialization.FormerlySerializedAs("DoubleBtn")]    public Button EthnicVia;
[UnityEngine.Serialization.FormerlySerializedAs("ReceiveBtn")]    public Button ConquerVia;
[UnityEngine.Serialization.FormerlySerializedAs("Loops")]    public bool Scout;
[UnityEngine.Serialization.FormerlySerializedAs("BoxSpine")]
    public GameObject FenBegin;
[UnityEngine.Serialization.FormerlySerializedAs("RewardBar")]    public GameObject MortalMud;
[UnityEngine.Serialization.FormerlySerializedAs("showList")]    public List<GameObject> LintName;
[UnityEngine.Serialization.FormerlySerializedAs("RewardText")]
    public Text MortalTear;
[UnityEngine.Serialization.FormerlySerializedAs("SlotObjs")]
    public List<GameObject> BlipClue;
[UnityEngine.Serialization.FormerlySerializedAs("EndRewardText")]    public Text RyeMortalTear;
[UnityEngine.Serialization.FormerlySerializedAs("CoinText")]
    public TextMeshProUGUI LuceTear;
[UnityEngine.Serialization.FormerlySerializedAs("CashText")]    public TextMeshProUGUI HurlTear;
[UnityEngine.Serialization.FormerlySerializedAs("CoinTF")]    public Transform LuceTF;
[UnityEngine.Serialization.FormerlySerializedAs("CashTF")]    public Transform HurlTF;

    //public GameObject BlockItem;
    // Start is called before the first frame update
    void Start()
    {
        EthnicVia.onClick.AddListener(() =>
        {
            EthnicVia.enabled = false;
            ConquerVia.enabled = false;
            //广告
            RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_doublereward);
            HarmLayerCloset.HisEquality().DramLayer("1006", HardyDesignBackupFaculty.Instance.AttachMortalID.ToString(), "1");
            BlipEscape();
            PortHabit = 0.5f;
            ADBlip(() =>
            {
                ElkGear();

            });
            
            
        });

        ConquerVia.onClick.AddListener(() => 
        {
            EthnicVia.enabled = false;
            ConquerVia.enabled = false;
            BlipEscape();
            //加金币
            if (Hear.type == "cash")
                HardyDesignWhenGazeFaculty.HisEquality().EonMeter(Style);
            else
                HardyDesignWhenGazeFaculty.HisEquality().EonFrom(Style);

            HarmLayerCloset.HisEquality().DramLayer("1006", HardyDesignBackupFaculty.Instance.AttachMortalID.ToString(), "0");
            StartCoroutine(PortCrop(1.5f, () => {
                SpoonUITrap(GetType().Name);
                
                SpoonUITrap("MarketSpear");
                if (HardyDesignTrafficFaculty.instance.HisHomelessTrafficShare())
                    UIFaculty.HisEquality().FordUISleek("DauntSpear");
                else
                    UIFaculty.HisEquality().FordUISleek(BureauVolt.WhenKnot());
                /*GameObject ChangeSceneMask = UIFaculty.GetInstance().MainCanvas.transform.Find("Top/FactorPupil").gameObject;
                ChangeSceneMask.SetActive(true);
                ChangeSceneMask.GetComponent<FactorPupil>().ChangeSceneAni(() =>
                {
                    CloseUIForm("MarketSpear");
                    if (HardyDesignTrafficFaculty.instance.GetCompleteChapterStage())
                        UIFaculty.GetInstance().ShowUIForms("DauntSpear");
                    else
                        UIFaculty.GetInstance().ShowUIForms("WhenSpear");
                }, () =>
                {

                });*/
            }));
        });


        PreciseCinemaBliss.HisEquality().Elongate(CChoppy.We_No_Overrun, (messageData) =>
        {
            MiteMobFlowerbed(messageData.StyleTransform, messageData.StyleEthnic);
        });
        PreciseCinemaBliss.HisEquality().Elongate(CChoppy.We_No_Promptly, (messageData) =>
        {
            PattyMobFlowerbed(messageData.StyleTransform, messageData.StyleEthnic);
        });
    }

    private void MobMortal()
    {
        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_countup);  
        if (Hear.type == "cash")
        {
                      
            DOTween.To(() => Style, x => MortalTear.text = x.ToString("f2"), Style * Militarily, 0.5f).OnComplete(() => 
            {
                MortalTear.text = (Style * Militarily).ToString("f2");
                MortalTear.transform.DOScale(1f, 0.3f).SetDelay(1).OnComplete(()=>
                {
                    HardyDesignWhenGazeFaculty.HisEquality().EonMeter(Style * Militarily);
                    LatheEthnicMortal();
                });
                            
            });
        }
        else
        {
            DOTween.To(() => Style, x => MortalTear.text = x.ToString("f0"), Style * Militarily, 0.5f).OnComplete(() => 
            {
                MortalTear.text = (Style * Militarily).ToString("f0");
                MortalTear.transform.DOScale(1f, 0.3f).SetDelay(1).OnComplete(()=>
                {
                    HardyDesignWhenGazeFaculty.HisEquality().EonFrom(Style * Militarily);
                    LatheEthnicMortal();
                });
                            
            });
        }
    }

    private void LatheEthnicMortal()
    {
        StartCoroutine(PortCrop(1.5f, () => {
            SpoonUITrap(GetType().Name);
            SpoonUITrap("MarketSpear");
            if (HardyDesignTrafficFaculty.instance.HisHomelessTrafficShare())
                UIFaculty.HisEquality().FordUISleek("DauntSpear");
            else
                UIFaculty.HisEquality().FordUISleek(BureauVolt.WhenKnot());
            /*GameObject ChangeSceneMask = UIFaculty.GetInstance().MainCanvas.transform.Find("Top/FactorPupil").gameObject;
            ChangeSceneMask.SetActive(true);
            ChangeSceneMask.GetComponent<FactorPupil>().ChangeSceneAni(() =>
            {
                CloseUIForm("MarketSpear");
                if (HardyDesignTrafficFaculty.instance.GetCompleteChapterStage())
                    UIFaculty.GetInstance().ShowUIForms("DauntSpear");
                else
                    UIFaculty.GetInstance().ShowUIForms("WhenSpear");
            }, () =>
            {

            });*/
        }));
    }

    double Style;
    public override void Display()
    {
        base.Display();
        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Openboard);
        EthnicVia.enabled = true;
        ConquerVia.enabled = true;
        //页面初始化
        Folk();
        IcelandBlipUI();
        //展示动画
        FordSun();
        //宝箱打开动画
        StartCoroutine(KilnFen());
        //slot转动动画
        BlipSun();
        BlipSun_1();
        HardyName_AD.SetActive(false);

        /*CoinText.text = (HardyDesignWhenGazeFaculty.GetInstance().getGold().ToString("f0"));
        CashText.text = SaddenVolt.DoubleToStr(HardyDesignWhenGazeFaculty.GetInstance().getToken());*/

    }
    RewardItem Hear;
    /// <summary>
    /// 初始化
    /// </summary>
    public void Folk() 
    {
        PortHabit = 10f;
        BlipHardyName[0].transform.GetChild(3).localScale = new Vector3(1, 1, 1);
        BlipHardyName[0].transform.localPosition = new Vector3(465, 0, 0);
        BlipHardyName[1].transform.localPosition = new Vector3(1395, 0, 0);
        Scout = true;
        HardyName.SetActive(true);
        MortalMud.SetActive(false);
        FenBegin.GetComponent<SkeletonGraphic>().AnimationState.SetAnimation(0, "idle1", false);
        Hear = HardyDesignDeftFaculty.instance.HisMortalWell(WitComaEka.instance.WhenGaze.BoxInfo.BoxReward);
        if (Hear.type == "cash")
        {
            Style = BlockPuzzleGameUtil.HisHurlExalt() * double.Parse(Hear.multiple);
            var parent = MortalTear.transform.parent;
            parent.GetChild(0).gameObject.SetActive(true); 
            parent.GetChild(1).gameObject.SetActive(false);
            MortalTear.text = Style.ToString("f2");
        }
        else
        {
            Style = BlockPuzzleGameUtil.HisFromExalt() * double.Parse(Hear.multiple);
            var parent = MortalTear.transform.parent;
            parent.GetChild(0).gameObject.SetActive(false); 
            parent.GetChild(1).gameObject.SetActive(true); 
            MortalTear.text = Style.ToString("f0");
        }
        
    }


    /// <summary>
    /// 默认状态下的slot轴1
    /// </summary>
    public void BlipSun() 
    {
        var SlotList = DOTween.Sequence();
        
        BlipHardyName[0].transform.DOLocalMoveX(-465, ((BlipHardyName[0].transform.localPosition.x/930)+0.5f)* PortHabit).SetEase(Ease.Linear).OnComplete(()=> 
        {
            BlipHardyName[0].transform.localPosition = new Vector3(1395, 0, 0);
            if (Scout) 
            {
                BlipSun();
            }
        });
        
    }
    /// <summary>
    /// 默认状态下的slot轴2
    /// </summary>
    public void BlipSun_1()
    {
        var SlotList = DOTween.Sequence();
        BlipHardyName[1].transform.DOLocalMoveX(-465, ((BlipHardyName[1].transform.localPosition.x / 930)+0.5f)* PortHabit).SetEase(Ease.Linear).OnComplete(() =>
        {
            BlipHardyName[1].transform.localPosition = new Vector3(1395, 0, 0);
            if (Scout)
            {
                BlipSun_1();
            }
            
        });

    }

    /// <summary>
    /// 看视频slot
    /// </summary>
    public void ADBlip(System.Action finish) 
    {
        HardyName.SetActive(false);
        HardyName_AD.SetActive(true);
        HardyName_AD.transform.localPosition = new Vector3(4652, 0, 0);
        var ADSlot = DOTween.Sequence();
        ADSlot.Append(HardyName_AD.transform.DOLocalMoveX(3101f, 1f).SetEase(Ease.InExpo));
        ADSlot.Append(HardyName_AD.transform.DOLocalMoveX(1550f, 0.5f).SetEase(Ease.Linear));
        ADSlot.Append(HardyName_AD.transform.DOLocalMoveX(-30f, 1f).SetEase(Ease.OutExpo));
        ADSlot.Append(HardyName_AD.transform.DOLocalMoveX(0f,0.4f));
        ADSlot.AppendCallback(() =>
        {
            
            //动画结束 text x2 
            finish();
        });
    }

    /// <summary>
    /// 停止两轴转动进行加速倍数动画
    /// </summary>
    public void BlipEscape() 
    {
        BlipHardyName[0].transform.DOKill();
        BlipHardyName[1].transform.DOKill();
        Scout = false;
    }
    /// <summary>
    /// 每次打开动画
    /// </summary>
    public void FordSun() 
    {
        /*float delayTime = 0;
        for (int i = 0; i < showList.Count; i++)
        {
            GameObject item = showList[i];
            item.transform.localScale = new Vector3(0, 0, 0);
            item.transform.DOScale(1, 0.4f).SetEase(Ease.OutBack).SetDelay(delayTime);
            delayTime += 0.5f;
        }*/
    }
    /// <summary>
    /// 宝箱打开动画
    /// </summary>
    /// <returns></returns>
    public IEnumerator KilnFen()
    {
        for (int i = 0; i < LintName.Count; i++)
        {
            GameObject Utah= LintName[i];
            Utah.transform.localScale = new Vector3(0, 0, 0);
            //item.transform.DOScale(1, 0.4f).SetEase(Ease.OutBack).SetDelay(delayTime);
            //delayTime += 0.5f;
        }
        FenBegin.transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        FenBegin.transform.DOScale(1, 0.4f).SetEase(Ease.OutBack).SetDelay(0);
        MortalMud.transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 350);
        yield return new WaitForSeconds(0.7f);
        FenBegin.GetComponent<SkeletonGraphic>().AnimationState.SetAnimation(0, "open", false);
        yield return new WaitForSeconds(1.3f);
        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_GetReward);
        MortalMud.SetActive(true);
        MortalMud.transform.localScale = new Vector3(0, 0, 0);
        MortalMud.transform.DOScale(1, 0.3f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(0.3f);
        FenBegin.GetComponent<SkeletonGraphic>().AnimationState.SetAnimation(0, "open_idel", true);
        //RewardBar.transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -150);
        MortalMud.transform.DOLocalMoveY(-300, 0.5f);
        yield return new WaitForSeconds(0.7f);
        MortalMud.transform.DOLocalMoveY(-300, 0.5f);
        
        MortalMud.transform.DOLocalMoveY(150, 0.5f);
        FenBegin.transform.DOLocalMoveY(450, 0.5f);
        yield return new WaitForSeconds(0.6f);
        float delayTime = 0;
        for (int i = 1; i < LintName.Count; i++)
        {
            GameObject Utah= LintName[i];
            Utah.transform.localScale = new Vector3(0, 0, 0);
            Utah.transform.DOScale(1, 0.4f).SetEase(Ease.OutBack).SetDelay(delayTime);
            delayTime += 0.2f;
        }
    }

    double Militarily= 0;
    private void IcelandBlipUI()
    {
        List<MultiplierBox> GirderSeedy= new List<MultiplierBox>();
        GirderSeedy = LuxuryName(WitComaEka.instance.WhenGaze.BoxInfo.MultiplierInfo);
        
        for (int i = 0; i < BlipClue.Count; i++)
        {
            for (int j = 0; j < BlipClue[i].transform.childCount; j++)
            {
                BlipClue[i].transform.GetChild(j).GetChild(0).GetComponent<Text>().text = "×" + GirderSeedy[j].Multiplier;
            }
        }
        Militarily = double.Parse(HardyDesignDeftFaculty.instance.HisMilitarily(WitComaEka.instance.WhenGaze.BoxInfo.MultiplierInfo).Multiplier);
        RyeMortalTear.text = "×" + Militarily.ToString();
        
    }
    
    

    private List<T> LuxuryName<T>(List<T> num)
    {
        for (int i = 0; i < num.Count; i++)
        {
            var temp = num[i];
            int randomIndex = UnityEngine.Random.Range(0, num.Count);
            num[i] = num[randomIndex];
            num[randomIndex] = temp;
        }
        return num;
    }
[UnityEngine.Serialization.FormerlySerializedAs("uiElement")]    
    public List<RectTransform> NoRemoval; // UI元素的RectTransform
[UnityEngine.Serialization.FormerlySerializedAs("controlPoint")]    public List<Vector2> PlummetSpend; // 曲线的控制点
[UnityEngine.Serialization.FormerlySerializedAs("duration")]    public float Electric= 0.3f; // 从起点到终点的时间

    private float t; // Lerp参数
    void ElkGear()
    {
        t = 0;
        for (int i = 0; i < NoRemoval.Count; i++)
        {
            GameObject Utah= NoRemoval[i].gameObject;
            Utah.gameObject.SetActive(true);
            Utah.transform.localScale = new Vector3(100, 100, 100);
            int B = i;
            float A = 0;
            if (i < 2)
            {
                A = 1;
            }
            else
            {
                A = -1;
            }
            Vector3 MidPos = new Vector3((Utah.transform.position.x + MortalMud.transform.position.x) / 2 + A, (Utah.transform.position.y + MortalMud.transform.position.y) / 2, 0);
            Vector3[] path = PrettyAgent.HisBeizerName(Utah.transform.position, MidPos, MortalMud.transform.position, 6);
            Utah.transform.DOPath(path, 0.8f).OnComplete(() =>
            {
                Utah.gameObject.SetActive(false);
                if (B == NoRemoval.Count - 1)
                {
                    MobMortal();
                }
            });
        }
    }
    
    // Update is called once per frame

    Vector2 DramatizePrettySpend(float t, Vector2 p0, Vector2 p1, Vector2 p2)
    {
        // 二次贝塞尔曲线计算
        float u = 1 - t;
        float tt = t * t;
        float uu = u * u;
        Vector2 p = uu * p0; // 第一项
        p += 2 * u * t * p1; // 第二项
        p += tt * p2; // 第三项
        return p;
    }


    public void MiteMobFlowerbed(Transform startTransform, double num)
    {
        EonFlowerbed(startTransform, LuceTF, LuceTF.gameObject, LuceTear, HardyDesignWhenGazeFaculty.HisEquality().DigFrom(), num);
    }

    public void PattyMobFlowerbed(Transform startTransform, double num)
    {
        EonFlowerbed(startTransform, HurlTF, HurlTF.gameObject, HurlTear, HardyDesignWhenGazeFaculty.HisEquality().DigMeter(), num);
    }

    private void EonFlowerbed(Transform startTransform, Transform endTransform, GameObject icon, TextMeshProUGUI text, double textValue, double num)
    {
        if (startTransform != null)
        {
            var count = HardyDesignDeftFaculty.instance.HisMobExtol(double.Parse(text.text), textValue, endTransform == HurlTF.transform);
            FlowerbedGeneralist.HardyRayFromAvid(icon, count, startTransform.position, endTransform.position, () =>
            {
                FlowerbedGeneralist.FactorSadden(double.Parse(text.text), textValue, 0f, text, () =>
                {
                    text.text = SaddenVolt.EthnicUpStr(textValue);
                });
            }, () => { });
        }
        else
        {
            FlowerbedGeneralist.FactorSadden(double.Parse(text.text), textValue, 0f, text, () => {
                text.text = SaddenVolt.EthnicUpStr(textValue);
            });
        }
    }

    public IEnumerator PortCrop(float time, Action finish)
    {
        yield return new WaitForSeconds(time);
        finish?.Invoke();
    }
}
