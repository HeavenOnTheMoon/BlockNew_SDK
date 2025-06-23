/*
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LitJson;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CruelCrudeSpear : AlgaUISleek
{
    public Button CreatBtn;
    public Button SaveBtn;
    public Button NextBtn;

    public TMP_InputField StartLevel;
    public List<TMP_InputField> CheckboardInputFields;

    public GameObject BlockParent;

    public TotalBlockThree totalBlockThree;
    public TotalBlockToCheckBoard totalBlockToCheckBoard;

    public List<GameObject> CheckBoardInfo;
    public List<int> CheckBoardInfoInts = new List<int>(81);
    // Start is called before the first frame update
    void Start()
    {
        InitBlockInfo();
        for (int i = 0; i < BlockParent.transform.childCount; i++)
        {
            BlockParent.transform.GetChild(i).transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().Init(i / 9, i % 9, 0);
            CheckBoardInfo.Add(BlockParent.transform.GetChild(i).gameObject);
        }
        CreatBtn.onClick.AddListener(() =>
        {
            CreatBtnClick();
        });

        SaveBtn.onClick.AddListener(() =>
        {
            SaveBtnClick();
        });

        NextBtn.onClick.AddListener(() =>
        {
            NextBtnClick();
        });
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// 初始化3*3
    /// </summary>
    public void InitBlockInfo()
    {
        TextAsset json = Resources.Load<TextAsset>("LocationJson/ThreeToThreeData");
        totalBlockThree = JsonMapper.ToObject<TotalBlockThree>(json.text);
        json = Resources.Load<TextAsset>("LocationJson/BlockToCheckBoardData");
        totalBlockToCheckBoard = JsonMapper.ToObject<TotalBlockToCheckBoard>(json.text);
        if (totalBlockToCheckBoard != null)
            StartLevel.text = totalBlockToCheckBoard.BlockToCheckBoards.Count.ToString();
    }

    Dictionary<int, ThreeToThree> checkBoardInfo = new Dictionary<int, ThreeToThree>();

    Dictionary<int, int> CurSelectTarget = new Dictionary<int, int>();
    public void CreatBtnClick()
    {
        checkBoardInfo.Clear();
        CheckBoardInfoInts.Clear();
        for (int i = 0; i < 81; i++)
        {
            CheckBoardInfoInts.Add(0);
        }
        RefreshTarget();

        for (int i = 0; i < CheckboardInputFields.Count; i++)
        {
            if (CheckboardInputFields[i].text == "" || CheckboardInputFields[i].text == "0")
            {
                //空数据
                RefreshCheckBoard(i, null, 0);
            }
            else
            {
                //存在数据
                if (checkBoardInfo.ContainsKey(int.Parse(CheckboardInputFields[i].text)))
                {
                    RefreshCheckBoard(i, checkBoardInfo[int.Parse(CheckboardInputFields[i].text)], int.Parse(CheckboardInputFields[i].text));
                }
                //不存在数据
                else
                {
                    var info = GetThree();
                    checkBoardInfo.Add(int.Parse(CheckboardInputFields[i].text), info);
                    RefreshCheckBoard(i, checkBoardInfo[int.Parse(CheckboardInputFields[i].text)], int.Parse(CheckboardInputFields[i].text));
                }
            }
        }

        for (int i = 0; i < CheckBoardInfoInts.Count; i++)
        {
            CheckBoardInfo[i].transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().ShowImage(CheckBoardInfoInts[i]);
        }
    }

    int[] target = new int[]{
        2, 3, 4, 5, 6
    };
    private void RefreshTarget()
    {
        target = GetRandomInts(target);
        for (int i = 0; i < 5; i++)
        {
            if (!CurSelectTarget.ContainsKey(i))
            {
                CurSelectTarget.Add(i, target[i]);
            }
            else
            {
                CurSelectTarget[i] = target[i];
            }
        }
    }

    public int[] GetRandomInts(int[] num)
    {
        for (int i = 0; i < num.Length; i++)
        {
            var temp = num[i];
            int randomIndex = RandomValue(0, num.Length);
            num[i] = num[randomIndex];
            num[randomIndex] = temp;
        }
        return num;
    }

    private int RandomValue(int min, int max)
    {
        return Random.Range(min, max);
    }

    private ThreeToThree GetThree()
    {
        int sum = 0;
        for (int i = 0; i < totalBlockThree.ThreeToThree.Count; i++)
        {
            sum += totalBlockThree.ThreeToThree[i].weight;
        }
        int rewardRandom = Random.Range(0, 999);

        float rate = 0;
        for (int i = 0; i < totalBlockThree.ThreeToThree.Count; i++)
        {
            rate += totalBlockThree.ThreeToThree[i].weight / (float)sum;
            if (rewardRandom <= rate * 1000)
            {
                return totalBlockThree.ThreeToThree[i];
            }
        }
        return totalBlockThree.ThreeToThree[0];
    }

    private void RefreshCheckBoard(int index, ThreeToThree three, int InputValue)
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
                    CheckBoardInfoInts[j + i * 9] = 0;
                }
                else
                {
                    //Debug.LogError("i == "+ i +"    j == "+ j + "    3 == " + ((2 - (j - startCol)) * 3 + (i - startRwo)) +"    4== " + (j + i * 9));

                    if (three.layout[(2 - (j - startCol)) * 3 + (i - startRwo)] == 2)
                    {
                        int value = CurSelectTarget[InputValue / 10];
                        CheckBoardInfoInts[j + i * 9] = value;
                    }
                    else
                    {
                        CheckBoardInfoInts[j + i * 9] = three.layout[(2 - (j - startCol)) * 3 + (i - startRwo)];
                    }
                }
            }
        }

    }

    public void SaveBtnClick()
    {
        if (StartLevel.text == "")
            StartLevel.text = "1";
        FileInfo file = new FileInfo("Assets/Resources/LocationJson/BlockToCheckBoardData.json");
        if (file.Exists)
        {
            bool isSave = false;
            TextAsset jsons = Resources.Load<TextAsset>("LocationJson/BlockToCheckBoardData");
            totalBlockToCheckBoard = JsonMapper.ToObject<TotalBlockToCheckBoard>(jsons.text);
            if (totalBlockToCheckBoard != null)
                for (int i = 0; i < totalBlockToCheckBoard.BlockToCheckBoards.Count; i++)
                {
                    if (HardyDesignCrudeFaculty.Instance.ListStringToListInt(totalBlockToCheckBoard.BlockToCheckBoards[i].OnceBlockInfo).SequenceEqual(CheckBoardInfoInts))
                        //if (CheckBoardInfoInts.SequenceEqual())
                    {
                        isSave = true;
                    }
                }

            if (isSave)
            {
                Debug.LogError("存在相同数据");
            }
            else
            {
                if (totalBlockToCheckBoard != null)
                    totalBlockToCheckBoard.BlockToCheckBoards.Add(new BlockToCheckBoard(){
                        Id = totalBlockToCheckBoard.BlockToCheckBoards.Count, OnceBlockInfo = HardyDesignCrudeFaculty.Instance.ListIntToListString(CheckBoardInfoInts)
                    });
                else
                {
                    totalBlockToCheckBoard = new TotalBlockToCheckBoard(){
                        BlockToCheckBoards = new List<BlockToCheckBoard>(){
                            new BlockToCheckBoard(){
                                Id = totalBlockToCheckBoard.BlockToCheckBoards.Count, OnceBlockInfo = HardyDesignCrudeFaculty.Instance.ListIntToListString(CheckBoardInfoInts)
                            }
                        }
                    };
                }
                StreamWriter sw = file.CreateText();
                //ToJson接口将你的列表类传进去，，并自动转换为string类型
                string json = JsonMapper.ToJson(totalBlockToCheckBoard);

                //Debug.Log("json == " + json);
                //将转换好的字符串存进文件，
                sw.WriteLine(json);
                //注意释放资源
                sw.Close();
                sw.Dispose();
                AssetDatabase.Refresh();
            }

        }
    }

    public void NextBtnClick()
    {
        if (int.Parse(StartLevel.text) < totalBlockToCheckBoard.BlockToCheckBoards.Count)
        {
            StartLevel.text = totalBlockToCheckBoard.BlockToCheckBoards[int.Parse(StartLevel.text)].Id.ToString();
            CheckBoardInfoInts = HardyDesignCrudeFaculty.Instance.ListStringToListInt(totalBlockToCheckBoard.BlockToCheckBoards[int.Parse(StartLevel.text)].OnceBlockInfo);
            for (int i = 0; i < CheckBoardInfoInts.Count; i++)
            {
                CheckBoardInfo[i].transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().ShowImage(CheckBoardInfoInts[i]);
            }
        }
        else
        {
            Debug.LogError("没有对应关卡");
        }
    }


}
*/
