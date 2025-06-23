using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LitJson;
using UnityEngine;
using Random = UnityEngine.Random;

public class HardyDesignCrudeFaculty : MonoBehaviour
{
    public static HardyDesignCrudeFaculty Instance;
[UnityEngine.Serialization.FormerlySerializedAs("levelInfoData")]
    public HardyDesignCrudeComaGaze WriteComaGaze;
[UnityEngine.Serialization.FormerlySerializedAs("totalBlockToCheckBoard")]    public TotalBlockToCheckBoard ApplyHardyUpRouteNovel;
[UnityEngine.Serialization.FormerlySerializedAs("totalBlockThree")]    public TotalBlockThree ApplyHardyDutch;
    void Awake()
    {
        Instance = this;
        BankCrudeComa();

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BankCrudeComa()
    {
        TextAsset Pool= Resources.Load<TextAsset>("LocationJson/LevelData");
        WriteComaGaze = JsonMapper.ToObject<HardyDesignCrudeComaGaze>(Pool.text);
        Pool = Resources.Load<TextAsset>("LocationJson/ThreeToThreeData");
        ApplyHardyDutch = JsonMapper.ToObject<TotalBlockThree>(Pool.text);
        Pool = Resources.Load<TextAsset>("LocationJson/BlockToCheckBoardData");
        ApplyHardyUpRouteNovel = JsonMapper.ToObject<TotalBlockToCheckBoard>(Pool.text);
    }


    public int HisPryCrude()
    {
        return MindGazeFaculty.GetInt(CChoppy.Of_CrudeAx);
    }

    public void MobCrude()
    {
        var level = MindGazeFaculty.GetInt(CChoppy.Of_CrudeAx);
        level++;
        MindGazeFaculty.SetInt(CChoppy.Of_CrudeAx, level);
        HardyDesignTrafficFaculty.instance.FactorHomelessTrafficShare();
        Debug.Log("LevelId Add:" + MindGazeFaculty.GetInt(CChoppy.Of_CrudeAx));
    }
[UnityEngine.Serialization.FormerlySerializedAs("CurLevelInfo")]
    public List<int> PryCrudeComa= new List<int>();
    public void HisPryCrudeComa()
    {
        MindGazeFaculty.SetBool(CChoppy.Of_MyPhrase, false);
        if (MindGazeFaculty.GetString(CChoppy.Of_PryWhenBoat) == "challenge")
        {
            TextAsset Pool= Resources.Load<TextAsset>("LocationJson/BlockToCheckBoardData");
            ApplyHardyUpRouteNovel = JsonMapper.ToObject<TotalBlockToCheckBoard>(Pool.text);
            if (WriteComaGaze.CrudeGaze.Count >= HisPryCrude() + 1)
            {
                PryCrudeComa.Clear();
                foreach (BlockToCheckBoard t in ApplyHardyUpRouteNovel.BlockToCheckBoards.Where(t => WriteComaGaze.CrudeGaze[HisPryCrude()].Syrup == t.Id))
                {
                    PryCrudeComa = NameHuddleUpNameWin(t.OnceBlockInfo);
                }
                if (PryCrudeComa.Count == 0)
                {
                    PryCrudeComa = HisLuxuryName();
                }
            }
            else
            {
                for (int i = 1; i <= HisPryCrude() + 1; i++)
                {
                    if (WriteComaGaze.CrudeGaze.Count >= i)
                    {

                    }
                    else
                    {
                        if (i == HisPryCrude() + 1)
                        {
                            IcelandRayCobalt();
                            WriteComaGaze.CrudeGaze.Add(new LevelData(){
                                Go = "", Cannon = "", Syrup = -1, Seldom = _Seldom,
                                Seldom_Greet = _Seldom_Greet, Trade = "", Adrenaline = 0
                            });
                        }
                        else
                        {
                            WriteComaGaze.CrudeGaze.Add(new LevelData(){
                                Go = "", Trade = "", Adrenaline = 0, Syrup = -1,
                                Cannon = "", Seldom = "", Seldom_Greet = ""
                            });
                        }
                    }
                }
                PryCrudeComa = HisLuxuryName();
            }
        }
        else if (MindGazeFaculty.GetString(CChoppy.Of_PryWhenBoat) == "Guide")
        {
            TextAsset Pool= Resources.Load<TextAsset>("LocationJson/GuideBlockToCheckBoardData");
            ApplyHardyUpRouteNovel = JsonMapper.ToObject<TotalBlockToCheckBoard>(Pool.text);
            PryCrudeComa.Clear();
            foreach (BlockToCheckBoard t in ApplyHardyUpRouteNovel.BlockToCheckBoards.Where(t => MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) == t.Id))
            {
                PryCrudeComa = NameHuddleUpNameWin(t.OnceBlockInfo);
            }
        }
        else
        {
            PryCrudeComa = new List<int>();
            for (int i = 0; i < 81; i++)
            {
                PryCrudeComa.Add(0);
            }
        }
    }

