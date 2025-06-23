using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Spine.Unity;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class HardyDesignRouteNovelFaculty : MonoBehaviour
{
    public static HardyDesignRouteNovelFaculty Instance;
[UnityEngine.Serialization.FormerlySerializedAs("CheckBoardInfo")]
    //统计棋盘UI
    public List<GameObject> RouteNovelComa;
[UnityEngine.Serialization.FormerlySerializedAs("TotalCheckBoard")]
    public int[,] EarlyRouteNovel= new int[9, 9];
[UnityEngine.Serialization.FormerlySerializedAs("PromptCheckBoard")]    public int[,] SweatyRouteNovel= new int[9, 9];
[UnityEngine.Serialization.FormerlySerializedAs("ChangeDistance")]
    public float FactorBlackout;


    void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #if UNITY_EDITOR
        if (Input.GetKeyDown(KeyCode.S))
        {
            //FlowerbedGeneralist.LevelOver(WhenSpear.Instance.transform);
            MindGazeFaculty.SetString(CChoppy.Of_MarketShare, "success");
            // 游戏胜利动画
            WhenSpear.Instance.HardyGiantClue.GetComponent<CanvasGroup>().DOFade(0, 0.3f);
            WhenSpear.Instance.DomainMud.GetComponent<CanvasGroup>().DOFade(0, 0.3f);
            //WhenSpear.Instance.Dolphin.SetActive(true);
            //WhenSpear.Instance.Dolphin.GetComponent<Dolphin>().PinballShow();
            HardyDesignRouteNovelFaculty.Instance.FordWinSun(() =>
            {
                UIFaculty.HisEquality().FordUISleek("MarketSpear");
                HardyDesignDeftFaculty.instance.WhenIceberg();
                //HardyDesignCrudeFaculty.Instance.AddLevel();
                HardyDesignCrudeFaculty.Instance.HisPryCrudeComa();
                HardyDesignCrudeFaculty.Instance.BankCobalt();
            });
            //UIFaculty.GetInstance().ShowUIForms("MarketSpear");
            
        }
        #endif
        
    }
    
    //初始化棋盘信息Block
    public void IcelandRouteNovel(GameObject CheckBoardGroup)
    {
        RouteNovelComa.Clear();
        if (RouteNovelComa.Count == 0)
        {
            for (int i = 0; i < EarlyRouteNovel.GetLength(0); i++)
            {
                for (int j = 0; j < EarlyRouteNovel.GetLength(1); j++)
                {
                    EarlyRouteNovel[i, j] = 0;
                }
            }

            BlockColor Upset= HisLuxuryThing();
            int guideRule = MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay);
            for (int i = 0; i < CheckBoardGroup.transform.childCount; i++)
            {
                if (guideRule == 2)
                {
                    if (i % 9 == 4 || i % 9 == 5)
                    {
                        Upset = BlockColor.Orange;
                    }
                    else
                    {
                        Upset = BlockColor.Purple;
                    }
                }
                CheckBoardGroup.transform.GetChild(i).transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().Bank(i / 9, i % 9, 
                    HardyDesignCrudeFaculty.Instance.PryCrudeComa[i], Upset);
                if (HardyDesignCrudeFaculty.Instance.PryCrudeComa[i] != 0)
                {
                    if (HardyDesignCrudeFaculty.Instance.PryCrudeComa[i] == -1)
                        EarlyRouteNovel[i / 9, i % 9] = -1;
                    else
                        EarlyRouteNovel[i / 9, i % 9] = 1;
                }
                RouteNovelComa.Add(CheckBoardGroup.transform.GetChild(i).gameObject);
            }
        }
    }

    public BlockColor HisLuxuryThing()
    {
        BlockColor Upset;
        int guideRule = MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay);
        if (guideRule == 99)
        {
            Upset = (BlockColor)Random.Range(0, 5);
        }
        else if (guideRule == 0)
        {
            Upset = BlockColor.Red;
        }
        else if (guideRule == 1)
        {
            Upset = BlockColor.Blue;
        }
        else
        {
            Upset = BlockColor.Green;
        }
        return Upset;
    }

    public void NebularEnforceHardy(bool isShow)
    {
        if (isShow)
        {
            foreach (var UPPER in FactorAlgaHardy)
            {
                UPPER.Key.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().FordChorus(true, UPPER.Value, HisHardyThing());
            }
        }
        else
        {
            for (int j = 0; j < RouteNovelComa.Count; j++)
            {
                RouteNovelComa[j].transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().FordChorus(false);
            }
        }
    }

    public void NebularUnityHardy(bool isShow)
    {
        if (isShow)
        {
            foreach (var UPPER in SweatyPut)
            {
                UPPER.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().FordFoeBowUnityKnife(true, HisHardyThing());
            }
        }
        else
        {
            SweatyPut.Clear();
            for (int j = 0; j < RouteNovelComa.Count; j++)
            {
                RouteNovelComa[j].transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().FordFoeBowUnityKnife(false);
            }
        }
    }

    #region 放置判断

    public bool QueryHardy(Vector3 pointPos, int[,] blockGroup, BlockColor color)
    {
        if (FoeQueryHardy(pointPos, blockGroup))
        {
            
                WhenSpear.Instance.FivePut.gameObject.SetActive(true);
            foreach (var variable in FactorAlgaHardy)
            {
                var block = variable.Key.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>();
                BackupFordBur = block.transform;
                block.FordHardyKnife(true, variable.Value, color, true);
                EarlyRouteNovel[block.X, block.Y] = 1;
            }
            SweatyPut.Clear();
            NebularUnityHardy(false);
            /*for (int i = 0; i < ChangeBaseBlock.Count; i++)
            {
                var block = ChangeBaseBlock[i].transform.GetChild(0).GetComponent<HardyDesignHardyLizard>();
                block.ShowBlockImage(true, blockGroup[,]);
            }*/
            HardyDesignWhenOvertime.Instance.BathSewer();
            
            return true;
        }
        else
        {
            return false;
        }
    }

    //能否放置方块
    public void FactorQueryHardy(Vector3 pointPos, int[,] blockGroup)
    {
        if (FoeQueryHardy(pointPos, blockGroup))
        {
            
            NebularEnforceHardy(true);
            SoHomelessHardyGiant();
        }
        else
        {
            SweatyPut.Clear();
            NebularEnforceHardy(false);

            NebularUnityHardy(false);
        }
    }
    
    

    
    private void SoHomelessHardyGiant()
    {
        SweatyPut.Clear();
        Array.Copy(EarlyRouteNovel, SweatyRouteNovel, EarlyRouteNovel.Length);
        foreach (HardyDesignHardyLizard block in FactorAlgaHardy.Select(variable 
            => variable.Key.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>()))
        {
            SweatyRouteNovel[block.X, block.Y] = 1;
        }


        
        FactorMackerel(false);
        FactorPersuasive(false);
        /*ChangeBlockGroup(0, 0, false);
        ChangeBlockGroup(0, 3, false);
        ChangeBlockGroup(0, 6, false);
        ChangeBlockGroup(3, 0, false);
        ChangeBlockGroup(3, 3, false);
        ChangeBlockGroup(3, 6, false);
        ChangeBlockGroup(6, 0, false);
        ChangeBlockGroup(6, 3, false);
        ChangeBlockGroup(6, 6, false);*/


        if(SweatyPut.Count > 0)
            NebularUnityHardy(true);
    }




    public bool FoeQueryHardy(Vector3 pointPos, int[,] blockGroup)
    {
        NebularEnforceHardy(false);
        for (int i = 0; i < RouteNovelComa.Count; i++)
        {
            //距离
            var dis = Vector3.Distance(pointPos, RouteNovelComa[i].transform.position);
            if (dis <= FactorBlackout)
            {
                //Debug.LogError("距离合适 == " + i + "      asd ===   " + dis);
                //棋盘中能否放得下
                if (FoeQueryHardy(blockGroup, i))
                {
                    return true;
                }
                return false;
            }
        }
        return false;
    }

    public bool FactorEarlyQueryHardy(int[,] blockGroup)
    {
        bool isCanPlace = false;
        for (int i = 0; i < 81; i++)
        {
            if (FoeQueryHardy(blockGroup, i, false))
            {
                isCanPlace = true;
                return isCanPlace;
            }
        }
        return isCanPlace;
    }
        
    Dictionary<GameObject, int> FactorAlgaHardy= new Dictionary<GameObject, int>();
    public bool FoeQueryHardy(int[,] blockGroup, int original, bool isHaveChangeBaseBlock = true)
    {
        bool isCanPlace = true;

        FactorAlgaHardy.Clear();
        int x = original / 9;
        int y = original - (x * 9);
        for (int i = 0; i < blockGroup.GetLength(0); i++)
        {
            for (int j = 0; j < blockGroup.GetLength(1); j++)
            {
                //存在棋子在进行判断
                if (blockGroup[i, j] != 0)
                {
                    //没有超
                    if (x + i < 9 && y + j < 9)
                    {
                        //当前位置存放了方块
                        if (EarlyRouteNovel[x + i, y + j] == 1 || EarlyRouteNovel[x + i, y + j] == -1)
                        {
                            isCanPlace = false;
                            return isCanPlace;
                        }
                        else
                        {
                            if (isHaveChangeBaseBlock)
                                FactorAlgaHardy.Add(RouteNovelComa[(x + i) * 9 + y + j], blockGroup[i, j]);
                        }
                    }
                    else
                    {
                        isCanPlace = false;
                        FactorAlgaHardy.Clear();
                        return isCanPlace;
                    }
                }
            }
        }
        return isCanPlace;
    }

  #endregion


    #region 消除判断

    List<GameObject> DeftVirgoPut= new List<GameObject>();
    List<GameObject> SweatyPut= new List<GameObject>();
