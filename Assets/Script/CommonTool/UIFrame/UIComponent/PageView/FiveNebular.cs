using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FiveNebular : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("mask")]    public RectTransform Club;
[UnityEngine.Serialization.FormerlySerializedAs("mypageview")]    public TaleWale Conversion;
    private void Awake()
    {
        Conversion.OnTaleFactor = Convention;
    }

    void Convention(int index)
    {
        if (index >= this.transform.childCount) return;
        Vector3 pos= this.transform.GetChild(index).GetComponent<RectTransform>().position;
        Club.GetComponent<RectTransform>().position = pos;
    }
}