    int[] ApplyCobaltName= new int[]{
        2, 3, 4, 5, 6
    };
    List<int> SeldomName= new List<int>();
    List<int> SeldomExtol= new List<int>();

    string _Seldom= "";
    string _Seldom_Greet= "";
    private void IcelandRayCobalt()
    {
        _Seldom = "";
        _Seldom_Greet = "";
        SeldomName.Clear();
        SeldomExtol.Clear();
        var totaltargetCount = Random.Range(1, 4);
        ApplyCobaltName = HardyDesignDeftFaculty.instance.LuxuryWin(ApplyCobaltName);

        for (int i = 0; i < totaltargetCount; i++)
        {
            SeldomName.Add(ApplyCobaltName[i]);
            switch (totaltargetCount)
            {
                case 1:
                    SeldomExtol.Add(Mathf.CeilToInt((15 + HisPryCrude() / 10) * (1 + Random.Range(-0.1f, 0.1f))));
                    break;
                case 2:
                    SeldomExtol.Add(Mathf.CeilToInt((10 + HisPryCrude() / 12) * (1 + Random.Range(-0.1f, 0.1f))));
                    break;
                case 3:
                    SeldomExtol.Add(Mathf.CeilToInt((7 + HisPryCrude() / 20) * (1 + Random.Range(-0.1f, 0.1f))));
                    break;
            }
        }
        _Seldom = String.Join("#", SeldomName);
        _Seldom_Greet = String.Join("#", SeldomExtol);
    }
    int[] Riverbed= new int[]{
        1, 2, 3, 4, 5, 6, 7, 8, 9
    };
    private List<int> HisLuxuryName()
    {
        Riverbed = HardyDesignDeftFaculty.instance.LuxuryWin(Riverbed);
        var showCount = Random.Range(2, 6);
        RouteNovelComaHost.Clear();
        for (int i = 0; i < 81; i++)
        {
            RouteNovelComaHost.Add(0);
        }
        for (int i = 0; i < Riverbed.Length; i++)
        {
            if (Riverbed[i] < showCount)
            {
                var Hear= HisDutch();
                IcelandRouteNovel(i, Hear);
            }
            else
            {

            }
        }
        /*for (int i = 0; i < targetList.Count; i++)
        {
            Debug.Log("i == "+ i +"   targetList == " + targetList[i]);
        }*/
        return RouteNovelComaHost;
    }
[UnityEngine.Serialization.FormerlySerializedAs("CheckBoardInfoInts")]
    public List<int> RouteNovelComaHost= new List<int>(81);
    private void IcelandRouteNovel(int index, ThreeToThree three)
    {

        int startRwo = 0;
        int startCol = 0;
        switch (index)
        {
            case 0:
                startRwo = 0;
                startCol = 0;
                break;
            case 1:
                startRwo = 0;
                startCol = 3;
                break;
            case 2:
                startRwo = 0;
                startCol = 6;
                break;
            case 3:
                startRwo = 3;
                startCol = 0;
                break;
            case 4:
                startRwo = 3;
                startCol = 3;
                break;
            case 5:
                startRwo = 3;
                startCol = 6;
                break;
            case 6:
                startRwo = 6;
                startCol = 0;
                break;
            case 7:
                startRwo = 6;
                startCol = 3;
                break;
            case 8:
                startRwo = 6;
                startCol = 6;
                break;
        }

        for (int i = startRwo; i < startRwo + 3; i++)
        {
            for (int j = startCol; j < startCol + 3; j++)
            {
                if (three == null)
                {
                    RouteNovelComaHost[j + i * 9] = 0;
                }
                else
                {
                    //Debug.LogError("i == "+ i +"    j == "+ j + "    3 == " + ((2 - (j - startCol)) * 3 + (i - startRwo)) +"    4== " + (j + i * 9));

                    if (three.layout[(2 - (j - startCol)) * 3 + (i - startRwo)] == 2)
                    {
                        //int value = CurSelectTarget[InputValue / 10];
                        RouteNovelComaHost[j + i * 9] = SeldomName[Random.Range(0, SeldomName.Count)];
                    }
                    else
                    {
                        RouteNovelComaHost[j + i * 9] = three.layout[(2 - (j - startCol)) * 3 + (i - startRwo)];
                    }
                }
            }
        }

    }

