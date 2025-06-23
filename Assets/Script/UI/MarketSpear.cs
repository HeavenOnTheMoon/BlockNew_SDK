using System;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Spine.Unity;

public class MarketSpear : AlgaUISleek
{
[UnityEngine.Serialization.FormerlySerializedAs("ShowList")]    public List<GameObject> FordName;
[UnityEngine.Serialization.FormerlySerializedAs("GoldButton")]    public Button FromProton;
[UnityEngine.Serialization.FormerlySerializedAs("TokenBtn")]    public Button MeterVia;
[UnityEngine.Serialization.FormerlySerializedAs("NextBtn")]    
    public Button DirtVia;
[UnityEngine.Serialization.FormerlySerializedAs("FailedBtn")]    public Button LethalVia;
[UnityEngine.Serialization.FormerlySerializedAs("ChallengeRetayBtn")]    public Button SwordfishCreepVia;
[UnityEngine.Serialization.FormerlySerializedAs("HomeBtn")]    public Button FindVia;
[UnityEngine.Serialization.FormerlySerializedAs("SuccessRewardImage")]
    //public Text SuccessLevelText;
    public Image IcebergMortalKnife;
[UnityEngine.Serialization.FormerlySerializedAs("SuccessRewardText")]    public Text IcebergMortalTear;
[UnityEngine.Serialization.FormerlySerializedAs("BoxRewardSlider")]    public int FenMortalMildly;//宝箱进度
[UnityEngine.Serialization.FormerlySerializedAs("BoxRewardSchObj")]    public List<GameObject> FenMortalLopPut;
[UnityEngine.Serialization.FormerlySerializedAs("TargetObjs")]
    //public Text FailedLevelText;
    public List<GameObject> CobaltClue;
[UnityEngine.Serialization.FormerlySerializedAs("ChallengeBestSourceText")]
    public Text SwordfishLimeBackupTear;
[UnityEngine.Serialization.FormerlySerializedAs("CurChallengeSourceText")]    public Text PrySwordfishBackupTear;
[UnityEngine.Serialization.FormerlySerializedAs("CurChallengeSourceTwoText")]    public Text PrySwordfishBackupHueTear;
[UnityEngine.Serialization.FormerlySerializedAs("BestChallengeSourceTwoText")]    //最高分
    public Text LimeSwordfishBackupHueTear;
[UnityEngine.Serialization.FormerlySerializedAs("ChallengeRewadImage")]
    public Image SwordfishCloseKnife;
[UnityEngine.Serialization.FormerlySerializedAs("ChallengeRewedText")]    public Text SwordfishRewedTear;
[UnityEngine.Serialization.FormerlySerializedAs("FX_Challenge")]
    public GameObject FX_Swordfish;
[UnityEngine.Serialization.FormerlySerializedAs("FX_FireWork")]    public GameObject FX_FourArab;
[UnityEngine.Serialization.FormerlySerializedAs("RewardChallengeCash")]    public GameObject MortalSwordfishHurl;
[UnityEngine.Serialization.FormerlySerializedAs("PBGroup")]
    //public GameObject PBLight;
    //public GameObject PBLight;
    public GameObject PBGiant;
[UnityEngine.Serialization.FormerlySerializedAs("Ancu")]
    public AnimationCurve Bake;
[UnityEngine.Serialization.FormerlySerializedAs("ChangeSceneMask")]
    public GameObject FactorPupilFive;
[UnityEngine.Serialization.FormerlySerializedAs("CoinText")]    
    public Text LuceTear;
[UnityEngine.Serialization.FormerlySerializedAs("CashText")]    public Text HurlTear;
[UnityEngine.Serialization.FormerlySerializedAs("CashTF")]    public Transform HurlTF;
[UnityEngine.Serialization.FormerlySerializedAs("CoinTF")]    public Transform LuceTF;
[UnityEngine.Serialization.FormerlySerializedAs("TopBar")]    public GameObject WaxMud;
    // Start is called before the first frame update
    void Start()
    {
        //BX  奖励界面点位
        FromProton.onClick.AddListener(() => {
            
        });
        MeterVia.transform.parent.gameObject.SetActive(!BureauVolt.MyRaise());
        MeterVia.onClick.AddListener(() =>
        {
           
        });
        
        FactorPupilFive = UIFaculty.HisEquality().MainObtain.transform.Find("Top/ChangeScene").gameObject;

        DirtVia.onClick.AddListener((() =>
        {
            DirtVia.enabled = false;
           
            FordFactor((() =>
            {
                DirtVia.enabled = true;
                SpoonUITrap(GetType().Name);
                if (HardyDesignTrafficFaculty.instance.HisHomelessTrafficShare())
                    UIFaculty.HisEquality().FordUISleek("DauntSpear");
                else
                    UIFaculty.HisEquality().FordUISleek(BureauVolt.WhenKnot());
                /*ChangeSceneMask.SetActive(true);
                ChangeSceneMask.GetComponent<FactorPupil>().ChangeSceneAni(() => 
                {
                    NextBtn.enabled = true;
                    CloseUIForm(GetType().Name);
                    if(HardyDesignTrafficFaculty.instance.GetCompleteChapterStage())
                        UIFaculty.GetInstance().ShowUIForms("DauntSpear");
                    else
                        UIFaculty.GetInstance().ShowUIForms("WhenSpear");
                }, () => 
                {
                
                });*/
            }));
            
        }));
        
        LethalVia.onClick.AddListener((() =>
        {
            FordFactor((() =>
            {
                SpoonUITrap(GetType().Name);
                UIFaculty.HisEquality().FordUISleek(BureauVolt.WhenKnot());
                /*ChangeSceneMask.SetActive(true);
                ChangeSceneMask.GetComponent<FactorPupil>().ChangeSceneAni(() => 
                {
                    CloseUIForm(GetType().Name);
                    UIFaculty.GetInstance().ShowUIForms("WhenSpear");
                }, () => 
                {
                
                });*/
            }));
            
        }));
        
        SwordfishCreepVia.onClick.AddListener((() =>
        {
            ByPeat.Equality.ItemMusicologistBy(10006, (success) =>
            {
                if (success)
                {
                    FordFactor(() =>
                    {
                        SpoonUITrap(GetType().Name);
                        UIFaculty.HisEquality().FordUISleek(BureauVolt.WhenKnot());
                        /*ChangeSceneMask.SetActive(true);
                        ChangeSceneMask.GetComponent<FactorPupil>().ChangeSceneAni(() => 
                        {
                            CloseUIForm(GetType().Name);
                            UIFaculty.GetInstance().ShowUIForms("WhenSpear");
                        }, () => 
                        {

                        });*/
                    });
                }
                else
                {
                    SpoonUITrap(GetType().Name);
                    UIFaculty.HisEquality().FordUISleek(BureauVolt.WhenKnot());
                }
            });
            
            
        }));
        
        FindVia.onClick.AddListener((() =>
        {
            ByPeat.Equality.ItemMusicologistBy(10006, (success) =>
            {
                if (success)
                {
                    // 播放成功逻辑处理
                    FordFactor(() =>
                    {
                        SpoonUITrap(GetType().Name);
                        UIFaculty.HisEquality().FordUISleek("FindSpear");
                        /*ChangeSceneMask.SetActive(true);
                        ChangeSceneMask.GetComponent<FactorPupil>().ChangeSceneAni(() =>
                        {
                            CloseUIForm(GetType().Name);
                            UIFaculty.GetInstance().ShowUIForms("FindSpear");
                        }, () =>
                        {

                        });*/
                    });
                }
                else
                {
                    SpoonUITrap(GetType().Name);
                    UIFaculty.HisEquality().FordUISleek("FindSpear");
                }
            });
            

            //CloseUIForm(GetType().Name);
        }));
        
        PreciseCinemaBliss.HisEquality().Elongate(CChoppy.We_No_Overrun, (messageData) =>
        {
            MiteMobFlowerbed(messageData.StyleTransform, messageData.StyleEthnic);
        });
        PreciseCinemaBliss.HisEquality().Elongate(CChoppy.We_No_Promptly, (messageData) =>
        {
            PattyMobFlowerbed(messageData.StyleTransform, messageData.StyleEthnic);
        });
    }

