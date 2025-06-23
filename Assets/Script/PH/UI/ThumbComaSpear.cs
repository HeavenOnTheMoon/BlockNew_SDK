using System.Net.Sockets;
using System.Net;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

#if Old_UIFramework
public class ThumbComaSpear : AlgaUISleek
#elif New_UIFramework
public class ThumbComaSpear : BaseUI
#else
public class ThumbComaSpear : MonoBehaviour
#endif
{
[UnityEngine.Serialization.FormerlySerializedAs("CloseBtn")]    public Button SpoonVia;
[UnityEngine.Serialization.FormerlySerializedAs("DebugText")]    public Text ThumbTear;
[UnityEngine.Serialization.FormerlySerializedAs("UpdateBtn")]    public Button RejoinVia;
[UnityEngine.Serialization.FormerlySerializedAs("ConfigIdInput")]    public InputField ChoppyAxJules;
[UnityEngine.Serialization.FormerlySerializedAs("UpdateConfigIdBtn")]    public Button RejoinChoppyAxVia;
[UnityEngine.Serialization.FormerlySerializedAs("AdLocationId")]    public InputField ByTimidityAx;
[UnityEngine.Serialization.FormerlySerializedAs("RewardBtn")]    public Button MortalVia;
[UnityEngine.Serialization.FormerlySerializedAs("IntBtn")]    public Button WinVia;

    // Start is called before the first frame update
    void Start()
    {
        SpoonVia.onClick.AddListener(() =>
        {
#if Old_UIFramework
            SpoonUITrap(GetType().Name);
#elif New_UIFramework
            UIFaculty.Instance.CloseUI();
#endif
        });


        RejoinVia.onClick.AddListener(() => {
            DeftStorm newUser = new() {
                visitorId = PHVolt.HisUUID()
            };
            NativePeat.Equality.IgnoreBifocal.SaveUserInfo(newUser);
            PHUIFaculty.Equality.FordWeave("Account has been updated, please reopen the game to login again.");
        });

        RejoinChoppyAxVia.onClick.AddListener(async () => {
            if (string.IsNullOrEmpty(ChoppyAxJules.text))
            {
                PHUIFaculty.Equality.FordWeave("Please input config id.");
                return;
            }
            string Fox= $"{PHCrest.BASE_URL}/api/game/appversionconfig/ph/test?appVersionGroupId={int.Parse(ChoppyAxJules.text)}";
            var response = await RootIsotopePeat.Equality.His(Fox, true, false);
            if (response.IsSuccess)
            {
                PHUIFaculty.Equality.FordWeave("Config id has been updated, please reopen the game to login again.");
            }
            else
            {
                PHUIFaculty.Equality.FordWeave("Config id update failed, please check your network.");
            }
        });

        MortalVia.onClick.AddListener(() => {
            if (string.IsNullOrEmpty(ByTimidityAx.text))
            {
                PHUIFaculty.Equality.FordWeave("Please input ad location id.");
                return;
            }
            ByPeat.Equality.ItemMortalBy(int.Parse(ByTimidityAx.text), (success) => { });
        });

        WinVia.onClick.AddListener(() => {
            if (string.IsNullOrEmpty(ByTimidityAx.text))
            {
                PHUIFaculty.Equality.FordWeave("Please input ad location id.");
                return;
            }
            ByPeat.Equality.ItemMusicologistBy(int.Parse(ByTimidityAx.text), (success) => { });
        });
    }

#if Old_UIFramework
    public override void Display()
    {
        base.Display();
#elif New_UIFramework
    public void Show()
    {
        base.Show();
#else
    public void Display()
    {
#endif

        FordComa();
    }

    private async void FordComa()
    {
        BoxModel BegStorm= await DustyPeat.Equality.HisFenComa();
        string ua = await NativePeat.Equality.HisDeftSetup();

        StringBuilder sb = new StringBuilder();
        sb.Append("游戏的用户ID     ：");
        sb.Append(DustyPeat.Equality.DeftComa.uid);
        sb.Append("\n");
        sb.Append("游戏关联的盒子用户ID ：");
        sb.Append(BegStorm?.uid);
        sb.Append("\n");
        sb.Append("keychain拿到的数据");
        sb.Append("\n");
        sb.Append("keychainAppName : " + BegStorm?.appName);
        sb.Append("\n");
        sb.Append("keychainCampaign : " + BegStorm?.campaign);
        sb.Append("\n");
        sb.Append("keychainIdfv : " + BegStorm?.visitorId);
        sb.Append("\n");
        sb.Append("keychainBoxUid : " + BegStorm?.uid);
        sb.Append("\n");
        sb.Append("keychainEnvironment : " + BegStorm?.environment);
        sb.Append("\n");
        sb.Append("keychainVifv : " + BegStorm?.vifv);
        sb.Append("\n");
        sb.Append("版本号 ：");
        sb.Append(Application.version);
        sb.Append("\n");
        sb.Append("UA信息 ：");
        sb.Append(ua);
        sb.Append("\n");
        sb.Append("IP信息 ：");
        sb.Append(HisSedgeIMe6());
        sb.Append("\n");
        sb.Append("campaign ：");
        sb.Append(BegStorm?.campaign);
        sb.Append("\n");
        sb.Append("deepLink ：");
        sb.Append(PHFaculty.Instance.LoanCateRye);
        sb.Append("\n");


        ThumbTear.text = sb.ToString();
    }

    public string HisSedgeIMe6()
    {
        string ipAddress = "";
        try
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetworkV6)
                {
                    ipAddress = ip.ToString();
                    break;
                }
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError("IP 获取失败" + e.Message);
        }
        return ipAddress;
    }
}
