using System.Collections.Generic;
using System.IO;
using System.Linq;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

public class RenameImage : OdinEditorWindow
{
    [MenuItem("Tools/RenameObj/RenameImage")]
    static void ShowSuperBuildWindow()
    {
        GetWindow(typeof(RenameImage));
    }

    [Title("Image重命名")]
    [ValidateInput("CheckSpace", "字符串不能有空格", InfoMessageType.Warning)]
    public string AddFirstString = "AddFirstString";
    /*[ValidateInput("CheckSpace", "字符串不能有空格", InfoMessageType.Warning)]
    public string AddLastString = "AddLastString";*/
    [ValidateInput("CheckPath", "路径不能为空", InfoMessageType.Warning)]
    [FolderPath(ParentFolder = "$ImageFolderPath")]
    [BoxGroup("Path")]
    public string ImageFolderPath;
    private bool CheckSpace(string value)
    {
        return value.IndexOf(' ') < 0;
    }
    private bool CheckPath(string value)
    {
        return true;
    }

    /*[AssetSelector(Filter = "name t:type l:label")]
    public UnityEngine.Object ImageFilters;*/
    /*[PreviewField(70, ObjectFieldAlignment.Center)]
    public Texture2D SingleObject;*/




    [Button(ButtonSizes.Large), GUIColor(0.4f, 0.8f, 0)]
    private void ClickRenameImage()
    {
        Debug.Log("ClickRenameImageBtn");

        string myfolderPath = ImageFolderPath.Replace("Assets/", "");

        string path = Path.Combine(Application.dataPath, myfolderPath);
        var images = Directory.GetFiles
            (path, ".", SearchOption.AllDirectories).Where(s => s.EndsWith(".png") || s.EndsWith(".jpg"));
        foreach (var i in images)
        {
            string NewPath = GetAssetsPath(i);
            string[] name = NewPath.Split('/');
            string fileName = name[name.Length - 1];
            //string newName = AddFirstString + fileName;
            string newName = fileName.Replace(AddFirstString, "");
            string newPath = NewPath.Replace(fileName, newName);
            AssetDatabase.RenameAsset(NewPath, newName);
        }

        AssetDatabase.Refresh();
        AssetDatabase.SaveAssets();
    }
    static string GetAssetsPath(string path)
    {
        string assetsDir = "Assets"; // Assets 文件夹的路径
        string assetsPath = path.Replace('\\', '/') // 将路径中的反斜杠替换为斜杠
            .Substring(path.IndexOf(assetsDir) + assetsDir.Length); // 截取从 Assets/ 开始的子字符串
        assetsPath = "Assets" + assetsPath;
        return assetsPath; // 返回相对于 Assets 文件夹的路径
    }
    static void SelectedChangeMimMap(bool enabled)
    {

        Object[] textures = GetSelectedTextures();
        Selection.objects = new UnityEngine.Object[0];
        foreach (Texture2D texture in textures)
        {
            string path = AssetDatabase.GetAssetPath(texture);
            TextureImporter textureImporter = AssetImporter.GetAtPath(path) as TextureImporter;
            textureImporter.mipmapEnabled = enabled;
            AssetDatabase.ImportAsset(path);
        }
    }
    static Object[] GetSelectedTextures()
    {
        return Selection.GetFiltered(typeof(Texture2D), SelectionMode.DeepAssets);
    }
    [Button(ButtonSizes.Large), GUIColor(1, 0.2f, 0)]
    private void ClickRemoveName()
    {
        List<string> CurrentName = new List<string>();
        List<string> OldName = new List<string>();

        string myfolderPath = ImageFolderPath.Replace("Assets/", "");

        string path = Path.Combine(Application.dataPath, myfolderPath);
        var images = Directory.GetFiles
            (path, ".", SearchOption.AllDirectories).Where(s => s.EndsWith(".png") || s.EndsWith(".jpg"));

        foreach (var i in images)
        {

            string NewPath = GetAssetsPath(i);
            string[] name = NewPath.Split('/');
            string fileName = name[name.Length - 1];
            var newName = i.Replace(AddFirstString, "");
            //string newName = AddFirstString + fileName;

            string newPath = NewPath.Replace(fileName, newName);
            AssetDatabase.RenameAsset(NewPath, newName);


            /*OldName.Add(i);
            var str = i.Replace(AddFirstString, "");
            CurrentName.Add(str);
            
            Debug.Log($"itss:{str}");*/
        }

        AssetDatabase.Refresh();
        AssetDatabase.SaveAssets();
    }
}


