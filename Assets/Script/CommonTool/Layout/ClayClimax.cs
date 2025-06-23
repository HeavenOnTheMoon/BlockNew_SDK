using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum TargetType
{
    Scene,
    UGUI
}
public enum LayoutType
{
    Sprite_First_Weight,
    Sprite_First_Height,
    Screen_First_Weight,
    Screen_First_Height,
    Bottom,
    Top,
    Left,
    Right
}
public enum RunTime
{
    Awake,
    Start,
    None
}
public class ClayClimax : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Target_Type")]    public TargetType Cobalt_Well;
[UnityEngine.Serialization.FormerlySerializedAs("Layout_Type")]    public LayoutType Layout_Well;
[UnityEngine.Serialization.FormerlySerializedAs("Run_Time")]    public RunTime Don_Port;
[UnityEngine.Serialization.FormerlySerializedAs("Layout_Number")]    public float Climax_Sadden;
    private void Awake()
    {
        if (Don_Port == RunTime.Awake)
        {
            CannonEscape();
        }
    }
    private void Start()
    {
        if (Don_Port == RunTime.Start)
        {
            CannonEscape();
        }
    }

    public void CannonEscape()
    {
        if (Layout_Well == LayoutType.Sprite_First_Weight)
        {
            if (Cobalt_Well == TargetType.UGUI)
            {

                float scale = Screen.width / Climax_Sadden;
                //GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.width / w * h);
                transform.localScale = new Vector3(scale, scale, scale);
            }
        }
        if (Layout_Well == LayoutType.Screen_First_Weight)
        {
            if (Cobalt_Well == TargetType.Scene)
            {
                float scale = HisDetectGaze.HisEquality().DigConferGesso() / Climax_Sadden;
                transform.localScale = transform.localScale * scale;
            }
        }
        
        if (Layout_Well == LayoutType.Bottom)
        {
            if (Cobalt_Well == TargetType.Scene)
            {
                float screen_bottom_y = HisDetectGaze.HisEquality().DigConferCooper() / -2;
                screen_bottom_y += (Climax_Sadden + (HisDetectGaze.HisEquality().DigSilentFlat(gameObject).y / 2f));
                transform.position = new Vector3(transform.position.x, screen_bottom_y, transform.position.y);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
