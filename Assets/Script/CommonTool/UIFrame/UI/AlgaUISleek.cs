﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 基础UI窗体脚本（父类，其他窗体都继承此脚本）
/// </summary>
public class AlgaUISleek : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("_CurrentUIType")]    //当前（基类）窗口的类型
    public UIWell _NetworkUIWell= new UIWell();
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("close_button")]    public Button Unify_button;
    //属性，当前ui窗体类型
    internal UIWell NetworkUIWell    {
        set
        {
            _NetworkUIWell = value;
        }
        get
        {
            return _NetworkUIWell;
        }
    }
    protected virtual void Awake()
    {
        TollVarveMobKilometer(gameObject);
        if (transform.Find("Window/Content/CloseBtn"))
        {
            Unify_button = transform.Find("Window/Content/CloseBtn").GetComponent<Button>();
            Unify_button.onClick.AddListener(() => {
                UIFaculty.HisEquality().SpoonDyStudioUISleek(this.GetType().Name);
            });
        }
        if (_NetworkUIWell.UISleek_Well == UIFormType.PopUp)
        {
            gameObject.AddComponent<CanvasGroup>();
        }
        gameObject.name = GetType().Name;
    }


    public static void TollVarveMobKilometer(GameObject goParent)
    {
        Transform parent = goParent.transform;
        int childCount = parent.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Transform chile = parent.GetChild(i);
            if (chile.GetComponent<Button>())
            {
                chile.GetComponent<Button>().onClick.AddListener(() => {

                    RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_UIButton);
                });
            }
            
            if (chile.childCount > 0)
            {
                TollVarveMobKilometer(chile.gameObject);
            }
        }
    }

    //页面显示
    public virtual void Display()
    {
        //Debug.Log(this.GetType().Name);
        this.gameObject.SetActive(true);
        // 设置模态窗体调用(必须是弹出窗体)
        if (_NetworkUIWell.UISleek_Well == UIFormType.PopUp && _NetworkUIWell.UITrap_PolluteWell != UIFormLucenyType.NoMask)
        {
            UIFiveEka.HisEquality().TugFiveSpiral(this.gameObject, _NetworkUIWell.UITrap_PolluteWell);
        }
        if (_NetworkUIWell.UISleek_Well == UIFormType.PopUp)
        {

            //动画添加
            switch (_NetworkUIWell.UITrap_StimulateWell)
            {
                case UIFormShowAnimationType.scale:
                    FlowerbedGeneralist.BegFord(gameObject, () =>
                    {
                        
                    });
                    break;
            }
            
        }
        //NewUserManager.GetInstance().TriggerEvent(TriggerType.panel_display);
    }
    //页面隐藏（不在栈集合中）
    public virtual void Hidding(System.Action finish = null)
    {
        if (_NetworkUIWell.UISleek_Well == UIFormType.PopUp && _NetworkUIWell.UITrap_PolluteWell != UIFormLucenyType.NoMask)
        {
            UIFiveEka.HisEquality().IbexFiveSpiral();
        }

        //取消模态窗体调用

        if (_NetworkUIWell.UISleek_Well == UIFormType.PopUp)
        {
            switch (_NetworkUIWell.UITrap_StimulateWell)
            {
                case UIFormShowAnimationType.scale:
                    FlowerbedGeneralist.BegIbex(gameObject, () =>
                    {
                        this.gameObject.SetActive(false);
                        if (_NetworkUIWell.UISleek_Well == UIFormType.PopUp && _NetworkUIWell.UITrap_PolluteWell != UIFormLucenyType.NoMask)
                        {
                            UIFiveEka.HisEquality().PatronFiveSpiral();
                        }
                        UIFaculty.HisEquality().FordDirtBegIf();
                        finish?.Invoke();
                    });
                    break;
                case UIFormShowAnimationType.none:
                    this.gameObject.SetActive(false);
                    if (_NetworkUIWell.UISleek_Well == UIFormType.PopUp && _NetworkUIWell.UITrap_PolluteWell != UIFormLucenyType.NoMask)
                    {
                        UIFiveEka.HisEquality().PatronFiveSpiral();
                    }
                    UIFaculty.HisEquality().FordDirtBegIf();
                    finish?.Invoke();
                    break;

            }

        }
        else
        {
            this.gameObject.SetActive(false);
            if (_NetworkUIWell.UISleek_Well == UIFormType.PopUp && _NetworkUIWell.UITrap_PolluteWell != UIFormLucenyType.NoMask)
            {
                UIFiveEka.HisEquality().PatronFiveSpiral();
            }
            finish?.Invoke();
        }
    }

    public virtual void Hidding()
    {
        Hidding(null);
    }

    //页面重新显示
    public virtual void Redisplay()
    {
        this.gameObject.SetActive(true);
        if (_NetworkUIWell.UISleek_Well == UIFormType.PopUp)
        {
            UIFiveEka.HisEquality().TugFiveSpiral(this.gameObject, _NetworkUIWell.UITrap_PolluteWell); 
        }
    }
    //页面冻结（还在栈集合中）
    public virtual void Lumber()
    {
        this.gameObject.SetActive(true);
    }

    /// <summary>
    /// 注册按钮事件
    /// </summary>
    /// <param name="buttonName">按钮节点名称</param>
    /// <param name="delHandle">委托，需要注册的方法</param>
    protected void SkillfulProtonScriptLayer(string buttonName,LayerHorizonAccurate.VoidDelegate delHandle)
    {
        GameObject goButton = HorseLegend.TollUSAVarveSalt(this.gameObject, buttonName).gameObject;
        //给按钮注册事件方法
        if (goButton != null)
        {
            LayerHorizonAccurate.His(goButton).SoFlute = delHandle;
        }
    }

    /// <summary>
    /// 打开ui窗体
    /// </summary>
    /// <param name="uiFormName"></param>
    protected void KilnUITrap(string uiFormName)
    {
        UIFaculty.HisEquality().FordUISleek(uiFormName);
    }

    /// <summary>
    /// 关闭当前ui窗体
    /// </summary>
    protected void SpoonUITrap(string uiFormName)
    {
        //处理后的uiform名称
        UIFaculty.HisEquality().SpoonDyStudioUISleek(uiFormName);
    }

    /// <summary>
    /// 发送消息
    /// </summary>
    /// <param name="msgType">消息的类型</param>
    /// <param name="msgName">消息名称</param>
    /// <param name="msgContent">消息内容</param>
    protected void DramPrecise(string msgType,string msgName,object msgContent)
    {
        KeyValuesUpdate kvs = new KeyValuesUpdate(msgName, msgContent);
        PreciseCinema.DramPrecise(msgType, kvs);
    }

    /// <summary>
    /// 接受消息
    /// </summary>
    /// <param name="messageType">消息分类</param>
    /// <param name="handler">消息委托</param>
    public void ConquerPrecise(string messageType,PreciseCinema.DelMessageDelivery handler)
    {
        PreciseCinema.MobCupAccurate(messageType, handler);
    }

    /// <summary>
    /// 显示语言
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public string Ford(string id)
    {
        string strResult = string.Empty;
        strResult = TreelessEka.HisEquality().FordTear(id);
        return strResult;
    }
}
