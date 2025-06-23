using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 所有事件打点管理
/// </summary>
public class LayerFatFaculty : MonoBehaviour
{
    public static LayerFatFaculty Instance;

    private bool SoAtmosphere;    // 当前是否在前台
    
    private long LoyallyPoll;        // 当前0时区0点时间戳，用于计算是否跨天，如果跨天，则上报一次日活事件

    // 前后台累计时间
    private double _HelicopterPort= 0f;
    private double _CollarlessPort= 0f;
    private double _IronClimaxPort;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        SoAtmosphere = true;
        string savedActivedDate = PHMindGazeFaculty.GetString("PH_active_date");
        LoyallyPoll = string.IsNullOrEmpty(savedActivedDate) ? 0 :  long.Parse(savedActivedDate);

        string Owe= PHVolt.HisUTCPollMachinery().ToString();
        _HelicopterPort = PHMindGazeFaculty.GetDouble("PH_foreground_duration_" + Owe);
        _CollarlessPort = PHMindGazeFaculty.GetDouble("PH_background_duration_" + Owe);
        _IronClimaxPort = Time.realtimeSinceStartup;
    }

    private void Update()
    {
        // 如果当前在前台，则累加前台时间
        if (Application.isFocused)
        {
            _HelicopterPort += Time.deltaTime;
        }
    }

    /// <summary>
    /// 游戏前后台切换
    /// </summary>
    /// <param name="pause"></param>
    private void OnApplicationPause(bool pause)
    {
        if (!PHFaculty.Instance.AboveIceberg) return;

        if (pause)
        {
            // 进入后台：记录当前时间
            float currentTime = Time.realtimeSinceStartup;
            _IronClimaxPort = currentTime;
            //Debug.Log("--- app enter background: " + currentTime + ", ad is showing:" + ByPeat.Instance.IsAdShowing());

            // 行为事件埋点 - background
            LayerFatPeat.Equality.DramDeftLayer(10003, "sys_app_background_10003");
        }
        else
        {
            // 回到前台：记录当前时间，并累加时间
            float currentTime = Time.realtimeSinceStartup;
            // 如果是播放广告，累加到前台时间；否则，累加到后台时间
            if (ByPeat.Equality.MyByNomadic())
            {
                _HelicopterPort += currentTime - _IronClimaxPort;
            }
            else
            {
                _CollarlessPort += currentTime - _IronClimaxPort;
            }
            _IronClimaxPort = currentTime;
            //Debug.Log("--- app enter foreground: " + currentTime + ", ad is showing:" + ByPeat.Instance.IsAdShowing());

            // 行为事件埋点 - foreground
            LayerFatPeat.Equality.DramDeftLayer(10004, "sys_app_foreground_10004");
        }
        // 前后台切换时，上报一次页面耗时
        DramUrnLayer();

        SoAtmosphere = !pause;
    }

#if UNITY_EDITOR
    void OnApplicationFocus(bool hasFocus)
    {
        if (!hasFocus)
        {
            // 失去焦点：记录当前时间
            float currentTime = Time.realtimeSinceStartup;
            _IronClimaxPort = currentTime;
        }
        else
        {
            // 获得焦点：记录当前时间，并累加后台时间
            float currentTime = Time.realtimeSinceStartup;
            _CollarlessPort += currentTime - _IronClimaxPort;
            _IronClimaxPort = currentTime;
        }

        // 前后台切换时，上报一次页面耗时
        DramUrnLayer();

        SoAtmosphere = hasFocus;
    }
#endif

    /// <summary>
    /// 开启事件打点计时器
    /// </summary>
    public void SewerLayerFatHilly()
    {
        // 1、根据后台配置的事件上报频率(eventSendRule)，设置事件打点计时器
        // EventSendMethod == 1表示需要定时批量上报；EventSendMethod == 2表示需要实时上报
        RunoffChoppyStorm config = RunoffChoppyPeat.Equality.RunoffChoppy;
        EventSendRuleItem eventSendMethod = config.EventSendMethod;
        EventSendRuleItem eventIntervalSeconds = config.EventIntervalSeconds;
        if (eventSendMethod.dauEvents == 2)
        {
            InvokeRepeating(nameof(DramUrnLayer), eventIntervalSeconds.dauEvents, eventIntervalSeconds.dauEvents);
        }
        
        if (eventSendMethod.userEvents == 1)
        {
            // 定时批量上报用户事件
            InvokeRepeating(nameof(ErectDramDeftLayer), eventIntervalSeconds.userEvents, eventIntervalSeconds.userEvents);
        } 
        else if (eventSendMethod.userEvents == 2)
        {
            // 实时上报用户事件，但是需要批量上报一次登录成功前产生的事件
            ErectDramDeftLayer();
        }

        // 2、固定5秒判断一下是否跨天，如果跨天则上报一次跨天事件
        InvokeRepeating(nameof(DramOilDiluteLayerFat), 0f, 5f);
    }

    /// <summary>
    /// 发送跨天事件
    /// </summary>
    public void DramOilDiluteLayerFat()
    {
        long nowDate = PHVolt.HisUTCPollMachinery();
        if (nowDate != LoyallyPoll)
        {
            // 跨天，发送日活事件
            LayerFatPeat.Equality.DramDeftLayer(99999, "sys_app_active_99999");
            LoyallyPoll = nowDate;
            PHMindGazeFaculty.SetString("PH_active_date", LoyallyPoll.ToString());
            
            // 清空耗时事件累计时长
            _HelicopterPort = 0;
            _CollarlessPort = 0;
        }
    }

    public void DramUrnLayer()
    {
        if (SoAtmosphere)
        {
            LayerFatPeat.Equality.DramUrnLayer(10001, "user_today_online", (long) _HelicopterPort);
        }
        else
        {
            LayerFatPeat.Equality.DramUrnLayer(10002, "user_today_background", (long) _CollarlessPort);
        }
        // 存档
        string Owe= PHVolt.HisUTCPollMachinery().ToString();
        PHMindGazeFaculty.SetDouble("PH_foreground_duration_" + Owe, _HelicopterPort);
        PHMindGazeFaculty.SetDouble("PH_background_duration_" + Owe, _CollarlessPort);

        //Debug.Log("--- dau event: _foregroundTime:" + _foregroundTime + " _backgroundTime:" + _backgroundTime);
    }

    public void ErectDramDeftLayer()
    {
        LayerFatPeat.Equality.ErectDramDeftLayer();
    }
}
