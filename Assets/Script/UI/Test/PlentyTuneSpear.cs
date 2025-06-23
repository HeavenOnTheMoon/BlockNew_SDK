using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlentyTuneSpear : AlgaUISleek
{
[UnityEngine.Serialization.FormerlySerializedAs("CloseButton")]    public Button SpoonProton;
[UnityEngine.Serialization.FormerlySerializedAs("AdjustAdidText")]    public Text PlentyRareTear;
[UnityEngine.Serialization.FormerlySerializedAs("ServerIdText")]    public Text RunoffAxTear;
[UnityEngine.Serialization.FormerlySerializedAs("ActCounterText")]    public Text FeeOctoberTear;
[UnityEngine.Serialization.FormerlySerializedAs("AdjustTypeText")]    public Text PlentyWellTear;
[UnityEngine.Serialization.FormerlySerializedAs("ResetActCountButton")]    public Button RiverFeeExtolProton;
[UnityEngine.Serialization.FormerlySerializedAs("AddActCountButton")]    public Button MobFeeExtolProton;

    // Start is called before the first frame update
    void Start()
    {
        SpoonProton.onClick.AddListener(() => {
            SpoonUITrap(GetType().Name);
        });

        RiverFeeExtolProton.onClick.AddListener(() => {
            //AdjustInitManager.Instance.ResetActCount();
        });

        MobFeeExtolProton.onClick.AddListener(() => {
            //AdjustInitManager.Instance.AddActCount("test");
        });
    }

    private void FordOctoberTear()
    {
        /*AdjustAdidText.text = AdjustInitManager.Instance.GetAdjustAdid();
        ServerIdText.text = MindGazeFaculty.GetString(CChoppy.sv_LocalServerId);
        ActCounterText.text = AdjustInitManager.Instance._currentCount.ToString();
        AdjustTypeText.text = MindGazeFaculty.GetString("sv_ADJustInitType");*/
    }

    public override void Display()
    {
        base.Display();
        InvokeRepeating(nameof(FordOctoberTear), 0, 0.5f);
    }

    public override void Hidding()
    {
        base.Hidding();
        CancelInvoke(nameof(FordOctoberTear));
    }
}