    private ThreeToThree HisDutch()
    {
        int sum = 0;
        for (int i = 0; i < ApplyHardyDutch.ThreeToThree.Count; i++)
        {
            sum += ApplyHardyDutch.ThreeToThree[i].weight;
        }
        int rewardRandom = Random.Range(0, 999);

        float Love= 0;
        for (int i = 0; i < ApplyHardyDutch.ThreeToThree.Count; i++)
        {
            Love += ApplyHardyDutch.ThreeToThree[i].weight / (float)sum;
            if (rewardRandom <= Love * 1000)
            {
                return ApplyHardyDutch.ThreeToThree[i];
            }
        }
        return ApplyHardyDutch.ThreeToThree[0];
    }

    /// <summary>
    /// 转置
    /// </summary>
    /// <param name="ints"></param>
    /// <returns></returns>
    public List<string> NameWinUpNameHuddle(List<int> ints)
    {
        PlusFlueUpCliff(ints);
        return PearlyNameDustVisible(ints, 9);
    }

    public List<int> NameHuddleUpNameWin(List<string> list)
    {
        List<int> allNumbers = new List<int>();
        foreach (string section in list)
        {
            allNumbers.AddRange(ArsenicHuddleUpName(section));
        }
        PlusFlueUpLeft(allNumbers);
        return allNumbers;
    }

    private int Stay= 9;
    private void PlusFlueUpCliff(List<int> ints)
    {
        for (int layer = 0; layer < Stay / 2; layer++)
        {
            int first = layer;
            int last = Stay - 1 - layer;
            for (int i = first; i < last; i++)
            {
                int offset = i - first;
                // 保存顶部的值
                int top = ints[first * Stay + i];
                // 右边的值到顶部
                ints[first * Stay + i] = ints[i * Stay + last];
                // 底部的值到右边
                ints[i * Stay + last] = ints[last * Stay + (last - offset)];
                // 左边的值到底部
                ints[last * Stay + (last - offset)] = ints[(last - offset) * Stay + first];
                // 顶部的值到左边
                ints[(last - offset) * Stay + first] = top;
            }
        }
    }

    // 定义滚动函数
    private void PlusFlueUpLeft(List<int> ints)
    {
        for (int layer = 0; layer < Stay / 2; layer++)
        {
            int first = layer;
            int last = Stay - 1 - layer;
            for (int i = first; i < last; i++)
            {
                int offset = i - first;
                // 保存顶部的值
                int top = ints[first * Stay + i];
                // 左边的值到顶部
                ints[first * Stay + i] = ints[(last - offset) * Stay + first];
                // 底部的值到左边
                ints[(last - offset) * Stay + first] = ints[last * Stay + (last - offset)];
                // 右边的值到底部
                ints[last * Stay + (last - offset)] = ints[i * Stay + last];
                // 顶部的值到右边
                ints[i * Stay + last] = top;
            }
        }
    }

