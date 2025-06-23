/*
        主题： UI遮罩管理器  

        “弹出窗体”往往因为需要玩家优先处理弹出小窗体，则要求玩家不能(无法)点击“父窗体”，这种窗体就是典型的“模态窗体”
  5  *    Description: 
  6  *           功能： 负责“弹出窗体”模态显示实现
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIFiveEka : MonoBehaviour
{
    private static UIFiveEka _Equality= null;
    //ui根节点对象
    private GameObject _GoObtainKiwi= null;
    //ui脚本节点对象
    private Transform _FluUICuticleSalt= null;
    //顶层面板
    private GameObject _AxUpSpear;
    //遮罩面板
    private GameObject _AxFiveSpear;
    //ui摄像机
    private Camera _UIConfer;
    //ui摄像机原始的层深
    private float _MudflatsUIConferDepth;
    //获取实例
    public static UIFiveEka HisEquality()
    {
        if (_Equality == null)
        {
            _Equality = new GameObject("_UIMaskMgr").AddComponent<UIFiveEka>();
        }
        return _Equality;
    }
    private void Awake()
    {
        _GoObtainKiwi = GameObject.FindGameObjectWithTag(EraOpenly.SYS_TAG_CANVAS);
        _FluUICuticleSalt = HorseLegend.TollUSAVarveSalt(_GoObtainKiwi, EraOpenly.SYS_SCRIPTMANAGER_NODE);
        //把脚本实例，座位脚本节点对象的子节点
        HorseLegend.MobVarveSaltUpDeadlySalt(_FluUICuticleSalt, this.gameObject.transform);
        //获取顶层面板，遮罩面板
        _AxUpSpear = _GoObtainKiwi;
        _AxFiveSpear = HorseLegend.TollUSAVarveSalt(_GoObtainKiwi, "_UIMaskPanel").gameObject;
        //得到uicamera摄像机原始的层深
        _UIConfer = GameObject.FindGameObjectWithTag("UICamera").GetComponent<Camera>();
        if (_UIConfer != null)
        {
            //得到ui相机原始的层深
            _MudflatsUIConferDepth = _UIConfer.depth;
        }
        else
        {
            Debug.Log("UI_Camera is Null!,Please Check!");
        }
    }

    /// <summary>
    /// 设置遮罩状态
    /// </summary>
    /// <param name="goDisplayUIForms">需要显示的ui窗体</param>
    /// <param name="lucenyType">显示透明度属性</param>
    public void TugFiveSpiral(GameObject goDisplayUIForms,UIFormLucenyType lucenyType = UIFormLucenyType.Lucency)
    {
        //顶层窗体下移
        _AxUpSpear.transform.SetAsLastSibling();
        switch (lucenyType)
        {
               //完全透明 不能穿透
            case UIFormLucenyType.Lucency:
                _AxFiveSpear.SetActive(true);
                Color newColor = new Color(255 / 255F, 255 / 255F, 255 / 255F, 0F / 255F);
                _AxFiveSpear.GetComponent<Image>().color = newColor;
                break;
                //半透明，不能穿透
            case UIFormLucenyType.Translucence:
                _AxFiveSpear.SetActive(true);
                Color newColor2 = new Color(0 / 255F, 0 / 255F, 0 / 255F, 220 / 255F);
                _AxFiveSpear.GetComponent<Image>().color = newColor2;
                PreciseCinemaBliss.HisEquality().Dram(CChoppy.We_SpiralKiln);
                break;
                //低透明，不能穿透
            case UIFormLucenyType.ImPenetrable:
                _AxFiveSpear.SetActive(true);
                Color newColor3 = new Color(50 / 255F, 50 / 255F, 50 / 255F, 240F / 255F);
                _AxFiveSpear.GetComponent<Image>().color = newColor3;
                break;
                //可以穿透
            case UIFormLucenyType.Penetrable:
                if (_AxFiveSpear.activeInHierarchy)
                {
                    _AxFiveSpear.SetActive(false);
                }
                break;
            default:
                break;
        }
        //遮罩窗体下移
        _AxFiveSpear.transform.SetAsLastSibling();
        //显示的窗体下移
        goDisplayUIForms.transform.SetAsLastSibling();
        //增加当前ui摄像机的层深（保证当前摄像机为最前显示）
        if (_UIConfer != null)
        {
            _UIConfer.depth = _UIConfer.depth + 100;
        }
    }
    public void IbexFiveSpiral()
    {
        if (UIFaculty.HisEquality().IconUISleek.Count > 0 || UIFaculty.HisEquality().HisNetworkTrapBoost().Count > 0)
        {
            return;
        }
        Color newColor3 = new Color(_AxFiveSpear.GetComponent<Image>().color.r, _AxFiveSpear.GetComponent<Image>().color.g, _AxFiveSpear.GetComponent<Image>().color.b,0);
        _AxFiveSpear.GetComponent<Image>().color = newColor3;
    }
    /// <summary>
    /// 取消遮罩状态
    /// </summary>
    public void PatronFiveSpiral()
    {
        if (UIFaculty.HisEquality().IconUISleek.Count > 0 || UIFaculty.HisEquality().HisNetworkTrapBoost().Count > 0)
        {
            return;
        }
        //顶层窗体上移
        _AxUpSpear.transform.SetAsFirstSibling();
        //禁用遮罩窗体
        if (_AxFiveSpear.activeInHierarchy)
        {
            _AxFiveSpear.SetActive(false);
            PreciseCinemaBliss.HisEquality().Dram(CChoppy.We_SpiralSpoon);
        }
        //恢复当前ui摄像机的层深
        if (_UIConfer != null)
        {
            _UIConfer.depth = _MudflatsUIConferDepth;
        }
    }
}
