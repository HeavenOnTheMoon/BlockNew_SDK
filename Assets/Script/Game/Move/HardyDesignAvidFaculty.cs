using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HardyDesignAvidFaculty : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public static HardyDesignAvidFaculty Instance;
[UnityEngine.Serialization.FormerlySerializedAs("isStartDraw")]
    public bool SoSewerCart= false;
[UnityEngine.Serialization.FormerlySerializedAs("isEndDrag")]    public bool SoRyeText;
[UnityEngine.Serialization.FormerlySerializedAs("SelectPoint")]    public PointerEventData ChorusSpend;
[UnityEngine.Serialization.FormerlySerializedAs("SelectObj")]    public GameObject ChorusPut;
    
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Take);
        
        if (SoRyeText)
        {
            return;
        }

        if (!SoRyeText)
        {
            if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) != 99)
            {
                WhenQuiltSpear.Instance.SoFordHawk(false);
            }
            SoRyeText = true;
            SoSewerCart = true;
            ChorusSpend = eventData;
            ChorusPut = eventData.pointerCurrentRaycast.gameObject;
            Vector3 wordPoint;
            RectTransformUtility.ScreenPointToWorldPointInRectangle((RectTransform)ChorusPut.transform, eventData.position, eventData.pressEventCamera, out wordPoint);
            ChorusPut.GetComponent<HardyDesignHardyGiant>()?.ChorusBur(wordPoint);
            RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Putdown);
        }
    }
    
    public void OnPointerUp(PointerEventData eventData)
    {
        
        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Drop);
        //SelectObj.GetComponent<HardyDesignHardyGiant>().RecoverPos();
        //确认能够放下方块
        SoRyeText = false;
        SoSewerCart = false;
        HardyDesignRouteNovelFaculty.Instance.NebularEnforceHardy(false);
        
        Vector3 wordPoint;
        RectTransformUtility.ScreenPointToWorldPointInRectangle((RectTransform)ChorusPut.transform, eventData.position, eventData.pressEventCamera, out wordPoint);
        ChorusPut.GetComponent<HardyDesignHardyGiant>()?.SpendIf(wordPoint);
        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Pickup);
    }
    public void OnDrag(PointerEventData eventData)
    {

        if (!SoSewerCart)
        {
            return;
        }

        if (SoSewerCart && ChorusPut != null)
        {
            Vector3 wordPoint;
            RectTransformUtility.ScreenPointToWorldPointInRectangle((RectTransform)ChorusPut.transform, eventData.position, eventData.pressEventCamera, out wordPoint);
            ChorusPut.GetComponent<HardyDesignHardyGiant>()?.AvidBur(wordPoint);
        }
    }

}