public class RenamePreFab : OdinEditorWindow
{
    [MenuItem("Tools/RenameObj/RenamePrefab")]
    static void ShowSuperBuildWindow()
    {
        GetWindow(typeof(RenamePreFab));
    }

    [Title("Prefab重命名")]
    [ValidateInput("CheckSpace", "字符串不能有空格", InfoMessageType.Warning)]
    public string AddFirstString = "AddFirstString";
    /*[ValidateInput("CheckSpace", "字符串不能有空格", InfoMessageType.Warning)]
    public string AddLastString = "AddLastString";*/
    [ValidateInput("CheckPath", "路径不能为空", InfoMessageType.Warning)]
    [FolderPath(ParentFolder = "$PrefabFolderPath")]
    [BoxGroup("Path")]
    public string PrefabFolderPath;
    private bool CheckSpace(string value)
    {
        return value.IndexOf(' ') < 0;
    }
    /*private bool CheckPath(string value)
    {
        return !value.IsNullOrEmpty();
    }*/

    /*[AssetSelector(Filter = "name t:type l:label")]
    public UnityEngine.Object ImageFilters;*/
    /*[PreviewField(70, ObjectFieldAlignment.Center)]
    public Texture2D SingleObject;*/




    [Button(ButtonSizes.Large), GUIColor(0.4f, 0.8f, 0)]
    private void ClickRenameImage()
    {
        Debug.Log("ClickRenamePrefabBtn");

        string myfolderPath = PrefabFolderPath.Replace("Assets/", "");

        string path = Path.Combine(Application.dataPath, myfolderPath);
        var images = Directory.GetFiles
            (path, ".", SearchOption.AllDirectories).Where(s => s.EndsWith(".prefab"));
        foreach (var i in images)
        {
            string NewPath = GetAssetsPath(i);
            string[] name = NewPath.Split('/');
            string fileName = name[name.Length - 1];
            //string newName = AddFirstString + fileName;
            string newName = fileName.Replace(AddFirstString, "");
            string newPath = NewPath.Replace(fileName, newName);
            AssetDatabase.RenameAsset(NewPath, newName);
        }

        AssetDatabase.Refresh();
        AssetDatabase.SaveAssets();
    }
    static string GetAssetsPath(string path)
    {
        string assetsDir = "Assets"; // Assets 文件夹的路径
        string assetsPath = path.Replace('\\', '/') // 将路径中的反斜杠替换为斜杠
            .Substring(path.IndexOf(assetsDir) + assetsDir.Length); // 截取从 Assets/ 开始的子字符串
        assetsPath = "Assets" + assetsPath;
        return assetsPath; // 返回相对于 Assets 文件夹的路径
    }
    static void SelectedChangeMimMap(bool enabled)
    {

        Object[] textures = GetSelectedTextures();
        Selection.objects = new UnityEngine.Object[0];
        foreach (Texture2D texture in textures)
        {
            string path = AssetDatabase.GetAssetPath(texture);
            TextureImporter textureImporter = AssetImporter.GetAtPath(path) as TextureImporter;
            textureImporter.mipmapEnabled = enabled;
            AssetDatabase.ImportAsset(path);
        }
    }
    static Object[] GetSelectedTextures()
    {
        return Selection.GetFiltered(typeof(Texture2D), SelectionMode.DeepAssets);
    }
    [Button(ButtonSizes.Large), GUIColor(1, 0.2f, 0)]
    private void ClickRemoveName()
    {
        List<string> CurrentName = new List<string>();
        List<string> OldName = new List<string>();

        string myfolderPath = PrefabFolderPath.Replace("Assets/", "");

        string path = Path.Combine(Application.dataPath, myfolderPath);
        var images = Directory.GetFiles
            (path, ".", SearchOption.AllDirectories).Where(s => s.EndsWith(".png") || s.EndsWith(".jpg"));

        foreach (var i in images)
        {

            string NewPath = GetAssetsPath(i);
            string[] name = NewPath.Split('/');
            string fileName = name[name.Length - 1];
            var newName = i.Replace(AddFirstString, "");
            //string newName = AddFirstString + fileName;

            string newPath = NewPath.Replace(fileName, newName);
            AssetDatabase.RenameAsset(NewPath, newName);


            /*OldName.Add(i);
            var str = i.Replace(AddFirstString, "");
            CurrentName.Add(str);
            
            Debug.Log($"itss:{str}");*/
        }

        AssetDatabase.Refresh();
        AssetDatabase.SaveAssets();
    }
}


