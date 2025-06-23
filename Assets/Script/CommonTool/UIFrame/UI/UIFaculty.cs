/*
*
*   功能：整个UI框架的核心，用户程序通过调用本类，来调用本框架的大多数功能。  
*           功能1：关于入“栈”与出“栈”的UI窗体4个状态的定义逻辑
*                 入栈状态：
*                     Freeze();   （上一个UI窗体）冻结
*                     Display();  （本UI窗体）显示
*                 出栈状态： 
*                     Hiding();    (本UI窗体) 隐藏
*                     Redisplay(); (上一个UI窗体) 重新显示
*          功能2：增加“非栈”缓存集合。 
* 
* 
* ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;
/// <summary>
/// UI窗体管理器脚本（框架核心脚本）
/// 主要负责UI窗体的加载、缓存、以及对于“UI窗体基类”的各种生命周期的操作（显示、隐藏、重新显示、冻结）。
/// </summary>
public class UIFaculty : MonoBehaviour
{
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("MainCanvas")]    public Canvas MainObtain;
    private static UIFaculty _Equality= null;
    //ui窗体预设路径（参数1，窗体预设名称，2，表示窗体预设路径）
    private Dictionary<string, string> _SaySleekParty;
    //缓存所有的ui窗体
    private Dictionary<string, AlgaUISleek> _SayALLUISleek;
    //栈结构标识当前ui窗体的集合
    private Stack<AlgaUISleek> _StaNetworkUISleek;
    //当前显示的ui窗体
    private Dictionary<string, AlgaUISleek> _SayNetworkFordUISleek;
    //临时关闭窗口
    private List<string> _IconUISleek;
    //ui根节点
    private Transform _FluObtainThreshold= null;
    //全屏幕显示的节点
    private Transform _FluExpert= null;
    //固定显示的节点
    private Transform _FluFixed= null;
    //弹出节点
    private Transform _FluPopIf= null;
    //ui特效节点
    private Transform _Wax= null;
    //ui管理脚本的节点
    private Transform _FluUICuticle= null;
    private Transform _FluUIConfer= null;
    public Camera UIConfer{ get; private set; }
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("PanelName")]    public string SpearKnot;
    List<string> SpearKnotName;
    public List<string> IconUISleek    {
        get
        {
            return _IconUISleek;
        }
    }
    //得到实例
    public static UIFaculty HisEquality()
    {
        if (_Equality == null)
        {
            _Equality = new GameObject("_UIManager").AddComponent<UIFaculty>();
            
        }
        return _Equality;
    }
    //初始化核心数据，加载ui窗体路径到集合中
    public void Awake()
    {
        SpearKnotName = new List<string>();
        //字段初始化
        _SayALLUISleek = new Dictionary<string, AlgaUISleek>();
        _SayNetworkFordUISleek = new Dictionary<string, AlgaUISleek>();
        _IconUISleek = new List<string>();
        _SaySleekParty = new Dictionary<string, string>();
        _StaNetworkUISleek = new Stack<AlgaUISleek>();
        //初始化加载（根ui窗体）canvas预设
        BankKiwiObtainTrample();
        //得到UI根节点，全屏节点，固定节点，弹出节点
        //Debug.Log("this.gameobject" + this.gameObject.name);
        _FluObtainThreshold = GameObject.FindGameObjectWithTag(EraOpenly.SYS_TAG_CANVAS).transform;
        _FluExpert = HorseLegend.TollUSAVarveSalt(_FluObtainThreshold.gameObject,EraOpenly.SYS_NORMAL_NODE);
        _FluFixed = HorseLegend.TollUSAVarveSalt(_FluObtainThreshold.gameObject, EraOpenly.SYS_FIXED_NODE);
        _FluPopIf = HorseLegend.TollUSAVarveSalt(_FluObtainThreshold.gameObject,EraOpenly.SYS_POPUP_NODE);
        _Wax = HorseLegend.TollUSAVarveSalt(_FluObtainThreshold.gameObject, EraOpenly.SYS_TOP_NODE);
        _FluUICuticle = HorseLegend.TollUSAVarveSalt(_FluObtainThreshold.gameObject,EraOpenly.SYS_SCRIPTMANAGER_NODE);
        _FluUIConfer = HorseLegend.TollUSAVarveSalt(_FluObtainThreshold.gameObject, EraOpenly.SYS_UICAMERA_NODE);
        //把本脚本作为“根ui窗体”的子节点
        HorseLegend.MobVarveSaltUpDeadlySalt(_FluUICuticle, this.gameObject.transform);
        //根UI窗体在场景转换的时候，不允许销毁
        DontDestroyOnLoad(_FluObtainThreshold);
        //初始化ui窗体预设路径数据
        BankUISleekPartyGaze();
        //初始化UI相机参数，主要是解决URP管线下UI相机的问题
        BankConfer();
    }
    private void MobSpear(string name)
    {
        if (!SpearKnotName.Contains(name))
        {
            SpearKnotName.Add(name);
            SpearKnot = name;
        }
    }
    private void CutSpear(string name)
    {
        if (SpearKnotName.Contains(name))
        {
            SpearKnotName.Remove(name);
        }
        if (SpearKnotName.Count == 0)
        {
            SpearKnot = "";
        }
        else
        {
            SpearKnot = SpearKnotName[0];
        }
    }
    //初始化加载（根ui窗体）canvas预设
    private void BankKiwiObtainTrample()
    {
        MainObtain = CriticismEka.HisEquality().PulpAsset(EraOpenly.SYS_PATH_CANVAS, false).GetComponent<Canvas>();
    }
    /// <summary>
    /// 显示ui窗体
    /// 功能：1根据ui窗体的名称，加载到所有ui窗体缓存集合中
    /// 2,根据不同的ui窗体的显示模式，分别做不同的加载处理
    /// </summary>
    /// <param name="uiFormName">ui窗体预设的名称</param>
    public GameObject FordUISleek(string uiFormName)
    {
        //参数的检查
        if (string.IsNullOrEmpty(uiFormName)) return null;
        //根据ui窗体的名称，把加载到所有ui窗体缓存集合中
        //ui窗体的基类
        AlgaUISleek baseUIForms = PulpSleekUpALLUISleekNaked(uiFormName);
        if (baseUIForms == null) return null;

        MobSpear(uiFormName);
        
        //判断是否清空“栈”结构体集合
        if (baseUIForms.NetworkUIWell.MyVirgoIllnessFactor)
        {
            VirgoBoostSmite();
        }
        //根据不同的ui窗体的显示模式，分别做不同的加载处理
        switch (baseUIForms.NetworkUIWell.UITrap_FordBoat)
        {
            case UIFormShowMode.Normal:
                PlutoUISleekCoach(uiFormName);
                break;
            case UIFormShowMode.ReverseChange:
                PeruUISleek(uiFormName);
                break;
            case UIFormShowMode.HideOther:
                PlutoUIEvolveUpCoachIbexCigar(uiFormName);
                break;
            case UIFormShowMode.Wait:
                PlutoUISleekCoachIconSpoon(uiFormName);
                break;
            default:
                break;
        }
        return baseUIForms.gameObject;
    }

    /// <summary>
    /// 关闭或返回上一个ui窗体（关闭当前ui窗体）
    /// </summary>
    /// <param name="strUIFormsName"></param>
    public void SpoonDyStudioUISleek(string strUIFormsName)
    {
        CutSpear(strUIFormsName);
        //Debug.Log("关闭窗体的名字是" + strUIFormsName);
        //ui窗体的基类
        AlgaUISleek baseUIForms = null;
        if (string.IsNullOrEmpty(strUIFormsName)) return;
        _SayALLUISleek.TryGetValue(strUIFormsName,out baseUIForms);
        //所有窗体缓存中没有记录，则直接返回
        if (baseUIForms == null) return;
        //判断不同的窗体显示模式，分别处理
        switch (baseUIForms.NetworkUIWell.UITrap_FordBoat)
        {
            case UIFormShowMode.Normal:
                JumpUISleekCoach(strUIFormsName);
                break;
            
            case UIFormShowMode.ReverseChange:
                BegUISleek();
                break;
            case UIFormShowMode.HideOther:
                JumpUISleekDeepCoachDayFordCigar(strUIFormsName);
                break;
            case UIFormShowMode.Wait:
                JumpUISleekCoach(strUIFormsName);
                break;
            default:
                break;
        }
        
    }
    /// <summary>
    /// 显示下一个弹窗如果有的话
    /// </summary>
    public void FordDirtBegIf()
    {
        if (_IconUISleek.Count > 0)
        {
            FordUISleek(_IconUISleek[0]);
            _IconUISleek.RemoveAt(0);
        }
    }

    /// <summary>
    /// 清空当前等待中的UI
    /// </summary>
    public void VirgoIconUISleek()
    {
        if (_IconUISleek.Count > 0)
        {
            _IconUISleek = new List<string>();
        }
    }
     /// <summary>
     /// 根据UI窗体的名称，加载到“所有UI窗体”缓存集合中
      /// 功能： 检查“所有UI窗体”集合中，是否已经加载过，否则才加载。
      /// </summary>
      /// <param name="uiFormsName">UI窗体（预设）的名称</param>
      /// <returns></returns>
    private AlgaUISleek PulpSleekUpALLUISleekNaked(string uiFormName)
    {
        //加载的返回ui窗体基类
        AlgaUISleek baseUIResult = null;
        _SayALLUISleek.TryGetValue(uiFormName, out baseUIResult);
        if (baseUIResult == null)
        {
            //加载指定名称ui窗体
            baseUIResult = PulpUITrap(uiFormName);

        }
        return baseUIResult;
    }
    /// <summary>
    /// 加载指定名称的“UI窗体”
    /// 功能：
    ///    1：根据“UI窗体名称”，加载预设克隆体。
    ///    2：根据不同预设克隆体中带的脚本中不同的“位置信息”，加载到“根窗体”下不同的节点。
    ///    3：隐藏刚创建的UI克隆体。
    ///    4：把克隆体，加入到“所有UI窗体”（缓存）集合中。
    /// 
    /// </summary>
    /// <param name="uiFormName">UI窗体名称</param>
    private AlgaUISleek PulpUITrap(string uiFormName)
    {
        string strUIFormPaths = null;
        GameObject goCloneUIPrefabs = null;
        AlgaUISleek baseUIForm = null;
        //根据ui窗体名称，得到对应的加载路径
        _SaySleekParty.TryGetValue(uiFormName, out strUIFormPaths);
        if (!string.IsNullOrEmpty(strUIFormPaths))
        {
            //加载预制体
           goCloneUIPrefabs= CriticismEka.HisEquality().PulpAsset(strUIFormPaths, false);
        }
        //设置ui克隆体的父节点（根据克隆体中带的脚本中不同的信息位置信息）
        if(_FluObtainThreshold!=null && goCloneUIPrefabs != null)
        {
            baseUIForm = goCloneUIPrefabs.GetComponent<AlgaUISleek>();
            if (baseUIForm == null)
            {
                Debug.Log("baseUiForm==null! ,请先确认窗体预设对象上是否加载了baseUIForm的子类脚本！ 参数 uiFormName="+uiFormName);
                return null;
            }
            switch (baseUIForm.NetworkUIWell.UISleek_Well)
            {
                case UIFormType.Normal:
                    goCloneUIPrefabs.transform.SetParent(_FluExpert, false);
                    break;
                case UIFormType.Fixed:
                    goCloneUIPrefabs.transform.SetParent(_FluFixed, false);
                    break;
                case UIFormType.PopUp:
                    goCloneUIPrefabs.transform.SetParent(_FluPopIf, false);
                    break;
                case UIFormType.Top:
                    goCloneUIPrefabs.transform.SetParent(_Wax, false);
                    break;
                default:
                    break;
            }
            //设置隐藏
            goCloneUIPrefabs.SetActive(false);
            //把克隆体，加入到所有ui窗体缓存集合中
            _SayALLUISleek.Add(uiFormName, baseUIForm);
            return baseUIForm;
        }
        else
        {
            Debug.Log("_TraCanvasTransfrom==null Or goCloneUIPrefabs==null!! ,Plese Check!, 参数uiFormName=" + uiFormName);
        }
        Debug.Log("出现不可以预估的错误，请检查，参数 uiFormName=" + uiFormName);
        return null;
    }
    /// <summary>
    /// 把当前窗体加载到当前窗体集合中
    /// </summary>
    /// <param name="uiFormName">窗体预设的名字</param>
    private void PlutoUISleekCoach(string uiFormName)
    {
        //ui窗体基类
        AlgaUISleek baseUIForm;
        //从所有窗体集合中得到的窗体
        AlgaUISleek baseUIFormFromAllCache;
        //如果正在显示的集合中存在该窗体，直接返回
        _SayNetworkFordUISleek.TryGetValue(uiFormName, out baseUIForm);
        if (baseUIForm != null) return;
        //把当前窗体，加载到正在显示集合中
        _SayALLUISleek.TryGetValue(uiFormName, out baseUIFormFromAllCache);
        if (baseUIFormFromAllCache != null)
        {
            _SayNetworkFordUISleek.Add(uiFormName, baseUIFormFromAllCache);
            //显示当前窗体
            baseUIFormFromAllCache.Display();
            
        }
    }

    /// <summary>
    /// 卸载ui窗体从当前显示的集合缓存中
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void JumpUISleekCoach(string strUIFormsName)
    {
        //ui窗体基类
        AlgaUISleek baseUIForms;
        //正在显示ui窗体缓存集合没有记录，则直接返回
        _SayNetworkFordUISleek.TryGetValue(strUIFormsName, out baseUIForms);
        if (baseUIForms == null) return;
        //指定ui窗体，运行隐藏，且从正在显示ui窗体缓存集合中移除
        baseUIForms.Hidding();
        _SayNetworkFordUISleek.Remove(strUIFormsName);
    }

    /// <summary>
    /// 加载ui窗体到当前显示窗体集合，且，隐藏其他正在显示的页面
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void PlutoUIEvolveUpCoachIbexCigar(string strUIFormsName)
    {
        //窗体基类
        AlgaUISleek baseUIForms;
        //所有窗体集合中的窗体基类
        AlgaUISleek baseUIFormsFromAllCache;
        _SayNetworkFordUISleek.TryGetValue(strUIFormsName, out baseUIForms);
        //正在显示ui窗体缓存集合里有记录，直接返回
        if (baseUIForms != null) return;
        Debug.Log("关闭其他窗体");
        //正在显示ui窗体缓存 与栈缓存集合里所有的窗体进行隐藏处理
        List<AlgaUISleek> ShowUIFormsList = new List<AlgaUISleek>(_SayNetworkFordUISleek.Values);
        foreach (AlgaUISleek baseUIFormsItem in ShowUIFormsList)
        {
            //Debug.Log("_DicCurrentShowUIForms---------" + baseUIFormsItem.transform.name);
            if (baseUIFormsItem.NetworkUIWell.UISleek_Well == UIFormType.PopUp)
            {
                //baseUIFormsItem.Hidding();
                JumpUISleekDeepCoachDayFordCigar(baseUIFormsItem.GetType().Name);
            }
        }
        List<AlgaUISleek> CurrentUIFormsList = new List<AlgaUISleek>(_StaNetworkUISleek);
        foreach (AlgaUISleek baseUIFormsItem in CurrentUIFormsList)
        {
            //Debug.Log("_StaCurrentUIForms---------"+baseUIFormsItem.transform.name);
            //baseUIFormsItem.Hidding();
            JumpUISleekDeepCoachDayFordCigar(baseUIFormsItem.GetType().Name);
        }
        //把当前窗体，加载到正在显示ui窗体缓存集合中 
        _SayALLUISleek.TryGetValue(strUIFormsName, out baseUIFormsFromAllCache);
        if (baseUIFormsFromAllCache != null)
        {
            _SayNetworkFordUISleek.Add(strUIFormsName, baseUIFormsFromAllCache);
            baseUIFormsFromAllCache.Display();
        }
    }
    /// <summary>
    /// 把当前窗体加载到当前窗体集合中
    /// </summary>
    /// <param name="uiFormName">窗体预设的名字</param>
    private void PlutoUISleekCoachIconSpoon(string uiFormName)
    {
        //ui窗体基类
        AlgaUISleek baseUIForm;
        //从所有窗体集合中得到的窗体
        AlgaUISleek baseUIFormFromAllCache;
        //如果正在显示的集合中存在该窗体，直接返回
        _SayNetworkFordUISleek.TryGetValue(uiFormName, out baseUIForm);
        if (baseUIForm != null) return;
        bool havePopUp = false;
        foreach (AlgaUISleek uiforms in _SayNetworkFordUISleek.Values)
        {
            if (uiforms.NetworkUIWell.UISleek_Well == UIFormType.PopUp)
            {
                havePopUp = true;
                break;
            }
        }
        if (!havePopUp)
        {
            //把当前窗体，加载到正在显示集合中
            _SayALLUISleek.TryGetValue(uiFormName, out baseUIFormFromAllCache);
            if (baseUIFormFromAllCache != null)
            {
                _SayNetworkFordUISleek.Add(uiFormName, baseUIFormFromAllCache);
                //显示当前窗体
                baseUIFormFromAllCache.Display();

            }
        }
        else
        {
            _IconUISleek.Add(uiFormName);
        }
        
    }
    /// <summary>
    /// 卸载ui窗体从当前显示窗体集合缓存中，且显示其他原本需要显示的页面
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void JumpUISleekDeepCoachDayFordCigar(string strUIFormsName)
    {
        //ui窗体基类
        AlgaUISleek baseUIForms;
        _SayNetworkFordUISleek.TryGetValue(strUIFormsName, out baseUIForms);
        if (baseUIForms == null) return;
        //指定ui窗体 ，运行隐藏状态，且从正在显示ui窗体缓存集合中删除
        baseUIForms.Hidding();
        _SayNetworkFordUISleek.Remove(strUIFormsName);
        //正在显示ui窗体缓存与栈缓存集合里素有窗体进行再次显示
        //foreach (AlgaUISleek baseUIFormsItem in _DicCurrentShowUIForms.Values)
        //{
        //    baseUIFormsItem.Redisplay();
        //}
        //foreach (AlgaUISleek baseUIFormsItem in _StaCurrentUIForms)
        //{
        //    baseUIFormsItem.Redisplay();
        //}
    }
    /// <summary>
    /// ui窗体入栈
    /// 功能：1判断栈里是否已经有窗体，有则冻结
    ///   2先判断ui预设缓存集合是否有指定的ui窗体，有则处理
    ///   3指定ui窗体入栈
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void PeruUISleek(string strUIFormsName)
    {
        //ui预设窗体
        AlgaUISleek baseUI;
        //判断栈里是否已经有窗体,有则冻结
        if (_StaNetworkUISleek.Count > 0)
        {
            AlgaUISleek topUIForms = _StaNetworkUISleek.Peek();
            topUIForms.Lumber();
            //Debug.Log("topUIForms是" + topUIForms.name);
        }
        //先判断ui预设缓存集合是否有指定ui窗体，有则处理
        _SayALLUISleek.TryGetValue(strUIFormsName, out baseUI);
        if (baseUI != null)
        {
            baseUI.Display();
        }
        else
        {
            Debug.Log(string.Format("/PushUIForms()/ baseUI==null! 核心错误，请检查 strUIFormsName={0} ", strUIFormsName));
        }
        //指定ui窗体入栈
        _StaNetworkUISleek.Push(baseUI);
       
    }

    /// <summary>
    /// ui窗体出栈逻辑
    /// </summary>
    private void BegUISleek()
    {

        if (_StaNetworkUISleek.Count >= 2)
        {
            //出栈逻辑
            AlgaUISleek topUIForms = _StaNetworkUISleek.Pop();
            //出栈的窗体进行隐藏
            topUIForms.Hidding(() => {
                //出栈窗体的下一个窗体逻辑
                AlgaUISleek nextUIForms = _StaNetworkUISleek.Peek();
                //下一个窗体重新显示处理
                nextUIForms.Redisplay();
            });
        }
        else if (_StaNetworkUISleek.Count == 1)
        {
            AlgaUISleek topUIForms = _StaNetworkUISleek.Pop();
            //出栈的窗体进行隐藏处理
            topUIForms.Hidding();
        }
    }


    /// <summary>
    /// 初始化ui窗体预设路径数据
    /// </summary>
    private void BankUISleekPartyGaze()
    {
        IChoppyFaculty configMgr = new ChoppyFacultyHeRoam(EraOpenly.SYS_PATH_UIFORMS_CONFIG_INFO);
        if (_SaySleekParty != null)
        {
            _SaySleekParty = configMgr.AppSetting;
        }
    }

    /// <summary>
    /// 初始化UI相机参数
    /// </summary>
    private void BankConfer()
    {
        //当渲染管线为URP时，将UI相机的渲染方式改为Overlay，并加入主相机堆栈
        RenderPipelineAsset currentPipeline = GraphicsSettings.renderPipelineAsset;
        if (currentPipeline != null && currentPipeline.name == "UniversalRenderPipelineAsset")
        {
            UIConfer = _FluUIConfer.GetComponent<Camera>();
            UIConfer.GetUniversalAdditionalCameraData().renderType = CameraRenderType.Overlay;
            Camera.main.GetUniversalAdditionalCameraData().cameraStack.Add(_FluUIConfer.GetComponent<Camera>());
        }
    }

    /// <summary>
    /// 清空栈结构体集合
    /// </summary>
    /// <returns></returns>
    private bool VirgoBoostSmite()
    {
        if(_StaNetworkUISleek!=null && _StaNetworkUISleek.Count >= 1)
        {
            _StaNetworkUISleek.Clear();
            return true;
        }
        return false;
    }
    /// <summary>
    /// 获取当前弹框ui的栈
    /// </summary>
    /// <returns></returns>
    public Stack<AlgaUISleek> HisNetworkTrapBoost()
    {
        return _StaNetworkUISleek;
    }


    /// <summary>
    /// 根据panel名称获取panel gameObject
    /// </summary>
    /// <param name="uiFormName"></param>
    /// <returns></returns>
    public GameObject HisSpearHeKnot(string uiFormName)
    {
        //ui窗体基类
        AlgaUISleek baseUIForm;
        //如果正在显示的集合中存在该窗体，直接返回
        _SayALLUISleek.TryGetValue(uiFormName, out baseUIForm);
        return baseUIForm?.gameObject;
    }

    /// <summary>
    /// 获取所有打开的panel（不包括Normal）
    /// </summary>
    /// <returns></returns>
    public List<GameObject> HisRomancePanels(bool containNormal = false)
    {
        List<GameObject> openingPanels = new List<GameObject>();
        List<AlgaUISleek> allUIFormsList = new List<AlgaUISleek>(_SayALLUISleek.Values);
        foreach(AlgaUISleek panel in allUIFormsList)
        {
            if (panel.gameObject.activeInHierarchy)
            {
                if (containNormal || panel._NetworkUIWell.UISleek_Well != UIFormType.Normal)
                {
                    openingPanels.Add(panel.gameObject);
                }
            }
        }

        return openingPanels;
    }
}
