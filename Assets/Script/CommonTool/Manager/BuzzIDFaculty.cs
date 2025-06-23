using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuzzIDFaculty : MonoBehaviour
{
    public static BuzzIDFaculty instance;
[UnityEngine.Serialization.FormerlySerializedAs("appid")]
    public string Inner;

    private void Awake()
    {
        instance = this;
    }

    public void KilnAPTedTethys()
    {
#if UNITY_ANDROID
        Application.OpenURL("market://details?id=" + appid);
#endif
#if UNITY_IOS
        var Fox= string.Format(
            "itms-apps://itunes.apple.com/cn/app/id{0}?mt=8&action=write-review",
            Inner);
        Application.OpenURL(Fox);
#endif
    }
}
