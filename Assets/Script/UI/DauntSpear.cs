using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DauntSpear : AlgaUISleek
{
[UnityEngine.Serialization.FormerlySerializedAs("OnceChapterObjs")]    public List<GameObject> MereTrafficClue;
[UnityEngine.Serialization.FormerlySerializedAs("ClickBtn")]
    public Button FluteVia;
[UnityEngine.Serialization.FormerlySerializedAs("ChangeSchBtn")]    public Button FactorLopVia;
[UnityEngine.Serialization.FormerlySerializedAs("CurLevelText")]    public Text PryCrudeTear;
[UnityEngine.Serialization.FormerlySerializedAs("ChangeSceneMask")]    public GameObject FactorPupilFive;
[UnityEngine.Serialization.FormerlySerializedAs("Content")]    public GameObject Rawhide;
[UnityEngine.Serialization.FormerlySerializedAs("TrophyFX")]
    public GameObject RocketFX;
[UnityEngine.Serialization.FormerlySerializedAs("TrophyImage")]    public GameObject RocketKnife;
    // Start is called before the first frame update
    void Start()
    {
        FactorPupilFive = UIFaculty.HisEquality().MainObtain.transform.Find("Top/ChangeScene").gameObject;
        FluteVia.onClick.AddListener((() =>
        {
            FluteVia.enabled = false;
            FluteVia.enabled = true;
            UIFaculty.HisEquality().FordUISleek(BureauVolt.WhenKnot());
            SpoonUITrap(GetType().Name);
            /*ChangeSceneMask.SetActive(true);
            ChangeSceneMask.GetComponent<FactorPupil>().ChangeSceneAni(() => 
            {
                ClickBtn.enabled = true;
                UIFaculty.GetInstance().ShowUIForms("WhenSpear");
            }, () => 
            {
                CloseUIForm(GetType().Name);
                
            });*/
        }));
        FactorLopVia.onClick.AddListener((() =>
        {
            RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Chapterchange);
            MindGazeFaculty.SetInt(CChoppy.Of_MyHomelessTraffic, 0);
            FactorLopVia.gameObject.SetActive(false);
            FluteVia.gameObject.SetActive(true);
            RocketFX.SetActive(false);
            RocketKnife.SetActive(false);
            IcelandUI();
        }));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public override void Display()
    {
        base.Display();
        if (HardyDesignTrafficFaculty.instance.HisHomelessTrafficShare())
        {
            var chapter = HardyDesignTrafficFaculty.instance.HisSourceUpTraffic(HardyDesignCrudeFaculty.Instance.HisPryCrude());
            for (int i = 0; i < MereTrafficClue.Count; i++)
            {
                MereTrafficClue[i].gameObject.SetActive(chapter - 1 == i);
                if (chapter - 1 == i)
                {
                    FordSun(MereTrafficClue[i], () => 
                    {
                        FordRocket();
                        
                    });
                    for (int j = 0; j < MereTrafficClue[i].transform.childCount; j++)
                    {
                        MereTrafficClue[i].transform.GetChild(j).gameObject.SetActive(true);


                    }
                }
            }
            FluteVia.gameObject.SetActive(false);
            FactorLopVia.gameObject.SetActive(true);
            
        }
        else
        {
            IcelandUI();
            FluteVia.gameObject.SetActive(true);
            FactorLopVia.gameObject.SetActive(false);
            RocketFX.SetActive(false);
            RocketKnife.SetActive(false);
        }
    }
    public override void Hidding()
    {
        base.Hidding();
        
    }


    //显示物体
    List<GameObject> FordClue= new List<GameObject>();
    private void IcelandUI()
    {
        Rawhide.GetComponent<CanvasGroup>().DOFade(0, 1f).OnComplete(() => 
        {
            PryCrudeTear.text = "LEVEL " + (HardyDesignCrudeFaculty.Instance.HisPryCrude() + 1);
            var chapter = HardyDesignTrafficFaculty.instance.HisSourceUpTraffic(HardyDesignCrudeFaculty.Instance.HisPryCrude());
            FordClue.Clear();
            for (int i = 0; i < MereTrafficClue.Count; i++)
            {
                if (chapter == i)
                {
                    MereTrafficClue[i].gameObject.SetActive(true);
                    var intlist = MindGazeFaculty.GetIntArray("Chapter" + chapter);
                    
                    for (int j = 0; j < intlist.Length; j++)
                    {
                        if(HardyDesignTrafficFaculty.instance.HisMyHomeless(intlist[j]))
                        {
                            MereTrafficClue[i].transform.GetChild(j).gameObject.SetActive(true);
                            FordClue.Add(MereTrafficClue[i].transform.GetChild(j).gameObject);
                        }
                    }
                    FordSun(FordClue, () => { });
                }
                else
                {
                    MereTrafficClue[i].gameObject.SetActive(false);
                }
            }
            Rawhide.GetComponent<CanvasGroup>().DOFade(1, 1.5f);
            
        });
        
    }
    
    private void FordSun(List<GameObject> objs,System.Action finish)
    {
        float delayTime =1;
        for (int i = 0; i < objs.Count; i++)
        {
            int A = 0;
            A = i;
            objs[i].transform.localScale = new Vector3(0, 0, 0);
            objs[i].transform.DOScale(1, 0.1f).SetEase(Ease.OutBack).SetDelay(delayTime).OnComplete(()=> 
            {
                RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Chapterpop);
                if (A == objs.Count - 1) 
                {
                    finish();
                }
            });
            delayTime += 0.1f;
        }
    }

    private void FordSun(GameObject objs,System.Action finish)
    {
        float delayTime =1;
        for (int i = 0; i < objs.transform.childCount; i++)
        {
            int A = 0;
            A = i;
            GameObject Utah= objs.transform.GetChild(i).gameObject;
            Utah.transform.localScale = new Vector3(0, 0, 0);
            Utah.transform.DOScale(1, 0.1f).SetEase(Ease.OutBack).SetDelay(delayTime).OnComplete(()=> 
            {
                RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Chapterpop);
                if (A == objs.transform.childCount - 1) 
                {
                    finish();
                }
            });
            delayTime += 0.02f;
        }
    }


    public void FordRocket() 
    {
        RocketKnife.SetActive(true);
        RocketKnife.transform.localScale = new Vector3(0, 0, 0);
        RocketKnife.transform.DOScale(1, 0.5f).SetEase(Ease.OutBack);
        RocketFX.transform.position = RocketKnife.transform.position;
        RocketFX.SetActive(true);
        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Trophy);
    }
}