public class RenameAudio : OdinEditorWindow
{
    [MenuItem("Tools/RenameObj/RenameAudio")]
    static void ShowSuperBuildWindow()
    {
        GetWindow(typeof(RenameAudio));
    }

    [Title("Audio重命名")]
    [ValidateInput("CheckSpace", "字符串不能有空格", InfoMessageType.Warning)]
    public string AddFirstString = "AddFirstString";
    /*[ValidateInput("CheckSpace", "字符串不能有空格", InfoMessageType.Warning)]
    public string AddLastString = "AddLastString";*/
    [ValidateInput("CheckPath", "路径不能为空", InfoMessageType.Warning)]
    [FolderPath(ParentFolder = "$AudioFolderPath")]
    [BoxGroup("Path")]
    public string AudioFolderPath;
    private bool CheckSpace(string value)
    {
        return value.IndexOf(' ') < 0;
    }
    private bool CheckPath(string value)
    {
        return true;
    }

    /*[AssetSelector(Filter = "name t:type l:label")]
    public UnityEngine.Object ImageFilters;*/
    /*[PreviewField(70, ObjectFieldAlignment.Center)]
    public Texture2D SingleObject;*/




    [Button(ButtonSizes.Large), GUIColor(0.4f, 0.8f, 0)]
    private void ClickRenameImage()
    {
        Debug.Log("ClickRenameAudioBtn");

        string myfolderPath = AudioFolderPath.Replace("Assets/", "");

        string path = Path.Combine(Application.dataPath, myfolderPath);
        var images = Directory.GetFiles
            (path, ".", SearchOption.AllDirectories).Where(s => s.EndsWith(".mp3") || s.EndsWith(".wav"));
        foreach (var i in images)
        {
            string NewPath = GetAssetsPath(i);
            string[] name = NewPath.Split('/');
            string fileName = name[name.Length - 1];
            //string newName = AddFirstString + fileName;
            string newName = fileName.Replace(AddFirstString, "");
            string newPath = NewPath.Replace(fileName, newName);
            AssetDatabase.RenameAsset(NewPath, newName);
        }

        AssetDatabase.Refresh();
        AssetDatabase.SaveAssets();
    }
    static string GetAssetsPath(string path)
    {
        string assetsDir = "Assets"; // Assets 文件夹的路径
        string assetsPath = path.Replace('\\', '/') // 将路径中的反斜杠替换为斜杠
            .Substring(path.IndexOf(assetsDir) + assetsDir.Length); // 截取从 Assets/ 开始的子字符串
        assetsPath = "Assets" + assetsPath;
        return assetsPath; // 返回相对于 Assets 文件夹的路径
    }
    static void SelectedChangeMimMap(bool enabled)
    {

        Object[] textures = GetSelectedTextures();
        Selection.objects = new UnityEngine.Object[0];
        foreach (Texture2D texture in textures)
        {
            string path = AssetDatabase.GetAssetPath(texture);
            TextureImporter textureImporter = AssetImporter.GetAtPath(path) as TextureImporter;
            textureImporter.mipmapEnabled = enabled;
            AssetDatabase.ImportAsset(path);
        }
    }
    static Object[] GetSelectedTextures()
    {
        return Selection.GetFiltered(typeof(Texture2D), SelectionMode.DeepAssets);
    }
    [Button(ButtonSizes.Large), GUIColor(1, 0.2f, 0)]
    private void ClickRemoveName()
    {
        List<string> CurrentName = new List<string>();
        List<string> OldName = new List<string>();

        string myfolderPath = AudioFolderPath.Replace("Assets/", "");

        string path = Path.Combine(Application.dataPath, myfolderPath);
        var images = Directory.GetFiles
            (path, ".", SearchOption.AllDirectories).Where(s => s.EndsWith(".png") || s.EndsWith(".jpg"));

        foreach (var i in images)
        {

            string NewPath = GetAssetsPath(i);
            string[] name = NewPath.Split('/');
            string fileName = name[name.Length - 1];
            var newName = i.Replace(AddFirstString, "");
            //string newName = AddFirstString + fileName;

            string newPath = NewPath.Replace(fileName, newName);
            AssetDatabase.RenameAsset(NewPath, newName);


            /*OldName.Add(i);
            var str = i.Replace(AddFirstString, "");
            CurrentName.Add(str);
            
            Debug.Log($"itss:{str}");*/
        }

        AssetDatabase.Refresh();
        AssetDatabase.SaveAssets();
    }
}




