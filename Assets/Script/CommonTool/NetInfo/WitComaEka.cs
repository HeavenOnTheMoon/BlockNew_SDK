/***
 * 
 * 
 * 网络信息控制
 * 
 * **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
using System.Runtime.InteropServices;
//using MoreMountains.NiceVibrations;

public class WitComaEka : MonoBehaviour
{

    public static WitComaEka instance;
    //请求超时时间
    private static float TIMEOUT= 3f;
[UnityEngine.Serialization.FormerlySerializedAs("BaseUrl")]    //base
    public string AlgaRye;
[UnityEngine.Serialization.FormerlySerializedAs("BaseLoginUrl")]    //登录url
    public string AlgaDustyRye;
[UnityEngine.Serialization.FormerlySerializedAs("BaseConfigUrl")]    //配置url
    public string AlgaChoppyRye;
[UnityEngine.Serialization.FormerlySerializedAs("BaseTimeUrl")]    //时间戳url
    public string AlgaPortRye;
[UnityEngine.Serialization.FormerlySerializedAs("BaseAdjustUrl")]    //更新AdjustId url
    public string AlgaPlentyRye;
[UnityEngine.Serialization.FormerlySerializedAs("GameCode")]    //后台gamecode
    public string WhenRosy= "20000";
[UnityEngine.Serialization.FormerlySerializedAs("Channel")]
    //channel渠道平台
#if UNITY_IOS
    public string Husband= "AppStore";
#elif UNITY_ANDROID
    public string Channel = "GooglePlay";
#else
    public string Channel = "Other";
#endif
    //工程包名
    private string GroceryKnot{ get { return Application.identifier; } }
    //登录url
    private string DustyUrl= "";
    //配置url
    private string ChoppyRye= "";
    //更新AdjustId url
    private string PlentyRye= "";
[UnityEngine.Serialization.FormerlySerializedAs("country")]    //国家
    public string Foundry= "";
[UnityEngine.Serialization.FormerlySerializedAs("ConfigData")]    //服务器Config数据
    public RunoffGaze ChoppyGaze;
[UnityEngine.Serialization.FormerlySerializedAs("InitData")]    //游戏内数据
    public Init BankGaze;
[UnityEngine.Serialization.FormerlySerializedAs("GameData")]    public Game WhenGaze;
[UnityEngine.Serialization.FormerlySerializedAs("adManager")]    //ADManager
    public GameObject OxFaculty;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("gaid")]    public string Yelp;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("aid")]    public string Ask;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("idfa")]    public string Clan;
    int Vapor_Greet= 0;
[UnityEngine.Serialization.FormerlySerializedAs("ready")]    public bool Vapor= false;
    //ios 获取idfa函数声明
#if UNITY_IOS
    [DllImport("__Internal")]
    internal extern static void getIDFA();
#endif
    void Awake()
    {
        instance = this;
        DustyUrl = AlgaDustyRye + WhenRosy + "&channel=" + Husband + "&version=" + Application.version;
        ChoppyRye = AlgaChoppyRye + WhenRosy + "&channel=" + Husband + "&version=" + Application.version;
        PlentyRye = AlgaPlentyRye + WhenRosy;
    }
    private void Start()
    {

        if (Application.platform == RuntimePlatform.Android)
        {
            AndroidJavaClass aj = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject p = aj.GetStatic<AndroidJavaObject>("currentActivity");
            p.Call("getGaid");
            p.Call("getAid");

        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
#if UNITY_IOS
            getIDFA();
#endif
        }
        else
        {
            Dusty();           //编辑器登录
        }
        //获取config数据
        HisChoppyGaze();
    }

    /// <summary>
    /// 获取gaid回调
    /// </summary>
    /// <param name="gaid_str"></param>
    public void YelpEscape(string gaid_str)
    {
        Debug.Log("unity收到gaid：" + gaid_str);
        Yelp = gaid_str; 
        if (Yelp == null || Yelp == "")
        {
            Yelp = MindGazeFaculty.GetString("gaid");
        }
        else
        {
            MindGazeFaculty.SetString("gaid", Yelp);
        }
        Vapor_Greet++;
        if (Vapor_Greet == 2)
        {
            Dusty();
        }
    }
    /// <summary>
    /// 获取aid回调
    /// </summary>
    /// <param name="aid_str"></param>
    public void AskEscape(string aid_str)
    {
        Debug.Log("unity收到aid：" + aid_str);
        Ask = aid_str;
        if (Ask == null || Ask == "")
        {
            Ask = MindGazeFaculty.GetString("aid");
        }
        else
        {
            MindGazeFaculty.SetString("aid", Ask);
        }
        Vapor_Greet++;
        if (Vapor_Greet == 2)
        {
            Dusty();
        }
    }
    /// <summary>
    /// 获取idfa成功
    /// </summary>
    /// <param name="message"></param>
    public void ClanIceberg(string message)
    {
        Debug.Log("idfa success:" + message);
        Clan = message;
        MindGazeFaculty.SetString("idfa", Clan);
        Dusty();
    }
    /// <summary>
    /// 获取idfa失败
    /// </summary>
    /// <param name="message"></param>
    public void ClanTile(string message)
    {
        Debug.Log("idfa fail");
        Clan = MindGazeFaculty.GetString("idfa");
        Dusty();
    }
    /// <summary>
    /// 登录
    /// </summary>
    public void Dusty()
    {
        //获取本地缓存的Local用户ID
        string localId = MindGazeFaculty.GetString(CChoppy.sv_SedgeUserAx);

        //没有用户ID，视为新用户，生成用户ID
        if (localId == "" || localId.Length == 0)
        {
            //生成用户随机id
            TimeSpan st = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0);
            string timeStr = Convert.ToInt64(st.TotalSeconds).ToString() + UnityEngine.Random.Range(0, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString();
            localId = timeStr;
            MindGazeFaculty.SetString(CChoppy.sv_SedgeUserAx, localId);
        }

        //拼接登录接口参数
        string Fox= "";
        if (Application.platform == RuntimePlatform.IPhonePlayer)       //一个参数 - iOS
        {
            Fox = DustyUrl + "&" + "randomKey" + "=" + localId + "&idfa=" + Clan + "&packageName=" + GroceryKnot;
        }
        else if (Application.platform == RuntimePlatform.Android)  //两个参数 - Android
        {
            Fox = DustyUrl + "&" + "randomKey" + "=" + localId + "&gaid=" + Yelp + "&androidId=" + Ask + "&packageName=" + GroceryKnot;
        }
        else //编辑器
        {
            Fox = DustyUrl + "&" + "randomKey" + "=" + localId + "&packageName=" + GroceryKnot;
        }

        //获取国家信息
        DigDictate(() => {
            Fox += "&country=" + Foundry;
            //登录请求
            WitArabFaculty.HisEquality().RootHis(Fox,
                (data) => {
                    Debug.Log("Login 成功" + data.downloadHandler.text);
                    MindGazeFaculty.SetString("init_time", DateTime.Now.ToString());
                    ServerUserData serverUserData = JsonMapper.ToObject<ServerUserData>(data.downloadHandler.text);
                    MindGazeFaculty.SetString(CChoppy.Of_SedgeRunoffAx, serverUserData.data.ToString());

                    //SendAdjustAdid();
                },
                () => {
                    Debug.Log("Login 失败");
                });
        });
    }
    /// <summary>
    /// 获取国家
    /// </summary>
    /// <param name="cb"></param>
    private void DigDictate(Action cb)
    {
        bool callBackReady = false;
        if (String.IsNullOrEmpty(Foundry))
        {
            //获取国家超时返回
            StartCoroutine(WitArabPortOut(() =>
            {
                if (!callBackReady)
                {
                    Foundry = "";
                    callBackReady = true;
                    cb?.Invoke();
                }
            }));
            WitArabFaculty.HisEquality().RootHis("https://a.mafiagameglobal.com/event/country/", (data) =>
            {
                Foundry = JsonMapper.ToObject<Dictionary<string, string>>(data.downloadHandler.text)["country"];
                Debug.Log("获取国家 成功:" + Foundry);
                if (!callBackReady)
                {
                    callBackReady = true;
                    cb?.Invoke();
                }
            },
            () => {
                Debug.Log("获取国家 失败");
                if (!callBackReady)
                {
                    Foundry = "";
                    callBackReady = true;
                    cb?.Invoke();
                }
            });
        }
        else
        {
            if (!callBackReady)
            {
                callBackReady = true;
                cb?.Invoke();
            }
        }
    }

    /// <summary>
    /// 获取服务器Config数据
    /// </summary>
    private void HisChoppyGaze()
    {
        Debug.Log("GetConfigData:" + ChoppyRye);
        StartCoroutine(WitArabPortOut(() =>
        {
            HisDecorateGaze();
        }));

        //获取并存入Config
        WitArabFaculty.HisEquality().RootHis(ChoppyRye,
        (data) => {
            Debug.Log("ConfigData 成功" + data.downloadHandler.text);
            MindGazeFaculty.SetString("OnlineData", data.downloadHandler.text);
            TugChoppyGaze(data.downloadHandler.text);
        },
        () => {
            Debug.Log("ConfigData 失败");
        });
    }

    /// <summary>
    /// 获取本地Config数据
    /// </summary>
    private void HisDecorateGaze()
    {
        //是否有缓存
        if (MindGazeFaculty.GetString("OnlineData") == "" || MindGazeFaculty.GetString("OnlineData").Length == 0)
        {
            Debug.Log("本地数据");
            TextAsset Pool= Resources.Load<TextAsset>("LocationJson/LocationData");
            //JsonData gameConfig = RunoffChoppyPeat.Instance.ServerConfig.gameConfig;
     
            
            TugChoppyGaze(Pool.text);
        }
        else
        {
            Debug.Log("服务器缓存数据");
            TugChoppyGaze(MindGazeFaculty.GetString("OnlineData"));
        }
    }


    /// <summary>
    /// 解析config数据
    /// </summary>
    /// <param name="configJson"></param>
    void TugChoppyGaze(string configJson)
    {
        //如果已经获得了数据则不再处理
        if (ChoppyGaze == null)
        {
            RootData rootData = JsonMapper.ToObject<RootData>(configJson);
            ChoppyGaze = rootData.data;
            if (RunoffChoppyPeat.Equality.RunoffChoppy != null)
            {
                JsonData gameConfig = RunoffChoppyPeat.Equality.RunoffChoppy.gameConfig;
                if (gameConfig.Keys.Contains("plan_AB"))
                {
                    Debug.Log("=========数据 ：  " + gameConfig["plan_AB"].ToString());
                    ChoppyGaze.plan_AB = gameConfig["plan_AB"].ToString();

                }
                else 
                {
                    Debug.Log("获取数据plan_AB失败");
                    ChoppyGaze.plan_AB = "a";
                }
            }
            else
            {
                Debug.Log("获取数据RunoffChoppyPeat.Equality.RunoffChoppy失败");
                ChoppyGaze.plan_AB = "a";
            }
            
            
            BankGaze = JsonMapper.ToObject<Init>(ChoppyGaze.init);
            WhenGaze = JsonMapper.ToObject<Game>(ChoppyGaze.game);
            WhenVoter();
        }
    }
    /// <summary>
    /// 进入游戏
    /// </summary>
    void WhenVoter()
    {
        //打开admanager
        //adManager.SetActive(true);
        //进度条可以继续
        Vapor = true;
    }



    /// <summary>
    /// 超时处理
    /// </summary>
    /// <param name="finish"></param>
    /// <returns></returns>
    IEnumerator WitArabPortOut(Action finish)
    {
        yield return new WaitForSeconds(TIMEOUT);
        finish();
    }

    /// <summary>
    /// 向后台发送adjustId
    /// </summary>
    public void DramPlentyRare()
    {
       
    }
}