    private void FordFactor(Action finish)
    {
        StartCoroutine(PortCrop(0.2f, () =>
        {
            finish?.Invoke();
        }));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public override void Display()
    {
        base.Display();
        LayerFatPeat.Equality.DramMortalLayer(1102, "game_pass_level_1102");
        WaxMud.SetActive(false);
        //FailedLevelText.text = "LEVEL " + (HardyDesignCrudeFaculty.Instance.GetCurLevel() + 1);
        //SuccessLevelText.text = "LEVEL " + (HardyDesignCrudeFaculty.Instance.GetCurLevel() + 1);
        LuceTear.text = (HardyDesignWhenGazeFaculty.HisEquality().DigFrom().ToString("f0"));
        HurlTear.text = SaddenVolt.EthnicUpStr(HardyDesignWhenGazeFaculty.HisEquality().DigMeter());
        HardyDesignDeftFaculty.instance.MarketWhen();
        IcelandUI();
        IcelandCobaltUI();
        float DelayTime = 0;
        int a = 0;
        var stage = MindGazeFaculty.GetString(CChoppy.Of_MarketShare);
        if (stage == "success")
        {
            CrudeMarketFlowerbed(() =>
            {
                
            });
        }
        else
        {
            for (int i = 0; i < FordName.Count; i++)
            {
                a = i;
                GameObject Utah= FordName[i];
                Utah.transform.localScale = new Vector3(0, 0, 0);
                Utah.transform.DOScale(0.7f, 0.3f).SetDelay(DelayTime).SetEase(Ease.OutBack).OnComplete((() =>
                {
                }));
                DelayTime += 0.1f;
                if (a == FordName.Count - 1)
                {

                }
            }
        }
        StartCoroutine(PortCrop(1.2f, () =>
        {
            var stage = MindGazeFaculty.GetString(CChoppy.Of_MarketShare);
            
            if (stage == "success")
            {
                FordName[2].transform.GetChild(0).gameObject.SetActive(false);
                FenMortalMildly = (HardyDesignCrudeFaculty.Instance.HisPryCrude()) % 5;
                if (FenMortalMildly == 0)
                    FenMortalMildly = 5;
                for (int i = 0; i < FenMortalMildly - 1; i++)
                {
                    if (i == FenMortalMildly - 1)
                    {
                        StartCoroutine(PortCrop(DelayTime + 0.5f, () => {
                            FenMortalLopPut[i].SetActive(true);
                            FenMortalLopPut[i].GetComponent<CanvasGroup>().alpha = 1;
                        }));
                    }
                    else
                    {
                        FenMortalLopPut[i].SetActive(true);
                        FenMortalLopPut[i].GetComponent<CanvasGroup>().alpha = 1;
                    }
                }
                StartCoroutine(HostileMortalFen((() =>
                {
                    FordName[2].transform.localScale = new Vector3(0, 0, 0);
                    //if (BoxRewardSlider != 5)
                    FordName[2].transform.GetChild(0).gameObject.SetActive(true);
                    FordName[2].transform.DOScale(0.7f, 0.3f).SetDelay(DelayTime).SetEase(Ease.OutBack).OnComplete((() =>
                    {
                    }));
                    
                })));
            }
            else if (stage == "bestChallenge" || stage == "Challenge")
            {
                if (stage == "bestChallenge")
                {
                    FX_FourArab.SetActive(true);
                }
                StartCoroutine(SwordfishSun());
            }
        }));
    }
    
    

    double Seedy;
    int Whip;
    private void IcelandUI()
    {
        var stage = MindGazeFaculty.GetString(CChoppy.Of_MarketShare);
        
        for (int i = 0; i < FordName[0].transform.childCount - 1; i++)
            FordName[0].transform.GetChild(i).gameObject.SetActive(false);
        
        for (int i = 0; i < FordName[1].transform.childCount; i++)
            FordName[1].transform.GetChild(i).gameObject.SetActive(false);
        
        for (int i = 0; i < FordName[2].transform.childCount; i++)
            FordName[2].transform.GetChild(i).gameObject.SetActive(false);
        var Hear= HardyDesignDeftFaculty.instance.HisMortalWell(WitComaEka.instance.WhenGaze.SuccessInfo);
        if (Hear.type == "cash")
        {
            Seedy = BlockPuzzleGameUtil.HisHurlExalt() * double.Parse(Hear.multiple);
            if(stage != "success")
                Seedy = (float)MindGazeFaculty.GetInt(CChoppy.Of_PryBackupExtol) / WitComaEka.instance.WhenGaze.FinishLimit * Seedy;
            Whip = 0;
            IcebergMortalKnife.sprite = HurlTF.transform.GetComponent<Image>().sprite;
            SwordfishCloseKnife.sprite = HurlTF.transform.GetComponent<Image>().sprite;
            IcebergMortalTear.text = Seedy.ToString("f2");
            SwordfishRewedTear.text = Seedy.ToString("f2");
        }
        else
        {
            Seedy = BlockPuzzleGameUtil.HisFromExalt() * double.Parse(Hear.multiple);
            if(stage != "success")
                Seedy = (float)MindGazeFaculty.GetInt(CChoppy.Of_PryBackupExtol) / WitComaEka.instance.WhenGaze.FinishLimit * Seedy;
            Whip = 1;
            IcebergMortalKnife.sprite = LuceTF.transform.GetComponent<Image>().sprite;
            SwordfishCloseKnife.sprite = LuceTF.transform.GetComponent<Image>().sprite;
            IcebergMortalTear.text = Seedy.ToString("f0");
            SwordfishRewedTear.text = Seedy.ToString("f0");
        }
        PrySwordfishBackupTear.text = MindGazeFaculty.GetInt(CChoppy.Of_PryBackupExtol).ToString("f0");
        LimeSwordfishBackupHueTear.text = MindGazeFaculty.GetInt(CChoppy.Of_UteBackupExtol).ToString("f0");
        PrySwordfishBackupHueTear.text =MindGazeFaculty.GetInt(CChoppy.Of_UteBackupExtol).ToString("f0"); 
        switch (stage)
        {
            case "success" :
                RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_CompleteLevel);
                FordName[0].transform.GetChild(0).gameObject.SetActive(true);
                FordName[1].transform.GetChild(0).gameObject.SetActive(true);
                //ShowList[2].transform.GetChild(0).gameObject.SetActive(true);
                
                break;
            case "failed" :
                FordName[0].transform.GetChild(1).gameObject.SetActive(true);
                FordName[1].transform.GetChild(1).gameObject.SetActive(true);
                FordName[2].transform.GetChild(1).gameObject.SetActive(true);
                FordName[2].transform.GetChild(3).gameObject.SetActive(true);
                break;
            case "bestChallenge" :
                FordName[0].transform.GetChild(2).gameObject.SetActive(true);
                FordName[1].transform.GetChild(2).gameObject.SetActive(true);
                FordName[1].transform.GetChild(2).transform.GetChild(0).gameObject.SetActive(false);
                FordName[1].transform.GetChild(2).transform.GetChild(1).gameObject.SetActive(true);
                FordName[2].transform.GetChild(2).gameObject.SetActive(true);
                FordName[2].transform.GetChild(3).gameObject.SetActive(true);
                HarmLayerCloset.HisEquality().DramLayer("1021", (MindGazeFaculty.GetInt(CChoppy.Of_PryBackupExtol) / 1000 + 1).ToString());
                break;
            case "Challenge" :
                FordName[0].transform.GetChild(3).gameObject.SetActive(true);
                FordName[1].transform.GetChild(2).gameObject.SetActive(true);
                FordName[1].transform.GetChild(2).transform.GetChild(0).gameObject.SetActive(true);
                FordName[1].transform.GetChild(2).transform.GetChild(1).gameObject.SetActive(false);
                FordName[2].transform.GetChild(2).gameObject.SetActive(true);
                FordName[2].transform.GetChild(3).gameObject.SetActive(true);
                HarmLayerCloset.HisEquality().DramLayer("1021", (MindGazeFaculty.GetInt(CChoppy.Of_PryBackupExtol) / 1000 + 1).ToString());
                break;
        }
        MortalSwordfishHurl.SetActive(false);
        FX_FourArab.SetActive(false);
        MortalSwordfishHurl.transform.localScale = new Vector3(0, 0, 0);
    }
    
