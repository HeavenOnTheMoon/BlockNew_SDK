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

public class WhenQuiltSpear : AlgaUISleek
{
    public static WhenQuiltSpear Instance;
[UnityEngine.Serialization.FormerlySerializedAs("BlockGroupObjs")]    
    public GameObject HardyGiantClue;
[UnityEngine.Serialization.FormerlySerializedAs("ComboItem")]
    public GameObject BlockBath;
[UnityEngine.Serialization.FormerlySerializedAs("SourceItem")]    public GameObject BackupBath;
[UnityEngine.Serialization.FormerlySerializedAs("CheckBoardGroup")]
    public GameObject RouteNovelGiant;
[UnityEngine.Serialization.FormerlySerializedAs("GameBoard")]    public GameObject WhenNovel;
[UnityEngine.Serialization.FormerlySerializedAs("BlockSP")]    public List<GameObject> HardySP;
[UnityEngine.Serialization.FormerlySerializedAs("MoreClear")]    public GameObject ToadVirgo;
[UnityEngine.Serialization.FormerlySerializedAs("ComboSpine")]    public GameObject BlockBegin;
[UnityEngine.Serialization.FormerlySerializedAs("TargetBarObj")]    public GameObject CobaltMudPut;
[UnityEngine.Serialization.FormerlySerializedAs("SourceBarObj")]    public GameObject BackupMudPut;
[UnityEngine.Serialization.FormerlySerializedAs("CueSourceText")]
    public TextMeshProUGUI GelBackupTear;
[UnityEngine.Serialization.FormerlySerializedAs("MaxSourceText")]    public Text UteBackupTear;
[UnityEngine.Serialization.FormerlySerializedAs("GuideSpine")]    public SkeletonGraphic QuiltBegin;
[UnityEngine.Serialization.FormerlySerializedAs("MaskObj")]    public GameObject FivePut;
[UnityEngine.Serialization.FormerlySerializedAs("ChangeSceneMask")]    public GameObject FactorPupilFive;
[UnityEngine.Serialization.FormerlySerializedAs("ClearSpineRect")]
    public List<SkeletonGraphic> VirgoBeginMain;
[UnityEngine.Serialization.FormerlySerializedAs("ClearSpineSquare")]    public List<SkeletonGraphic> VirgoBeginGender;
[UnityEngine.Serialization.FormerlySerializedAs("CashTF")]
    public Transform HurlTF;
[UnityEngine.Serialization.FormerlySerializedAs("CashText")]    public TextMeshProUGUI HurlTear;


    void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        if ((float)Screen.height / Screen.width < 1.8f)
        {
            HardyGiantClue.transform.localScale = new Vector3(0.86f, 0.86f, 0.86f);
            HardyGiantClue.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -1090);
            RouteNovelGiant.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
            RouteNovelGiant.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -658);
            WhenNovel.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
            WhenNovel.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -660);
            QuiltBegin.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
            QuiltBegin.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -900);
        }
        PreciseCinemaBliss.HisEquality().Elongate(CChoppy.We_IcelandBackup, data =>
        { 
            IcelandBackupUI();
        });
        PreciseCinemaBliss.HisEquality().Elongate(CChoppy.We_FactorQuiltWhenStay, data =>
        {
            StartCoroutine(Icon(1.5f, () =>
            {
                FactorQuiltWhenStay();
            }));
        });
        PreciseCinemaBliss.HisEquality().Elongate(CChoppy.We_No_PromptlyFishery, (messageData) =>
        {
            PattyMobFlowerbed(messageData.StyleTransform, messageData.StyleEthnic);
        });
    }

    float Heal= 0;
