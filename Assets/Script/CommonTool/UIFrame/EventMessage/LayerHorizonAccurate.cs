/*
 *     主题： 事件触发监听      
 *    Description: 
 *           功能： 实现对于任何对象的监听处理。
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LayerHorizonAccurate : UnityEngine.EventSystems.EventTrigger
{
    public delegate void VoidDelegate(GameObject go);
    public VoidDelegate SoFlute;
    public VoidDelegate SoLeaf;
    public VoidDelegate SoPluto;
    public VoidDelegate SoJump;
    public VoidDelegate SoUp;
    public VoidDelegate SoChorus;
    public VoidDelegate SoRejoinChorus;

    /// <summary>
    /// 得到监听器组件
    /// </summary>
    /// <param name="go">监听的游戏对象</param>
    /// <returns></returns>
    public static LayerHorizonAccurate His(GameObject go)
    {
        LayerHorizonAccurate listener = go.GetComponent<LayerHorizonAccurate>();
        if (listener == null)
        {
            listener = go.AddComponent<LayerHorizonAccurate>();
        }
        return listener;
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        if (SoFlute != null)
        {
            SoFlute(gameObject);
        }
    }
    public override void OnPointerDown(PointerEventData eventData)
    {
        if (SoLeaf != null)
        {
            SoLeaf(gameObject);
        }
    }
    public override void OnPointerEnter(PointerEventData eventData)
    {
        if (SoPluto != null)
        {
            SoPluto(gameObject);
        }
    }
    public override void OnPointerExit(PointerEventData eventData)
    {
        if (SoJump != null)
        {
            SoJump(gameObject);
        }
    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        if (SoUp != null)
        {
            SoUp(gameObject);
        }
    }
    public override void OnSelect(BaseEventData eventData)
    {
        if (SoChorus != null)
        {
            SoChorus(gameObject);
        }
    }
    public override void OnUpdateSelected(BaseEventData eventData)
    {
        if (SoRejoinChorus != null)
        {
            SoRejoinChorus(gameObject);
        }
    }
}
