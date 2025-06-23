using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using DG.Tweening;
using Spine;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class WhenSpear : AlgaUISleek
{
    public static WhenSpear Instance;
[UnityEngine.Serialization.FormerlySerializedAs("GoldButton")]
    public Button FromProton;
[UnityEngine.Serialization.FormerlySerializedAs("TokenBtn")]    public Button MeterVia;
[UnityEngine.Serialization.FormerlySerializedAs("SettingBtn")]    
    public Button ForeverVia;
[UnityEngine.Serialization.FormerlySerializedAs("BrainBtn")]    public Button FattyVia;
[UnityEngine.Serialization.FormerlySerializedAs("TargetList")]    
    public List<GameObject> CobaltName;
[UnityEngine.Serialization.FormerlySerializedAs("CoinText")]    public TextMeshProUGUI LuceTear;
[UnityEngine.Serialization.FormerlySerializedAs("CashText")]    public TextMeshProUGUI HurlTear;
[UnityEngine.Serialization.FormerlySerializedAs("CashTF")]    public Transform HurlTF;
[UnityEngine.Serialization.FormerlySerializedAs("CoinTF")]    public Transform LuceTF;
[UnityEngine.Serialization.FormerlySerializedAs("LevelOverSpine")]
    public GameObject CrudeRoteBegin;
[UnityEngine.Serialization.FormerlySerializedAs("Dolphin")]
    public GameObject Dolphin;
[UnityEngine.Serialization.FormerlySerializedAs("LevelStart")]
    public GameObject CrudeSewer;
[UnityEngine.Serialization.FormerlySerializedAs("BlockGroupObjs")]
    public GameObject HardyGiantClue;
[UnityEngine.Serialization.FormerlySerializedAs("ComboItem")]
    public GameObject BlockBath;
[UnityEngine.Serialization.FormerlySerializedAs("SourceItem")]    public GameObject BackupBath;
[UnityEngine.Serialization.FormerlySerializedAs("CheckBoardGroup")]
    public GameObject RouteNovelGiant;
[UnityEngine.Serialization.FormerlySerializedAs("GameBoard")]    public GameObject WhenNovel;
[UnityEngine.Serialization.FormerlySerializedAs("MoreClear")]
    public GameObject ToadVirgo;
[UnityEngine.Serialization.FormerlySerializedAs("ComboSpine")]    public GameObject BlockBegin;
[UnityEngine.Serialization.FormerlySerializedAs("WheelRightImage")]
    public Image BowelCliffKnife;
[UnityEngine.Serialization.FormerlySerializedAs("WheelReward1")]    public BowelMortalBath BowelMortal1;
[UnityEngine.Serialization.FormerlySerializedAs("WheelReward2")]    public BowelMortalBath BowelMortal2;
[UnityEngine.Serialization.FormerlySerializedAs("BrainImage")]
    public Image FattyKnife;
[UnityEngine.Serialization.FormerlySerializedAs("BrainProgressText")]    public Text FattyRegionalTear;
[UnityEngine.Serialization.FormerlySerializedAs("BlockSP")]
    public List<GameObject> HardySP;
[UnityEngine.Serialization.FormerlySerializedAs("TargetBarObj")]
    public GameObject CobaltMudPut;
[UnityEngine.Serialization.FormerlySerializedAs("SourceBarObj")]    public GameObject BackupMudPut;
[UnityEngine.Serialization.FormerlySerializedAs("CueSourceText")]
    public Text GelBackupTear;
[UnityEngine.Serialization.FormerlySerializedAs("MaxSourceText")]    public Text UteBackupTear;
[UnityEngine.Serialization.FormerlySerializedAs("MaskObj")]    
    public GameObject FivePut;
[UnityEngine.Serialization.FormerlySerializedAs("Ancu")]
    public AnimationCurve Bake;
[UnityEngine.Serialization.FormerlySerializedAs("BottomBar")]
    public GameObject DomainMud;
[UnityEngine.Serialization.FormerlySerializedAs("ClearSpineRect")]
    public List<SkeletonGraphic> VirgoBeginMain;
[UnityEngine.Serialization.FormerlySerializedAs("ClearSpineSquare")]    public List<SkeletonGraphic> VirgoBeginGender;
[UnityEngine.Serialization.FormerlySerializedAs("BonusSpine")]
    public SkeletonAnimation TemptBegin;


    void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        if ((float)Screen.height / Screen.width < 1.8f)
        {
            if (!BureauVolt.MyBodyAB())
            {
                //BlockGroupObjs.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -1090);
                //CheckBoardGroup.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -658);
                //GameBoard.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -660);
                HardyGiantClue.transform.localScale = new Vector3(0.86f, 0.86f, 0.86f);
            }
           
            RouteNovelGiant.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
            WhenNovel.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
            
        }
        ForeverVia.onClick.AddListener(() =>
        {
            //UIFaculty.GetInstance().ShowUIForms("IncorrectlySpear");
            MindGazeFaculty.SetString(CChoppy.Of_ForeverFind, BureauVolt.WhenKnot());
            UIFaculty.HisEquality().FordUISleek("ForeverSpear");
        });
        FattyVia.onClick.AddListener((() =>
        {
            UIFaculty.HisEquality().FordUISleek("FattySpear");
        }));
       
        if (BureauVolt.MyRaise())
        {
            MeterVia.transform.parent.gameObject.SetActive(false);
        }
        

        FromProton.onClick.AddListener(() => {
            
        });
        
        MeterVia.onClick.AddListener(() =>
        {
            
        });
        
        PreciseCinemaBliss.HisEquality().Elongate(CChoppy.We_No_Overrun, (messageData) =>
        {
            MiteMobFlowerbed(messageData.StyleTransform, messageData.StyleEthnic);
        });
        PreciseCinemaBliss.HisEquality().Elongate(CChoppy.We_No_Promptly, (messageData) =>
        {
            PattyMobFlowerbed(messageData.StyleTransform, messageData.StyleEthnic);
        });
        PreciseCinemaBliss.HisEquality().Elongate(CChoppy.We_No_PromptlyFishery, (messageData) =>
        {
            PattyMobFlowerbedImpinge(messageData.StyleTransform, messageData.Style2Literally, messageData.StyleEthnic);
        });
        PreciseCinemaBliss.HisEquality().Elongate(CChoppy.We_IcelandCrudeCobalt, data =>
        {
            IcelandCobaltUI();
        });
        PreciseCinemaBliss.HisEquality().Elongate(CChoppy.We_IcelandBackup, data =>
        { 
            IcelandBackupUI();
        });
        
        PreciseCinemaBliss.HisEquality().Elongate(CChoppy.We_BowelUI, data =>
        {
            IcelandBowelUI(data.StyleWin, data.StyleEthnic);
        });
        
        PreciseCinemaBliss.HisEquality().Elongate(CChoppy.We_FattyUI, data =>
        {
            IcelandFattyUI();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public override void Display()
    {
        base.Display();
        
        MindGazeFaculty.SetBool(CChoppy.Of_RedwingTempt, false);
        WhenSpear.Instance.HardyGiantClue.GetComponent<CanvasGroup>().alpha =1 ;
        WhenSpear.Instance.DomainMud.GetComponent<CanvasGroup>().alpha = 1;
        Dolphin.gameObject.SetActive(false);

        StartCoroutine(Icon(1f,()=>
        {
            RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_startgame);
        }));
        
        if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenLop) == 0)
        {
            
        }
        if (MindGazeFaculty.GetString(CChoppy.Of_PryWhenBoat) == "challenge")
        {
            HarmLayerCloset.HisEquality().DramLayer("1007", (HardyDesignCrudeFaculty.Instance.HisPryCrude() + 1).ToString());
            CobaltMudPut.gameObject.SetActive(true);
            BackupMudPut.gameObject.SetActive(false);
            //初始化关卡目标和当前信息
            HardyDesignCrudeFaculty.Instance.HisPryCrudeComa();
            HardyDesignCrudeFaculty.Instance.BankCobalt();
            
        }
        else
        {
            HarmLayerCloset.HisEquality().DramLayer("1020");
            //积分制
            CobaltMudPut.gameObject.SetActive(false);
            BackupMudPut.gameObject.SetActive(true);
            //初始化关卡目标和当前信息
            HardyDesignCrudeFaculty.Instance.HisPryCrudeComa();
        }
        HardyDesignBackupFaculty.Instance.VirgoMereBackup();
        //刷新棋盘
        HardyDesignRouteNovelFaculty.Instance.IcelandRouteNovel(RouteNovelGiant);
        MindGazeFaculty.SetInt(CChoppy.Of_FleetCompanyScat, 0);
        HardyDesignBackupFaculty.Instance.VirgoBlock();
        
        LuceTear.text = (HardyDesignWhenGazeFaculty.HisEquality().DigFrom().ToString("f0"));
        HurlTear.text = SaddenVolt.EthnicUpStr(HardyDesignWhenGazeFaculty.HisEquality().DigMeter());

        IcelandCobaltUI();
        IcelandBackupUI();
        IcelandBowelUI();
        IcelandFattyUI();
        
        FivePut.gameObject.SetActive(false);
        if (MindGazeFaculty.GetString(CChoppy.Of_PryWhenBoat) == "challenge")
        {
            CrudeSewer.SetActive(true);
            CrudeSewer.GetComponent<CrudeCobalt>().FordFlowerbed(CobaltName, () => 
            {
                RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Targetfly);
                IcelandCobaltUI();
                HardyDesignHardyFaculty.Instance.CruelHardy();
            
                if (HardyDesignCrudeFaculty.Instance.HisPryCrude() + 1 == WitComaEka.instance.WhenGaze.RateUs && !BureauVolt.MyRaise() && 
                    MindGazeFaculty.GetInt(CChoppy.Of_Worsen) == 0)
                {
                    UIFaculty.HisEquality().FordUISleek("BuzzIDSpear");
                }
            });
        }
        else
        {
            CrudeSewer.SetActive(false);
            StartCoroutine(Icon(1.5f, () =>
            {
                HardyDesignHardyFaculty.Instance.CruelHardy();
            }));
        }


        

    }
    
    public void MiteMobFlowerbed(Transform startTransform, double num)
    {
        EonFlowerbed(startTransform, LuceTF, LuceTF.gameObject, LuceTear, HardyDesignWhenGazeFaculty.HisEquality().DigFrom(), num);
    }

    public void PattyMobFlowerbed(Transform startTransform, double num)
    {
        EonFlowerbed(startTransform, HurlTF, HurlTF.gameObject, HurlTear, HardyDesignWhenGazeFaculty.HisEquality().DigMeter(), num);
    }
    public void PattyMobFlowerbedImpinge(Transform startTransform, Transform bottomTransform, double num)
    {
        EonFlowerbedImpinge(startTransform, HurlTF, bottomTransform, HurlTF.gameObject, HurlTear, HardyDesignWhenGazeFaculty.HisEquality().DigMeter(), num);
    }

    private void EonFlowerbedImpinge(Transform startTransform, Transform endTransform, Transform bottomTransform, GameObject icon, TextMeshProUGUI text, double textValue, double num)
    {
        if (startTransform != null)
        {
            var count = HardyDesignDeftFaculty.instance.HisMobExtol(double.Parse(text.text), textValue, endTransform == HurlTF.transform);
            FlowerbedGeneralist.HardyRayFromScan(icon, count, startTransform.position, endTransform.position, bottomTransform.position, () =>
            {
                FlowerbedGeneralist.FactorSadden(double.Parse(text.text), textValue, 0.1f, text, () =>
                {
                    text.text = SaddenVolt.EthnicUpStr(textValue);
                    if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenLop) == 0 && !BureauVolt.MyRaise())
                    {
                        UIFaculty.HisEquality().FordUISleek("QuiltSpear");
                        
                    }
                });
            }, Bake, () => { });
        }
        else
        {
            FlowerbedGeneralist.FactorSadden(double.Parse(text.text), textValue, 0.1f, text, () => {
                text.text = SaddenVolt.EthnicUpStr(textValue);
            });
        }
    }

    private void EonFlowerbed(Transform startTransform, Transform endTransform, GameObject icon, TextMeshProUGUI text, double textValue, double num)
    {
        if (startTransform != null)
        {
            var count = HardyDesignDeftFaculty.instance.HisMobExtol(double.Parse(text.text), textValue, endTransform == HurlTF.transform);

            FlowerbedGeneralist.HardyRayFromAvid(icon, count, startTransform.position, endTransform.position, () =>
            {
                FlowerbedGeneralist.FactorSadden(double.Parse(text.text), textValue, 0.1f, text, () =>
                {
                    text.text = SaddenVolt.EthnicUpStr(textValue);
                    if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenLop) == 0 && !BureauVolt.MyRaise())
                    {
                        UIFaculty.HisEquality().FordUISleek("QuiltSpear");
                        
                    }
                });
            }, () => { });
        }
        else
        {
            FlowerbedGeneralist.FactorSadden(double.Parse(text.text), textValue, 0.1f, text, () => {
                text.text = SaddenVolt.EthnicUpStr(textValue);
            });
        }
    }

    private void IcelandCobaltUI()
    {

        for (int i = 0; i < CobaltName.Count; i++)
        {
            CobaltName[i].transform.localScale = new Vector3(1, 1, 1);
            if (HardyDesignCrudeFaculty.Instance.Cobalt.ContainsKey(i + 2))
            {
                CobaltName[i].gameObject.SetActive(true);
                if (HardyDesignCrudeFaculty.Instance.Cobalt[i + 2] == "0" /*&& !TargetList[i].transform.GetChild(1).gameObject.activeSelf*/)
                {
                    CobaltName[i].transform.GetChild(0).gameObject.SetActive(false);
                    CobaltName[i].transform.GetChild(1).gameObject.SetActive(true);
                }
                else
                {
                    CobaltName[i].transform.GetChild(0).gameObject.SetActive(true);
                    CobaltName[i].transform.GetChild(1).gameObject.SetActive(false);
                    if (CobaltName[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text != HardyDesignCrudeFaculty.Instance.Cobalt[i + 2])
                    {
                        CobaltName[i].transform.DOScale(1.2f, 0.06f).SetEase(Ease.OutSine);
                        CobaltName[i].transform.DOScale(1f, 0.2f).SetDelay(0.1f).SetEase(Ease.OutSine);
                    }
                    CobaltName[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = HardyDesignCrudeFaculty.Instance.Cobalt[i + 2];
                }
            }
            else
            {
                CobaltName[i].gameObject.SetActive(false);
            }
        }
    }

    private void IcelandBowelUI(int oldWheelReward = -1, double rewardValue = 0)
    {
        if (BureauVolt.MyRaise())
        {
            BowelCliffKnife.transform.parent.gameObject.SetActive(false);
            FallacyRegionalMud(BowelCliffKnife, 0.5f, 0.5f);
        }
        else
        {
            int totalCount = WitComaEka.instance.WhenGaze.WheelReward.ShowCount;
            int currentCount = HardyDesignDeftFaculty.instance.HisBowelLop();
            float Style= (float)currentCount / (totalCount * 3);
            //if (value < 0.5f)
            //{
            //    value = value / 1.1785f;
            //}
            FallacyRegionalMud(BowelCliffKnife, 0.5f, Style);

            // 处理奖励图标
            int newWheelReward = MindGazeFaculty.GetInt(CChoppy.Of_BowelMortal);
            bool hasReward = newWheelReward > oldWheelReward;   // 是否需要播放奖励动画
            string GirderWell= WitComaEka.instance.WhenGaze.WheelReward.Reward[0].type;
            if (!hasReward || oldWheelReward == -1)
            {
                // 不需要发奖励，直接显示奖品图标
                BowelMortal1.TugSpell(newWheelReward >= 1, GirderWell, rewardValue);
                BowelMortal2.TugSpell(newWheelReward >= 2, GirderWell, rewardValue);
            }
            else
            {
                // 需要发奖励，打开奖励弹窗
                BowelMortalBath Utah= newWheelReward == 1 ? BowelMortal1 : BowelMortal2;
                Utah.TugSpell(true, GirderWell, rewardValue);
                MindGazeFaculty.SetString(CChoppy.Of_MortalWell, WitComaEka.instance.WhenGaze.WheelReward.Reward[0].type);
                MindGazeFaculty.SetString(CChoppy.Of_MortalSeedy, rewardValue.ToString());
                StartCoroutine(Icon(1.2f, () =>
                {
                    UIFaculty.HisEquality().FordUISleek("MortalSpear");
                    //MaskObj.SetActive(false);
                }));
                
            }
        }
        
    }

    private void IcelandFattyUI()
    {
        var Hear= HardyDesignBackupFaculty.Instance.HisMereAttachComa(19);
        float Pul= (float)Hear.Backup / WitComaEka.instance.WhenGaze.SourceRewards.dailyMaxSource;
        //WheelLeftImage
        FallacyRegionalMud(FattyKnife, 0.5f, Pul);
        FattyRegionalTear.text = (int)(Pul * 100) + "%";
    }

    private void FallacyRegionalMud(Image image, float time, float endValue)
    {
        if (endValue == 0)
        {
            image.fillAmount = 0;
        }
        else
        {
            image.DOFillAmount(endValue, time).SetEase(Ease.Linear);
        }
    }
    
    public void IcelandBackupUI()
    {
        var startNum = MindGazeFaculty.GetInt(CChoppy.Of_PryBackupExtol);
        if (MindGazeFaculty.GetInt(CChoppy.Of_PryBackupExtol) == MindGazeFaculty.GetInt(CChoppy.Of_UteBackupExtol))
        {
            DOTween.To(() => float.Parse(GelBackupTear.text), x => GelBackupTear.text = x.ToString("f0"), startNum, 0.5f).OnComplete(() => 
            {
                
            });
            DOTween.To(() => float.Parse(UteBackupTear.text), x => UteBackupTear.text = x.ToString("f0"), startNum, 0.5f).OnComplete(() => 
            {
                
            });
            //CueSourceText.text = MindGazeFaculty.GetFloat(CChoppy.sv_CurSourceCount).ToString("f0");
            //MaxSourceText.text = CueSourceText.text;
        }
        else
        {
            DOTween.To(() => float.Parse(GelBackupTear.text), x => GelBackupTear.text = x.ToString("f0"), startNum, 0.5f).OnComplete(() => 
            {
                
            });
            //CueSourceText.text = MindGazeFaculty.GetFloat(CChoppy.sv_CurSourceCount).ToString("f0");
            UteBackupTear.text = MindGazeFaculty.GetInt(CChoppy.Of_UteBackupExtol).ToString("f0");
        }
    }

    /// <summary>
    /// 胜利Spine动画
    /// </summary>
    /// <param name="LifeOrDie"></param>
    /// <param name="finish"></param>
    public void CrudeIceberg(bool LifeOrDie , System.Action finish) 
    {
        CrudeRoteBegin.SetActive(true);
        if (LifeOrDie)
        {
            HarmLayerCloset.HisEquality().DramLayer("1008", (HardyDesignCrudeFaculty.Instance.HisPryCrude() + 1).ToString());
            RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Welldone);
            CrudeRoteBegin.GetComponent<SkeletonGraphic>().AnimationState.SetAnimation(0, "Victory", false);
        }
        else 
        {
            HarmLayerCloset.HisEquality().DramLayer("1009", (HardyDesignCrudeFaculty.Instance.HisPryCrude() + 1).ToString());
            RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Fail);
            CrudeRoteBegin.GetComponent<SkeletonGraphic>().AnimationState.SetAnimation(0, "Fail", false);
        }
        StartCoroutine(Icon(2.5f,()=>
        {
            CrudeRoteBegin.SetActive(false);
            finish();
        }));
    }

    public IEnumerator Icon(float time, System.Action finish) 
    {
        yield return new WaitForSeconds(time);
        finish();
    }


    public void BlockFordSun(int A, Vector3 Start, bool isShowConbo)
    {
        GameObject Comboitem = Instantiate(BlockBath, transform);
        Vector3 pos = new Vector3();
        if (Start.x > 0.7f)
        {
            Start = new Vector3(0.7f, Start.y, Start.z);
        }
        if (Start.x < -0.7f)
        {
            Start = new Vector3(-0.7f, Start.y, Start.z);
        }
        if (Start.y > 0.8f)
        {
            Start = new Vector3(Start.x, 0.8f, Start.z);
        }
        if (Start.y < -0.8f)
        {
            Start = new Vector3(Start.x, -0.8f, Start.z);
        }

        Comboitem.transform.position = Start;
        pos = new Vector3(Start.x, Start.y - 80, 0);

        if (isShowConbo)
        {
            Comboitem.GetComponent<HardyDesignBlockLizard>().Bank(A);
            //Comboitem.transform.position = ComboTF;
            Comboitem.transform.localScale = new Vector3(0, 0, 0);
            Comboitem.GetComponent<CanvasGroup>().alpha = 1;
            Comboitem.SetActive(true);
            Comboitem.transform.DOScale(1.2f, 0.3f).SetEase(Ease.OutBack).OnComplete(() =>
            {
                Comboitem.GetComponent<CanvasGroup>().DOFade(0, 0.5f).SetDelay(0.3f).OnComplete(() =>
                {
                    Destroy(Comboitem);
                });
            });
        }
        FordBackupBath(pos, null, false);
    }

    public void FordVirgoBegin(int type, BlockColor color, Vector3 position)
    {
        var spinePrefab = VirgoBeginMain[0];
        if (type == 1 || type == 2)
        {
            spinePrefab = VirgoBeginMain[(int)color];
        }
        else if (type == 3)
        {
            spinePrefab = VirgoBeginGender[(int)color];
        }
        var Venue= Instantiate(spinePrefab, spinePrefab.transform.parent);
        Venue.GetComponent<RectTransform>().position = position;
        Venue.GetComponent<RectTransform>().localRotation = type == 2 ? Quaternion.AngleAxis(90, Vector3.forward) : Quaternion.AngleAxis(0, Vector3.forward);
        Venue.gameObject.SetActive(true);
        Venue.AnimationState.Complete += (TrackEntry trackEntry) => { Destroy(Venue.gameObject); };
        Venue.AnimationState.SetAnimation(0, "animation", false);
    }

    public void FordBackupBath(Vector2 startPos, Transform startTranPos, bool isTran)
    {
        
        //if (sourceValue > 0)
        {
            GameObject _sourceItem = Instantiate(BackupBath, transform);
            if (isTran)
            {
                var position = startTranPos.position;
                _sourceItem.transform.position = position;
            }
            else
            {
                _sourceItem.GetComponent<RectTransform>().anchoredPosition = startPos;
            }
            _sourceItem.transform.GetChild(0).GetComponent<Text>().text = HardyDesignBackupFaculty.Instance.MereBackup.ToString();
            _sourceItem.transform.localScale = new Vector3(0, 0, 0);
            _sourceItem.GetComponent<CanvasGroup>().alpha = 1;
            _sourceItem.SetActive(true);
            _sourceItem.transform.DOScale(0.7f, 0.3f).SetEase(Ease.OutBack).OnComplete(()=> 
            {
                _sourceItem.GetComponent<CanvasGroup>().DOFade(0, 0.5f).SetDelay(0.3f).OnComplete(() =>
                {
                    Destroy(_sourceItem);
                });
            });
        }
    }
}

