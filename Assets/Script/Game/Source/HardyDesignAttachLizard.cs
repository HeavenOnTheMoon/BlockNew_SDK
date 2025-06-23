using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HardyDesignAttachLizard : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("SchIamge")]    public Image LopIamge;
[UnityEngine.Serialization.FormerlySerializedAs("SchText")]    public Text LopTear;
[UnityEngine.Serialization.FormerlySerializedAs("DisText")]    public Text DisTear;
[UnityEngine.Serialization.FormerlySerializedAs("TodayObj")]
    public GameObject BelowPut;
[UnityEngine.Serialization.FormerlySerializedAs("BeforeObj")]    public GameObject OrnatePut;
[UnityEngine.Serialization.FormerlySerializedAs("BeforeDataText")]    public Text OrnateGazeTear;
[UnityEngine.Serialization.FormerlySerializedAs("TodayDataText")]    public Text BelowGazeTear;
[UnityEngine.Serialization.FormerlySerializedAs("CountDownText")]    public Text ExtolLeafTear;
[UnityEngine.Serialization.FormerlySerializedAs("SelectBtn")]    public Button ChorusVia;
[UnityEngine.Serialization.FormerlySerializedAs("Select")]    
    public Action<int> Chorus;

    int ID;
    // Start is called before the first frame update
    void Start()
    {
        ChorusVia = transform.GetComponent<Button>();
        ChorusVia.onClick.AddListener((() =>
        {
            Chorus?.Invoke(ID);
        }));
    }

    // Update is called once per frame
    void Update()
    {
        if (ID == 19)
        {
            DateTime now = DateTime.Now;
            DateTime midnight = now.AddDays(1).Date;
            TimeSpan timeToMidnight = midnight.Subtract(now);
            // 使用ToString方法格式化日期时间字符串
            ExtolLeafTear.text = String.Format("{0}:{1}:{2}", 
                timeToMidnight.Hours, timeToMidnight.Minutes, timeToMidnight.Seconds);
        }
    }

    public void Bank(int index)
    {
        ID = index;
        var Hear= HardyDesignBackupFaculty.Instance.HisMereAttachComa(index);
        //Today
        float Pul= (float)Hear.Backup / WitComaEka.instance.WhenGaze.SourceRewards.dailyMaxSource;
        LopTear.text = (Pul * 100).ToString("f0") + "%";
        LopIamge.fillAmount = Pul;
        
        if (Pul < 0.25f)
            DisTear.text = "Conscious";
        else if(Pul >= 0.25f && Pul < 0.5f)
            DisTear.text = "Conscious";
        else if(Pul >= 0.5f && Pul < 0.75f)
            DisTear.text = "Clever";
        else if(Pul >= 0.75f && Pul < 1f)
            DisTear.text = "Brain";
        else
            DisTear.text = "Genus";

        if (ID == 19)
        {
            BelowPut.gameObject.SetActive(true);
            OrnatePut.gameObject.SetActive(false);
            BelowGazeTear.text = Hear.Gaze;
        }
        else
        {
            BelowPut.gameObject.SetActive(false);
            OrnatePut.gameObject.SetActive(true);
            OrnateGazeTear.text = Hear.Gaze;
        }
    }
}
