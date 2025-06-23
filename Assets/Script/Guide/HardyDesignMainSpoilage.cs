using System;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 矩形遮罩镂空
/// </summary>
public class HardyDesignMainSpoilage : MonoBehaviour
{
    public static HardyDesignMainSpoilage instance;
[UnityEngine.Serialization.FormerlySerializedAs("target")]    /// <summary>
    /// 高亮显示目标
    /// </summary>
    public Image Seldom;
[UnityEngine.Serialization.FormerlySerializedAs("ClickBtn")]
    public Button FluteVia;
[UnityEngine.Serialization.FormerlySerializedAs("Text")]    public Text Tear;
    /// <summary>
    /// 区域范围缓存
    /// </summary>
    private Vector3[] Kinship= new Vector3[4];
    /// <summary>
    /// 镂空区域中心
    /// </summary>
    private Vector4 Indium;
    /// <summary>
    /// 最终的偏移x
    /// </summary>
    private float SeldomBrutalX= 0;
    /// <summary>
    /// 最终的偏移y
    /// </summary>
    private float SeldomBrutalY= 0;
    /// <summary>
    /// 遮罩材质
    /// </summary>
    private Material Titanium;
    /// <summary>
    /// 当前的偏移x
    /// </summary>
    private float LoyallyBrutalX= 0f;
    /// <summary>
    /// 当前的偏移y
    /// </summary>
    private float LoyallyBrutalY= 0f;
    /// <summary>
    /// 高亮区域缩放的动画时间
    /// </summary>
    private float MainlyPort= 0.3f;
    /// <summary>
    /// 事件渗透组件
    /// </summary>
    private HardyDesignSpoilageLayerAesthetic ChunkAesthetic;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        FluteVia.onClick.AddListener(() =>
        {
            /*if (MindGazeFaculty.GetInt(CChoppy.sv_GuideSch) == 5)
            {
                PreciseCinemaBliss.GetInstance().Send(CChoppy.mg_CloseAndComGuide);
                MindGazeFaculty.SetInt(CChoppy.sv_GuideSch, 6);
                UIFaculty.GetInstance().ShowUIForms("QuiltSpear");
            }*/
        });
    }
[UnityEngine.Serialization.FormerlySerializedAs("Currentindex")]
    public int Musicologist;
    public void Bank(Image target, int index = -1)
    {
        FluteVia.enabled = true;
        Titanium = GetComponent<Image>().material;
        Titanium.SetFloat("_Slider", 1500);
        this.Seldom = target;
        
        /*eventPenetrate = GetComponent<HardyDesignSpoilageLayerAesthetic>();
        if (eventPenetrate != null)
        {
            eventPenetrate.SetTargetImage(target);
        }*/

#if EmojiMerge
        Canvas canvas = GameObject.Find("RobloxCanvas(Clone)").GetComponent<Canvas>();
#else
        Canvas canvas = GameObject.Find("Canvas(Clone)").GetComponent<Canvas>();
#endif
        
        //Canvas canvas = /*GameController.Instance.Canvas*/null;
        //获取高亮区域的四个顶点的世界坐标
        target.rectTransform.GetWorldCorners(Kinship);
        //计算高亮显示区域在画布中的范围
        SeldomBrutalX = Vector2.Distance(GuideUpObtainBur(canvas, Kinship[0]), GuideUpObtainBur(canvas, Kinship[3])) / 2f;
        SeldomBrutalY = Vector2.Distance(GuideUpObtainBur(canvas, Kinship[0]), GuideUpObtainBur(canvas, Kinship[1])) / 2f;
        //计算高亮显示区域的中心
        float x = Kinship[0].x + ((Kinship[3].x - Kinship[0].x) / 2);
        float y = Kinship[0].y + ((Kinship[1].y - Kinship[0].y) / 2);
        Vector3 centerWorld = new Vector3(x, y, 0);
        Vector2 Indium= GuideUpObtainBur(canvas, centerWorld);
        //设置遮罩材质中的中心变量
        Vector4 centerMat = new Vector4(Indium.x, Indium.y, 0, 0);
        
        Titanium.SetVector("_Center", centerMat);
        //计算当前高亮显示区域的半径
        RectTransform canRectTransform = canvas.transform as RectTransform;
        if (canRectTransform != null)
        {
            //获取画布区域的四个顶点
            canRectTransform.GetWorldCorners(Kinship);
            //计算偏移初始值
            for (int i = 0; i < Kinship.Length; i++)
            {
                if (i % 2 == 0)
                {
                    LoyallyBrutalX = Mathf.Max(Vector3.Distance(GuideUpObtainBur(canvas, Kinship[i]), Indium), LoyallyBrutalX);
                }
                else
                {
                    LoyallyBrutalY = Mathf.Max(Vector3.Distance(GuideUpObtainBur(canvas, Kinship[i]), Indium), LoyallyBrutalY);
                }
            }
        }
        //设置遮罩材质中当前偏移的变量
        Titanium.SetFloat("_SliderX", LoyallyBrutalX);
        Titanium.SetFloat("_SliderY", LoyallyBrutalY);
    }
    /// <summary>
    /// 收缩速度
    /// </summary>
    private float MainlyMagneticX= 0f;
    private float MainlyMagneticY= 0f;
    private void Update()
    {
        //从当前偏移量到目标偏移量差值显示收缩动画
        float valueX = Mathf.SmoothDamp(LoyallyBrutalX, SeldomBrutalX, ref MainlyMagneticX, MainlyPort);
        float valueY = Mathf.SmoothDamp(LoyallyBrutalY, SeldomBrutalY, ref MainlyMagneticY, MainlyPort);
        if (!Mathf.Approximately(valueX, LoyallyBrutalX))
        {
            LoyallyBrutalX = valueX;
            Titanium.SetFloat("_SliderX", LoyallyBrutalX);
        }
        if (!Mathf.Approximately(valueY, LoyallyBrutalY))
        {
            LoyallyBrutalY = valueY;
            Titanium.SetFloat("_SliderY", LoyallyBrutalY);
        }
        
        
    }

    /// <summary>
    /// 世界坐标转换为画布坐标
    /// </summary>
    /// <param name="canvas">画布</param>
    /// <param name="world">世界坐标</param>
    /// <returns></returns>
    private Vector2 GuideUpObtainBur(Canvas canvas, Vector3 world)
    {
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, world, canvas.GetComponent<Camera>(), out position);
        return position;
    }
}
