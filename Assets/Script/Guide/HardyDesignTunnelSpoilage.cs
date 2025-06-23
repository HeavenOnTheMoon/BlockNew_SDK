using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 圆形遮罩镂空
/// </summary>
public class HardyDesignTunnelSpoilage : MonoBehaviour
{
    public static HardyDesignTunnelSpoilage instance;
[UnityEngine.Serialization.FormerlySerializedAs("target")]    /// <summary>
    /// 高亮显示目标
    /// </summary>
    public Image Seldom;
[UnityEngine.Serialization.FormerlySerializedAs("ClickBtn")]    
    public Button FluteVia;
    //public Text Text;
    /// <summary>
    /// 区域范围缓存
    /// </summary>
    private Vector3[] Kinship= new Vector3[4];
    /// <summary>
    /// 镂空区域中心
    /// </summary>
    private Vector4 Indium;
    /// <summary>
    /// 镂空区域半径
    /// </summary>
    private float Hollow;
    /// <summary>
    /// 遮罩材质
    /// </summary>
    private Material Titanium;
    /// <summary>
    /// 当前高亮区域半径
    /// </summary>
    private float LoyallyBreach;
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
        FluteVia.onClick.AddListener( () =>
        {
            /*if(MindGazeFaculty.GetInt(CChoppy.sv_GuideSch) != 4 && 
               MindGazeFaculty.GetInt(CChoppy.sv_GuideSch) != 6 &&
               MindGazeFaculty.GetInt(CChoppy.sv_GuideSch) != 1)
                PreciseCinemaBliss.GetInstance().Send(CChoppy.mg_CloseAndComGuide);*/
        });
    }

    public void Bank(Image target)
    {
        Titanium = GetComponent<Image>().material;
        Titanium.SetFloat("_Slider", 1500);
        FluteVia.enabled = true;
        this.Seldom = target;
        ChunkAesthetic = GetComponent<HardyDesignSpoilageLayerAesthetic>();
        if (ChunkAesthetic != null)
        {
            ChunkAesthetic.SetCobaltKnife(target);
        }
#if EmojiMerge
        Canvas canva = GameObject.Find("RobloxCanvas(Clone)").GetComponent<Canvas>();
#else
        Canvas canva = GameObject.Find("Canvas(Clone)").GetComponent<Canvas>();
#endif
        //Canvas canva = /*GameController.Instance.Canvas*/null;
        //获取高亮区域的四个顶点的世界坐标
        target.rectTransform.GetWorldCorners(Kinship);
        //计算最终高亮显示区域的半径
        Hollow = Vector2.Distance(GuideUpObtainBur(canva, Kinship[0]), GuideUpObtainBur(canva, Kinship[2])) / 2;
        //计算高亮显示区域的中心
        float x = Kinship[0].x + ((Kinship[3].x - Kinship[0].x) / 2);
        float y = Kinship[0].y + ((Kinship[1].y - Kinship[0].y) / 2);
        Vector3 centerWorld = new Vector3(x, y, 0);
        Vector2 Indium= GuideUpObtainBur(canva, centerWorld);
        //设置遮罩材质中的中心变量
        Vector4 centerMat = new Vector4(Indium.x, Indium.y, 0, 0);
        
        Titanium.SetVector("_Center", centerMat);
        //计算当前高亮显示区域的半径
        RectTransform canRectTransform = canva.transform as RectTransform;
        if (canRectTransform != null)
        {
            //获取画布区域的四个顶点
            canRectTransform.GetWorldCorners(Kinship);
            //将画布顶点距离高亮区域中心最近的距离昨晚当前高亮区域半径的初始值
            foreach (var corner in Kinship)
            {
                LoyallyBreach = Mathf.Max(Vector3.Distance(GuideUpObtainBur(canva, corner), corner), LoyallyBreach);
            }
        }
        Titanium.SetFloat("_Slider", LoyallyBreach);
    }
    /// <summary>
    /// 收缩速度
    /// </summary>
    private float MainlyMagnetic= 0f;
    private void Update()
    {
        //从当前半径到目标半径差值显示收缩动画
        //float value = Mathf.SmoothDamp(currentRadius, radius, ref shrinkVelocity, shrinkTime);
        /*if (currentRadius < 150)
        {
            currentRadius = Mathf.SmoothDamp(radius, 500, ref shrinkVelocity, shrinkTime);
            currentRadius = 350;
            material.SetFloat("_Slider", currentRadius);
        }*/
        /*else
        {
            if (!Mathf.Approximately(value, currentRadius))
            {
                currentRadius = value;
                material.SetFloat("_Slider", currentRadius);
            }
        }*/
        
        //从当前半径到目标半径差值显示收缩动画
        float Style= Mathf.SmoothDamp(LoyallyBreach, Hollow, ref MainlyMagnetic, MainlyPort);
        if (!Mathf.Approximately(Style, LoyallyBreach))
        {
            LoyallyBreach = Style;
            Titanium.SetFloat("_Slider", LoyallyBreach);
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