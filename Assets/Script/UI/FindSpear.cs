using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindSpear : AlgaUISleek
{
    public static FindSpear instance;
[UnityEngine.Serialization.FormerlySerializedAs("ChallengeBtn")]    public Button SwordfishVia;
[UnityEngine.Serialization.FormerlySerializedAs("ClassicBtn")]    public Button RedwingVia;
[UnityEngine.Serialization.FormerlySerializedAs("ClassicBtnText")]    public Text RedwingViaTear;
[UnityEngine.Serialization.FormerlySerializedAs("NoClassicBtn")]    public Button NoRedwingVia;
[UnityEngine.Serialization.FormerlySerializedAs("SettingBtn")]    public Button ForeverVia;
[UnityEngine.Serialization.FormerlySerializedAs("ChangeSceneMask")]    public GameObject FactorPupilFive;

    void Awake()
    {
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        bool showAdvernture = false;//WitComaEka.instance.GameData.ShowAdventure;
        SwordfishVia.gameObject.SetActive(showAdvernture);
        RedwingViaTear.text = showAdvernture ? "Classic" : "PLAY";
        if (!showAdvernture)
        {
            RedwingVia.GetComponent<RectTransform>().localPosition = SwordfishVia.GetComponent<RectTransform>().localPosition - new Vector3(0, 100, 0);
        }

        ForeverVia.onClick.AddListener(() =>
        {
            RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_UIButton);
            MindGazeFaculty.SetString(CChoppy.Of_ForeverFind,"FindSpear");
            UIFaculty.HisEquality().FordUISleek("ForeverSpear");
        });
		SwordfishVia.onClick.AddListener(SwordfishViaFlute);
		FactorPupilFive = UIFaculty.HisEquality().MainObtain.transform.Find("Top/ChangeScene").gameObject;
        RedwingVia.onClick.AddListener(() =>
        {
            RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_UIButton);
            RedwingVia.enabled = false;
            MindGazeFaculty.SetString(CChoppy.Of_PryWhenBoat,"Classic");
            PreciseCinemaBliss.HisEquality().Dram(CChoppy.We_SpoonAndBowQuilt);
            //ChangeSceneMask.SetActive(true);
            RedwingVia.enabled = true;
           UIFaculty.HisEquality().FordUISleek(BureauVolt.WhenKnot());
            SpoonUITrap(GetType().Name);
            /*ChangeSceneMask.GetComponent<FactorPupil>().ChangeSceneAni(() => 
            {
                ClassicBtn.enabled = true;
                UIFaculty.GetInstance().ShowUIForms("WhenSpear");
                
                    
            }, () => 
            {
                CloseUIForm(GetType().Name);
            });*/
        });
        
        NoRedwingVia.onClick.AddListener((() =>
        {
            WeaveFaculty.HisEquality().FordWeave("Unlock at Level " + (WitComaEka.instance.WhenGaze.Unlock_classic + 1));
        }));
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SwordfishViaFlute()
    {
        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_UIButton);
        SwordfishVia.enabled = false;
        MindGazeFaculty.SetString(CChoppy.Of_PryWhenBoat,"challenge");
        //ChangeSceneMask.SetActive(true);
        UIFaculty.HisEquality().FordUISleek("WhenSpear"); 
        SpoonUITrap(GetType().Name);
        /*ChangeSceneMask.GetComponent<FactorPupil>().ChangeSceneAni(() => 
        {
            UIFaculty.GetInstance().ShowUIForms("WhenSpear");
        }, () => 
        {
            CloseUIForm(GetType().Name);
        });*/
    }
    
    public override void Display()
    {
        base.Display();

        SwordfishVia.enabled = true;
        RedwingVia.enabled = true;
        if (BureauVolt.MyRaise())
        {
            //UIFaculty.GetInstance().ShowUIForms("QuiltSpear");
        }
        /*if (HardyDesignCrudeFaculty.Instance.GetCurLevel() >= WitComaEka.instance.GameData.Unlock_classic)
        {
            NoClassicBtn.gameObject.SetActive(false);
        }*/
    }
    public override void Hidding()
    {
        base.Hidding();
        
    }
}
