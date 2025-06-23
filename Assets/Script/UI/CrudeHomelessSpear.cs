using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrudeHomelessSpear : AlgaUISleek
{
    [Header("按钮")]
[UnityEngine.Serialization.FormerlySerializedAs("ADButton")]    public Button ADProton;
[UnityEngine.Serialization.FormerlySerializedAs("NextLevelButton")]    public Button DirtCrudeProton;
[UnityEngine.Serialization.FormerlySerializedAs("ADText")]    public GameObject ADTear;
    [Header("转盘组")]
[UnityEngine.Serialization.FormerlySerializedAs("SlotBG")]    public BlipGiant BlipBG;
[UnityEngine.Serialization.FormerlySerializedAs("RewardCashImage")]
    public GameObject MortalHurlKnife;
[UnityEngine.Serialization.FormerlySerializedAs("RewardGoldImage")]    public GameObject MortalFromKnife;
[UnityEngine.Serialization.FormerlySerializedAs("RewardText")]    public Text MortalTear;

    private double GirderSeedy;
    private bool WetPresageByVia;

    // Start is called before the first frame update
    void Start()
    {
        ADProton.onClick.AddListener(() => {
            if (SoRayDeft())
            {
                GistBlip();
            }
            else
            {
                //广告
                GistBlip();
            }
        });

        DirtCrudeProton.onClick.AddListener(() =>
        {
            DirtCrudeProton.enabled = false;
            if (BureauVolt.MyRaise())
            {
                HardyDesignWhenGazeFaculty.HisEquality().EonFrom(GirderSeedy, transform);
            }
            else
            {
                HardyDesignWhenGazeFaculty.HisEquality().EonMeter(GirderSeedy, transform);
            }
            SpoonUITrap(GetType().Name);
            
        });

    }

    public override void Display()
    {
        base.Display();

        if (SoRayDeft())
        {
            ADTear.SetActive(false);
            DirtCrudeProton.gameObject.SetActive(false);
        }
        else
        {
            ADTear.SetActive(true);
            DirtCrudeProton.gameObject.SetActive(true);
        }
        DirtCrudeProton.enabled = true;

        ADProton.gameObject.SetActive(true);
        WetPresageByVia = false;

        // 根据实际项目计算奖励
        //rewardValue = BureauVolt.IsApple() ? WitComaEka.instance.InitData.box_gold_price * BlockPuzzleGameUtil.GetGoldMulti() : WitComaEka.instance.InitData.passlevel_cash_price * BlockPuzzleGameUtil.GetCashMulti();
        GirderSeedy = 1 * BlockPuzzleGameUtil.HisHurlExalt();
        MortalHurlKnife.SetActive(!BureauVolt.MyRaise());
        MortalFromKnife.SetActive(BureauVolt.MyRaise());
        MortalTear.text = "+" + SaddenVolt.EthnicUpStr(GirderSeedy);

        BlipBG.FolkExalt();
    }

    private bool SoRayDeft()
    {
        return !PlayerPrefs.HasKey(CChoppy.Of_NightBlip + "Bool") || MindGazeFaculty.GetBool(CChoppy.Of_NightBlip);
    }
    // 计算本次slot应该获得的奖励
    private int DigBlipExaltFrown()
    {
        // 新用户，第一次固定翻5倍
        if (SoRayDeft())
        {
            int Syrup= 0;
            foreach (SlotItem wg in WitComaEka.instance.BankGaze.slot_group)
            {
                if (wg.multi == 5)
                {
                    return Syrup;
                }
                Syrup++;
            }
        }
        else
        {
            int sumWeight = 0;
            foreach (SlotItem wg in WitComaEka.instance.BankGaze.slot_group)
            {
                sumWeight += wg.weight;
            }
            int r = Random.Range(0, sumWeight);
            int nowWeight = 0;
            int Syrup= 0;
            foreach (SlotItem wg in WitComaEka.instance.BankGaze.slot_group)
            {
                nowWeight += wg.weight;
                if (nowWeight > r)
                {
                    return Syrup;
                }
                Syrup++;
            }

        }
        return 0;
    }


    private void GistBlip()
    {
        DirtCrudeProton.gameObject.SetActive(false);
        ADProton.gameObject.SetActive(false);
        int Syrup= DigBlipExaltFrown();
        BlipBG.Snap(Syrup, (multi) => {
            // slot结束后的回调
            
            /*FlowerbedGeneralist.ChangeNumber(rewardValue, rewardValue * multi, 0, RewardText, "+", () =>
            {
                rewardValue = rewardValue * multi;
                RewardText.text = "+" + SaddenVolt.DoubleToStr(rewardValue);
                hasClickedAdBtn = true;
                NextLevelButton.gameObject.SetActive(true);
            });*/
        });

        MindGazeFaculty.SetBool(CChoppy.Of_NightBlip, false);
    }
}
