using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 事件渗透
/// </summary>
public class HardyDesignSpoilageLayerAesthetic : MonoBehaviour, ICanvasRaycastFilter
{
    private Image SeldomKnife;
    public void SetCobaltKnife(Image target)
    {
        SeldomKnife = target;
    }
    public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
    {
        if (SeldomKnife == null)
        {
            return true;
        }
        return !RectTransformUtility.RectangleContainsScreenPoint(SeldomKnife.rectTransform, sp, eventCamera);
    }
}
