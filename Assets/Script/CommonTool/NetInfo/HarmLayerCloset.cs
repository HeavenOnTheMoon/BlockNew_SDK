using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
public class HarmLayerCloset : RomeEndocrine<HarmLayerCloset>
{
    public string Shopper= "1.2";
    public string WhenRosy= WitComaEka.instance.WhenRosy;
    //channel
#if UNITY_IOS
    private string Husband= "AppStore";
#elif UNITY_ANDROID
    private string Channel = "GooglePlay";
#else
    private string Channel = "GooglePlay";
#endif


    private void OnApplicationPause(bool pause)
    {
        HarmLayerCloset.HisEquality().TentWhenRegional();
    }
    
    public Text Tang;

    protected override void Awake()
    {
        base.Awake();
        
        Shopper = Application.version;
        StartCoroutine("DiscPrecise");
    }
    IEnumerator DiscPrecise()
    {
        while (true)
        {
            yield return new WaitForSeconds(120f);
            HarmLayerCloset.HisEquality().TentWhenRegional();
        }
    }
    private void Start()
    {
        if (MindGazeFaculty.GetInt("event_day") != DateTime.Now.Day && MindGazeFaculty.GetString("user_servers_id").Length != 0)
        {
            MindGazeFaculty.SetInt("event_day", DateTime.Now.Day);
        }
    }
    public void DramByParaLayer(string event_id)
    {
        DramLayer(event_id);
    }
    public void TentWhenRegional(List<string> valueList = null)
    {
        if (MindGazeFaculty.GetDouble(CChoppy.Of_InnovationFromLuce) == 0)
        {
            MindGazeFaculty.SetDouble(CChoppy.Of_InnovationFromLuce, MindGazeFaculty.GetDouble(CChoppy.Of_FromLuce));
        }
        if (MindGazeFaculty.GetDouble(CChoppy.Of_InnovationMeter) == 0)
        {
            MindGazeFaculty.SetDouble(CChoppy.Of_InnovationMeter, MindGazeFaculty.GetDouble(CChoppy.Of_Meter));
        }
        if (valueList == null)
        {
            valueList = new List<string>() { 
                MindGazeFaculty.GetInt(CChoppy.Of_InnovationFromLuce).ToString(),
                MindGazeFaculty.GetString(CChoppy.Of_InnovationMeter),
                (HardyDesignCrudeFaculty.Instance.HisPryCrude() + 1).ToString()
                //MindGazeFaculty.GetInt(SlotConfig.sv_SlotSpinCount).ToString()
            };
        }
        
        if (MindGazeFaculty.GetString(CChoppy.Of_SedgeRunoffAx) == null)
        {
            return;
        }
        WWWForm wwwForm = new WWWForm();
        wwwForm.AddField("gameCode", WhenRosy);
        wwwForm.AddField("userId", MindGazeFaculty.GetString(CChoppy.Of_SedgeRunoffAx));

        wwwForm.AddField("gameVersion", Shopper);

        wwwForm.AddField("channel", Husband);

        for (int i = 0; i < valueList.Count; i++)
        {
            wwwForm.AddField("resource" + (i + 1), valueList[i]);
        }



        StartCoroutine(DramHarm(WitComaEka.instance.AlgaRye + "/api/client/game_progress", wwwForm,
        (error) =>
        {
            Debug.Log(error);
        },
        (message) =>
        {
            Debug.Log(message);
        }));
    }
    public void DramLayer(string event_id, string p1 = null, string p2 = null, string p3 = null)
    {
        if (Tang != null)
        {
            if (int.Parse(event_id) < 9100 && int.Parse(event_id) >= 9000)
            {
                if (p1 == null)
                {
                    p1 = "";
                }
                Tang.text += "\n" + DateTime.Now.ToString() + "id:" + event_id + "  p1:" + p1;
            }
        }
        if (MindGazeFaculty.GetString(CChoppy.Of_SedgeRunoffAx) == null)
        {
            WitComaEka.instance.Dusty();
            return;
        }
        WWWForm wwwForm = new WWWForm();
        wwwForm.AddField("gameCode", WhenRosy);
        wwwForm.AddField("userId", MindGazeFaculty.GetString(CChoppy.Of_SedgeRunoffAx));
        //Debug.Log("userId:" + MindGazeFaculty.GetString(CChoppy.sv_LocalServerId));
        wwwForm.AddField("version", Shopper);
        //Debug.Log("version:" + version);
        wwwForm.AddField("channel", Husband);
        //Debug.Log("channel:" + channal);
        wwwForm.AddField("operateId", event_id);
        Debug.Log("operateId:" + event_id);


        if (p1 != null)
        {
            wwwForm.AddField("params1", p1);
        }
        if (p2 != null)
        {
            wwwForm.AddField("params2", p2);
        }
        if (p3 != null)
        {
            wwwForm.AddField("params3", p3);
        }
        StartCoroutine(DramHarm(WitComaEka.instance.AlgaRye + "/api/client/log", wwwForm,
        (error) =>
        {
            Debug.Log(error);
        },
        (message) =>
        {
            Debug.Log(message);
        }));
    }
    IEnumerator DramHarm(string _url, WWWForm wwwForm, Action<string> fail, Action<string> success)
    {
        //Debug.Log(SerializeDictionaryToJsonString(dic));
        using UnityWebRequest request = UnityWebRequest.Post(_url, wwwForm);
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isNetworkError)
        {
            fail(request.error);
            ApeIsotope();
        }
        else
        {
            success(request.downloadHandler.text);
            ApeIsotope();
        }
    }
    private void ApeIsotope()
    {
        StopCoroutine("SendGet");
    }


}