    /// <summary>
    /// 刷新进度条
    /// </summary>
    public IEnumerator HostileMortalFen(Action finish) 
    {
        //yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < FenMortalLopPut.Count; i++)
        {
            GameObject Utah= FenMortalLopPut[i];
            if (FenMortalMildly > i)
            {
                Utah.SetActive(true);
                if (Utah.GetComponent<CanvasGroup>().alpha != 1)
                {
                    //RaiseEka.GetInstance().PlayEffect(RaiseWell.UIMusic.Sound_RewardBoxSch);
                    Utah.GetComponent<SkeletonGraphic>().AnimationState.SetAnimation(0, "1", false);
                }
                Utah.GetComponent<CanvasGroup>().DOFade(1, 0.3f);
            }
            else
            {
                Utah.SetActive(false);
                Utah.GetComponent<CanvasGroup>().alpha = 0;
            }
            if (FenMortalMildly == 5)
            {

                //BoxRewardSlider = 0;
                StartCoroutine(FordHaremSpear(() =>
                {
                    Utah.SetActive(false);
                    Utah.GetComponent<CanvasGroup>().alpha = 0;
                    //PBLight.GetComponent<CanvasGroup>().DOFade(0, 0.1f);
                }));
            }
        }
        if (FenMortalMildly == 5)
            yield return new WaitForSeconds(5f);
        else
            yield return new WaitForSeconds(0.5f);
        finish?.Invoke();
        
    }

