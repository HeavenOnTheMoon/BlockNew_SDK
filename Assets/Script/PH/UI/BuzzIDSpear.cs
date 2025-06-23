using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#if Old_UIFramework
public class BuzzIDSpear : AlgaUISleek
#elif New_UIFramework
public class BuzzIDSpear : BaseUI
#else
public class BuzzIDSpear : MonoBehaviour
#endif
{
[UnityEngine.Serialization.FormerlySerializedAs("Stars")]    public Button[] Quilt;
[UnityEngine.Serialization.FormerlySerializedAs("star1Sprite")]    public Sprite Berg1Silent;
[UnityEngine.Serialization.FormerlySerializedAs("star2Sprite")]    public Sprite Berg2Silent;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Button star in Quilt)
        {
            star.onClick.AddListener(() =>
            {
                string indexStr = System.Text.RegularExpressions.Regex.Replace(star.gameObject.name, @"[^0-9]+", "");
                int Syrup= indexStr == "" ? 0 : int.Parse(indexStr);
                ShoreSewer(Syrup);
            });
        }

    }

#if Old_UIFramework
    public override void Display()
    {
        base.Display();
#elif New_UIFramework
    public void Show()
    {
        base.Show();
#else
    public void Display()
    {
#endif
        for (int i = 0; i < 5; i++)
        {
            Quilt[i].gameObject.GetComponent<Image>().sprite = Berg2Silent;
        }
    }

    private void KilnOilAtTethys()
    {
        RunoffChoppyStorm config = RunoffChoppyPeat.Equality.RunoffChoppy;
        string appStoreUrl = config.appVersionUpdate.appStoreUrl;
        Application.OpenURL(appStoreUrl);
    }

    private void ShoreSewer(int index)
    {
        for (int i = 0; i < 5; i++)
        {
            Quilt[i].gameObject.GetComponent<Image>().sprite = i <= index ? Berg1Silent : Berg2Silent;
        }
        
        if (index < 3)
        {
            StartCoroutine(SpoonSpear());
        }
        else
        {
            // 跳转到应用商店
            KilnOilAtTethys();
            StartCoroutine(SpoonSpear());
        }
    }

    IEnumerator SpoonSpear(float waitTime = 0.5f)
    {
        yield return new WaitForSeconds(waitTime);
#if Old_UIFramework
        SpoonUITrap(GetType().Name);
#elif New_UIFramework
        UIFaculty.Instance.CloseUI();
#endif
    }
}
