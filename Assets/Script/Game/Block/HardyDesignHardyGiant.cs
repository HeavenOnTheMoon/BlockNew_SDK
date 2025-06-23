using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class HardyDesignHardyGiant : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("ShowObj")]    public List<GameObject> FordPut;
[UnityEngine.Serialization.FormerlySerializedAs("BlockInfo")]    public int[,] HardyComa= new int[,]{
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0}
    };
[UnityEngine.Serialization.FormerlySerializedAs("BlockPos")]    public GameObject HardyBur;
[UnityEngine.Serialization.FormerlySerializedAs("canvasGroup")]    public CanvasGroup BudgetGiant;
    int _Go;
[UnityEngine.Serialization.FormerlySerializedAs("_blockItem")]    public BlockItem _TradeBath;
[UnityEngine.Serialization.FormerlySerializedAs("color")]
    public BlockColor Upset;
[UnityEngine.Serialization.FormerlySerializedAs("isOpenSendTime")]
    public bool SoKilnDramPort;

    // Start is called before the first frame update
    void Start()
    {
        SoKilnDramPort = false;
        StartCoroutine(nameof(SewerAvidBurPort));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Bank(BlockItem blockItem, float DelayTime, int index = 0, bool isShowScratchCard = false, BlockColor color = BlockColor.Red)
    {
        this.Upset = color;
        _Go = index;
        _TradeBath = blockItem;
        //Debug.LogError("_blockItem == " + _blockItem.id + "     _id == " + _id);
        IcelandUI(isShowScratchCard, color);
        DensityBur();
        FordHardyBur(DelayTime);
        FactorBur();
    }

    public void ChorusBur(Vector3 oPosition)
    {
        transform.localScale = new Vector3(2.2f, 2.2f, 2.2f);//(1.7857f, 1.7857f, 1.7857f);
        
        transform.position = new Vector3(oPosition.x, oPosition.y + 1.5f, 0);
    }

    public void AvidBur(Vector3 oPosition)
    {
        transform.localScale = new Vector3(2.2f, 2.2f, 2.2f);//(1.7857f, 1.7857f, 1.7857f);
        transform.position = new Vector3(oPosition.x, oPosition.y + 1.5f, 0);
        //ShowObj[12].transform.position
        HardyDesignRouteNovelFaculty.Instance.FactorQueryHardy(FordPut[12].transform.position, HardyComa);
        if (SoKilnDramPort)
        {
            LayerFatPeat.Equality.DramMortalLayer(1105, "game_key_interaction_1105");
        }
    }

    IEnumerator SewerAvidBurPort()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            SoKilnDramPort = true;
        }
    }
    
    public void SpendIf(Vector3 Position)
    {
        if (HardyDesignRouteNovelFaculty.Instance.QueryHardy(FordPut[12].transform.position, HardyComa, Upset))
        {
            
                WhenSpear.Instance.FivePut.gameObject.SetActive(true);
            HardyDesignHardyFaculty.Instance.ClarityHardy(gameObject);
            HardyDesignHardyFaculty.Instance.HomelessMereHardyGiant();
        }
        else
        {
            
            DensityBur();
        }
    }
    
    /// <summary>
    /// 复原位置
    /// </summary>
    public void DensityBur()
    {
        transform.localScale = new Vector3(1, 1, 1);

        switch (_Go)
        {
            case 0:
                transform.localPosition = new Vector3(-230, 20, 0);
                break;
            case 1:
                transform.localPosition = new Vector3(0, 20, 0);
                break;
            case 2:
                transform.localPosition = new Vector3(230, 20, 0);
                break;
        }
    }

    public void FordHardyBur(float delayTime)
    {
        switch (_Go)
        {
            case 0:
                transform.localPosition = new Vector3(460, 20, 0);
                break;
            case 1:
                transform.localPosition = new Vector3(460, 20, 0);
                break;
            case 2:
                transform.localPosition = new Vector3(460, 20, 0);
                break;
        }
        if (transform != null)
            transform.DOLocalMove(new Vector3((230 * _Go) - 230, 20, 0), 0.3f).SetEase(Ease.OutBack).SetDelay(delayTime);
    }

    public void IcelandUI(bool isShowScratchCard, BlockColor color)
    {
        if (isShowScratchCard)
        {
            FactorWispy(99);
        }
        else
        {
            var nonZeroIndices = _TradeBath.shape.Select((value, index) => new { value, index })
                .Where(item => item.value == 99)
                .Select(item => item.index)
                .ToList();

            foreach (int t in nonZeroIndices)
            {
                _TradeBath.shape[t] = 1;
            }
        }
        for (int i = 0; i < HardyComa.GetLength(0); i++)
        {
            for (int j = 0; j < HardyComa.GetLength(1); j++)
            {
                HardyComa[i, j] = _TradeBath.shape[(3 - j)  * 4 + ( i)];
            }
        }
        
        for (int i = 0; i < FordPut.Count; i++)
        {
            FordPut[i].gameObject.SetActive(_TradeBath.shape[i] != 0);
            switch (_TradeBath.shape[i])
            {
                case 0 :
                    FordPut[i].gameObject.GetComponent<Image>().sprite = HardyDesignHardyFaculty.Instance.HardyEnclose[0];
                    break;
                case 1 :
                    //ShowObj[i].gameObject.GetComponent<Image>().sprite = HardyDesignHardyFaculty.Instance.BlockSprites[0];
                    FordPut[i].gameObject.GetComponent<Image>().sprite = BureauVolt.MyBodyAB() ? HardyDesignHardyFaculty.Instance.ThingHardyEnclose_A[(int)color] : HardyDesignHardyFaculty.Instance.ThingHardyEnclose[(int)color]; //HardyDesignHardyFaculty.Instance.ColorBlockSprites[(int)color];
                    break;
                case 2 : 
                    FordPut[i].gameObject.GetComponent<Image>().sprite = HardyDesignHardyFaculty.Instance.HardyEnclose[1];
                    break;
                case 3 : 
                    FordPut[i].gameObject.GetComponent<Image>().sprite = HardyDesignHardyFaculty.Instance.HardyEnclose[2];
                    break;
                case 4 : 
                    FordPut[i].gameObject.GetComponent<Image>().sprite = HardyDesignHardyFaculty.Instance.HardyEnclose[3];
                    break;
                case 5 : 
                    FordPut[i].gameObject.GetComponent<Image>().sprite = HardyDesignHardyFaculty.Instance.HardyEnclose[4];
                    break;
                case 6 : 
                    FordPut[i].gameObject.GetComponent<Image>().sprite = HardyDesignHardyFaculty.Instance.HardyEnclose[5];
                    break;
                case 99 : 
                    FordPut[i].gameObject.GetComponent<Image>().sprite = HardyDesignHardyFaculty.Instance.HardyEnclose[6];
                    break;
            }
        }
        
        
    }
    private void FactorWispy(int type)
    {
        // 获取所有非零元素的索引
        var nonZeroIndices = _TradeBath.shape.Select((value, index) => new { value, index })
            .Where(item => item.value != 0)
            .Select(item => item.index)
            .ToList();


        if (nonZeroIndices.Count > 0)
        {
            int randomIndex = nonZeroIndices[Random.Range(0, nonZeroIndices.Count)];
            _TradeBath.shape[randomIndex] = type;
        }
    }

    private void FactorBur()
    {
        HardyBur.transform.localPosition = new Vector3((63 - (_TradeBath.widht - 1) * 21), (55.2f - (_TradeBath.height - 1) * 18.4f), 0);
    }

    public void FactorFluteShare(bool canClick)
    {
        if (canClick)
        {
            BudgetGiant.alpha = 1;
            BudgetGiant.blocksRaycasts = true;
        }
        else
        {
            BudgetGiant.alpha = 0.48f;
            BudgetGiant.blocksRaycasts = false;
        }
    }
}