    private List<string> PearlyNameDustVisible(List<int> numbers, int parts)
    {
        List<string> stringSections = new List<string>();
        int partSize = numbers.Count / parts;

        for (int i = 0; i < parts; i++)
        {
            // 获取子列表
            List<int> section = numbers.GetRange(i * partSize, partSize);

            // 将子列表转换成字符串
            string sectionAsString = string.Join(", ", section);

            // 添加字符串到结果列表
            stringSections.Add(sectionAsString);
        }

        return stringSections;
    }

    private List<int> ArsenicHuddleUpName(string numbersString)
    {
        List<int> numbers = new List<int>();
        // 用分隔符分割字符串
        string[] numbersArray = numbersString.Split(new string[]{
            ", "
        }, System.StringSplitOptions.RemoveEmptyEntries);

        // 将每个分割出的字符串转换成整数并添加到列表
        foreach (string number in numbersArray)
        {
            if (int.TryParse(number, out int result))
            {
                numbers.Add(result);
            }
        }

        return numbers;
    }

    private List<int> ArsenicHuddleUpNameByRocky(string numbersString)
    {
        List<int> numbers = new List<int>{
        };
        // 用分隔符分割字符串
        string[] numbersArray = numbersString.Split(new string[]{
            ","
        }, System.StringSplitOptions.RemoveEmptyEntries);

        // 将每个分割出的字符串转换成整数并添加到列表
        foreach (string number in numbersArray)
        {
            if (int.TryParse(number, out int result))
            {
                numbers.Add(result);
            }
        }

        return numbers;
    }
[UnityEngine.Serialization.FormerlySerializedAs("Target")]
    public Dictionary<int, string> Cobalt= new Dictionary<int, string>();
    List<int> VirusNumbers= new List<int>{
    };
    List<int> AvoidableJewelry= new List<int>();
[UnityEngine.Serialization.FormerlySerializedAs("SumTargetCount")]    public int AntCobaltExtol= 0;
    
    public void BankCobalt()
    {
        Cobalt.Clear();
        VirusNumbers.Clear();
        AntCobaltExtol = 0;
        string[] newKeyStr;
        string[] newValueStr;
        newKeyStr = WriteComaGaze.CrudeGaze[HisPryCrude()].Seldom.Split('#');
        newValueStr = WriteComaGaze.CrudeGaze[HisPryCrude()].Seldom_Greet.Split('#');
        if (newKeyStr.Length >= 2)
        {
            for (int i = 0; i < newKeyStr.Length; i++)
            {
                VirusNumbers.Add(int.Parse(newKeyStr[i]));
            }
        }
        else
        {
            VirusNumbers.Add(int.Parse(newKeyStr[0]));
        }

        AvoidableJewelry = ArsenicJewelry(VirusNumbers);
        for (int i = 0; i < AvoidableJewelry.Count; i++)
        {
            if (!Cobalt.ContainsKey(AvoidableJewelry[i]))
                Cobalt.Add(AvoidableJewelry[i], newValueStr[i]);
        }
        AntCobaltExtol = Cobalt.Sum(pair => int.Parse(pair.Value));
        IcelandHardyBeauty();
    }

    private void IcelandHardyBeauty()
    {
        //获取当前数据数
        var list = ArsenicHuddleUpNameByRocky(WriteComaGaze.CrudeGaze[HisPryCrude()].Trade);

        //新关卡没有这个配置
        if (list.Count == 0)
        {
            MindGazeFaculty.SetInt(CChoppy.Of_BeautyExtol, 0);
        }
        //存在这个值
        else
        {
            //打乱顺序
            //list = HardyDesignDeftFaculty.instance.RandomList(list);
            int[] BlockPreset = list.ToArray();
            MindGazeFaculty.SetIntArray(CChoppy.Of_HardyBeauty, BlockPreset);
            MindGazeFaculty.SetInt(CChoppy.Of_BeautyExtol, list.Count);
        }
    }

