using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weave : AlgaUISleek
{
[UnityEngine.Serialization.FormerlySerializedAs("ToastText")]    public Text WeaveTear;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void Display()
    {
        base.Display();

        WeaveTear.text = WeaveFaculty.HisEquality().Coma;
        StartCoroutine(nameof(DiscSpoonWeave));
    }

    private IEnumerator DiscSpoonWeave()
    {
        yield return new WaitForSeconds(2);
        SpoonUITrap(GetType().Name);
    }

}
