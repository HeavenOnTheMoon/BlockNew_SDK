// Project: HappyBingo
// FileName: HardyDesignWinKnifeGeneralist.cs
// Author: AX
// CreateDate: 20221205
// CreateTime: 10:58
// Description:

using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HardyDesignWinKnifeGeneralist : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
[UnityEngine.Serialization.FormerlySerializedAs("isStartEraser")]    //是否擦除了
    public bool SoSewerRarity;
[UnityEngine.Serialization.FormerlySerializedAs("isEndEraser")]
    //是否擦除结束了
    public bool SoRyeRarity;
[UnityEngine.Serialization.FormerlySerializedAs("eraserStartEvent")]
    //开始事件
    public Action FranceSewerLayer;
[UnityEngine.Serialization.FormerlySerializedAs("eraserEndEvent")]
    //结束事件
    public Action FranceRyeLayer;
[UnityEngine.Serialization.FormerlySerializedAs("uiTex")]    public RawImage NoSaw;
    Texture2D Web;
    Texture2D IfSaw;
    int mGesso;
    int mCooper;
    [Header("笔刷大小")] [UnityEngine.Serialization.FormerlySerializedAs("brushSize")]public int UniteFlat= 50;
    [Header("刮刮乐比例")] [UnityEngine.Serialization.FormerlySerializedAs("rate")]public int Love= 60;
    float GinThingA;
    float UpsetA;

    void Awake()
    {
        Web = (Texture2D) NoSaw.mainTexture;
        //InitCover();
    }

    public void BankSeedy()
    {
        NoSaw.gameObject.SetActive(true);

        IfSaw = new Texture2D(Web.width, Web.height, TextureFormat.ARGB32, false);
        mGesso = IfSaw.width;
        mCooper = IfSaw.height;
        IfSaw.SetPixels(Web.GetPixels());
        IfSaw.Apply();
        NoSaw.texture = IfSaw;
        GinThingA = IfSaw.GetPixels().Length;
        UpsetA = 0;
        SoRyeRarity = false;
        SoSewerRarity = false;
    }


    /// <summary>
    /// 贝塞尔平滑
    /// </summary>
    /// <param name="start">起点</param>
    /// <param name="mid">中点</param>
    /// <param name="end">终点</param>
    /// <param name="segments">段数</param>
    /// <returns></returns>
    public Vector2[] Chinese(Vector2 start, Vector2 mid, Vector2 end, int segments)
    {
        float d = 1f / segments;
        Vector2[] points = new Vector2[segments - 1];
        for (int i = 0; i < points.Length; i++)
        {
            float t= d * (i + 1);
            points[i] = (1 - t) * (1 - t) * mid + 2 * t * (1 - t) * start + t * t * end;
        }

        List<Vector2> rps = new List<Vector2>();
        rps.Add(mid);
        rps.AddRange(points);
        rps.Add(end);
        return rps.ToArray();
    }

    bool GradeCart= false;
    bool EyePotash= false;
    Vector2 IronBur; //最后一个点
    Vector2 DeviseBur; //倒数第二个点
    float Hollow= 12f;
    float Nestling= 1f;

    #region 事件

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.LogError("OnPointerDown == " + transform.name);
        if (SoRyeRarity)
        {
            return;
        }

        GradeCart = true;
        DeviseBur = eventData.position;
        RouteSpend(DeviseBur);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.LogError("OnDrag == " + transform.name);
        if (SoRyeRarity)
        {
            return;
        }

        if (EyePotash && Vector2.Distance(eventData.position, IronBur) > Nestling) //如果两次记录的鼠标坐标距离大于一定的距离，开始记录鼠标的点
        {
            Vector2 pos = eventData.position;
            float dis = Vector2.Distance(IronBur, pos);

            RouteSpend(eventData.position);
            int segments = (int) (dis / Hollow); //计算出平滑的段数                                              
            segments = segments < 1 ? 1 : segments;
            if (segments >= 10)
            {
                segments = 10;
            }

            Vector2[] points = Chinese(DeviseBur, IronBur, pos, segments); //进行贝塞尔平滑
            for (int i = 0; i < points.Length; i++)
            {
                RouteSpend(points[i]);
            }

            IronBur = pos;
            if (points.Length > 2)
                DeviseBur = points[points.Length - 2];
        }
        else
        {
            EyePotash = true;
            IronBur = eventData.position;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (SoRyeRarity)
        {
            return;
        }

        //CheckPoint(eventData.position);
        GradeCart = false;
        EyePotash = false;
    }

    #endregion

    void RouteSpend(Vector3 pScreenPos)
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(pScreenPos);
        Vector3 localPos = NoSaw.gameObject.transform.InverseTransformPoint(worldPos);

        /*Debug.Log("localPos.x == " + localPos.x + "     localPos.y == " + localPos.y + "      == " + (-mWidth / 2) + "       == " + mWidth / 2
        + "             == " + -mHeight / 2 + "            == " + mHeight / 2);*/
        if (localPos.x > -mGesso / 2 && localPos.x < mGesso / 2 && localPos.y > -mCooper / 2 &&
            localPos.y < mCooper / 2)
        {
            for (int i = (int) localPos.x - UniteFlat; i < (int) localPos.x + UniteFlat; i++)
            {
                for (int j = (int) localPos.y - UniteFlat; j < (int) localPos.y + UniteFlat; j++)
                {
                    if (Mathf.Pow(i - localPos.x, 2) + Mathf.Pow(j - localPos.y, 2) > Mathf.Pow(UniteFlat, 2))
                        continue;
                    if (i < 0)
                    {
                        if (i < -mGesso / 2)
                        {
                            continue;
                        }
                    }

                    if (i > 0)
                    {
                        if (i > mGesso / 2)
                        {
                            continue;
                        }
                    }

                    if (j < 0)
                    {
                        if (j < -mCooper / 2)
                        {
                            continue;
                        }
                    }

                    if (j > 0)
                    {
                        if (j > mCooper / 2)
                        {
                            continue;
                        }
                    }

                    Color col = IfSaw.GetPixel(i + (int) mGesso / 2, j + (int) mCooper / 2);
                    if (col.a != 0f)
                    {
                        col.a = 0.0f;
                        UpsetA++;
                        IfSaw.SetPixel(i + (int) mGesso / 2, j + (int) mCooper / 2, col);
                    }
                }
            }


            //开始刮的时候 去判断进度
            if (!SoSewerRarity)
            {
                if (!RouteIfSewer())
                {
                    return;
                }

                SoSewerRarity = true;
                InvokeRepeating(nameof(HisVariabilitySeepage), 0f, 0.2f);
                // eraserStartEvent?.Invoke();
            }

            IfSaw.Apply();
        }
    }

    double Life;

    /// <summary> 
    /// 检测当前刮刮卡 进度
    /// </summary>
    /// <returns></returns>
    public void HisVariabilitySeepage()
    {
        if (SoRyeRarity)
        {
            return;
        }

        Life = UpsetA / GinThingA * 100;
        Life = (float) Math.Round(Life, 2);
        Debug.Log("当前百分比: " + Life);
        if (Life >= Love)
        {
            Debug.LogError("uiTex" + NoSaw.transform.name);
            SoRyeRarity = true;
            CancelInvoke("GetTransparentPercent");
            NoSaw.gameObject.SetActive(false);
            //触发结束事件
            Invoke("ShowScratchBonus", 0.5f);
        }
    }

    private void FordCompanyTempt()
    {
        Debug.LogError("ShowScratchBonus");
        //PreciseCinemaBliss.GetInstance().Send(CChoppy.mg_ScardReward, new PreciseGaze(false));
    }

    private bool RouteIfSewer()
    {
        return true;
        
        
        /*if (ScrapingCard.instance.GetScrapingCardCount() >= 1)
        {
            ScrapingCard.instance.SCardManagerCount();
            PreciseCinemaBliss.GetInstance().Send(CChoppy.mg_ScardCount);
            return true;
        }*/
        WeaveFaculty.HisEquality().FordWeave("Not enough cards");
        return false;
    }
}


