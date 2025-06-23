using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LitJson;
using UnityEngine;
using static UnityEditor.Progress;
using Random = UnityEngine.Random;

public class HardyDesignHardyFaculty : MonoBehaviour
{
    public static HardyDesignHardyFaculty Instance;
[UnityEngine.Serialization.FormerlySerializedAs("BlockInfo")]
    public HardyDesignWhenHardy HardyComa;
[UnityEngine.Serialization.FormerlySerializedAs("EasyBlockInfo")]    public HardyDesignWhenHardy FineHardyComa;
[UnityEngine.Serialization.FormerlySerializedAs("ChangeBlock")]    public HardyDesignWhenHardy FactorHardy;
[UnityEngine.Serialization.FormerlySerializedAs("BlockSprites")]
    public List<Sprite> HardyEnclose;
[UnityEngine.Serialization.FormerlySerializedAs("BlockTargetSprites")]    public List<Sprite> HardyCobaltEnclose;
[UnityEngine.Serialization.FormerlySerializedAs("ShowBlockItems")]    public List<BlockItem> FordHardyVogue= new List<BlockItem>();
[UnityEngine.Serialization.FormerlySerializedAs("BlockGroupItems")]    public List<GameObject> HardyGiantVogue= new List<GameObject>();
[UnityEngine.Serialization.FormerlySerializedAs("ColorBlockSprites")]    public List<Sprite> ThingHardyEnclose;
[UnityEngine.Serialization.FormerlySerializedAs("ColorBlockSprites_A")]    public List<Sprite> ThingHardyEnclose_A;

    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        IcelandHardyPoll();

    }

    // Update is called once per frame
    void Update()
    {

    }
    TextAsset Pool;
    TextAsset PoolHue;
    /// <summary>
    /// 重新刷新获取方块组比重
    /// </summary>
    public void IcelandHardyPoll()
    {
        Pool = Resources.Load<TextAsset>("LocationJson/BlockGroupData");
        HardyComa = JsonMapper.ToObject<HardyDesignWhenHardy>(Pool.text);
        FactorHardy = JsonMapper.ToObject<HardyDesignWhenHardy>(Pool.text);
        PoolHue = Resources.Load<TextAsset>("LocationJson/EasyBlockGroupData");
        FineHardyComa = JsonMapper.ToObject<HardyDesignWhenHardy>(PoolHue.text);
    }

    /// <summary>
    /// 生成方块
    /// </summary>
    /// <param name="isAllAdaptation"></param>
    public void CruelHardy(bool isAllAdaptation = false)
    {
        Transform ParTransform;
        
            ParTransform = WhenSpear.Instance.HardyGiantClue.transform;

        Dictionary<FillFourToFour, List<BlockItem>> fillBlocks = null;
        var NextBlock = HardyDesignCrudeFaculty.Instance.HisDirtHardyGiant();
        if (NextBlock.Count == 3)
        {
            FordHardyVogue.Clear();
            for (int i = 0; i < 3; i++)
            {
                HardyComa = JsonMapper.ToObject<HardyDesignWhenHardy>(Pool.text);
                FordHardyVogue.Add(HardyComa.Block[NextBlock[i]]);
                //ConvertOneToTwo(ShowBlockItems[i].shape);
            }
            MobRayHardyGiant();
        }
        else
        {
            HisHardyWell();
            if (isAllAdaptation)
            {
                FordHardyVogue[2] = HardyComa.Block[Random.Range(0,3)];
                FordHardyVogue[1] = HardyComa.Block[Random.Range(0,3)];
                FordHardyVogue[0] = HardyComa.Block[Random.Range(0,3)];
            }
            if (MindGazeFaculty.GetString(CChoppy.Of_PryWhenBoat) == "challenge")
            {
                if (MindGazeFaculty.GetInt(CChoppy.Of_BlissAbsolutelyHardy) - 1 >= 
                    HardyDesignCrudeFaculty.Instance.WriteComaGaze.CrudeGaze[HardyDesignCrudeFaculty.Instance.HisPryCrude()].Adrenaline || 
                    isAllAdaptation)
                {
                    MindGazeFaculty.SetInt(CChoppy.Of_BlissAbsolutelyHardy, 0);
                    fillBlocks = BlissAbsolutelyHardyHue();
                }
            }
            else if (MindGazeFaculty.GetString(CChoppy.Of_PryWhenBoat) == "Guide")
            {
                HisQuiltHardyWell();
            }
            else
            {
                if (MyFoeBlissAbsolutelyHardy() || isAllAdaptation)
                {
                    fillBlocks = BlissAbsolutelyHardyHue();
                }
            }
        }
        IcelandCobaltHardy();
        FordHardyVogue = HardyDesignDeftFaculty.instance.LuxuryName(FordHardyVogue);
        HardyGiantVogue.Clear();
        float DelayTime = 0;
        var needShow = IcelandCompanyScat();
        Debug.Log("needShow == " + needShow);
        for (int i = 0; i < 3; i++)
        {
            if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == 99)
            {
                if (!ScriptPonyFaculty.HisEquality().BrushPony("BlockItem"))
                {
                    ScriptPony pool = ScriptPonyFaculty.HisEquality().RecordScriptPony<ScriptPony>("BlockItem", ParTransform);
                    pool.Cyclic = Resources.Load<GameObject>(CChoppy.View_Hardy);
                }
                BlockColor Upset= (BlockColor)Random.Range(0, 5);
                GameObject Obj = ScriptPonyFaculty.HisEquality().HisWhenScript("BlockItem");
                Obj.GetComponent<HardyDesignHardyGiant>().Bank(FordHardyVogue[i], DelayTime, i, needShow == i, Upset);
                DelayTime += 0.1f;
                HardyGiantVogue.Add(Obj);
            }
            else
            {
                if (!ScriptPonyFaculty.HisEquality().BrushPony("GuideBlockItem"))
                {
                    ScriptPony pool = ScriptPonyFaculty.HisEquality().RecordScriptPony<ScriptPony>("GuideBlockItem", ParTransform);
                    pool.Cyclic = Resources.Load<GameObject>(CChoppy.View_Hardy);
                }
                GameObject Obj = ScriptPonyFaculty.HisEquality().HisWhenScript("GuideBlockItem");
                if (i == 1)
                    Obj.GetComponent<HardyDesignHardyGiant>().Bank(FordHardyVogue[i], DelayTime, i, needShow == i, HardyDesignRouteNovelFaculty.Instance.HisLuxuryThing());
                else
                    Obj.gameObject.SetActive(false);
                
                DelayTime += 0.1f;
                HardyGiantVogue.Add(Obj);
            }
        }
        
        FactorFoeQuery();
        if (isAllAdaptation)
        {
            FactorCruelHardyLethalHue();
        }
        else
            FactorCruelHardyLethal();


        // 空格子上补充现金奖励
        if (fillBlocks != null && fillBlocks.Count > 0)
        {
            foreach (var fillBlock in fillBlocks)
            {
                FillFourToFour key = fillBlock.Key;
                int GradeFrown= key.X * 9 + key.Y;
                int[] smallArray = key.GuestSmite.Cast<int>().ToArray();
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (key.GuestSmite[i, j] == 0)
                        {
                            int diffIndex = i * 9 + j;
                            GameObject block = HardyDesignRouteNovelFaculty.Instance.RouteNovelComa[GradeFrown + diffIndex];
                            block.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().TugMortalWellLuxury();
                        }
                    }
                }
            }
        }
        else
        {
            int currentRewardCount = HardyDesignRouteNovelFaculty.Instance.RouteNovelComa
            .Where(x => x.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().Well == 0 && x.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().GirderWell != 0).Count(); ;
            if (currentRewardCount < WitComaEka.instance.WhenGaze.RewardBlockNumLimit)
            {
                List<GameObject> emptyBlocks = HardyDesignRouteNovelFaculty.Instance.RouteNovelComa
                    .Where(x => x.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().Well == 0 && x.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().GirderWell == 0).ToList();
                List<GameObject> randomList = LuxuryVolt.HisLuxurySquare(emptyBlocks, WitComaEka.instance.WhenGaze.RewardBlockNumLimit - currentRewardCount);
                foreach (var block in randomList)
                {
                    block.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().TugMortalWellLuxury();
                }
            }
        }
    }


    /// <summary>
    /// 回收方块
    /// </summary>
    /// <param name="gameObject"></param>
    public void ClarityHardy(GameObject gameObject)
    {
        if (HardyGiantVogue.Contains(gameObject))
        {
            HardyGiantVogue.Remove(gameObject);
            Destroy(gameObject);
        }
    }

    public void MobRayHardyGiant()
    {
        MindGazeFaculty.SetInt(CChoppy.Of_HardyGiantExtol, 3);
    }
    
    /// <summary>
    /// 放置方块自动生成
    /// </summary>
    public void HomelessMereHardyGiant()
    {
        var count = MindGazeFaculty.GetInt(CChoppy.Of_HardyGiantExtol);
        count--;
        MindGazeFaculty.SetInt(CChoppy.Of_HardyGiantExtol, count);
        if (count == 0)
        {
            CruelHardy();
        }
    }
    
    /// <summary>
    /// 复活生成方块
    /// </summary>
    public void LethalPhrase()
    {
        VirgoHitHardy(); 
        //生成新的方块

        CruelHardy(true);
        HardyDesignWhenOvertime.Instance.WhenLethal?.Invoke();
    }

    /// <summary>
    /// 清除全部方块
    /// </summary>
    public void VirgoHitHardy()
    {
        //清除现有的方块
        for (int i = HardyGiantVogue.Count - 1; i >= 0; i--)
        {
            ClarityHardy(HardyGiantVogue[i]);
        }
    }

    /// <summary>
    /// 刷新出现方块信息
    /// </summary>
    public void HisHardyWell()
    {
        FordHardyVogue.Clear();
        MindGazeFaculty.SetInt(CChoppy.Of_BlissAbsolutelyHardy, MindGazeFaculty.GetInt(CChoppy.Of_BlissAbsolutelyHardy) + 1);
        int SeldomExtol= HardyDesignRouteNovelFaculty.Instance.RouteNovelComa.Count(t => t.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().Well == 0);
        if (SeldomExtol <= WitComaEka.instance.WhenGaze.EmptyBlock)
        {
            //方块出现位置
            for (int i = 0; i < 3; i++)
            {
                FineHardyComa = JsonMapper.ToObject<HardyDesignWhenHardy>(PoolHue.text);
                FordHardyVogue.Add(FineHardyComa.Block[HisDamHardy(FineHardyComa)]);
                //ConvertOneToTwo(ShowBlockItems[i].shape);
            }
        }
        else
        {
            //方块出现位置
            for (int i = 0; i < 3; i++)
            {
                HardyComa = JsonMapper.ToObject<HardyDesignWhenHardy>(Pool.text);
                FordHardyVogue.Add(HardyComa.Block[HisDamHardy(HardyComa)]);
                //ConvertOneToTwo(ShowBlockItems[i].shape);
            }
        }


        MobRayHardyGiant();
    }

    /// <summary>
    /// 引导生成方块
    /// </summary>
    private void HisQuiltHardyWell()
    {
        FordHardyVogue.Clear();
        int blockID = 0;
        switch (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay))
        {
            case 0 : blockID = 2; break;
            case 1: blockID = 30; break;
            case 2: blockID = 9; break;
        }
        FordHardyVogue.Add(HardyComa.Block[blockID]);
        FordHardyVogue.Add(HardyComa.Block[blockID]);
        FordHardyVogue.Add(HardyComa.Block[blockID]);
        MindGazeFaculty.SetInt(CChoppy.Of_HardyGiantExtol, 3);
    }
