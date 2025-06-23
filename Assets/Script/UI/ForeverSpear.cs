using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForeverSpear : AlgaUISleek
{
[UnityEngine.Serialization.FormerlySerializedAs("Sound_Button")]    public Button Biome_Proton;
[UnityEngine.Serialization.FormerlySerializedAs("Music_Button")]    public Button Raise_Proton;
[UnityEngine.Serialization.FormerlySerializedAs("VibrationBtn")]    public Button AmazementVia;
[UnityEngine.Serialization.FormerlySerializedAs("BugInfoButton")]    public Button BusComaProton;
[UnityEngine.Serialization.FormerlySerializedAs("SoundIcon")]    public Sprite BiomeLeak;
[UnityEngine.Serialization.FormerlySerializedAs("MusicIcon")]    public Sprite RaiseLeak;
[UnityEngine.Serialization.FormerlySerializedAs("VibrationIcon")]    public Sprite AmazementLeak;
[UnityEngine.Serialization.FormerlySerializedAs("HomeBtn")]    public Button FindVia;
[UnityEngine.Serialization.FormerlySerializedAs("BackBtn")]    public Button GoodVia;
[UnityEngine.Serialization.FormerlySerializedAs("SoundOpenSprite")]    public Sprite BiomeKilnSilent;
[UnityEngine.Serialization.FormerlySerializedAs("MusicOpenSprite")]    public Sprite RaiseKilnSilent;
[UnityEngine.Serialization.FormerlySerializedAs("VibrationOpenSprite")]    public Sprite AmazementKilnSilent;
[UnityEngine.Serialization.FormerlySerializedAs("ChangeSceneMask")]    public GameObject FactorPupilFive;

    private int ThumbComaFrown;
    public override void Display()
    {
        base.Display();
        ThumbComaFrown = 0;
        ByPeat.Equality.ItemMusicologistBy(10008, (success) =>
        {
            if (success)
            {
                // 播放成功逻辑处理
            }
        });
        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Openboard);
        Raise_Proton.GetComponent<Image>().sprite = RaiseEka.HisEquality().OfRaiseClimax ? RaiseLeak : RaiseKilnSilent;
        Biome_Proton.GetComponent<Image>().sprite = RaiseEka.HisEquality().PuffinRaiseClimax ? BiomeLeak : BiomeKilnSilent;
        AmazementVia.GetComponent<Image>().sprite = MindGazeFaculty.GetBool(CChoppy.Of_MyCabbage) ? AmazementLeak : AmazementKilnSilent;
    }
    // Start is called before the first frame update
    void Start()
    {
        FactorPupilFive = UIFaculty.HisEquality().MainObtain.transform.Find("Top/ChangeScene").gameObject;
        FindVia.onClick.AddListener(() => {
            if (MindGazeFaculty.GetString(CChoppy.Of_ForeverFind) != "FindSpear")
            {
                SpoonUITrap(GetType().Name);
                HardyDesignDeftFaculty.instance.MarketWhen();
                UIFaculty.HisEquality().FordUISleek("FindSpear");
                /*ChangeSceneMask.SetActive(true);
                ChangeSceneMask.GetComponent<FactorPupil>().ChangeSceneAni(() => 
                {
                    CloseUIForm(GetType().Name);
                    HardyDesignDeftFaculty.instance.FinishGame();
                    UIFaculty.GetInstance().ShowUIForms("FindSpear");
                }, () =>
                {
                    
                });*/
            }
            else
            {
                SpoonUITrap(GetType().Name);
            }
        });
        GoodVia.onClick.AddListener(() => {
            SpoonUITrap(GetType().Name);
        });
        
        Raise_Proton.onClick.AddListener(() =>
        {

            RaiseEka.HisEquality().OfRaiseClimax = !RaiseEka.HisEquality().OfRaiseClimax;
            Raise_Proton.GetComponent<Image>().sprite = RaiseEka.HisEquality().OfRaiseClimax ? RaiseLeak : RaiseKilnSilent;
        });
        Biome_Proton.onClick.AddListener(() =>
        {

            RaiseEka.HisEquality().PuffinRaiseClimax = !RaiseEka.HisEquality().PuffinRaiseClimax;
            Biome_Proton.GetComponent<Image>().sprite = RaiseEka.HisEquality().PuffinRaiseClimax ? BiomeLeak : BiomeKilnSilent;
        });
        AmazementVia.onClick.AddListener((() =>
        {
            MindGazeFaculty.SetBool(CChoppy.Of_MyCabbage, !MindGazeFaculty.GetBool(CChoppy.Of_MyCabbage));
            AmazementVia.GetComponent<Image>().sprite = MindGazeFaculty.GetBool(CChoppy.Of_MyCabbage) ? AmazementLeak : AmazementKilnSilent;
        }));

        BusComaProton.onClick.AddListener(()=> {
            if (ThumbComaFrown > 5)
            {
                UIFaculty.HisEquality().FordUISleek("ThumbComaSpear");
            }
            ThumbComaFrown += 1;
        });
    }

}
