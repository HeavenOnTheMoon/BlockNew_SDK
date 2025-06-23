using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DebugWindow : OdinEditorWindow
{
    [MenuItem("Tools/DebugWindow")]
    private static void OpenWindow()
    {
        GetWindow<DebugWindow>().Show();
    }

    /******************************* UI Panel *******************************/
    [HorizontalGroup("UI Panel", LabelWidth = 100)]
    [InlineButton(nameof(OpenPanel), "打开弹窗")]
    [LabelText("UI Panel名称")]
    public string uiPanelName;
    private void OpenPanel()
    {
        if (!string.IsNullOrEmpty(uiPanelName))
        {
            UIFaculty.HisEquality().FordUISleek(uiPanelName);
        }
    }
   
}