    public IEnumerator FordHaremSpear(System.Action finish) 
    {
        yield return new WaitForSeconds(0.2f);
        //PBLight.GetComponent<CanvasGroup>().DOFade(1, 0.2f);
        yield return new WaitForSeconds(1f);
        UIFaculty.HisEquality().FordUISleek("HaremSpear");
        finish();
    }

    public IEnumerator SwordfishSun() 
    {
        yield return new WaitForSeconds(0.3f);
        FX_Swordfish.transform.position = SwordfishLimeBackupTear.transform.parent.position;
        FX_Swordfish.SetActive(true);
        FX_Swordfish.transform.DOMove(SwordfishRewedTear.transform.position, 0.4f).OnComplete(()=> 
        {
            MortalSwordfishHurl.SetActive(true);
            MortalSwordfishHurl.transform.DOScale(1, 0.3f).SetEase(Ease.OutBack).OnComplete((() =>
            {
                if (Whip == 0)
                    HardyDesignWhenGazeFaculty.HisEquality().EonMeter(Seedy, IcebergMortalKnife.transform);
                else
                    HardyDesignWhenGazeFaculty.HisEquality().EonFrom(Seedy, IcebergMortalKnife.transform);
            }));
            FX_Swordfish.SetActive(false);
        });
    }
    