[UnityEngine.Serialization.FormerlySerializedAs("CashShowPos")]    public Transform HurlFordBur;
[UnityEngine.Serialization.FormerlySerializedAs("SourceShowPos")]    public Transform BackupFordBur;
[UnityEngine.Serialization.FormerlySerializedAs("ClearBlockGroupCount")]    public int VirgoHardyGiantExtol;
    /// <summary>
    /// 校验是否可以消除
    /// </summary>
    public void FactorFoeVirgoHardy()
    {
        DeftVirgoPut.Clear();
        VirgoHardyGiantExtol = 0;
        //清零
        for (int i = 0; i < 9; i++)
            for (int j = 0; j < 9; j++)
                SunDeftVirgoNovel[i, j] = 0;
        
        //棋盘中可以消除的棋子
        FactorMackerel(true);
        FactorPersuasive(true);
        /*ChangeBlockGroup(0, 0, true);
        ChangeBlockGroup(0, 3, true);
        ChangeBlockGroup(0, 6, true);
        ChangeBlockGroup(3, 0, true);
        ChangeBlockGroup(3, 3, true);
        ChangeBlockGroup(3, 6, true);
        ChangeBlockGroup(6, 0, true);
        ChangeBlockGroup(6, 3, true);
        ChangeBlockGroup(6, 6, true);*/

        if (VirgoHardyGiantExtol > 0)
        {
            RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Clear);
        }

        HardyDesignBackupFaculty.Instance.QueryHardy(DeftVirgoPut.Count != 0);
        
        for (int i = 0; i < DeftVirgoPut.Count; i++)
        {
            foreach (var VARIABLE in FactorAlgaHardy)
            {
                if (VARIABLE.Key == DeftVirgoPut[i])
                {
                    HurlFordBur = DeftVirgoPut[i].transform;
                    break;
                }
            }
        }
        Transform bottom = null;
        int bottomID = 99;
        for (int i = 0; i < DeftVirgoPut.Count; i++)
        {
            if (DeftVirgoPut[i].transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().Y < bottomID)
            {
                bottomID = DeftVirgoPut[i].transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().Y;
                bottom = DeftVirgoPut[i].transform;
            }
        }
        if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) != 99 && !BureauVolt.MyRaise())
        {
            float Style= (float)40 / DeftVirgoPut.Count;
            for (int i = 0; i < DeftVirgoPut.Count; i++)
            {
                HardyDesignWhenGazeFaculty.HisEquality().EonMeterHue(Style, DeftVirgoPut[i].transform, bottom);
            }
        }
        else if (DeftVirgoPut.Count != 0 && !BureauVolt.MyRaise() && MindGazeFaculty.GetString(CChoppy.Of_PryWhenBoat) != "Guide")
        {
            double cashValue = float.Parse(WitComaEka.instance.WhenGaze.Cashmultiple) * DeftVirgoPut.Count * BlockPuzzleGameUtil.HisHurlExalt();
            cashValue *= 1 + 0.1f * HardyDesignBackupFaculty.Instance.HisBlock();
            cashValue *= 1 + 0.1f * VirgoHardyGiantExtol;
            float Style= (float)cashValue / DeftVirgoPut.Count;
            //HardyDesignWhenGazeFaculty.GetInstance().addToken(cashValue , CashShowPos);
            for (int i = 0; i < DeftVirgoPut.Count; i++)
            {
                HardyDesignWhenGazeFaculty.HisEquality().EonMeterHue(Style, DeftVirgoPut[i].transform, bottom);
            }
        }
    }
    // 0 默认值， 1 需要消除的
    private int[,] SunDeftVirgoNovel= new int[9, 9];