public class RenameScripte : OdinEditorWindow
{
    [MenuItem("Tools/RenameObj/RenameScripte")]
    static void ShowSuperBuildWindow()
    {
        GetWindow(typeof(RenameScripte));
    }

    [Title("Audio重命名")]
    [ValidateInput("CheckSpace", "字符串不能有空格", InfoMessageType.Warning)]
    public string AddFirstString = "AddFirstString";
    /*[ValidateInput("CheckSpace", "字符串不能有空格", InfoMessageType.Warning)]
    public string AddLastString = "AddLastString";*/
    [ValidateInput("CheckPath", "路径不能为空", InfoMessageType.Warning)]
    [FolderPath(ParentFolder = "$ScripteFolderPath")]
    [BoxGroup("Path")]
    public string ScripteFolderPath;
    private bool CheckSpace(string value)
    {
        return value.IndexOf(' ') < 0;
    }
    /*private bool CheckPath(string value)
    {
        return !value.IsNullOrEmpty();
    }*/

    /*[AssetSelector(Filter = "name t:type l:label")]
    public UnityEngine.Object ImageFilters;*/
    /*[PreviewField(70, ObjectFieldAlignment.Center)]
    public Texture2D SingleObject;*/




    [Button(ButtonSizes.Large), GUIColor(0.4f, 0.8f, 0)]
    private void ClickRenameScripts()
    {
        Debug.Log("ClickRenameScripteBtn");

        string myfolderPath = ScripteFolderPath.Replace("Assets/", "");

        string path = Path.Combine(Application.dataPath, myfolderPath);
        var images = Directory.GetFiles
            (path, ".", SearchOption.AllDirectories).Where(s => s.EndsWith(".cs"));
        foreach (var i in images)
        {
            string NewPath = GetAssetsPath(i);
            string[] name = NewPath.Split('/');
            string fileName = name[name.Length - 1];
            string newName = AddFirstString + fileName;

            string newPath = NewPath.Replace(fileName, newName);
            AssetDatabase.RenameAsset(NewPath, newName);
        }

        AssetDatabase.Refresh();
        AssetDatabase.SaveAssets();
    }
    static string GetAssetsPath(string path)
    {
        string assetsDir = "Assets"; // Assets 文件夹的路径
        string assetsPath = path.Replace('\\', '/') // 将路径中的反斜杠替换为斜杠
            .Substring(path.IndexOf(assetsDir) + assetsDir.Length); // 截取从 Assets/ 开始的子字符串
        assetsPath = "Assets" + assetsPath;
        return assetsPath; // 返回相对于 Assets 文件夹的路径
    }
    static void SelectedChangeMimMap(bool enabled)
    {

        Object[] textures = GetSelectedTextures();
        Selection.objects = new UnityEngine.Object[0];
        foreach (Texture2D texture in textures)
        {
            string path = AssetDatabase.GetAssetPath(texture);
            TextureImporter textureImporter = AssetImporter.GetAtPath(path) as TextureImporter;
            textureImporter.mipmapEnabled = enabled;
            AssetDatabase.ImportAsset(path);
        }
    }
    static Object[] GetSelectedTextures()
    {
        return Selection.GetFiltered(typeof(Texture2D), SelectionMode.DeepAssets);
    }
    [Button(ButtonSizes.Large), GUIColor(1, 0.2f, 0)]
    private void ClickRemoveName()
    {
        List<string> CurrentName = new List<string>();
        List<string> OldName = new List<string>();

        string myfolderPath = ScripteFolderPath.Replace("Assets/", "");

        string path = Path.Combine(Application.dataPath, myfolderPath);
        var images = Directory.GetFiles
            (path, ".", SearchOption.AllDirectories).Where(s => s.EndsWith(".png") || s.EndsWith(".jpg"));

        foreach (var i in images)
        {

            string NewPath = GetAssetsPath(i);
            string[] name = NewPath.Split('/');
            string fileName = name[name.Length - 1];
            var newName = i.Replace(AddFirstString, "");
            //string newName = AddFirstString + fileName;

            string newPath = NewPath.Replace(fileName, newName);
            AssetDatabase.RenameAsset(NewPath, newName);


            /*OldName.Add(i);
            var str = i.Replace(AddFirstString, "");
            CurrentName.Add(str);
            
            Debug.Log($"itss:{str}");*/
        }

        AssetDatabase.Refresh();
        AssetDatabase.SaveAssets();
    }
}