[UnityEngine.Serialization.FormerlySerializedAs("isStart")]    public bool SoSewer= false;
    // Update is called once per frame
    void Update()
    {
        if(SoSewer)
            Heal += Time.deltaTime;
        if (Heal > 1.0f && !QuiltBegin.gameObject.activeSelf)
        {
            Heal = 0;
            SkeletonGraphic skeleton = QuiltBegin.gameObject.GetComponent<SkeletonGraphic>();
            skeleton.AnimationState.SetEmptyAnimation(0, 0);
            skeleton.AnimationState.AddAnimation(0, (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) + 1).ToString(), true, 0);
            skeleton.Update(0); 
            QuiltBegin.gameObject.SetActive(true); 
        }
    }
    
    public override void Display()
    {
        base.Display();
        MindGazeFaculty.SetString(CChoppy.Of_PryWhenBoat, "Guide");
        
        StartCoroutine(Icon(1f,()=>
        {
            RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_startgame);
        }));
        HarmLayerCloset.HisEquality().DramLayer("1007", (HardyDesignCrudeFaculty.Instance.HisPryCrude() + 1).ToString());
        CobaltMudPut.gameObject.SetActive(false);
        BackupMudPut.gameObject.SetActive(true);
        HardyDesignCrudeFaculty.Instance.HisPryCrudeComa();
        
        HardyDesignBackupFaculty.Instance.VirgoMereBackup();
        //刷新棋盘
        HardyDesignRouteNovelFaculty.Instance.IcelandRouteNovel(RouteNovelGiant);
        MindGazeFaculty.SetInt(CChoppy.Of_FleetCompanyScat, 0);
        HardyDesignBackupFaculty.Instance.VirgoBlock();


        IcelandBackupUI();
        
        FivePut.gameObject.SetActive(false);
        
        StartCoroutine(Icon(0.5f, () =>
        {
            HardyDesignHardyFaculty.Instance.CruelHardy();
            SoFordHawk(true);
        }));

        if (BureauVolt.MyRaise())
        {
            BackupMudPut.SetActive(true);
            HurlTear.transform.parent.gameObject.SetActive(false);
        }
        else
        {
            BackupMudPut.SetActive(false);
            HurlTear.transform.parent.gameObject.SetActive(true);
            HurlTear.text = SaddenVolt.EthnicUpStr(HardyDesignWhenGazeFaculty.HisEquality().DigMeter());
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

    public IEnumerator Icon(float time, System.Action finish) 
    {
        yield return new WaitForSeconds(time);
        finish();
    }


    public void BlockFordSun(int A,int Pos, bool isShowConbo) 
    {
        GameObject Comboitem = Instantiate(BlockBath, transform);
        Vector2 pos = new Vector2();
        switch (Pos)
        {
            case 1: Comboitem.GetComponent<RectTransform>().anchoredPosition = new Vector2(-160,-150);
                pos = new Vector2(-160,-220);
                break;
            case 2: Comboitem.GetComponent<RectTransform>().anchoredPosition = new Vector2(-160, 85); 
                pos = new Vector2(-160,5);
                break;
            case 3: Comboitem.GetComponent<RectTransform>().anchoredPosition = new Vector2(-160, 300); 
                pos = new Vector2(-160,230);
                break;
            case 4: Comboitem.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -150);
                pos = new Vector2(0,-220);
                break;
            case 5: Comboitem.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 85); 
                pos = new Vector2(0,5);
                break;
            case 6: Comboitem.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 300);
                pos = new Vector2(0,230);
                break;
            case 7: Comboitem.GetComponent<RectTransform>().anchoredPosition = new Vector2(160, -150); 
                pos = new Vector2(160,-220);
                break;
            case 8: Comboitem.GetComponent<RectTransform>().anchoredPosition = new Vector2(160, 85); 
                pos = new Vector2(160,5);
                break;
            case 9: Comboitem.GetComponent<RectTransform>().anchoredPosition = new Vector2(160, 300); 
                pos = new Vector2(160,230);
                break;
        }
        if (isShowConbo)
        {
            Comboitem.GetComponent<HardyDesignBlockLizard>().Bank(A);
            //Comboitem.transform.position = ComboTF;
            Comboitem.transform.localScale = new Vector3(0, 0, 0);
            Comboitem.GetComponent<CanvasGroup>().alpha = 1;
            Comboitem.SetActive(true);
            Comboitem.transform.DOScale(0.7f, 0.3f).SetEase(Ease.OutBack).OnComplete(()=> 
            {
                Comboitem.GetComponent<CanvasGroup>().DOFade(0, 0.5f).SetDelay(0.3f).OnComplete(() =>
                {
                    Destroy(Comboitem);
                });
            });
        }
        FordBackupBath(pos, null, false);
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
            _sourceItem.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = HardyDesignBackupFaculty.Instance.MereBackup.ToString();
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

    private void FactorMyHomelessQuilt()
    {
        
    }

    private void FactorQuiltWhenStay()
    {

        /*MindGazeFaculty.SetInt(CChoppy.sv_GuideGameRule, 99);
        ChangeSceneMask = UIFaculty.GetInstance().MainCanvas.transform.Find("Top/FactorPupil").gameObject;
        MindGazeFaculty.SetString(CChoppy.sv_CurGameMode, WitComaEka.instance.GameData.ShowAdventure ? "challenge" : "Classic");
        ChangeSceneMask.SetActive(true);
        ChangeSceneMask.GetComponent<FactorPupil>().ChangeSceneAni(() =>
        {
            HarmLayerCloset.GetInstance().SendEvent("1024");
            UIFaculty.GetInstance().ShowUIForms("WhenSpear");
        }, () =>
        {
            CloseUIForm(GetType().Name);
        });
        //RefreshUI();*/

        switch (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay))
        {
            case 0:
                if (HardyDesignRouteNovelFaculty.Instance.VirgoHardyGiantExtol == 2)
                {
                    MindGazeFaculty.SetInt(CChoppy.Of_QuiltWhenStay, 99);
                    IcelandUI();
                }
                else
                    IcelandUI();
                break;
            case 1:
                if (HardyDesignRouteNovelFaculty.Instance.VirgoHardyGiantExtol == 1)
                {
                    MindGazeFaculty.SetInt(CChoppy.Of_QuiltWhenStay, 99);
                    IcelandUI();
                }
                else
                    IcelandUI();
                break;
            case 2:
                if (HardyDesignRouteNovelFaculty.Instance.VirgoHardyGiantExtol == 4)
                {
                    MindGazeFaculty.SetInt(CChoppy.Of_QuiltWhenStay, 99);
                    HarmLayerCloset.HisEquality().DramLayer("1024");
                    UIFaculty.HisEquality().FordUISleek(BureauVolt.WhenKnot());
                    SpoonUITrap(GetType().Name);
                    FactorPupilFive = UIFaculty.HisEquality().MainObtain.transform.Find("Top/ChangeScene").gameObject;
                    MindGazeFaculty.SetString(CChoppy.Of_PryWhenBoat,  "challenge" );
                   /* ChangeSceneMask.SetActive(true);
                    ChangeSceneMask.GetComponent<FactorPupil>().ChangeSceneAni(() =>
                    {
                        HarmLayerCloset.GetInstance().SendEvent("1024");
                        UIFaculty.GetInstance().ShowUIForms("WhenSpear");
                    }, () =>
                    {
                        CloseUIForm(GetType().Name);
                    });*/
                    //RefreshUI();
                }
                else
                    IcelandUI();
                break;
        }
    }

    private void IcelandUI()
    {
        HardyDesignHardyFaculty.Instance.VirgoHitHardy();
        HardyDesignCrudeFaculty.Instance.HisPryCrudeComa();
        HardyDesignBackupFaculty.Instance.VirgoMereBackup();
        HardyDesignRouteNovelFaculty.Instance.IcelandRouteNovel(RouteNovelGiant);
        MindGazeFaculty.SetInt(CChoppy.Of_FleetCompanyScat, 0);
        HardyDesignBackupFaculty.Instance.VirgoBlock();

        IcelandBackupUI();
        StartCoroutine(Icon(0.5f, () =>
        {
            HardyDesignHardyFaculty.Instance.CruelHardy();
            SoFordHawk(true);
        }));
    }

    public void SoFordHawk(bool isShow)
    {
        if (isShow)
            SoSewer = true;
        else
        {
            Heal = 0;
            SoSewer = false;
            QuiltBegin.gameObject.SetActive(false);
        }
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

    public void PattyMobFlowerbed(Transform startTransform, double num)
    {
        EonFlowerbed(startTransform, HurlTF, HurlTF.gameObject, HurlTear, HardyDesignWhenGazeFaculty.HisEquality().DigMeter(), num);
    }

    private void EonFlowerbed(Transform startTransform, Transform endTransform, GameObject icon, TextMeshProUGUI text, double textValue, double num)
    {
        if (startTransform != null)
        {
            var count = HardyDesignDeftFaculty.instance.HisMobExtol(double.Parse(text.text), textValue, endTransform == HurlTF.transform);

            FlowerbedGeneralist.HardyRayFromAvid(icon, 1, startTransform.position, endTransform.position, () =>
            {
                FlowerbedGeneralist.FactorSadden(double.Parse(text.text), textValue, 0.1f, text, () =>
                {
                    text.text = SaddenVolt.EthnicUpStr(textValue);
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

}

