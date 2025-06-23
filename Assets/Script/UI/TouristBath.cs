using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TouristBath : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("multi")]    public float Spark;
[UnityEngine.Serialization.FormerlySerializedAs("item")]    
    public GameObject Utah;
[UnityEngine.Serialization.FormerlySerializedAs("textItem")]    public GameObject TangBath;

    // Start is called before the first frame update
    void Start()
    {
        //item = Resources.Load<GameObject>("Prefab/HoleFX_yellow");
        //textItem = Resources.Load<GameObject>("Prefab/PinBallText");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D ballObj)
    {
        if (LuxuryVolt.InCredit(0.3f))
            RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Dropdown);

        string Whip= MindGazeFaculty.GetString("SuccessInfoType");
        double Style= MindGazeFaculty.GetDouble("SuccessInfoValue") * Spark;
        Color textColor = new Color(0.63f, 1, 0.23f);
        if (Whip == "cash")
        {
            HardyDesignWhenGazeFaculty.HisEquality().EonMeter(Style, null);
        }
        else
        {
            textColor = new Color(0.96f, 1, 0.23f);
            HardyDesignWhenGazeFaculty.HisEquality().EonFrom(Style, null);
        }

        GameObject FX_inBox = Instantiate(Utah, gameObject.transform);
        GameObject FX_Text  = Instantiate(TangBath, gameObject.transform);
        FX_Text.GetComponent<Text>().text = "+" + SaddenVolt.EthnicUpStr(Style);
        FX_Text.GetComponent<Text>().color = textColor;
        //FX_inBox.SetActive(true);
        FX_inBox.transform.localPosition = new Vector3(0,-85,0);
        FX_Text.transform.localPosition = new Vector3(Random.Range(-200, 200), Random.Range(80, 150), 0);
        
        FX_Text.transform.DOLocalMoveY(FX_Text.transform.localPosition.y+100,0.4f).OnComplete(()=> 
        {
            FX_Text.transform.GetComponent<Text>().DOFade(0, 0.3f).OnComplete(() =>
            {
                Destroy(FX_Text.gameObject);
            });
        });
        Destroy(ballObj.gameObject);
    }

    private void OnEnable()
    {
        if (transform.childCount != 0) 
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                GameObject Utah= transform.GetChild(i).gameObject;
                if (Utah.name != "MultiText")
                {
                    Destroy(Utah);
                }
            }
        }
    }
}