[UnityEngine.Serialization.FormerlySerializedAs("CheckBoardTarget")]
    public Dictionary<int, int> RouteNovelCobalt= new Dictionary<int, int>();

    /// <summary>
    /// 刷新目标生成逻辑
    /// </summary>
    private void IcelandCobaltHardy()
    {
        if (MindGazeFaculty.GetString(CChoppy.Of_PryWhenBoat) != "challenge")
            return;
        RouteNovelCobalt.Clear();
        for (int i = 2; i < 7; i++)
        {

            int SeldomExtol= HardyDesignRouteNovelFaculty.Instance.RouteNovelComa.Count(t => t.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().Well == i
                                                                                   && t.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().HardyKnife.gameObject.activeSelf);
            if (!RouteNovelCobalt.ContainsKey(i))
            {
                RouteNovelCobalt.Add(i, SeldomExtol);
            }
            else
            {
                RouteNovelCobalt[i] = SeldomExtol;
            }
        }


        int sum = 0;
        foreach (var VARIABLE in RouteNovelCobalt)
        {
            sum += VARIABLE.Value;
        }

        Debug.Log("sum == " + sum);
        //满足条件
        if (sum < WitComaEka.instance.WhenGaze.TargetBlockMaxCount)
        {
            var Cement= Random.Range(1, 4);
            for (int i = 0; i < Cement; i++)
            {

                int randomTwo = Random.Range(1, 101);
                if (sum < WitComaEka.instance.WhenGaze.TargetBlockMinCount)
                    randomTwo = Random.Range(51, 101);
                switch (randomTwo)
                {
                    case <= 50:
                        //不生成带块积木
                        break;
                    case <= 90:
                        //生成一块
                        ArsenicDamUpHue(FordHardyVogue[i].shape);
                        break;
                    default:
                        ArsenicDamUpHue(FordHardyVogue[i].shape);
                        ArsenicDamUpHue(FordHardyVogue[i].shape);
                        break;
                }

            }
        }
    }

    /// <summary>
    /// 修改指定方块组
    /// </summary>
    /// <param name="list"></param>
    private void ArsenicDamUpHue(List<int> list)
    {

        // 找出所有1的索引
        List<int> indicesOfOne = list.Select((value, index) => new{
                value, index
            })
            .Where(x => x.value == 1)
            .Select(x => x.index)
            .ToList();

        // 确保列表中至少有一个1
        if (indicesOfOne.Count > 0)
        {
            // 随机选择一个1的索引
            int randomIndex = indicesOfOne[Random.Range(0, indicesOfOne.Count - 1)];

            // 将选定的1改为2
            list[randomIndex] = HardyDesignCrudeFaculty.Instance.HisLuxuryCobalt();
            //Debug.Log("randomIndex == " + randomIndex + "     2 == " + list[randomIndex]);
        }
    }

    //按照概率获取单个方块
    private int HisDamHardy(HardyDesignWhenHardy block)
    {
        int sum = 0;
        for (int i = 0; i < block.Block.Count; i++)
        {
            sum += block.Block[i].weight;
        }
        int rewardRandom = Random.Range(0, 999);

        float Love= 0;
        for (int i = 0; i < block.Block.Count; i++)
        {
            Love += block.Block[i].weight / (float)sum;
            if (rewardRandom <= Love * 1000)
            {
                return i;
            }
        }
        return 0;
    }

    /// <summary>
    /// 判断生成的方块能否放到棋盘中
    /// </summary>
    public void FactorFoeQuery()
    {
        for (int i = 0; i < HardyGiantVogue.Count; i++)
        {
            if (HardyDesignRouteNovelFaculty.Instance.FactorEarlyQueryHardy(HardyGiantVogue[i].GetComponent<HardyDesignHardyGiant>().HardyComa))
            {
                HardyGiantVogue[i].GetComponent<HardyDesignHardyGiant>().FactorFluteShare(true);
            }
            else
            {
                HardyGiantVogue[i].GetComponent<HardyDesignHardyGiant>().FactorFluteShare(false);
            }
        }
    }

    /// <summary>
    /// 方块生成时判断都能消除
    /// </summary>
    private void FactorCruelHardyLethalHue()
    {
        bool isFailed = false;
        foreach (GameObject t in HardyGiantVogue.Where(t => !t.GetComponent<HardyDesignHardyGiant>().BudgetGiant.blocksRaycasts))
        {
            isFailed = true;
        }
        if (isFailed)
        {
            LethalPhrase();
        }
    }
    
    /// <summary>
    /// 方块生成时判断能否有消除
    /// </summary>
    public void FactorCruelHardyLethal()
    {
        bool isFailed = true;
        foreach (GameObject t in HardyGiantVogue.Where(t => t.GetComponent<HardyDesignHardyGiant>().BudgetGiant.blocksRaycasts))
        {
            isFailed = false;
        }
        if (isFailed)
        {
            for (int i = HardyGiantVogue.Count - 1; i >= 0; i--)
            {
                ClarityHardy(HardyGiantVogue[i]);
            }
            //生成新的方块
            CruelHardy();
        }
    }

    private int RedwingBackupExtolWeedy= 1000;   // 经典模式，积分大于该值，显示bonus

    /// <summary>
    /// 判断是否失败
    /// </summary>
    public void FactorLethal()
    {
        bool isFailed = true;
        for (int i = 0; i < HardyGiantVogue.Count; i++)
        {
            if (HardyGiantVogue[i].GetComponent<HardyDesignHardyGiant>().BudgetGiant.blocksRaycasts)
            {
                isFailed = false;
            }
        }
        if (isFailed)
        {
            LethalBliss();
            /* bool showFail = (!MindGazeFaculty.GetBool(CChoppy.sv_IsRevive) && IsShowRevive()) || !(MindGazeFaculty.GetString(CChoppy.sv_CurGameMode) == "Classic" && MindGazeFaculty.GetInt(CChoppy.sv_CurSourceCount) >= ClassicSourceCountLimit);
             if (showFail)
             {
                 WhenSpear.Instance.LevelSuccess(false, () =>
                 {
                     FailedLogic();
                 });
             }
             else
             {
                 FailedLogic();
             }*/
        }
        else
        {
            HardyDesignWhenOvertime.Instance.WhenLethal?.Invoke();
        }
    }

    /// <summary>
    /// 失败逻辑
    /// </summary>
    private void LethalBliss()
    {
        if (!MindGazeFaculty.GetBool(CChoppy.Of_MyPhrase) && MyFordPhrase())
        {
            // 复活
            UIFaculty.HisEquality().FordUISleek("PhraseSpear");
        }
        else
        {
            StartCoroutine(nameof(WhenRote));
            // 如果经典模式，且积分>=1000，走bonus逻辑
            /*if (MindGazeFaculty.GetString(CChoppy.sv_CurGameMode) == "Classic" && MindGazeFaculty.GetInt(CChoppy.sv_CurSourceCount) >= ClassicSourceCountLimit)
            {
                MindGazeFaculty.SetBool(CChoppy.sv_ClassicBonus, true);
                HardyDesignWhenOvertime.Instance.GameFailed?.Invoke();
            }
            else
            {
                GameFailBlockAni();
            }*/
        }
    }

    IEnumerator WhenRote()
    {
        yield return new WaitForSeconds(1);
        WhenTileHardySun();
    }

    /// <summary>
    /// 复活页面是否显示
    /// </summary>
    /// <returns></returns>
    private bool MyFordPhrase()
    {
        //收集
        if (MindGazeFaculty.GetString(CChoppy.Of_PryWhenBoat) == "challenge")
        {
            int cur = HardyDesignCrudeFaculty.Instance.Cobalt.Sum(variable => int.Parse(variable.Value));
            return (float)cur / HardyDesignCrudeFaculty.Instance.AntCobaltExtol <= 0.5f;
        }
        
        else if (MindGazeFaculty.GetString(CChoppy.Of_PryWhenBoat) == "Guide")
        {
            return false;
        }
        //积分
        else
        {
            return MindGazeFaculty.GetInt(CChoppy.Of_PryBackupExtol) >= RedwingBackupExtolWeedy;
        }
    }

    /// <summary>
    /// 游戏失败动画
    /// </summary>
    public void WhenTileHardySun()
    {
        Debug.LogError("游戏失败。。。");
        HardyDesignWhenOvertime.Instance.Overtime = "";
        HardyDesignRouteNovelFaculty.Instance.IcelandLethalNovel();
        /*FlowerbedGeneralist.GameFaildAni(HardyDesignRouteNovelFaculty.Instance.FailedBlock, () =>
        {
            HardyDesignDeftFaculty.instance.GameFailed();
        });*/
        HardyDesignDeftFaculty.instance.WhenLethal();
    }
    
    /// <summary>
    /// 刮刮卡出现替换逻辑
    /// </summary>
    /// <returns></returns>
    private int IcelandCompanyScat()
    {
        if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenLop) == 0 || BureauVolt.MyRaise())
            return -1;
        int ShowID = -1;
        //场面中不存在刮刮卡
        if (MindGazeFaculty.GetInt(CChoppy.Of_FleetCompanyScat) == 0)
        {
            var count = MindGazeFaculty.GetInt(CChoppy.Of_CompanyScatExtol);
            count++;
            if (count >= WitComaEka.instance.WhenGaze.ScratchInfo.AppearCount)
            {
                MindGazeFaculty.SetInt(CChoppy.Of_FleetCompanyScat, 1);
                count = 0;
                ShowID = Random.Range(0, 3);
            }
            MindGazeFaculty.SetInt(CChoppy.Of_CompanyScatExtol, count);
            return ShowID;
        }
        else
        {
            return -1;
        }

    }

    /// <summary>
    /// 方块补充逻辑
    /// </summary>
    /// <param name="index"></param>
    public void BlissAbsolutelyHardy(int index)
    {
        if (index != 0)
        {
            FactorHardy = JsonMapper.ToObject<HardyDesignWhenHardy>(Pool.text);
            FactorHardy.Block = HardyDesignDeftFaculty.instance.LuxuryName(FactorHardy.Block);
            BlockItem blockItem = new BlockItem();
            //最多只有两个
            if (HardyDesignRouteNovelFaculty.Instance.VirgoComa.Count == 1)
            {
                blockItem = HardyDesignRouteNovelFaculty.Instance.HisHealHardyGiant(HardyDesignRouteNovelFaculty.Instance.VirgoComa[1], null, FactorHardy);
                FordHardyVogue[0] = blockItem;
            }
            else
            {
                blockItem = HardyDesignRouteNovelFaculty.Instance.HisHealHardyGiant(HardyDesignRouteNovelFaculty.Instance.VirgoComa[1], HardyDesignRouteNovelFaculty.Instance.VirgoComa[2], FactorHardy);
                FordHardyVogue[0] = blockItem;
                FactorHardy.Block = HardyDesignDeftFaculty.instance.LuxuryName(FactorHardy.Block);
                blockItem = HardyDesignRouteNovelFaculty.Instance.HisHealHardyGiant(HardyDesignRouteNovelFaculty.Instance.VirgoComa[2], HardyDesignRouteNovelFaculty.Instance.VirgoComa[1], FactorHardy);
                FordHardyVogue[1] = blockItem;
            }
        }
        else
        {
            Debug.LogError("没有消除的");
        }
    }
    
    public Dictionary<FillFourToFour, List<BlockItem>> BlissAbsolutelyHardyHue()
    {
        Dictionary<FillFourToFour, List<BlockItem>> res = new();
        FactorHardy = JsonMapper.ToObject<HardyDesignWhenHardy>(Pool.text);
        FactorHardy.Block = HardyDesignDeftFaculty.instance.LuxuryName(FactorHardy.Block);
        HardyDesignRouteNovelFaculty.Instance.HisHealHardyGiant();

        int Syrup= 0;
        foreach (var FillBlockGroup in HardyDesignRouteNovelFaculty.Instance.HealHardyGiant)
        {
            List<BlockItem> list = new();
            if (FillBlockGroup.Value.Item1 != null)
            {
                if (Syrup <= 2)
                {
                    //Debug.LogError("1 == " + FillBlockGroup.Value.Item1.id + "     xStart == " + FillBlockGroup.Key.X +"    yStart == " + FillBlockGroup.Key.Y);
                    FordHardyVogue[Syrup] = FillBlockGroup.Value.Item1;
                    list.Add(FillBlockGroup.Value.Item1);
                }
                    
                Syrup++;
            }
            if (FillBlockGroup.Value.Item2 != null)
            {

                if (Syrup <= 2)
                {
                    //Debug.LogError("2 == " + FillBlockGroup.Value.Item2.id + "     xStart == " + FillBlockGroup.Key.X +"    yStart == " + FillBlockGroup.Key.Y);
                    FordHardyVogue[Syrup] = FillBlockGroup.Value.Item2;
                    list.Add(FillBlockGroup.Value.Item2);
                }
                    
                Syrup++;
            }
            if (list.Count > 0)
            {
                res.Add(FillBlockGroup.Key, list);
            }
        }
        return res;
    }

    /// <summary>
    /// 挑战模式判断是否走填充逻辑
    /// </summary>
    /// <returns></returns>
    public bool MyFoeBlissAbsolutelyHardy()
    {
        var OnceAdd = MindGazeFaculty.GetInt(CChoppy.Of_PryBackupExtol) / int.Parse(WitComaEka.instance.WhenGaze.OnceSource) + 1;
        var AddWeight = OnceAdd * float.Parse(WitComaEka.instance.WhenGaze.OnceWeight);
        var CurWeight = MindGazeFaculty.GetFloat(CChoppy.Of_ScourBlissAbsolutelyHardy);
        //Debug.LogError("CurWeight == "+ CurWeight + "      OnceAdd == " + OnceAdd + "      AddWeight == "+ AddWeight);
        switch (CurWeight)
        {
            case < 1:
                CurWeight += AddWeight;
                MindGazeFaculty.SetFloat(CChoppy.Of_ScourBlissAbsolutelyHardy, CurWeight);
                return true;
                break;
            case >= 1 and < 2:
                CurWeight -= 1;
                MindGazeFaculty.SetFloat(CChoppy.Of_ScourBlissAbsolutelyHardy, CurWeight);
                break;
            default:
                CurWeight -= 1;
                break;
        }
        MindGazeFaculty.SetFloat(CChoppy.Of_ScourBlissAbsolutelyHardy, CurWeight);
        
        return false;
    }
}


public enum BlockColor
{
    Blue,
    Orange,
    Purple,
    Red,
    Green
}
