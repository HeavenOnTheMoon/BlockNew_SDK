using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaveFaculty : RomeEndocrine<WeaveFaculty>
{
    public string Coma;

    public void FordWeave(string info)
    {
        Coma = info;
        UIFaculty.HisEquality().FordUISleek("Weave");
    }
}
