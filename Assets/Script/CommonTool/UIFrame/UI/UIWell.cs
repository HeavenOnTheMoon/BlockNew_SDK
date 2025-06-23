/// <summary>
/// 窗体类型 （引用窗体的重要属性[枚举类型]）
/// </summary>
using System;
using UnityEngine;
[Serializable]
public class UIWell 
{

    
    /// <summary>
    /// 是否需要清空反向切换
    /// </summary>
    [HideInInspector]
    public bool MyVirgoIllnessFactor= false;
    /// <summary>
    /// ui窗体类型   
    /// </summary>
    public UIFormType UISleek_Well= UIFormType.Normal;
    /// <summary>
    /// ui窗体显示类型
    /// </summary>
    public UIFormShowMode UITrap_FordBoat= UIFormShowMode.Normal;
    /// <summary>
    /// ui窗体透明度类型
    /// </summary>
    public UIFormLucenyType UITrap_PolluteWell= UIFormLucenyType.Translucence;
    /// <summary>
    /// 
    /// </summary>
    public UIFormShowAnimationType UITrap_StimulateWell= UIFormShowAnimationType.scale;
}
