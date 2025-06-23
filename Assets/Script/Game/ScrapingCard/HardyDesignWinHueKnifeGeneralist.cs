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

public class HardyDesignWinHueKnifeGeneralist : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
[UnityEngine.Serialization.FormerlySerializedAs("isStartEraser")]    //是否擦除了
    public bool SoSewerRarity;
[UnityEngine.Serialization.FormerlySerializedAs("isEndEraser")]
    //是否擦除结束了
    public bool SoRyeRarity;
[UnityEngine.Serialization.FormerlySerializedAs("isStartEraserTwo")]    
    //是否擦除了
    public bool SoSewerRarityHue;
[UnityEngine.Serialization.FormerlySerializedAs("isEndEraserTwo")]
    //是否擦除结束了
    public bool SoRyeRarityHue;
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
[UnityEngine.Serialization.FormerlySerializedAs("uiTexTwo")]    
    public RawImage NoSawHue;
    Texture2D WebHue;
    Texture2D IfSawHue;
    int mGessoHue;
    int mCooperHue;
    [Header("笔刷大小")] [UnityEngine.Serialization.FormerlySerializedAs("brushSizeTwo")]public int UniteFlatHue= 50;
    [Header("刮刮乐比例")] [UnityEngine.Serialization.FormerlySerializedAs("rateTwo")]public int LoveHue= 60;
    float GinThingAHue;
    float UpsetAHue;

    void Awake()
    {
        Web = (Texture2D) NoSaw.mainTexture;
        WebHue = (Texture2D) NoSawHue.mainTexture;
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
        
        
        NoSawHue.gameObject.SetActive(true);

        IfSawHue = new Texture2D(WebHue.width, WebHue.height, TextureFormat.ARGB32, false);
        mGessoHue = IfSawHue.width;
        mCooperHue = IfSawHue.height;
        IfSawHue.SetPixels(WebHue.GetPixels());
        IfSawHue.Apply();
        NoSawHue.texture = IfSawHue;
        GinThingAHue = IfSawHue.GetPixels().Length;
        UpsetAHue = 0;
        SoRyeRarityHue = false;
        SoSewerRarityHue = false;
    }

    public void MarketSeedy()
    {
        NoSaw.gameObject.SetActive(false);
        NoSawHue.gameObject.SetActive(false);
        SoRyeRarity = true;
        SoRyeRarityHue = true;
        Life = 100;
        LifeHue = 100;
        FordCompanyTempt();
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
    float Nestling= 2f;
    
    bool GradeCartHue= false;
    bool EyePotashHue= false;
    Vector2 IronBurHue; //最后一个点
    Vector2 DeviseBurHue; //倒数第二个点
    float HollowHue= 12f;
    float NestlingHue= 2f;

    #region 事件

    public void OnPointerDown(PointerEventData eventData)
    {
        /*Debug.LogError("OnPointerDown == " + transform.name);*/
        if (SoRyeRarity && SoRyeRarityHue)
        {
            return;
        }

        if (!SoRyeRarity)
        {
            GradeCart = true;
            
            DeviseBur = eventData.position;
            IronBur = DeviseBur;
            RouteSpend(DeviseBur);
        }
        if (!SoRyeRarityHue)
        {
            GradeCartHue = true;
            DeviseBurHue = eventData.position;
            IronBurHue = DeviseBurHue;
            RouteSpendHue(DeviseBurHue);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        /*Debug.LogError("OnDrag == " + transform.name);*/
        if (SoRyeRarity && SoRyeRarityHue)
        {
            return;
        }

        if (!SoRyeRarity)
        {
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
        
        if (!SoRyeRarityHue)
        {
            if (EyePotashHue && Vector2.Distance(eventData.position, IronBurHue) > NestlingHue) //如果两次记录的鼠标坐标距离大于一定的距离，开始记录鼠标的点
            {
                Vector2 pos = eventData.position;
                float dis = Vector2.Distance(IronBurHue, pos);


                RouteSpendHue(eventData.position);
                int segments = (int) (dis / HollowHue); //计算出平滑的段数                                              
                segments = segments < 1 ? 1 : segments;
                if (segments >= 10)
                {
                    segments = 10;
                }

                Vector2[] points = Chinese(DeviseBurHue, IronBurHue, pos, segments); //进行贝塞尔平滑
                for (int i = 0; i < points.Length; i++)
                {
                    RouteSpendHue(points[i]);
                }

                IronBurHue = pos;
                if (points.Length > 2)
                    DeviseBurHue = points[points.Length - 2];
            }
            else
            {
                EyePotashHue = true;
                IronBurHue = eventData.position;
            }
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (SoRyeRarity && SoRyeRarityHue)
        {
            return;
        }

        //CheckPoint(eventData.position);
        GradeCart = false;
        EyePotash = false;
        GradeCartHue = false;
        EyePotashHue = false;
    }

    #endregion
    void RouteSpendHue(Vector3 pScreenPos)
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(pScreenPos);
        Vector3 localPos = NoSawHue.gameObject.transform.InverseTransformPoint(worldPos);
        
        if (localPos.x > -mGessoHue / 2 && localPos.x < mGessoHue / 2 && localPos.y > -mCooperHue / 2 &&
            localPos.y < mCooperHue / 2)
        {
            /*Debug.Log("localPos.x222222222222 == " + localPos.x + "     localPos.y == " + localPos.y + "      == " + (-mWidthTwo / 2) + "       == " + mWidthTwo / 2
                      + "             == " + -mHeightTwo / 2 + "            == " + mHeightTwo / 2);*/
            for (int i = (int) localPos.x - UniteFlatHue; i < (int) localPos.x + UniteFlatHue; i++)
            {
                for (int j = (int) localPos.y - UniteFlatHue; j < (int) localPos.y + UniteFlatHue; j++)
                {
                    if (Mathf.Pow(i - localPos.x, 2) + Mathf.Pow(j - localPos.y, 2) > Mathf.Pow(UniteFlatHue, 2))
                        continue;
                    if (i < 0)
                    {
                        if (i < -mGessoHue / 2)
                        {
                            continue;
                        }
                    }

                    if (i > 0)
                    {
                        if (i > mGessoHue / 2)
                        {
                            continue;
                        }
                    }

                    if (j < 0)
                    {
                        if (j < -mCooperHue / 2)
                        {
                            continue;
                        }
                    }

                    if (j > 0)
                    {
                        if (j > mCooperHue / 2)
                        {
                            continue;
                        }
                    }

                    Color col = IfSawHue.GetPixel(i + (int) mGessoHue / 2, j + (int) mCooperHue / 2);
                    if (col.a != 0f)
                    {
                        col.a = 0.0f;
                        UpsetAHue++;
                        IfSawHue.SetPixel(i + (int) mGessoHue / 2, j + (int) mCooperHue / 2, col);
                    }
                }
            }


            //开始刮的时候 去判断进度
            if (!SoSewerRarityHue)
            {
                /*if (!CheckIfStart())
                {
                    return;
                }*/

                SoSewerRarityHue = true;
                InvokeRepeating(nameof(HisVariabilitySeepageHue), 0f, 0.2f);
                // eraserStartEvent?.Invoke();
            }

            IfSawHue.Apply();
        }
    }
    void RouteSpend(Vector3 pScreenPos)
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(pScreenPos);
        Vector3 localPos = NoSaw.gameObject.transform.InverseTransformPoint(worldPos);

        
        if (localPos.x > -mGesso / 2 && localPos.x < mGesso / 2 && localPos.y > -mCooper / 2 &&
            localPos.y < mCooper / 2)
        {
            /*Debug.Log("localPos.x111111111111 == " + localPos.x + "     localPos.y == " + localPos.y + "      == " + (-mWidth / 2) + "       == " + mWidth / 2
                      + "             == " + -mHeight / 2 + "            == " + mHeight / 2);*/
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
                SoSewerRarity = true;
                InvokeRepeating(nameof(HisVariabilitySeepage), 0f, 0.2f);
                // eraserStartEvent?.Invoke();
            }

            IfSaw.Apply();
        }
    }

    double Life;
    double LifeHue;
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
        //Debug.Log("当前百分比111: " + fate);
        if (Life >= Love)
        {
            //Debug.LogError("uiTex" + uiTex.transform.name);
            SoRyeRarity = true;
            CancelInvoke("GetTransparentPercent");
            NoSaw.gameObject.SetActive(false);
            //触发结束事件
            Invoke("ShowScratchBonus", 0.5f);
        }
    }
    
    public void HisVariabilitySeepageHue()
    {
        if (SoRyeRarityHue)
        {
            return;
        }

        LifeHue = UpsetAHue / GinThingAHue * 100;
        LifeHue = (float) Math.Round(LifeHue, 2);
        //Debug.Log("当前百分比222: " + fateTwo);
        if (LifeHue >= LoveHue)
        {
            //Debug.LogError("uiTex" + uiTexTwo.transform.name);
            SoRyeRarityHue = true;
            CancelInvoke("GetTransparentPercentTwo");
            NoSawHue.gameObject.SetActive(false);
            //触发结束事件
            Invoke("ShowScratchBonus", 0.5f);
        }
    }

    private void FordCompanyTempt()
    {
        if (LifeHue >= LoveHue && Life >= Love)
        {
            LifeHue = 0;
            Life = 0;
            PreciseCinemaBliss.HisEquality().Dram(CChoppy.We_ThreeMortal, new PreciseGaze(false));
        }
            
        //WordHikeScratchcardPanel.Instance.ShowScratchBar();
    }
}
