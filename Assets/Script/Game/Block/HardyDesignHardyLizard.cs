using DG.Tweening;
using Spine;
using Spine.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class HardyDesignHardyLizard : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("BlockImage")]    public Image HardyKnife;
[UnityEngine.Serialization.FormerlySerializedAs("SelectImage")]    public Image ChorusKnife;
[UnityEngine.Serialization.FormerlySerializedAs("CanComPleteImage")]    public Image FoeBowUnityKnife;
[UnityEngine.Serialization.FormerlySerializedAs("ClearObj")]    public GameObject VirgoPut;
[UnityEngine.Serialization.FormerlySerializedAs("FlyEffect")]    public List<GameObject> ElkPuffin;
[UnityEngine.Serialization.FormerlySerializedAs("spine")]
    public SkeletonGraphic Venue;
[UnityEngine.Serialization.FormerlySerializedAs("X")]    public int X;
[UnityEngine.Serialization.FormerlySerializedAs("Y")]    public int Y;
[UnityEngine.Serialization.FormerlySerializedAs("Type")]    public int Well;
[UnityEngine.Serialization.FormerlySerializedAs("color")]
    public BlockColor Upset;
    private BlockColor AdjacentThing;
[UnityEngine.Serialization.FormerlySerializedAs("RewardImage")]
    public Image MortalKnife;
