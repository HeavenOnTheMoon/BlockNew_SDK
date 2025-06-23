using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowelMortalBath : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("RewardIcon")]    public Image MortalLeak;
[UnityEngine.Serialization.FormerlySerializedAs("RewardText")]    public Text MortalTear;
[UnityEngine.Serialization.FormerlySerializedAs("GoldIcon")]    public Sprite FromLeak;
[UnityEngine.Serialization.FormerlySerializedAs("CashIcon")]    public Sprite HurlLeak;
[UnityEngine.Serialization.FormerlySerializedAs("FinishIcon")]    public Sprite MarketLeak;

    public void TugSpell(bool finish, string type, double value)
    {
        if (finish)
        {
            MortalLeak.sprite = MarketLeak;
            MortalTear.gameObject.SetActive(false);
        }
        else
        {
            MortalLeak.sprite = type == "cash" ? HurlLeak : FromLeak;
            if (value == 0)
            {
                MortalTear.gameObject.SetActive(false);
            }
            else
            {
                MortalTear.text = SaddenVolt.EthnicUpStr(value);
                MortalTear.gameObject.SetActive(true);
            }
        }
    }

}
