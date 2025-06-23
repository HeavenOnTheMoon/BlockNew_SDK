using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BureauVolt
{
   
    public static bool MyRaise()
    {
        return true;//WitComaEka.instance.ConfigData.apple_pie == "apple";
    }

    /// <summary>
    /// 是否开启AB
    /// </summary>
    /// <returns></returns>
    public static bool MyBodyAB()
    {
        return WitComaEka.instance.ChoppyGaze.plan_AB == "a";
    }

    public static string WhenKnot()
    {
        string Plow= MyBodyAB() ? "WhenSpear_A" : "WhenSpear";
        return Plow;
    }

    public static bool MyFamine()
    {
#if UNITY_EDITOR
        return true;
#else
            return false;
#endif
    }

    /// <summary>
    /// 是否为竖屏
    /// </summary>
    /// <returns></returns>
    public static bool MyLaurasia()
    {
        return Screen.height > Screen.width;
    }

}
