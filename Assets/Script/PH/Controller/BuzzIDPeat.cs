using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuzzIDPeat : MonoBehaviour
{
    public static BuzzIDPeat instance;
    public static BuzzIDPeat Equality    {
        get
        {
            instance ??= new BuzzIDPeat();
            return instance;
        }
    }

    /// <summary>
    /// 打开引导弹窗
    /// </summary>
    /// <returns></returns>
    public bool KilnBuzzUsSpear()
    {
        // 判断是否可以打开引导弹窗
        RunoffChoppyStorm config = RunoffChoppyPeat.Equality.RunoffChoppy;
        if (config.gameReviewGuide == null || config.gameReviewGuide.isOpenReviewGuide == 0)
        {
            return false;
        }

        PHUIFaculty.Equality.FordUISleek("BuzzIDSpear");
        return true;
    }
}
