using System;
using System.Collections.Generic;
using DG.Tweening;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class RoostBowelSpear : AlgaUISleek
{
[UnityEngine.Serialization.FormerlySerializedAs("FreeSpinBtn")]    public Button WarmMossVia;
[UnityEngine.Serialization.FormerlySerializedAs("RewardObjs")]    public List<GameObject> MortalClue;
[UnityEngine.Serialization.FormerlySerializedAs("WheelObj")]    public GameObject BowelPut;    
[UnityEngine.Serialization.FormerlySerializedAs("EffectObj")]    public GameObject PuffinPut;
[UnityEngine.Serialization.FormerlySerializedAs("WheelSpineAni")]    public SkeletonGraphic BowelBeginSun;
    //public SkeletonAnimation LightSpineAni;

    double[] Vestige= new double[6];
    int HisMortalWell= 0;
    int WoodShaper= 0;
    // Start is called before the first frame update
    void Start()
    {
        WarmMossVia.onClick.AddListener(WarmMossViaFlute);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Display()
    {
        base.Display();
        PuffinPut.gameObject.SetActive(false);
        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Openboard);
        WarmMossVia.gameObject.SetActive(true);
        HisMortalWell = 0;
        BowelBeginSun.AnimationState.SetAnimation(0, "1", true);

        IcelandMortal();
        IcelandMortalUI();
        TugRootlessVogue(256, 6);
    }
    public override void Hidding()
    {
        base.Hidding();
        
    }

    private void WarmMossViaFlute()
    {
        WarmMossVia.gameObject.SetActive(false);
        BowelBeginSun.AnimationState.SetAnimation(0, "2", false);
        MossSun(() =>
        {
            SpoonUITrap(GetType().Name);
        });
    }

    private void SpoonViaFlute()
    {
        SpoonUITrap(GetType().Name);
    }

    private void MossSun(Action finish = null)
    { 
        var rewardItem = HardyDesignDeftFaculty.instance.HisMortalWell(WitComaEka.instance.WhenGaze.WheelReward.Reward);
        MindGazeFaculty.SetString(CChoppy.Of_MortalWell, rewardItem.type);
        
        MindGazeFaculty.SetString(CChoppy.Of_MortalSeedy, Vestige[rewardItem.id].ToString());
        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_SchFillamount);
        BowelPut.transform.DOLocalRotate(new Vector3(0, 0, -360 * 6 - 60 * rewardItem.id), 2.5f).OnComplete(() =>
        {
            BowelBeginSun.AnimationState.SetAnimation(0, "3", false);
            //LightSpineAni.AnimationState.SetAnimation(0, "1", false);
            PuffinPut.gameObject.SetActive(true);
            RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_WheelFinish);
            BowelPut.transform.DOScale(1, 1.5f).OnComplete(() =>
            {
                finish?.Invoke();
                HardyDesignDeftFaculty.instance.VirgoBowelLop();
                UIFaculty.HisEquality().FordUISleek("MortalSpear");
            });
            
        });
    }

    private void IcelandMortal()
    {
        for (int i = 0; i < MortalClue.Count; i++)
        {
            if (WitComaEka.instance.WhenGaze.WheelReward.Reward[i].type == "cash")
            {
                Vestige[i] = BlockPuzzleGameUtil.HisHurlExalt() * double.Parse(WitComaEka.instance.WhenGaze.WheelReward.Reward[i].multiple);
                
            }
            else
            {
                Vestige[i] = BlockPuzzleGameUtil.HisFromExalt() * double.Parse(WitComaEka.instance.WhenGaze.WheelReward.Reward[i].multiple);
            }
        }
    }

    private void IcelandMortalUI()
    {
        for (int i = 0; i < MortalClue.Count; i++)
        {
            if (WitComaEka.instance.WhenGaze.WheelReward.Reward[i].type == "cash")
            {
                MortalClue[i].transform.GetChild(0).gameObject.SetActive(false);
                MortalClue[i].transform.GetChild(1).gameObject.SetActive(true);
                MortalClue[i].transform.GetChild(1).Find("Text").GetComponent<Text>().text = SaddenVolt.EthnicUpStr(Vestige[i]);
            }
            else
            {
                MortalClue[i].transform.GetChild(0).gameObject.SetActive(true);
                MortalClue[i].transform.GetChild(0).Find("Text").GetComponent<Text>().text = SaddenVolt.EthnicUpStr(Vestige[i]);
                MortalClue[i].transform.GetChild(1).gameObject.SetActive(false);
            }
        }
    }

    /// <summary>
    /// 修改奖品位置
    /// </summary>
    /// <param name="radius">半径（奖品距离圆心的距离）</param>
    /// <param name="num">总的奖品数量</param>
    /// <returns></returns>
    private List<GameObject> TugRootlessVogue(float radius, int num)
    {
        List<GameObject> items = new();
        float angleIncrement = 360f / num; // 每个点之间的角度增量
        for (int i = 0; i < num; i++)
        {
            float angle = -90f + i * angleIncrement; // 从圆底部开始，逆时针计算角度  
            float angleInRadians = angle * Mathf.Deg2Rad; // 将角度转换为弧度  

            // 计算x和y坐标  
            float x = Mathf.Cos(angleInRadians) * radius;
            float y = Mathf.Sin(angleInRadians) * radius;

            GameObject Utah= MortalClue[i];
            Utah.GetComponent<RectTransform>().localPosition = new Vector3(x, y, 0);
            // 沿z轴旋转
            Utah.GetComponent<RectTransform>().localRotation = Quaternion.AngleAxis(i * angleIncrement, Vector3.forward);
            Utah.SetActive(true);
            items.Add(Utah);
        }
        return items;
    }
}


