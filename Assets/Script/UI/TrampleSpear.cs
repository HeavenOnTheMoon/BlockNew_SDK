using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrampleSpear : MonoBehaviour
{
    
    public static TrampleSpear Instance;
[UnityEngine.Serialization.FormerlySerializedAs("sliderImage")]    public Image GaslitKnife;
[UnityEngine.Serialization.FormerlySerializedAs("progressPercent")]    public Text BuildingSeepage;
[UnityEngine.Serialization.FormerlySerializedAs("ProgressText")]    public Text RegionalTear;
[UnityEngine.Serialization.FormerlySerializedAs("VersionText")]    public Text FresherTear;

    private float Melange;

    private const string LAST_LOGIN_DATE_KEY= "LastLoginDate";
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
       
        GaslitKnife.fillAmount = 0;
        BuildingSeepage.text = "0%";

#if TEST_MODE
        VersionText.text = Application.version + "(TEST_MODE)";
#else
        FresherTear.text = Application.version;
#endif
    }

    // Update is called once per frame
    void Update()
    {
        // 如果有弹窗（如强更弹窗或断网提示弹窗），则阻塞进度
        if (PHUIFaculty.Equality.MyAnyUIFord())
        {
            return;
        }

        // 如果没有登录成功，进度卡在60%，显示“登录中”
        // 如果登录后没有成功获取配置，进度卡在80%，显示“获取配置中”
        // 如果登录成功，获取配置成功，但有其他问题，进度卡在90%，显示“初始化中”
        if (Melange < 0.6f
            || PHFaculty.Instance.AboveIceberg && Melange < 0.8f
            || PHFaculty.Instance.MeatyChoppyIceberg && Melange < 0.9f
            || PHFaculty.Instance.FolkIceberg)
        {
            Melange += Time.deltaTime / 3f;
        }

        GaslitKnife.fillAmount = Melange;
        BuildingSeepage.text = (int)(Melange * 100) + "%";
        if (Melange <= 0.6f)
        {
            RegionalTear.text = "Loading...";
        }
        else if (Melange < 0.8f)
        {
            RegionalTear.text = "Pull config...";
        }
        else if (Melange < 0.9f)
        {
            RegionalTear.text = "Initializing...";
        }
        else
        {
            RegionalTear.text = "Initialization successful";
        }
        if (Melange >= 1)
        {
            // 进入游戏
            Destroy(transform.parent.gameObject);
            HardyDesignDeftFaculty.instance.GobiBank();
            MyUpYamNight();
        }
    }

    public void MyUpYamNight()
    {
        string Fault= DateTime.Today.ToString("yyyy-MM-dd");
        string lastLoginDate = PlayerPrefs.GetString(LAST_LOGIN_DATE_KEY, "");

        if (lastLoginDate != Fault)
        {
            // 今日首次登录
            Debug.Log("欢迎！今天是你的首次登录");

            // 更新最后登录日期
            PlayerPrefs.SetString(LAST_LOGIN_DATE_KEY, Fault);
            PlayerPrefs.Save();

            LayerFatPeat.Equality.DramMortalLayer(1101, "app_first_open_per_1101");
        }
        else
        {
            Debug.Log("今天已经登录过了");
        }
    }
}