[UnityEngine.Serialization.FormerlySerializedAs("GoldAppearSpine")]    public SkeletonGraphic FromCubismBegin;
[UnityEngine.Serialization.FormerlySerializedAs("CashAppearSpine")]    public SkeletonGraphic HurlCubismBegin;
[UnityEngine.Serialization.FormerlySerializedAs("rewardType")]
    public int GirderWell;     // 棋盘初始时随机放置奖励，0：没有奖励；1：现金奖励；2：金币奖励
    private RewardItem Girder;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void Bank(int x, int y, int index, BlockColor color)
    {
        X = x;
        Y = y;
        Well = index;
        this.Upset = color;
        AdjacentThing = color;
        FordKnife(index);
        HardyKnife.transform.localPosition = new Vector3(0, 7, 0);
        HardyKnife.transform.localScale = new Vector3(1, 1, 1);
        HardyKnife.color = new Color(1, 1, 1, 1);
    }
    
    // 空棋盘上随机放置奖励
    public void TugMortalWellLuxury()
    {
        if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) != 99 || Well != 0 || BureauVolt.MyRaise())
        {
            GirderWell = 0;
            return;
        }

        if (GirderWell != 0)
        {
            return;
        }

        //int rewardBlockNum = HardyDesignRouteNovelFaculty.Instance.CheckBoardInfo
        //    .Where(x => x.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().Type == 0 && x.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().rewardType != 0)
        //    .Count();
        //if (rewardBlockNum >= WitComaEka.instance.GameData.RewardBlockNumLimit)
        //{
        //    return;
        //}

        Girder = LuxuryVolt.HisComplyLuxury(WitComaEka.instance.WhenGaze.BlockReward.ToArray(), WitComaEka.instance.WhenGaze.BlockReward.Select(x => x.weight).ToArray());

        if (Girder.type == "cash")
        {
            GirderWell = 1;
        }
        else if (Girder.type == "coin")
        {
            GirderWell = 2;
        }
        else
        {
            GirderWell = 0;
        }

        FordMortalKnife();

    }

    private void FordMortalKnife()
    {
        if (MindGazeFaculty.GetInt(CChoppy.Of_QuiltWhenStay) != 99 || Well != 0)
        {
            GirderWell = 0;
            MortalKnife.gameObject.SetActive(false);
            return;
        }

        if (GirderWell == 1 || GirderWell == 2)
        {
            if (!MortalKnife.gameObject.activeSelf)
            {
                if (GirderWell == 1)
                {
                    HurlCubismBegin.gameObject.SetActive(true);
                    HurlCubismBegin.AnimationState.SetAnimation(0, "animation", false);
                }
                else if (GirderWell == 2)
                {
                    FromCubismBegin.gameObject.SetActive(true);
                    FromCubismBegin.AnimationState.SetAnimation(0, "animation", false);
                }
                StartCoroutine(nameof(FordMortalKnifeLatheBegin));
            }
        }
        else
        {
            MortalKnife.gameObject.SetActive(false);
        }
    }
    
    private IEnumerator FordMortalKnifeLatheBegin()
    {
        yield return new WaitForSeconds(0.5f);
        MortalKnife.GetComponent<RectTransform>().localScale = Vector3.zero;
        MortalKnife.sprite = GirderWell == 1 ? HardyDesignHardyFaculty.Instance.HardyEnclose[7] : HardyDesignHardyFaculty.Instance.HardyEnclose[8];
        MortalKnife.gameObject.SetActive(true);
        MortalKnife.GetComponent<RectTransform>().DOScale(1, 0.2f);
    }

    // 可放置提示
    public void FordChorus(bool isShow, int type = 0, BlockColor color = BlockColor.Red)
    {
        if (!isShow || type == 0)
        {
            ChorusKnife.gameObject.SetActive(false);
        }
        else
        {
            ChorusKnife.sprite = HisSilentHeWell(type, color);
            ChorusKnife.gameObject.SetActive(true);
        }
    }

    // 可消除提示
    public void FordFoeBowUnityKnife(bool isShow, BlockColor color = BlockColor.Red)
    {
        if(Well == -1 || Well == 99)
            return;
        

        if (ChorusKnife.gameObject.activeSelf)
        {
            return;
        }

        if (isShow && Well == 1)
        {
            this.Upset = color;
            FordKnife(1, false);
        }
        else
        {
            this.Upset = AdjacentThing;
            FordKnife(Well);
        }
    }

    public void FordHardyKnife(bool isShow, int index, BlockColor color = BlockColor.Red, bool checkReward = false)
    {
        this.Upset = color;
        AdjacentThing = color;
        if (isShow)
        {
            if (checkReward)
            {
                if (GirderWell == 1)
                {
                    double GirderSeedy= BlockPuzzleGameUtil.HisHurlExalt() * double.Parse(Girder.multiple);
                    HardyDesignWhenGazeFaculty.HisEquality().EonMeter(GirderSeedy, transform);
                }
                else if (GirderWell == 2)
                {
                    double GirderSeedy= BlockPuzzleGameUtil.HisFromExalt() * double.Parse(Girder.multiple);
                    HardyDesignWhenGazeFaculty.HisEquality().EonFrom(GirderSeedy, transform);
                }
                GirderWell = 0;
            }
            Well = index;
            FordKnife(index);
            HardyKnife.gameObject.SetActive(true);
        }
        else
        {
            Well = 0;
            FordKnife(0);
        }
    }
    
    public void FordKnife(int index, bool changeType = true)
    {
        HardyKnife.gameObject.SetActive(true);
        HardyKnife.sprite = HardyDesignHardyFaculty.Instance.HardyEnclose[0];
        if (changeType) Well = index;
        if (index == -1)
        {
            HardyKnife.gameObject.SetActive(false);
        }
        else if (index == 0)
        {
            HardyKnife.gameObject.SetActive(false);
        }
        else
        {
            HardyKnife.sprite = HisSilentHeWell(index, Upset);
        }

        FordMortalKnife();
    }

    private Sprite HisSilentHeWell(int _type, BlockColor _color)
    {
        Sprite sprite = null;
        switch (_type)
        {
            case -1:
                sprite = null;
                break;
            case 0:
                sprite = null;
                break;
            case 1:
                sprite = BureauVolt.MyBodyAB()? HardyDesignHardyFaculty.Instance.ThingHardyEnclose_A[(int)_color]: HardyDesignHardyFaculty.Instance.ThingHardyEnclose[(int)_color];
                break;
            case 2:
                sprite = HardyDesignHardyFaculty.Instance.HardyEnclose[1];
                break;
            case 3:
                sprite = HardyDesignHardyFaculty.Instance.HardyEnclose[2];
                break;
            case 4:
                sprite = HardyDesignHardyFaculty.Instance.HardyEnclose[3];
                break;
            case 5:
                sprite = HardyDesignHardyFaculty.Instance.HardyEnclose[4];
                break;
            case 6:
                sprite = HardyDesignHardyFaculty.Instance.HardyEnclose[5];
                break;
            case 7:
                sprite = HardyDesignHardyFaculty.Instance.HardyEnclose[5];
                break;
            case 8:
                sprite = HardyDesignHardyFaculty.Instance.HardyEnclose[5];
                break;
            case 9:
                sprite = HardyDesignHardyFaculty.Instance.HardyEnclose[5];
                break;
            case 99:
                sprite = HardyDesignHardyFaculty.Instance.HardyEnclose[6];
                break;

        }
        return sprite;
    }

    public void VirgoHardy()
    {
        HardyDesignCrudeFaculty.Instance.GrainyCobalt(Well);
        Well = 0;
        GirderWell = 0;
        gameObject.SetActive(false);
    }

    public void VirgoFlowerbed(List<GameObject> InsTF, Action finish)
    {
        VirgoPut.gameObject.SetActive(true);
        if (Well != 99)
        {
            Venue.gameObject.SetActive(true);
            SkeletonGraphic skeleton = Venue.gameObject.GetComponent<SkeletonGraphic>();
            skeleton.AnimationState.SetEmptyAnimation(0, 0);
            skeleton.AnimationState.SetAnimation(0, "animation", true);
            skeleton.Update(0);

            HardyKnife.transform.DOScale(1.1f, 0.1f).SetEase(Ease.InOutSine).OnComplete(() =>
            {
                HardyKnife.transform.DOScale(0, 0.2f).SetEase(Ease.InOutSine).OnComplete(() =>
                {
                    Venue.gameObject.SetActive(false);
                    VirgoPut.gameObject.SetActive(false);
                    HardyKnife.transform.localScale = new Vector3(1, 1, 1);
                    HardyKnife.color = new Color(1, 1, 1, 1);
                    
                    finish?.Invoke();
                });
            });

            if (Well != 1)
            {
                //ClearObj.gameObject.SetActive(false);
                GameObject SpItem = Instantiate(gameObject, transform.parent);
                if (Well > 1)
                {
                    SpItem.GetComponent<HardyDesignHardyLizard>().HardyKnife.GetComponent<Image>().sprite = HardyDesignHardyFaculty.Instance.HardyCobaltEnclose[Well - 2];
                    SpItem.GetComponent<HardyDesignHardyLizard>().Venue.gameObject.SetActive(false);
                }
                SpItem.transform.position = transform.position;
                SpItem.AddComponent<Canvas>().overrideSorting = true;
                SpItem.GetComponent<Canvas>().sortingOrder = 110;
                InsTF.Add(SpItem);
            }
        }
        else
        {
            VirgoPut.gameObject.SetActive(false);
            GameObject SpItem = Instantiate(gameObject, transform.parent);
            SpItem.transform.position = transform.position;
            InsTF.Add(SpItem);
            finish?.Invoke();
        }

    }
}