    public List<int> HisDirtHardyGiant()
    {
        var PresetCount = MindGazeFaculty.GetInt(CChoppy.Of_BeautyExtol);
        List<int> nextGroup = new List<int>{
        };
        if (PresetCount >= 3)
        {
            var intGroup = MindGazeFaculty.GetIntArray(CChoppy.Of_HardyBeauty);
            List<int> intlist2 = new List<int>(intGroup);
            nextGroup = intlist2.GetRange(intGroup.Length - PresetCount, 3);
            PresetCount -= 3;
            MindGazeFaculty.SetInt(CChoppy.Of_BeautyExtol, PresetCount);
        }
        return nextGroup;
    }

    List<int> CementCobalt= new List<int>();
    public int HisLuxuryCobalt()
    {
        CementCobalt = new List<int>();
        foreach (var vable in Cobalt)
        {
            //还存在未完成目标
            if (vable.Value != "0")
            {
                //目标块数
                if (HardyDesignHardyFaculty.Instance.RouteNovelCobalt[vable.Key] <= int.Parse(vable.Value) + 2)
                {
                    CementCobalt.Add(vable.Key);
                }
            }
        }
        Debug.Log("randomTarget.Count == " + CementCobalt.Count);
        if (CementCobalt.Count == 0)
            return 1;
        return CementCobalt[Random.Range(0, CementCobalt.Count)];
    }

    private System.Random Cement= new System.Random();
    private List<int> ArsenicJewelry(List<int> inputNumbers)
    {
        // 用来存储2到6之间已经出现的数字
        HashSet<int> existingNumbers = new HashSet<int>();

        // 保存转换后的结果
        List<int> result = new List<int>();

        foreach (var number in inputNumbers)
        {
            // 如果数字在2到6之间，直接添加
            if (number >= 2 && number <= 6)
            {
                existingNumbers.Add(number);
                result.Add(number);
            }
            // 如果数字是7、8、9，则需要转换
            else if (number >= 7 && number <= 9)
            {
                // 获取一个2到6之间未被选取的随机数字
                int convertedNumber = HisLuxuryUniqueSadden(existingNumbers);
                existingNumbers.Add(convertedNumber);
                result.Add(convertedNumber);
                for (int i = 0; i < PryCrudeComa.Count; i++)
                {
                    if (PryCrudeComa[i] == number)
                        PryCrudeComa[i] = convertedNumber;
                }
            }
        }

        return result;
    }

    private int HisLuxuryUniqueSadden(HashSet<int> existingNumbers)
    {
        List<int> possibleNumbers = Enumerable.Range(2, 5).ToList();
        // 移除已经存在的数字
        possibleNumbers.RemoveAll(x => existingNumbers.Contains(x));
        int Syrup= Cement.Next(possibleNumbers.Count);
        return possibleNumbers[Syrup];
    }

    /// <summary>
    /// 消减目标
    /// </summary>
    /// <param name="index"></param>
    public void GrainyCobalt(int index)
    {
        if (Cobalt.ContainsKey(index) && int.Parse(Cobalt[index]) > 0)
        {
            Cobalt[index] = (int.Parse(Cobalt[index]) - 1).ToString();
            if (Cobalt[index] != "0")
            {
                RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Targetfly);
            }
            else
            {
                RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Targetcomplete);
            }
            PreciseCinemaBliss.HisEquality().Dram(CChoppy.We_IcelandCrudeCobalt);
        }
    }

    /// <summary>
    /// 正常模式判断胜利
    /// </summary>
    /// <returns></returns>
    public bool FactorIceberg()
    {
        bool isSuccess = true;
        foreach (var dic in Cobalt)
        {
            if (int.Parse(dic.Value) > 0)
            {
                isSuccess = false;
                return isSuccess;
            }
        }
        return isSuccess;
    }
}