[UnityEngine.Serialization.FormerlySerializedAs("ScratchObjs")]
    public GameObject CompanyClue;
    public void VirgoHardySun()
    {
        
        float DelayTime = 0;
        bool isAddtime = false;
        
            WhenSpear.Instance.HardySP = new();
        

        bool isHaveTarget = false;
        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Blockclean_2);
        for (int slice = 0; slice < 2 * 9 - 1; ++slice)
        {
            int z = slice < 9 ? 0 : slice - 9 + 1;
            for (int j = slice - z; j >= z; --j)
            {
                if (SunDeftVirgoNovel[j, (slice - j)] == 1)
                {
                    //消除动画
                    var block = RouteNovelComa[(j) * 9 + 8 - (slice - j)].transform.GetChild(0).GetComponent<HardyDesignHardyLizard>();
                    if (block.Well != 1)
                        isHaveTarget = true;
                    EarlyRouteNovel[block.X, block.Y] = 0;
                    if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == 99)
                        FlowerbedGeneralist.VirgoSun(block.gameObject, WhenSpear.Instance.HardySP, () =>
                        {
                            block.FordHardyKnife(false, 0);
                        });
                    else
                        FlowerbedGeneralist.VirgoSun(block.gameObject, WhenQuiltSpear.Instance.HardySP, () =>
                        {
                            block.FordHardyKnife(false, 0);
                        });
                }
            }
        }

        BlockDayTricycleFactor();
        float Heal= 0;
        if (isHaveTarget)
            Heal = 0f;
        else
            Heal = 0f;
        StartCoroutine(PortCrop(Heal, () =>
        {
            HardyDesignWhenOvertime.Instance.VirgoHardy?.Invoke();
        }));
    }

    IEnumerator PortCrop(float time, Action finish)
    {
        yield return new WaitForSeconds(time);
        finish?.Invoke();
    }

    private void FactorMackerel(bool isNeedClear)
    {
        if (isNeedClear)
        {
            for (int i = 0; i < 9; i++)
            {
                bool isComplete = true;
                for (int j = 0; j < 9; j++)
                {
                    //0 还有没有填充的
                    if (EarlyRouteNovel[j, i] == 0 || EarlyRouteNovel[j, i] == -1)
                    {
                        isComplete = false;
                        break;
                    }
                }
                if (isComplete)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (!DeftVirgoPut.Contains(RouteNovelComa[9 * j + i]))
                        {
                            DeftVirgoPut.Add(RouteNovelComa[9 * j + i]);
                            SunDeftVirgoNovel[j, 8 - i] = 1;
                        }
                    }
                    VirgoHardyGiantExtol++;
                    
                        WhenSpear.Instance?.FordVirgoBegin(2, HisHardyThing(), RouteNovelComa[9 * 4 + i].transform.position);
                    
                }
            }
        }
        else
        {
            for (int i = 0; i < 9; i++)
            {
                bool isComplete = true;
                for (int j = 0; j < 9; j++)
                {
                    //0 还有没有填充的
                    if (SweatyRouteNovel[j, i] == 0 || SweatyRouteNovel[j, i] == -1)
                    {
                        isComplete = false;
                        break;
                    }
                }
                if (isComplete)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (!SweatyPut.Contains(RouteNovelComa[9 * j + i]))
                        {
                            SweatyPut.Add(RouteNovelComa[9 * j + i]);
                        }
                    }
                }
            }
        }
    }

    private void FactorPersuasive(bool isNeedClear)
    {
        if (isNeedClear)
        {
            for (int i = 0; i < 9; i++)
            {
                bool isComplete = true;
                for (int j = 0; j < 9; j++)
                {
                    //0 还有没有填充的
                    if (EarlyRouteNovel[i, j] == 0|| EarlyRouteNovel[i, j] == -1)
                    {
                        isComplete = false;
                        break;
                    }
                }
                if (isComplete)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (!DeftVirgoPut.Contains(RouteNovelComa[j + i * 9]))
                        {
                            DeftVirgoPut.Add(RouteNovelComa[j + i * 9]);
                            SunDeftVirgoNovel[i, 8 - j] = 1;
                        }
                    }
                    VirgoHardyGiantExtol++;
                    
                        WhenSpear.Instance?.FordVirgoBegin(1, HisHardyThing(), RouteNovelComa[9 * i + 4].transform.position);
                    
                }
            }
        }
        else
        {
            for (int i = 0; i < 9; i++)
            {
                bool isComplete = true;
                for (int j = 0; j < 9; j++)
                {
                    //0 还有没有填充的
                    if (SweatyRouteNovel[i, j] == 0 || SweatyRouteNovel[i, j] == -1)
                    {
                        isComplete = false;
                        break;
                    }
                }
                if (isComplete)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (!SweatyPut.Contains(RouteNovelComa[j + i * 9]))
                        {
                            SweatyPut.Add(RouteNovelComa[j + i * 9]);
                        }
                    }
                }
            }
        }
        
    }

    private void FactorHardyGiant(int startRow, int startCol, bool isNeedClear)
    {
        if (isNeedClear)
        {
            bool isComplete = true;
            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    if (EarlyRouteNovel[i, j] == 0 || EarlyRouteNovel[i, j] == -1)
                    {
                        isComplete = false;
                        break;
                    }
                }
            }
            if (isComplete)
            {
                for (int i = startRow; i < startRow + 3; i++)
                {
                    for (int j = startCol; j < startCol + 3; j++)
                    {
                        if (!DeftVirgoPut.Contains(RouteNovelComa[j + i * 9]))
                        {
                            DeftVirgoPut.Add(RouteNovelComa[j + i * 9]);
                            SunDeftVirgoNovel[i, 8 - j] = 1;
                        }
                    }
                }
                VirgoHardyGiantExtol++;
                
                    WhenSpear.Instance?.FordVirgoBegin(3, HisHardyThing(), RouteNovelComa[9 * (startRow + 1) + startCol].transform.position);
                
            }
        }
        else
        {
            bool isComplete = true;
            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    if (SweatyRouteNovel[i, j] == 0 || SweatyRouteNovel[i, j] == -1)
                    {
                        isComplete = false;
                        break;
                    }
                }
            }
            if (isComplete)
            {
                for (int i = startRow; i < startRow + 3; i++)
                {
                    for (int j = startCol; j < startCol + 3; j++)
                    {
                        if (!SweatyPut.Contains(RouteNovelComa[j + i * 9]))
                        {
                            SweatyPut.Add(RouteNovelComa[j + i * 9]);
                        }
                    }
                }
            }
        }
       
    }

    /// <summary>
    /// 获取放置的方块的颜色
    /// </summary>
    /// <returns></returns>
    private BlockColor HisHardyThing()
    {
        BlockColor Upset= BlockColor.Blue;
        if (HardyDesignAvidFaculty.Instance.ChorusPut != null)
        {
            Upset = HardyDesignAvidFaculty.Instance.ChorusPut.GetComponent<HardyDesignHardyGiant>().Upset;
        }
        else
        {
            
            foreach (GameObject block in FactorAlgaHardy.Keys)
            {
                if (FactorAlgaHardy[block] == 1)
                {
                    Upset = block.transform.Find("Block").GetComponent<HardyDesignHardyLizard>().Upset;
                    break;
                }
            }
        }
        return Upset;
    }

  #endregion

    #region 填充逻辑判断

    //1 ~ 9 3*3 左下开始，11 ~ 19 横从下往上， 21 ~ 29 竖从左到右
    int[] CamelNovelComa= new int[]{
        1, 2, 3, 4, 5, 6, 7, 8, 9, 
        11, 12, 13, 14, 15, 16, 17, 18, 19,
        21, 22, 23, 24, 25, 26, 27, 28, 29
    };
    public int FactorHealRouteNovel()
    {
        CamelNovelComa = HardyDesignDeftFaculty.instance.LuxuryWin(CamelNovelComa);

        for (int i = 0; i < CamelNovelComa.Length; i++)
        {
            if (SoFoeHeal(CamelNovelComa[i]))
            {
                Debug.Log("checkBoardInfo[i] == " + CamelNovelComa[i] +  "         Count == " + VirgoComa.Count);
                foreach (var VARIABLE in VirgoComa)
                {
                    Debug.Log("1 == " + VARIABLE.Key + "       2 == " + VARIABLE.Value.Count);
                    for (int j = 0; j < VARIABLE.Value.Count; j++)
                    {
                        Debug.Log("i == "+ j +"     x == " + VARIABLE.Value[j].X +"      y == " + VARIABLE.Value[j].Y);
                    }
                }
                return CamelNovelComa[i];
            }
        }
        return 0;
    }
    public bool SoFoeHeal(int index)
    {
        //3*3
        if (index < 10)
        {
            int startRow = 0;
            int startCol = 0;
            switch (index)
            {
                case 1 : startRow = 0; startCol = 0; break;
                case 2 : startRow = 0; startCol = 3; break;
                case 3 : startRow = 0; startCol = 6; break;
                case 4 : startRow = 3; startCol = 0; break;
                case 5 : startRow = 3; startCol = 3; break;
                case 6 : startRow = 3; startCol = 6; break;
                case 7 : startRow = 6; startCol = 0; break;
                case 8 : startRow = 6; startCol = 3; break;
                case 9 : startRow = 6; startCol = 6; break;
            }
            return FactorDutchUpDutch(startRow, startCol);
        }
        //竖列
        else if(index > 20)
        {
            return SoFoeHealHardyMackerel(index - 21);
        }
        //横列
        else
        {
            return SoFoeHealHardyPersuasive(index - 11);
        }
        return false;
    }

    public bool SoFoeHealHardyMackerel(int Vertical)
    {
        VirgoComa.Clear();
        int emptyCount = 0;
        for (int i = 0; i < 9; i++)
        {
            if(EarlyRouteNovel[Vertical, i] == 0)
                emptyCount++;
        }
        if (emptyCount <= 4)
        {
            int breaksCount = 0;
            bool isOneSequence = false;
            
            int currentCount = 0; // 当前连续1的计数器
            int maxCount = 0; // 目前为止遇到的连续1的最大数量
            if (EarlyRouteNovel[Vertical , 0] == 0)
            {
                breaksCount++;
            }
            
            for (int i = 0; i < 9; i++)
            {
                // 如果当前数字是
                if (EarlyRouteNovel[Vertical, i] == 0)
                {
                    if (!isOneSequence && i > 0 && EarlyRouteNovel[Vertical, i - 1] == 1)
                    {
                        breaksCount++;
                    }
                    
                    if (breaksCount > 0)
                    {
                        if (VirgoComa.ContainsKey(breaksCount))
                        {
                            VirgoComa[breaksCount].Add(new EmptyBlockPos(){
                                X = Vertical, Y = i
                            });
                        }
                        else
                        {
                            VirgoComa.Add(breaksCount,new List<EmptyBlockPos>(){
                                new EmptyBlockPos(){X = Vertical, Y = i}
                            });
                        }
                    }
                    isOneSequence = true;
                    
                    currentCount++;
                    // 更新遇到的连续1的最大数量
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    isOneSequence = false;
                    currentCount = 0;
                    
                    
                }
            }
            
            if (breaksCount <= 2)
            {
                if (breaksCount == 1 && emptyCount != 1)
                {
                    FactorSizeDIc(emptyCount);
                }
                return true;
            }
        }
        return false;
    }

    private void FactorSizeDIc(int LineCount)
    {
        List<EmptyBlockPos> firstInfo = new List<EmptyBlockPos>();
        List<EmptyBlockPos> secondInfo = new List<EmptyBlockPos>();
        switch (LineCount)
        {
            case 2 :
                if (HardyDesignDeftFaculty.instance.MyMobSeedy(500))
                {
                    firstInfo.Add(VirgoComa[1][0]);
                    secondInfo.Add(VirgoComa[1][1]);

                    VirgoComa[1] = firstInfo;
                    VirgoComa.Add(2, secondInfo);
                }
                break;
            case 3 :
                if (HardyDesignDeftFaculty.instance.MyMobSeedy(500))
                {
                    var Cement= Random.Range(1, VirgoComa[1].Count - 1);
                    firstInfo = VirgoComa[1].GetRange(0, Cement);
                    secondInfo = VirgoComa[1].GetRange(Cement, VirgoComa[1].Count - Cement);
                    
                    VirgoComa[1] = firstInfo;
                    VirgoComa.Add(2, secondInfo);
                }
                break;
            case 4 : 
                if (HardyDesignDeftFaculty.instance.MyMobSeedy(500))
                {
                    var Cement= Random.Range(1, VirgoComa[1].Count - 1);
                    firstInfo = VirgoComa[1].GetRange(0, Cement);
                    secondInfo = VirgoComa[1].GetRange(Cement, VirgoComa[1].Count - Cement);
                
                    VirgoComa[1] = firstInfo;
                    VirgoComa.Add(2, secondInfo);
                }
                break;
        }
    }
    
    public bool SoFoeHealHardyPersuasive(int Horizontal)
    {
        VirgoComa.Clear();
        int emptyCount = 0;
        for (int i = 0; i < 9; i++)
        {
            if(EarlyRouteNovel[i , Horizontal] == 0)
            {
                emptyCount++;
            }
        }
        if (emptyCount <= 4)
        {
            int breaksCount = 0;
            bool isOneSequence = false;
            
            int currentCount = 0; // 当前连续1的计数器
            int maxCount = 0; // 目前为止遇到的连续1的最大数量
            if (EarlyRouteNovel[0, Horizontal] == 0)
            {
                breaksCount++;
            }
            for (int i = 0; i < 9; i++)
            {
                // 如果当前数字是
                if (EarlyRouteNovel[i , Horizontal] == 0)
                {
                    if (!isOneSequence && i > 0 && EarlyRouteNovel[i - 1, Horizontal] == 1)
                    {
                        breaksCount++;
                    }
                    if (breaksCount > 0)
                    {
                        if (VirgoComa.ContainsKey(breaksCount))
                        {
                            VirgoComa[breaksCount].Add(new EmptyBlockPos(){
                                X = i, Y = Horizontal
                            });
                        }
                        else
                        {
                            VirgoComa.Add(breaksCount,new List<EmptyBlockPos>(){
                                new EmptyBlockPos(){X = i, Y = Horizontal}
                            });
                        }
                    }
                    
                    isOneSequence = true;
                    
                    currentCount++;
                    // 更新遇到的连续1的最大数量
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    isOneSequence = false;
                    currentCount = 0;
                    
                }
            }
            if (breaksCount <= 2)
            {
                if (breaksCount == 1 && emptyCount != 1)
                {
                    FactorSizeDIc(emptyCount);
                }
                return true;
            }
        }
        return false;
    }

    private bool FactorDutchUpDutch(int startRow, int startCol)
    {
        VirgoComa.Clear();
        int emptyCount = 0;
        

        List<EmptyBlockPos> emptyBlockPosList = new List<EmptyBlockPos>();
        for (int i = startRow; i < startRow + 3; i++)
        {
            for (int j = startCol; j < startCol + 3; j++)
            {
                if (EarlyRouteNovel[i, j] == 0)
                {
                    emptyCount++;
                    emptyBlockPosList.Add(new EmptyBlockPos(){X = i, Y = j});
                }
            }
        }
        Failure = new bool[3, 3];
        if (emptyCount <= 4)
        {
            var maxConnectResult = UtePrejudiceVast(startRow, startCol);
            Debug.Log("emptyCount == " + emptyCount + "    2 == " + maxConnectResult.Count);
            /*
            for (int i = 0; i < maxConnectResult.Count; i++)
            {
                Debug.LogError("   i == " + i + "     x == " + maxConnectResult[i].X +"      y == " + maxConnectResult[i].Y);
            }*/
            if (emptyCount == 1 && maxConnectResult.Count == 1)
                VirgoComa.Add(1,emptyBlockPosList);
            else if (emptyCount == 2 && maxConnectResult.Count == 2)
            {
                VirgoComa.Add(1,emptyBlockPosList);
                FactorSizeDIc(emptyCount);
            }
            else if (emptyCount == 3 && maxConnectResult.Count == 3)
            {
                VirgoComa.Add(1,emptyBlockPosList);
                FactorSizeDIc(emptyCount);
            }
            else if (emptyCount == 4 && maxConnectResult.Count == 4)
            {
                VirgoComa.Add(1,emptyBlockPosList);
            }
            else if (emptyCount == 2 && maxConnectResult.Count == 1)
            {
                if (Mathf.Abs(emptyBlockPosList[0].X - emptyBlockPosList[1].X) <= 1
                    && Mathf.Abs(emptyBlockPosList[0].Y - emptyBlockPosList[1].Y) <= 1)
                {
                    VirgoComa.Add(1,emptyBlockPosList);
                    FactorSizeDIc(emptyCount);
                }
                else
                {
                    VirgoComa.Add(1, new List<EmptyBlockPos>(){emptyBlockPosList[0]});
                    VirgoComa.Add(2, new List<EmptyBlockPos>(){emptyBlockPosList[1]});
                }
            }
                
            else if (emptyCount == 3 && maxConnectResult.Count == 1)
            {
                return false;
                var Style= TollHueVast(startRow, startCol);
                if (Style.Count >= 2)
                {
                    VirgoComa.Add(1, new List<EmptyBlockPos>{ 
                        new(){X = Style[0].x, Y = Style[0].y}, 
                        new(){X = Style[1].x, Y = Style[1].y }});
                    if (MyMobHueVirgo(emptyBlockPosList))
                        return true;
                }
                else
                {
                    return false;
                }
                
            }
            else if (emptyCount == 3 && maxConnectResult.Count == 2)
            {
                var Style= TollHueVast(startRow, startCol);
                if (Style.Count >= 2)
                {
                    VirgoComa.Add(1, new List<EmptyBlockPos>{ 
                        new(){X = Style[0].x, Y = Style[0].y}, 
                        new(){X = Style[1].x, Y = Style[1].y }});
                    
                    var clearOne = VirgoComa[1];
                    
                    if (MyMobHueVirgo(emptyBlockPosList))
                        return true;
                }
                else
                {
                    return false;
                }
            }
            else if (emptyCount == 4 && maxConnectResult.Count == 3)
            {
                //横竖满足后就只有一种情况
                if (RouteSewDutchCrackAtSize(startRow, startCol))
                {
                    VirgoComa.Add(1, maxConnectResult);
                    
                    //剩余的那个放到另一个里面
                    if (MyMobHueVirgo(emptyBlockPosList))
                        return true;
                }
                else
                {
                    //先判断是否三一
                    if (HardyDesignDeftFaculty.instance.MyMobSeedy(500))
                    {
                        VirgoComa.Add(1, maxConnectResult);
                        
                        //剩余的那个放到另一个里面
                        if (MyMobHueVirgo(emptyBlockPosList))
                            return true;
                    }
                    else
                    {
                        var result = FoeCrackBeOverwhelm(startRow, startCol);
                        if (result.canSeparate)
                        {
                            VirgoComa.Add(1, result.zeroPositions.GetRange(0,2));
                            VirgoComa.Add(2, result.zeroPositions.GetRange(2,2));
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else if (emptyCount == 4 && maxConnectResult.Count == 2)
            {
                var result = RouteSlantSize(startRow, startCol);
                //斜线判断
                if (result.isCon)
                {
                    VirgoComa.Add(1, result.maxOnesPositions);
                    
                    if (MyMobHueVirgo(emptyBlockPosList))
                        return true;
                }
                else
                {
                    var resultTwo = FoeCrackBeOverwhelm(startRow, startCol);
                    if (resultTwo.canSeparate)
                    {
                        VirgoComa.Add(1, resultTwo.zeroPositions.GetRange(0,2));
                        VirgoComa.Add(2, resultTwo.zeroPositions.GetRange(2,2));
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (emptyCount == 4 && maxConnectResult.Count == 1)
            {
                var result = RouteSlantSize(startRow, startCol);
                //斜线判断
                if (result.isCon)
                {
                    VirgoComa.Add(1, result.maxOnesPositions);
                    if (MyMobHueVirgo(emptyBlockPosList))
                        return true;
                }
                else
                {
                    return false;
                }
            }
            return VirgoComa.Count <= 2;
        }
        return false;
    }

    private bool MyMobHueVirgo(List<EmptyBlockPos> emptyBlockPosList)
    {
        var clearOne = VirgoComa[1];
        var Two = emptyBlockPosList.Except(clearOne).ToList();
        VirgoComa.Add(2, Two);
        return true;
        for (int i = 0; i < emptyBlockPosList.Count; i++)
        {
            bool isExistence = false;
            foreach (EmptyBlockPos t in clearOne.Where(t => emptyBlockPosList[i] == t))
            {
                isExistence = true;
            }

            if (!isExistence)
            {
                VirgoComa.Add(2, new List<EmptyBlockPos>{emptyBlockPosList[i]});
                return true;
            }
        }
        return false;
    }
    
    private bool[,] Failure;
    private List<EmptyBlockPos> UtePrejudiceVast(int startRow, int startCol)
    {
        List<EmptyBlockPos> maxCount = new List<EmptyBlockPos>();
        List<List<EmptyBlockPos>> allBlocks = new List<List<EmptyBlockPos>>();
        for (int i = startRow; i < startRow + 3; i++)
        {
            for (int j = startCol; j < startCol + 3; j++)
            {
                if (EarlyRouteNovel[i, j] == 0 && !Failure[i - startRow, j - startCol])
                {
                    List<EmptyBlockPos> currentBlock = new List<EmptyBlockPos>();
                    // 使用DFS更新最大连通数量
                    DFS(startRow, startCol, i, j, currentBlock);
                    //maxCount = Math.Max(maxCount, );
                    allBlocks.Add(currentBlock);
                }
            }
        }
        for (int i = 0; i < allBlocks.Count; i++)
        {
            if (maxCount.Count < allBlocks[i].Count)
            {
                maxCount = allBlocks[i];
            }
        }
        return maxCount;
    }
    
    private int DFS(int startRow, int startCol, int i, int j, List<EmptyBlockPos> currentBlock)
    {
        if (i < startRow || i >= 3 + startRow || j < startCol || j >= startCol + 3 || EarlyRouteNovel[i, j] != 0 || Failure[i - startRow, j - startCol])
        {
            return 0;
        }

        Failure[i - startRow, j - startCol] = true; // 标记为已访问
        //Debug.LogError("x == " + i + "      y == "  + j);
        currentBlock.Add(new EmptyBlockPos(){X = i,Y = j});
        // 为当前位置的1计数，再加上上下左右四个方向的DFS返回值
        return 1 + DFS(startRow, startCol, i+1, j, currentBlock) + 
               DFS(startRow, startCol, i-1, j, currentBlock) + 
               DFS(startRow, startCol, i, j+1, currentBlock) + 
               DFS(startRow, startCol, i, j-1, currentBlock);
    }
    
    /// <summary>
    /// 横竖线
    /// </summary>
    /// <param name="startRow"></param>
    /// <param name="startCol"></param>
    /// <returns></returns>
    public bool RouteSewDutchCrackAtSize(int startRow, int startCol)
    {
        // 检查行
        for (int row = startRow; row < startRow + 3; row++)
        {
            if (EarlyRouteNovel[row, 0] == 0 && EarlyRouteNovel[row, 1] == 0 && EarlyRouteNovel[row, 2] == 0)
                return true;
        }

        // 检查列
        for (int col = startCol; col < startCol + 3; col++)
        {
            if (EarlyRouteNovel[0, col] == 0 && EarlyRouteNovel[1, col] == 0 && EarlyRouteNovel[2, col] == 0)
                return true;
        }

        return false;
    }

    /// <summary>
    /// 斜线
    /// </summary>
    /// <param name="startRow"></param>
    /// <param name="startCol"></param>
    /// <returns></returns>
    public (bool isCon, List<EmptyBlockPos> maxOnesPositions) RouteSlantSize(int startRow, int startCol)
    {
        if (EarlyRouteNovel[startRow, startCol] == 0 && EarlyRouteNovel[startRow + 1, startCol + 1] == 0 && EarlyRouteNovel[startRow + 2, startCol + 2] == 0)
        {
            return (true, new List<EmptyBlockPos>(){ new(){X = startRow,Y = startCol},new(){X = startRow + 1,Y = startCol + 1},new(){X = startRow + 2,Y = startCol + 2}});
        }
        if (EarlyRouteNovel[startRow, startCol + 2] == 0 && EarlyRouteNovel[startRow + 1,startCol + 1] == 0 && EarlyRouteNovel[startRow + 2,startCol + 0] == 0)
            return (true, new List<EmptyBlockPos>(){ new(){X = startRow,Y = startCol + 2},new(){X = startRow + 1,Y = startCol + 1},new(){X = startRow + 2,Y = startCol}});

        return (false,null);
    }
    
    /// <summary>
    /// 最大连接数，以及对应位置
    /// </summary>
    /// <param name="startRow"></param>
    /// <param name="startCol"></param>
    /// <returns></returns>
    public (int maxCount, List<EmptyBlockPos> maxOnesPositions) TollUtePortraitistVast(int startRow, int startCol)
    {
        int maxSize = 0;
        List<EmptyBlockPos> positions = new List<EmptyBlockPos>();
        
        // 检查行
        for (int i = startRow; i < startRow + 3; i++)
        {
            int rowCount = 0;
            for (int j = startCol; j < startCol + 3; j++)
            {
                if (EarlyRouteNovel[i, j] == 0)
                {
                    rowCount++;
                    if (rowCount > maxSize)
                    {
                        maxSize = rowCount;
                        positions.Clear();
                        for (int k = 0; k < rowCount; k++)
                        {
                            positions.Add(new EmptyBlockPos(){X = i, Y = j - k});
                            //positions.Add(new EmptyBlockPos(i, j - k));
                        }
                    }
                }
                else
                {
                    rowCount = 0;
                }
            }
        }
        
        // 检查列
        for (int j = startCol; j <startCol + 3; j++)
        {
            int colCount = 0;
            for (int i = startRow; i <startRow + 3; i++)
            {
                if (EarlyRouteNovel[i, j] == 1)
                {
                    colCount++;
                    if (colCount > maxSize)
                    {
                        maxSize = colCount;
                        positions.Clear();
                        for (int k = 0; k < colCount; k++)
                        {
                            positions.Add(new EmptyBlockPos(){X = i - k, Y = j});
                            //positions.Add(new Vector2Int(i - k, j));
                        }
                    }
                }
                else
                {
                    colCount = 0;
                }
            }
        }
        
        return (maxSize, positions);
    }
    
    /// <summary>
    /// 两两相连
    /// </summary>
    /// <param name="startRow"></param>
    /// <param name="startCol"></param>
    /// <returns></returns>
    public List<Vector2Int> TollHueVast(int startRow, int startCol)
    {
        List<Vector2Int> positions = new List<Vector2Int>();
        
        for (int i = startRow; i < startRow + 2; i++) 
        {
            for (int j = startCol; j < startCol + 2; j++)
            {
                if (EarlyRouteNovel[i, j] == 0) positions.Add(new Vector2Int(i, j));
                if (EarlyRouteNovel[i, j + 1] == 0) positions.Add(new Vector2Int(i, j + 1));
                if (EarlyRouteNovel[i + 1, j] == 0) positions.Add(new Vector2Int(i + 1, j));
                if (EarlyRouteNovel[i + 1, j + 1] == 0) positions.Add(new Vector2Int(i + 1, j + 1));


                if (positions.Count >= 2)
                {
                    return positions.GetRange(0, 2);
                }
                positions.Clear();
            }
        }
        
        for (int i = startRow + 1; i < startRow + 3; i++) 
        {
            for (int j = startCol; j < startCol + 2; j++)
            {
                if (EarlyRouteNovel[i, j] == 0) positions.Add(new Vector2Int(i, j));
                if (EarlyRouteNovel[i, j + 1] == 0) positions.Add(new Vector2Int(i, j + 1));
                if (EarlyRouteNovel[i + 1, j] == 0) positions.Add(new Vector2Int(i + 1, j));
                if (EarlyRouteNovel[i + 1, j + 1] == 0) positions.Add(new Vector2Int(i + 1, j + 1));


                if (positions.Count >= 2)
                {
                    return positions.GetRange(0, 2);
                }
                positions.Clear();
            }
        }
        
        for (int i = startRow; i < startRow + 2; i++) 
        {
            for (int j = startCol + 1; j < startCol + 3; j++)
            {
                if (EarlyRouteNovel[i, j] == 0) positions.Add(new Vector2Int(i, j));
                if (EarlyRouteNovel[i, j + 1] == 0) positions.Add(new Vector2Int(i, j + 1));
                if (EarlyRouteNovel[i + 1, j] == 0) positions.Add(new Vector2Int(i + 1, j));
                if (EarlyRouteNovel[i + 1, j + 1] == 0) positions.Add(new Vector2Int(i + 1, j + 1));


                if (positions.Count >= 2)
                {
                    return positions.GetRange(0, 2);
                }
                positions.Clear();
            }
        }
        
        for (int i = startRow + 1; i < startRow + 3; i++) 
        {
            for (int j = startCol + 1; j < startCol + 3; j++)
            {
                if (EarlyRouteNovel[i, j] == 0) positions.Add(new Vector2Int(i, j));
                if (EarlyRouteNovel[i, j + 1] == 0) positions.Add(new Vector2Int(i, j + 1));
                if (EarlyRouteNovel[i + 1, j] == 0) positions.Add(new Vector2Int(i + 1, j));
                if (EarlyRouteNovel[i + 1, j + 1] == 0) positions.Add(new Vector2Int(i + 1, j + 1));


                if (positions.Count >= 2)
                {
                    return positions.GetRange(0, 2);
                }
                positions.Clear();
            }
        }
        
        return positions;
    }

    private (bool canSeparate, List<EmptyBlockPos> zeroPositions) FoeCrackBeOverwhelm(int startRow, int startCol)
    {
        List<EmptyBlockPos>[] subGridZeroPositions = new List<EmptyBlockPos>[4];
        for (int i = 0; i < subGridZeroPositions.Length; i++)
        {
            subGridZeroPositions[i] = new List<EmptyBlockPos>();
        }
        
        // 记录每个2x2子区域中0的位置
        for (int row = startRow; row <= startRow + 1; row++)
        {
            for (int col = startCol; col <= startCol + 1; col++)
            {
                int subGridIndex = (row - startRow) * 2 + col - startCol;
                for (int i = row; i < row + 2; i++)
                {
                    for (int j = col; j < col + 2; j++)
                    {
                        if (EarlyRouteNovel[i, j] == 0)
                        {
                            subGridZeroPositions[subGridIndex].Add(new EmptyBlockPos(){X = i, Y = j});
                        }
                    }
                }
            }
        }
        
        // 检查是否有两个子区域中各有两个0
        for (int i = 0; i < subGridZeroPositions.Length; i++)
        {
            for (int j = i + 1; j < subGridZeroPositions.Length; j++)
            {
                if (subGridZeroPositions[i].Count == 2 && subGridZeroPositions[j].Count == 2)
                {
                    // 组合所有0的位置
                    List<EmptyBlockPos> zeroPositions = new List<EmptyBlockPos>();
                    zeroPositions.AddRange(subGridZeroPositions[i]);
                    zeroPositions.AddRange(subGridZeroPositions[j]);
                    return (true, zeroPositions);
                }
            }
        }
        
        return (false, null);
    }
[UnityEngine.Serialization.FormerlySerializedAs("ClearInfo")]    
    //最多只有两个，每次弄给剩下那个填充上
    public Dictionary<int, List<EmptyBlockPos>> VirgoComa= new Dictionary<int, List<EmptyBlockPos>>();

    int[,] RayEarly= new int[9,9];
    int[,] FactorEarly=  new int[9,9];
    public BlockItem HisHealHardyGiant(List<EmptyBlockPos> EmptyNeedFill, List<EmptyBlockPos> EmptyNoFill, HardyDesignWhenHardy curGameBlock)
    {
        Array.Copy(EarlyRouteNovel, RayEarly, EarlyRouteNovel.Length);
        //修改放置物体的棋盘
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (EmptyNoFill != null)
                    foreach (EmptyBlockPos t in EmptyNoFill.Where(t => t.X == i && t.Y == j))
                    {
                        RayEarly[i, j] = 1;
                    }
            }
        }

        Array.Copy(RayEarly, FactorEarly, RayEarly.Length);

        //方块组，
        for (int i = 0; i < curGameBlock.Block.Count; i++)
        {
            HisHardyGiant(curGameBlock.Block[i].shape);
            //位置
            for (int j = 0; j < 81; j++)
            {
                if (FoeQueryFactorHardy(HardyComa, j))
                {
                    //判断这次填充是否满足填充需要填充的位置
                    if (FactorMyHomelessCobalt(EmptyNeedFill))
                    {
                        Debug.Log("id ==  " +curGameBlock.Block[i].id  +"      pos == " + j);
                        return curGameBlock.Block[i];
                    }
                    //没有满足，重置填充棋子
                    else
                    {
                        Array.Copy(RayEarly, FactorEarly, RayEarly.Length);
                    }
                }
            }
        }
        Debug.LogError("1111111111111111111111111111111");
        return null;
    }

    private bool FactorMyHomelessCobalt(List<EmptyBlockPos> EmptyNeedFill)
    {
        bool isComplete = true;
        for (int i = 0; i < EmptyNeedFill.Count; i++)
        {
            if (FactorEarly[EmptyNeedFill[i].X, EmptyNeedFill[i].Y] == 0)
            {
                isComplete = false;
            }
        }
        return isComplete;
    }
[UnityEngine.Serialization.FormerlySerializedAs("BlockInfo")]    public int[,] HardyComa= new int[,]{
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0}
    };
[UnityEngine.Serialization.FormerlySerializedAs("BlockInfoTwo")]    
    public int[,] HardyComaHue= new int[,]{
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0}
    };
    private void HisHardyGiant(List<int> shape)
    {
        for (int i = 0; i < HardyComa.GetLength(0); i++)
        {
            for (int j = 0; j < HardyComa.GetLength(1); j++)
            {
                HardyComa[i, j] = shape[(3 - j)  * 4 + ( i)];
            }
        }
    }
    
    private void HisHardyGiantHue(List<int> shape)
    {
        for (int i = 0; i < HardyComaHue.GetLength(0); i++)
        {
            for (int j = 0; j < HardyComaHue.GetLength(1); j++)
            {
                HardyComaHue[i, j] = shape[(3 - j)  * 4 + ( i)];
            }
        }
    }
    
    Dictionary<GameObject, int> AlgaHardy= new Dictionary<GameObject, int>();
    public bool FoeQueryFactorHardy(int[,] blockGroup, int original)
    {
        bool isCanPlace = true;
        AlgaHardy.Clear();
        int x = original / 9;
        int y = original - (x * 9);
        for (int i = 0; i < blockGroup.GetLength(0); i++)
        {
            for (int j = 0; j < blockGroup.GetLength(1); j++)
            {
                //存在棋子在进行判断
                if (blockGroup[i, j] != 0)
                {
                    //没有超
                    if (x + i < 9 && y + j < 9)
                    {
                        //当前位置存放了方块
                        if (FactorEarly[x + i, y + j] == 1)
                        {
                            isCanPlace = false;
                            return isCanPlace;
                        }
                        else
                        {
                            AlgaHardy.Add(RouteNovelComa[(x + i) * 9 + y + j], blockGroup[i, j]);
                        }
                    }
                    else
                    {
                        isCanPlace = false;
                        AlgaHardy.Clear();
                        return isCanPlace;
                    }
                }
            }
        }
        
        //可以放置
        foreach (var VARIABLE in AlgaHardy)
        {
            var block = VARIABLE.Key.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>(); 
            FactorEarly[block.X, block.Y] = 1;
        }
        return isCanPlace;
    }
[UnityEngine.Serialization.FormerlySerializedAs("FillingBlockDic")]
  #endregion
    
    
    #region 填充逻辑判断第二版
    
    public Dictionary<int, List<FillFourToFour>> VehicleHardySay= new Dictionary<int, List<FillFourToFour>>();
[UnityEngine.Serialization.FormerlySerializedAs("TotalFillFourToFour")]    public List<FillFourToFour> EarlyFillSlitUpSlit= new List<FillFourToFour>(36);
    public void BlissHisPretendHardy()
    {
        int smallArraySize = 4; // 小数组的尺寸
        EarlyFillSlitUpSlit.Clear();
        VehicleHardySay.Clear();
        HealHardyGiant.Clear();
        // 遍历大数组，步长为小数组的尺寸
        for (int i = 0; i < EarlyRouteNovel.GetLength(0) - 3; i += 1)
        {
            for (int j = 0; j < EarlyRouteNovel.GetLength(1) - 3; j += 1)
            {
                // 创建小数组
                int[,] smallArray = new int[smallArraySize, smallArraySize];

                // 遍历小数组内的元素
                for (int si = 0; si < smallArraySize; si++)
                {
                    for (int sj = 0; sj < smallArraySize; sj++)
                    {
                        // 计算当前元素在大数组中的位置
                        int bigArrayI = i + si;
                        int bigArrayJ = j + sj;

                        // 检查是否越界
                        if (bigArrayI < EarlyRouteNovel.GetLength(0) && bigArrayJ < EarlyRouteNovel.GetLength(1))
                        {
                            smallArray[si, sj] = EarlyRouteNovel[bigArrayI, bigArrayJ];
                        }
                        else
                        {
                            smallArray[si, sj] = 0; // 或者其它你想要的默认值
                        }
                    }
                }
                //TotalFillFourToFour.Add(new FillFourToFour(){X = i,Y = j, smallArray = smallArray});
                // 这里你可以处理小数组，例如打印出来或进行其他操作
                FactorAlienHardy(smallArray, i,j);
            }
        }

        /*foreach (var VARIABLE in FillingBlockDic)
        {
            Debug.LogError("key == " + VARIABLE.Key + "     value == " + VARIABLE.Value.Count);
            for (int i = 0; i < VARIABLE.Value.Count; i++)
            {
                Debug.LogError("VARIABLE.Value.Count == " + VARIABLE.Value[i].X + "     y == " + VARIABLE.Value[i].Y);
            }
        }*/
    }

    
    /// <summary>
    /// 判断这个小的4*4是否满足填充初步逻辑
    /// </summary>
    /// <param name="smallArray"></param>
    /// <param name="horizontalStart"></param>
    /// <param name="verticalStart"></param>
    private void FactorAlienHardy(int[,] smallArray, int horizontalStart, int verticalStart)
    {
        int emptyCount = 0;
        for (int i = 0; i < smallArray.GetLength(0); i++)
        {
            for (int j = 0; j < smallArray.GetLength(1); j++)
            {
                if (smallArray[i, j] == 0)
                {
                    emptyCount++;
                }
            }
        }
        //Debug.LogError("1 == " + horizontalStart + "    2 == " + verticalStart + "     3 == " + emptyCount);
        if (emptyCount is <= 6 and > 0)
        {
            if (!VehicleHardySay.ContainsKey(emptyCount))
            { 
                VehicleHardySay.Add(emptyCount, new List<FillFourToFour>(){
                    new (){
                        X = horizontalStart,
                        Y = verticalStart,
                        GuestSmite = smallArray
                    }
                });
            }
            else
            {
                var Style= VehicleHardySay[emptyCount];
                Style.Add(new FillFourToFour(){X = horizontalStart,Y = verticalStart, GuestSmite = smallArray});
                VehicleHardySay[emptyCount] = Style;
            }
            
        }

        

        //IsCanOneBlockPlace();
    }


    public void HisHealHardyGiant()
    {
        BlissHisPretendHardy();

        var oneBlockFill = MyFoeDamHardyQuery();
        if (oneBlockFill)
        {
            var twoBlockFill = MyFoeDamHardyQuery();
            if (twoBlockFill)
            {
                //Debug.LogError("两个1个方块组完成两个4*4");
            }
            else
            {
                var tes = MyFoeHueHardyQuery();
            }
        }
        else
        {
            //Debug.LogError("1123123123 个方块填充4*4");
            var tes = MyFoeHueHardyQuery();
        }
    }
    
    (BlockItem, BlockItem) SoCareHardy= (null, null);
[UnityEngine.Serialization.FormerlySerializedAs("FillBlockGroup")]
    public Dictionary<FillFourToFour, (BlockItem, BlockItem)> HealHardyGiant= new();
    private bool MyFoeDamHardyQuery()
    {
        bool isCanPlace = false;
        SoCareHardy = (null, null);
        for (int i = 6; i > 0; i--)
        {
            if (VehicleHardySay.ContainsKey(i))
            {
                //满足空格子1到6的4*4
                for (int j = 0; j < VehicleHardySay[i].Count; j++)
                {
                    if (!HealHardyGiant.ContainsKey(VehicleHardySay[i][j]))
                    {
                        SoCareHardy = (HisHealHardyGiantHue(i, VehicleHardySay[i][j], HardyDesignHardyFaculty.Instance.FactorHardy), null);
                        //返回null，没有满足的，继续遍历查找
                        if (SoCareHardy.Item1 != null)
                        {
                            HealHardyGiant.Add(VehicleHardySay[i][j], SoCareHardy);
                            isCanPlace = true;
                            return isCanPlace;
                        }
                    }
                }
            }
        }
        return isCanPlace;
    }

    private bool MyFoeHueHardyQuery()
    {
        bool isCanPlace = false; 
        SoCareHardy = (null, null);
        for (int i = 6; i > 0; i--)
        {
            if (VehicleHardySay.ContainsKey(i))
            {
                for (int j = 0; j < VehicleHardySay[i].Count; j++)
                {
                    if (!HealHardyGiant.ContainsKey(VehicleHardySay[i][j]))
                    {
                        SoCareHardy = HisHealHueHardyGiant(i, VehicleHardySay[i][j], HardyDesignHardyFaculty.Instance.FactorHardy);
                        if (SoCareHardy.Item1 != null)
                        {
                            HealHardyGiant.Add(VehicleHardySay[i][j], SoCareHardy);
                            isCanPlace = true;
                            return isCanPlace;
                        }
                    }
                }
            }
        }
        return isCanPlace;
    }
    
    int[,] RayEarlyHue= new int[4,4];
    int[,] FactorEarlyHue=  new int[4,4];
    public BlockItem HisHealHardyGiantHue(int emptyCount, FillFourToFour fillFourToFour, HardyDesignWhenHardy curGameBlock)
    {
        Array.Copy(fillFourToFour.GuestSmite, RayEarlyHue, fillFourToFour.GuestSmite.Length);
        Array.Copy(RayEarlyHue, FactorEarlyHue, RayEarlyHue.Length);

        //方块组
        for (int i = 0; i < curGameBlock.Block.Count; i++)
        {
            if (curGameBlock.Block[i].count == emptyCount)
            {
                HisHardyGiant(curGameBlock.Block[i].shape);
                
                //位置
                for (int j = 0; j < 16; j++)
                {
                    if (FoeQueryFactorHardyHue(HardyComa, j, fillFourToFour))
                    {
                        return curGameBlock.Block[i];
                    }
                    else
                    {
                        Array.Copy(RayEarlyHue, FactorEarlyHue, RayEarlyHue.Length);
                    }
                }
            }
        }
        return null;
    }
    
    public bool FoeQueryFactorHardyHue(int[,] blockGroup, int original, FillFourToFour fillFourToFour)
    {
        bool isCanPlace = true;
        int x = original / 4;
        int y = original - (x * 4);
        for (int i = 0; i < blockGroup.GetLength(0); i++)
        {
            for (int j = 0; j < blockGroup.GetLength(1); j++)
            {
                //存在棋子在进行判断
                if (blockGroup[i, j] != 0)
                {
                    //没有超
                    if (x + i < 4 && y + j < 4)
                    {
                        //当前位置存放了方块 4*4
                        if (FactorEarlyHue[x + i, y + j] == 1)
                        {
                            isCanPlace = false;
                            return isCanPlace;
                        }
                    }
                    else
                    {
                        isCanPlace = false;
                        return isCanPlace;
                    }
                }
            }
        }
        
        return isCanPlace;
    }

    public (BlockItem,BlockItem) HisHealHueHardyGiant(int emptyCount, FillFourToFour fillFourToFour, HardyDesignWhenHardy curGameBlock)
    {
        Array.Copy(fillFourToFour.GuestSmite, RayEarlyHue, fillFourToFour.GuestSmite.Length);
        Array.Copy(RayEarlyHue, FactorEarlyHue, RayEarlyHue.Length);
        for (int i = 0; i < curGameBlock.Block.Count; i++)
        {
            if (curGameBlock.Block[i].count < emptyCount)
            {
                for (int j = 0; j < 16; j++)
                {
                    Array.Copy(RayEarlyHue, FactorEarlyHue, RayEarlyHue.Length);
                    HisHardyGiant(curGameBlock.Block[i].shape);
                    if (FoeQueryFactorDamHardy(HardyComa, j, fillFourToFour))
                    {
                        for (int k = 0; k < curGameBlock.Block.Count; k++)
                        {
                            if (curGameBlock.Block[k].count == emptyCount - curGameBlock.Block[i].count)
                            {
                                for (int l = 0; l < 16; l++)
                                {
                                    HisHardyGiantHue(curGameBlock.Block[k].shape);
                                    if (FoeQueryFactorHardyHue(HardyComaHue, l, fillFourToFour))
                                    {
                                        return (curGameBlock.Block[i], curGameBlock.Block[k]);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        
                    }
                }
            }
        }
        
        return (null, null);
    }
    
    public bool FoeQueryFactorDamHardy(int[,] blockGroup, int original, FillFourToFour fillFourToFour)
    {
        bool isCanPlace = true;
        int x = original / 4;
        int y = original - (x * 4);
        for (int i = 0; i < blockGroup.GetLength(0); i++)
        {
            for (int j = 0; j < blockGroup.GetLength(1); j++)
            {
                //存在棋子在进行判断
                if (blockGroup[i, j] != 0)
                {
                    //没有超
                    if (x + i < 4 && y + j < 4)
                    {
                        //当前位置存放了方块 4*4
                        if (FactorEarlyHue[x + i, y + j] == 1)
                        {
                            isCanPlace = false;
                            return isCanPlace;
                        }
                    }
                    else
                    {
                        isCanPlace = false;
                        return isCanPlace;
                    }
                }
            }
        }
        
        
        for (int i = 0; i < blockGroup.GetLength(0); i++)
        {
            for (int j = 0; j < blockGroup.GetLength(1); j++)
            {
                //存在棋子在进行判断
                if (blockGroup[i, j] == 0)
                    continue;
                //没有超
                if (x + i >= 4 || y + j >= 4)
                    continue;
                //当前位置存放了方块 4*4
                if (FactorEarlyHue[x + i, y + j] != 1)
                {
                    FactorEarlyHue[x + i, y + j] = 1;
                }
            }
        }
        return isCanPlace;
    }

  #endregion
    
    public void HisMortalBedroom()
    {
        HardyDesignWhenOvertime.Instance.SoCareCompanyScat = false;
        HardyDesignWhenOvertime.Instance.SoCareBowel = false; 
        HardyDesignWhenOvertime.Instance.SoCareBackup = false;
        if (!BureauVolt.MyRaise() && MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == 99)
        {
            for (int i = 0; i < DeftVirgoPut.Count; i++)
            {
                //暂定刮刮卡
                if (DeftVirgoPut[i].transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().Well == 99)
                {
                    HardyDesignWhenOvertime.Instance.SoCareCompanyScat = true;
                    MindGazeFaculty.SetInt(CChoppy.Of_FleetCompanyScat, 0);
                    break;
                } 
            }
            //刮刮卡奖励
            HardyDesignDeftFaculty.instance.MobBowelLop();
        }
        if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == 99)
        {
            //分数奖励
            HardyDesignBackupFaculty.Instance.MobBackup(FactorAlgaHardy.Count, VirgoHardyGiantExtol);
        }
        else
        {
            //分数奖励
            if (BureauVolt.MyRaise())
            {
                HardyDesignBackupFaculty.Instance.MobQuiltBackup(FactorAlgaHardy.Count, VirgoHardyGiantExtol);
            }
        }
        
        HardyDesignWhenOvertime.Instance.FactorVirgoHardyShare?.Invoke();
    }

    List<HardyDesignHardyLizard> ElkCobalt= new List<HardyDesignHardyLizard>();
    /// <summary>
    /// 目标方块飞行
    /// </summary>
    public void ElkCobaltHardy()
    {
        ElkCobalt.Clear();
        PreciseCinemaBliss.HisEquality().Dram(CChoppy.We_FattyUI);
        
        StartCoroutine(PortCrop(0.1f, () =>
        {
            float Time = 0;
            var list = WhenSpear.Instance.HardySP.Select(t => t.gameObject).Where(Item => Item.GetComponent<HardyDesignHardyLizard>().Well != 99).ToList();
            for (int k = 0; k < list.Count; k++)
            {
                int a = k;
                Time += 0.1f;
                GameObject Item = list[k].gameObject;
                Item.transform.GetChild(0).GetComponent<Image>().sprite = WhenSpear.Instance.CobaltName[Item.GetComponent<HardyDesignHardyLizard>().Well - 2].GetComponent<Image>().sprite;
                Sequence mySequence = DOTween.Sequence();

                // 加入缩放动画
                //mySequence.Append(Item.transform.DOScale(1.5f, 0.3f).SetEase(Ease.OutSine))
                //    .Append(Item.transform.DOScale(1.2f, 0.2f).SetEase(Ease.OutSine));


                // 创建随机移动方向的向量
                Vector3 randomMove1 = new Vector3(Random.Range(-0.55f, 0.55f) + Item.transform.position.x, Random.Range(-0.55f, 0.55f) + Item.transform.position.y,
                     +Item.transform.position.z);
                Vector3 randomMove2 = new Vector3(Random.Range(-0.4f, 0.4f) + randomMove1.x, Random.Range(-0.4f, 0f) + randomMove1.y, randomMove1.z);

                // 加入移动动作
                mySequence.Insert(0, Item.transform.DOMove(randomMove1, 0.2f).SetEase(Ease.OutSine));
                //.Append(Item.transform.DOMove(randomMove2, 0.2f).SetEase(Ease.OutSine));

                // 随机旋转角度向量
                Vector3 rotateValue = new Vector3(0, 0, Random.Range(-10f, 10f));

                // 加入旋转动作
                mySequence.Insert(0, Item.transform.DORotate(rotateValue, 0.2f).SetEase(Ease.OutSine));



                mySequence.Insert(0.2f, Item.transform.DOMove(WhenSpear.Instance.CobaltName[Item.GetComponent<HardyDesignHardyLizard>().Well - 2].transform.position, 0.6f).SetEase(Ease.InQuint).SetDelay(Time).OnComplete(() =>
                {
                    Item.GetComponent<HardyDesignHardyLizard>().VirgoHardy();
                    StartCoroutine(PortCrop(3, () =>
                    {
                        Destroy(Item);
                    }));
                    if (a == k - 1)
                        HardyDesignWhenOvertime.Instance.CobaltHardyElk?.Invoke();
                })).OnStart((() =>
                {
                    //Item.GetComponent<HardyDesignHardyLizard>().ShowFlyEffect();
                }));
                mySequence.Insert(0.2f, Item.transform.DOScale(0.9f, 0.5f).SetDelay(Time).SetEase(Ease.InBack));
                mySequence.Insert(0.2f, Item.transform.DORotate(new Vector3(0, 0, 0), 0.5f).SetEase(Ease.OutSine).SetDelay(Time));
                // 启动整个动画序列
                mySequence.Play();
            }
        }));

        
        foreach (HardyDesignHardyLizard block in DeftVirgoPut.Select(t => t.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>()).Where(block => block.Well != 0 && block.Well != 1 && block.Well != 99))
        {
            ElkCobalt.Add(block);
        }
        
        if (ElkCobalt.Count == 0)
        {
            HardyDesignWhenOvertime.Instance.CobaltHardyElk?.Invoke();
        }
        else
        {
            /*for (int i = 0; i < FlyTarget.Count; i++)
            {
                FlyTarget[i].ClearBlock();
            }
            
            //finish
            HardyDesignWhenOvertime.Instance.TargetBlockFly?.Invoke();*/
        }
        
        
    }


    private void BlockDayTricycleFactor()
    {
        GameObject panel = null;
        
            panel = WhenSpear.Instance.gameObject;
       

        FordBlockBegin(HardyDesignBackupFaculty.Instance.HisBlock() >= 3);
        // 没有消除
        if (VirgoHardyGiantExtol == 0)
        {
            //BlockPuzzleGamePanel.Instance.ShowSourceItem(new Vector2(0,0),SourceShowPos, true);
        }
        //消除一组
        else if (VirgoHardyGiantExtol == 1)
        {
            //HardyDesignDeftFaculty.instance.TapPopVibrate();
            if (HardyDesignBackupFaculty.Instance.HisBlock() > 1)
            {
                if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == 99)
                    WhenSpear.Instance.BlockFordSun(HardyDesignBackupFaculty.Instance.HisBlock(), HurlFordBur.position, true);
            }
            else
            {
                if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == 99)
                    WhenSpear.Instance.BlockFordSun(HardyDesignBackupFaculty.Instance.HisBlock(), HurlFordBur.position, false);
            }
            //震动
            if (HardyDesignBackupFaculty.Instance.HisBlock() >= 3)
                ShakeLengthBur();
        }
        //多组
        else
        {
            //HardyDesignDeftFaculty.instance.TapPopVibrate();
            if (HardyDesignBackupFaculty.Instance.HisBlock() > 1)
            {
                if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == 99)
                    WhenSpear.Instance.BlockFordSun(HardyDesignBackupFaculty.Instance.HisBlock(), HurlFordBur.position, true);
                //震动
                if (HardyDesignBackupFaculty.Instance.HisBlock() >= 3)
                    ShakeLengthBur();

                StartCoroutine(PortCrop(1.2f, () =>
                {
                    FordToadVirgo();
                }));
            }
            else
            {
                ShakeLengthBur();
                if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == 99)
                    WhenSpear.Instance.FordBackupBath(new Vector2(0, 0), BackupFordBur, true);
                RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Multipleclean);
                FordToadVirgo();
            }
        }

        LayerFatPeat.Equality.DramMortalLayer(1104, "game_key_feedback_1104");
    }
[UnityEngine.Serialization.FormerlySerializedAs("duration")]    public float Electric= 0.5f; // 震动持续的时间
[UnityEngine.Serialization.FormerlySerializedAs("strength")]    public float Hermetic= 10f; // 震动的强度，数值越大震动越明显
[UnityEngine.Serialization.FormerlySerializedAs("vibrato")]    public int Besides= 10; // 震动的次数
[UnityEngine.Serialization.FormerlySerializedAs("randomness")]    public float Acceptance= 90f; // 震动的随机性
    private void ShakeLengthBur()
    {
        RectTransform ani = MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == 99 ?
            WhenSpear.Instance.gameObject.GetComponent<RectTransform>() :
            WhenQuiltSpear.Instance.gameObject.GetComponent<RectTransform>();
        ani.DOShakeAnchorPos(Electric, Hermetic, Besides, Acceptance, false, false);
    }

    public void FordBlockBegin(bool isShow)
    {
        SkeletonGraphic ani = MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == 99 ?
            WhenSpear.Instance.BlockBegin.GetComponent<SkeletonGraphic>() :
            WhenQuiltSpear.Instance.BlockBegin.GetComponent<SkeletonGraphic>();
        if (isShow)
        {
            //显示中
            if (!ani.gameObject.activeSelf)
            {
                //ani.gameObject.SetActive(true);
                //ani.AnimationState.SetAnimation(0, "animation", true);
            }
        }
        else
        {
            ani.gameObject.SetActive(false);
        }

    }

    private void FordToadVirgo()
    {
        Vector3 pos = HurlFordBur.position;

        if (pos.x > 0.7f)
        {
            pos = new Vector3(0.7f, pos.y, pos.z);
        }
        if (pos.x < -0.7f)
        {
            pos = new Vector3(-0.7f, pos.y, pos.z);
        }
        if (pos.y > 0.8f)
        {
            pos = new Vector3(pos.x, 0.8f, pos.z);
        }
        if (pos.y < -0.8f)
        {
            pos = new Vector3(pos.x, -0.8f, pos.z);
        }


        SkeletonGraphic ani = WhenSpear.Instance.ToadVirgo.GetComponent<SkeletonGraphic>();
        ani.transform.position = pos;
        switch (VirgoHardyGiantExtol)
        {
            case 2:
                ani.AnimationState.SetAnimation(0, "good", false);//BX 打点需求
                RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Good);
                break;
            case 3:
                ani.AnimationState.SetAnimation(0, "shake", false);
                RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Amazing);
                break;
            case 4:
                ani.AnimationState.SetAnimation(0, "brain", false);
                RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Excellent);
                break;
            default:
                ani.AnimationState.SetAnimation(0, "crush", false);
                RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Great);
                break;
        }
    }
    private int HisHurlBur()
    {
        var x = HurlFordBur.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().X;
        var y = HurlFordBur.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().Y;
        switch (x)
        {
            case < 3 when y < 3:
                return 1;
            case < 3 when y < 6:
                return 2;
            case < 3:
                return 3;
            case < 6 when y < 3:
                return 4;
            case < 6 when y < 6:
                return 5;
            case < 6:
                return 6;
            default:
                {
                    if (y < 3)
                        return 7;
                    else if (y < 6)
                        return 8;
                    else
                        return 9;
                }
        }
    }
