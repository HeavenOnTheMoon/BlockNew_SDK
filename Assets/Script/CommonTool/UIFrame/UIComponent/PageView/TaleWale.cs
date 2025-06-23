/**
 * 
 * 左右滑动的页面视图
 * 
 * ***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class TaleWale : MonoBehaviour,IBeginDragHandler,IEndDragHandler
{
[UnityEngine.Serialization.FormerlySerializedAs("rect")]    //scrollview
    public ScrollRect Jibe;
    //求出每页的临界角，页索引从0开始
    List<float> FinName= new List<float>();
[UnityEngine.Serialization.FormerlySerializedAs("isDrag")]    //是否拖拽结束
    public bool SoText= false;
    bool CrowAvid= true;
    //滑动的起始坐标  
    float SeldomPersuasive= 0;
    float GradeTextPersuasive;
    float GradePort= 0f;
[UnityEngine.Serialization.FormerlySerializedAs("smooting")]    //滑动速度  
    public float Novelist= 1f;
[UnityEngine.Serialization.FormerlySerializedAs("sensitivity")]    public float Degradation= 0.3f;
[UnityEngine.Serialization.FormerlySerializedAs("OnPageChange")]    //页面改变
    public Action<int> OnTaleFactor;
    //当前页面下标
    int LoyallyTaleFrown= -1;
    void Start()
    {
        Jibe = this.GetComponent<ScrollRect>();
        float horizontalLength = Jibe.content.rect.width - this.GetComponent<RectTransform>().rect.width;
        FinName.Add(0);
        for(int i = 1; i < Jibe.content.childCount - 1; i++)
        {
            FinName.Add(GetComponent<RectTransform>().rect.width * i / horizontalLength);
        }
        FinName.Add(1);
    }

    
    void Update()
    {
        if(!SoText && !CrowAvid)
        {
            GradePort += Time.deltaTime;
            float t= GradePort * Novelist;
            Jibe.horizontalNormalizedPosition = Mathf.Lerp(Jibe.horizontalNormalizedPosition, SeldomPersuasive, t);
            if (t >= 1)
            {
                CrowAvid = true;
            }
        }
        
    }
    /// <summary>
    /// 设置页面的index下标
    /// </summary>
    /// <param name="index"></param>
    void TugTaleFrown(int index)
    {
        if (LoyallyTaleFrown != index)
        {
            LoyallyTaleFrown = index;
            if (OnTaleFactor != null)
            {
                OnTaleFactor(index);
            }
        }
    }
    /// <summary>
    /// 开始拖拽
    /// </summary>
    /// <param name="eventData"></param>
    public void OnBeginDrag(PointerEventData eventData)
    {
        SoText = true;
        GradeTextPersuasive = Jibe.horizontalNormalizedPosition;
    }
    /// <summary>
    /// 拖拽结束
    /// </summary>
    /// <param name="eventData"></param>
    public void OnEndDrag(PointerEventData eventData)
    {
        float posX = Jibe.horizontalNormalizedPosition;
        posX += ((posX - GradeTextPersuasive) * Degradation);
        posX = posX < 1 ? posX : 1;
        posX = posX > 0 ? posX : 0;
        int Syrup= 0;
        float offset = Mathf.Abs(FinName[Syrup] - posX);
        for(int i = 0; i < FinName.Count; i++)
        {
            float temp = Mathf.Abs(FinName[i] - posX);
            if (temp < offset)
            {
                Syrup = i;
                offset = temp;
            }
        }
        TugTaleFrown(Syrup);
        SeldomPersuasive = FinName[Syrup];
        SoText = false;
        GradePort = 0f;
        CrowAvid = false;
    }
}
