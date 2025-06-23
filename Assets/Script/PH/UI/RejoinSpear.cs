using UnityEngine;
using UnityEngine.UI;

#if Old_UIFramework
public class RejoinSpear : AlgaUISleek
#elif New_UIFramework
public class RejoinSpear : BaseUI
#else
public class RejoinSpear : MonoBehaviour
#endif
{
[UnityEngine.Serialization.FormerlySerializedAs("UpdateBtn")]    public Button RejoinVia;
[UnityEngine.Serialization.FormerlySerializedAs("CloseBtn")]    public Button SpoonVia;
[UnityEngine.Serialization.FormerlySerializedAs("ContentText")]    public Text RawhideTear;

    private string DialogueRye;

    // Start is called before the first frame update
    void Start()
    {
        RejoinVia.onClick.AddListener(() =>
        {
            UpRejoin();
        });

        SpoonVia.onClick.AddListener(() => {
#if Old_UIFramework
            SpoonUITrap(GetType().Name);
#elif New_UIFramework
            UIFaculty.Instance.CloseUI();
#endif
        });
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

        RunoffChoppyStorm config = RunoffChoppyPeat.Equality.RunoffChoppy;
        SpoonVia.gameObject.SetActive(config.appVersionUpdate.updateType == 0);
        if (!string.IsNullOrEmpty(config.appVersionUpdate.updateDesc))
        {
            RawhideTear.text = config.appVersionUpdate.updateDesc;
        }
        DialogueRye = config.appVersionUpdate.appStoreUrl;
    }

    public void UpRejoin()
    {
        Application.OpenURL(DialogueRye);
    }
}