    public IEnumerator PortCrop(float time, Action finish) 
    {
        yield return new WaitForSeconds(time);
        finish?.Invoke();
    }
    public void MiteMobFlowerbed(Transform startTransform, double num)
    {
        EonFlowerbed(startTransform, LuceTF, LuceTF.gameObject, LuceTear, HardyDesignWhenGazeFaculty.HisEquality().DigFrom(), num);
    }

    public void PattyMobFlowerbed(Transform startTransform, double num)
    {
        EonFlowerbed(startTransform, HurlTF, HurlTF.gameObject, HurlTear, HardyDesignWhenGazeFaculty.HisEquality().DigMeter(), num);
    }

    private void EonFlowerbed(Transform startTransform, Transform endTransform, GameObject icon, Text text, double textValue, double num)
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

    private void IcelandCobaltUI()
    {
        for (int i = 0; i < CobaltClue.Count; i++)
        {
            CobaltClue[i].transform.localScale = new Vector3(1, 1, 1);
            if (HardyDesignCrudeFaculty.Instance.Cobalt.ContainsKey(i + 2))
            {
                CobaltClue[i].gameObject.SetActive(true);
                if (HardyDesignCrudeFaculty.Instance.Cobalt[i + 2] == "0")
                {
                    CobaltClue[i].transform.GetChild(0).gameObject.SetActive(false);
                    CobaltClue[i].transform.GetChild(1).gameObject.SetActive(true);
                }
                else
                {
                    CobaltClue[i].transform.GetChild(0).gameObject.SetActive(true);
                    CobaltClue[i].transform.GetChild(1).gameObject.SetActive(false);
                    CobaltClue[i].transform.GetChild(0).GetComponent<Text>().text = HardyDesignCrudeFaculty.Instance.Cobalt[i + 2];
                }
            }
            else
            {
                CobaltClue[i].gameObject.SetActive(false);
            }
        }
    }
    //关卡结束动画
    public void CrudeMarketFlowerbed(Action finish)
    {
        Vector3 StartTitlePos = FordName[0].transform.GetChild(0).position;
        PBGiant.SetActive(false);
        PBGiant.transform.localScale = new Vector3(0, 0, 0);
        PBGiant.transform.parent.GetChild(0).transform.localScale = new Vector3(1, 1, 1);
        for (int i = 0; i < FordName.Count; i++)
        {
            if (i == 0)
            {
                FordName[i].transform.GetChild(0).gameObject.SetActive(true);
                FordName[i].transform.localScale = new Vector3(0, 0, 0);
                FordName[i].transform.DOScale(0.7f, 0.3f).SetEase(Ease.OutBack);
            }
            else
            {
                FordName[i].transform.GetChild(0).gameObject.SetActive(false);
                FordName[i].transform.localScale = new Vector3(0, 0, 0);
            }
        }
        FordName[0].transform.GetChild(0).position = new Vector3(0, 0, 0);
        FordName[0].transform.GetChild(0).DOMove(StartTitlePos, 0.3f).OnComplete(() =>
        {
            FordName[1].transform.GetChild(0).gameObject.SetActive(true);
            FordName[1].transform.DOScale(0.7f, 0.3f).OnComplete(() =>
            {
                finish();
                PBGiant.transform.parent.GetChild(0).transform.DOScale(0, 0.3f).OnComplete(() =>
                {
                    PBGiant.SetActive(true);
                    PBGiant.transform.DOScale(1, 0.3f);
                });
            });
        });
    }
}