[UnityEngine.Serialization.FormerlySerializedAs("FailedBlock")]
    //棋盘中放置的棋子
    public List<GameObject> LethalHardy= new List<GameObject>();
    public void IcelandLethalNovel()
    {
        LethalHardy.Clear();
        for (int i = 0; i < RouteNovelComa.Count; i++)
        {
            if (EarlyRouteNovel[i / 9, i % 9] == 1)
            {
                LethalHardy.Add(RouteNovelComa[i]);
            }
        }
    }
    
    /// <summary>
    /// 关卡完成动画
    /// </summary>
    /// <param name="cb"></param>
    public void FordWinSun(Action cb)
    {
        StartCoroutine(FordOweSunDemo(cb));
    }

    private IEnumerator FordOweSunDemo(Action cb)
    {
        WhenSpear.Instance.TemptBegin.AnimationState.SetAnimation(0, "Action", true);
        //WhenSpear.Instance.BonusSpine.gameObject.SetActive(true);
        GameObject RouteNovelGiant= WhenSpear.Instance.RouteNovelGiant;
        BlockColor Upset= MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == 99 ? (BlockColor)Random.Range(0, 5) : BlockColor.Red;
        for (int i = 0; i < RouteNovelGiant.transform.childCount; i++)
        {
            RouteNovelGiant.transform.GetChild(i).transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().Bank(i / 9, i % 9, 1, Upset);
            RouteNovelGiant.transform.GetChild(i).transform.localScale = new Vector3(0, 0, 0);
            RouteNovelGiant.transform.GetChild(i).transform.DOScale(1, 0.3f).SetEase(Ease.OutBack).SetDelay(RouteNovelGiant.transform.GetChild(i).transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().Y * 0.1f);
        }

        WhenSpear.Instance.Dolphin.SetActive(true);
        WhenSpear.Instance.Dolphin.GetComponent<Dolphin>().TouristFord();
        yield return new WaitForSeconds(1);
        //CheckBoardGroup 方块父级的父级        
        for (int i = 8; i >= 0; i--)
        {
            for (int j = 0; j < 9; j++)
            {
                //StartCoroutine(FlowerbedGeneralist.LevelOver(CheckBoardGroup.transform.GetChild(i + j * 9).transform, 1 - i * 0.1f, true));
                StartCoroutine(FlowerbedGeneralist.CrudeRote(RouteNovelGiant.transform.GetChild(i + j * 9).transform, 1 - i * 0.1f));
            }
        }

        for (int i = 0; i < RouteNovelGiant.transform.childCount; i++)
        {
            StartCoroutine(FlowerbedGeneralist.RoteVirgoSun(RouteNovelGiant.transform.GetChild(i).transform.GetChild(0).gameObject, 1 - (RouteNovelGiant.transform.GetChild(i).transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().Y * 0.1f), () =>
            {
                //CheckBoardGroup.transform.GetChild(i).transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().ShowImage(0);
            }));
        }
        for (int i = 0; i < 9; i++)
        {
            RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Clear);
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(4);
        WhenSpear.Instance.TemptBegin.AnimationState.SetEmptyAnimation(0, 0);
        //WhenSpear.Instance.BonusSpine.gameObject.SetActive(false);
        cb?.Invoke();
    }
    
}

public class EmptyBlockPos
{
    public int X;
    public int Y;
}

public class FillFourToFour
{
    public int X{ get; set; }
    public int Y{ get; set; }
    public int[,] GuestSmite{ get; set; }
}