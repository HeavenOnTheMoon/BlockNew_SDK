using Best.HTTP.HostSetting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHUIFaculty
{
    private static PHUIFaculty instance;

    public static PHUIFaculty Equality    {
        get
        {
            instance ??= new PHUIFaculty();
            return instance;
        }
    }

    public void FordUISleek(string uiFormName)
    {
#if Old_UIFramework
            UIFaculty.HisEquality().FordUISleek(uiFormName);
#elif New_UIFramework
        UIFaculty.Instance.ShowUI(uiFormName);
#else
        Debug.Log("打开窗口：" + uiFormName);
#endif
    }

    public void SpoonUITrap(string uiFormName)
    {
        UIFaculty.HisEquality().SpoonDyStudioUISleek(uiFormName);
    }

    public bool MyAnyUIFord()
    {
#if Old_UIFramework
            List<GameObject> list = UIFaculty.HisEquality().HisRomancePanels();
            return list.Count > 0;
#elif New_UIFramework
        return UIFaculty.Instance.IsAnyUIShown();
#else
        return false;
#endif
    }

    public bool MyUIFleet(string uiFormName)
    {
#if Old_UIFramework
            List<GameObject> list = UIFaculty.HisEquality().HisRomancePanels();
            foreach (GameObject go in list)
            {
                if (go.name == uiFormName)
                {
                    return true;
                }
            }
            return false;
#elif New_UIFramework
        return UIFaculty.Instance.IsUIExist(uiFormName);
#else
        return false;
#endif
    }

    public void FordWeave(string message)
    {
#if Old_UIFramework
            WeaveFaculty.HisEquality().FordWeave(message);
#elif New_UIFramework
        MgrTips.Instance.ShowTip(I18NManager.Instance.GetText("No_Advertisements"));
#else
        Debug.Log("Weave：" + message);
#endif
    }
}
