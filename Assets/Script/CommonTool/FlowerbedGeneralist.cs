using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;
using Spine.Unity;

public class FlowerbedGeneralist : MonoBehaviour
{
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    /// <summary>
    /// 弹窗出现效果
    /// </summary>
    /// <param name="PopBarUp"></param>
    public static void BegFord(GameObject PopBarUp,System.Action finish)
    {
        /*-------------------------------------初始化------------------------------------*/
        PopBarUp.GetComponent<CanvasGroup>().alpha = 0;
        PopBarUp.transform.localScale = new Vector3(0, 0, 0);
        /*-------------------------------------动画效果------------------------------------*/
        PopBarUp.GetComponent<CanvasGroup>().DOFade(1, 0.3f);
        PopBarUp.transform.DOScale(1, 0.5f).SetEase(Ease.OutBack).OnComplete(() => 
        {
            finish();
        });
    }


    /// <summary>
    /// 弹窗消失效果
    /// </summary>
    /// <param name="PopBarDisapper"></param>
    public static void BegIbex(GameObject PopBarDisapper,System.Action finish)
    {
        /*-------------------------------------初始化------------------------------------*/
        PopBarDisapper.GetComponent<CanvasGroup>().alpha = 1;
        PopBarDisapper.transform.localScale = new Vector3(1, 1, 1);
        /*-------------------------------------动画效果------------------------------------*/
        PopBarDisapper.GetComponent<CanvasGroup>().DOFade(0, 0.5f);
        PopBarDisapper.transform.DOScale(0, 0.5f).SetEase(Ease.InBack).OnComplete(() => 
        {
            finish();
        });
    }
    /// <summary>
    /// 数字变化动画
    /// </summary>
    /// <param name="startNum"></param>
    /// <param name="endNum"></param>
    /// <param name="text"></param>
    /// <param name="finish"></param>
    public static void FactorSadden(int startNum, int endNum,float delay, Text text,System.Action finish)
    {
        DOTween.To(() => startNum, x => text.text = x.ToString(), endNum, 0.5f).SetDelay(delay).OnComplete(() =>
        {
            finish();
        });
    }
    
    public static void FactorSadden(double startNum, double endNum,float delay, Text text,System.Action finish)
    {
        DOTween.To(() => startNum, x => text.text = x.ToString(), endNum, 0.5f).SetDelay(delay).OnComplete(() =>
        {
            finish();
        });
    }

    public static void FactorSadden(double startNum, double endNum, float delay, TextMeshProUGUI text, System.Action finish)
    {
        FactorSadden(startNum, endNum, delay, text, "", finish);
    }
    public static void FactorSadden(double startNum, double endNum, float delay, TextMeshProUGUI text, string prefix, System.Action finish)
    {
        DOTween.To(() => startNum, x => text.text = prefix + SaddenVolt.EthnicUpStr(x), endNum, 0.5f).SetDelay(delay).OnComplete(() =>
        {
            finish();
        });
    }

    /// <summary>
    /// 收金币
    /// </summary>
    /// <param name="GoldImage">金币图标</param>
    /// <param name="a">金币数量</param>
    /// <param name="StartTF">起始位置</param>
    /// <param name="EndTF">最终位置</param>
    /// <param name="finish">结束回调</param>
    public static void FromAvidLime(GameObject GoldImage, int a, Vector3 StartTF, Vector3 EndTF, System.Action TextAdd,System.Action finish)
    {
        //如果没有就算了
        if (a == 0)
        {
            finish();
        }
        //数量不超过15个
        else if (a > 10)
        {
            a = 10;
        }
        //每个金币的间隔
        float Delaytime = 0;
        for (int i = 0; i < a; i++)
        {
            int t= i;
            //每次延迟+1
            Delaytime += 0.06f;
            //复制一个图标
            GameObject FromLeak= Instantiate(GoldImage, GoldImage.transform.parent);
            //初始化
            FromLeak.transform.position = StartTF;
            FromLeak.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            //创建动画队列
            var s = DOTween.Sequence();
            //金币移动到最终位置
            s.Append(FromLeak.transform.DOMove(EndTF, 0.6f).SetDelay(Delaytime).OnComplete(() =>
            {
                if (t == 0)
                {
                    TextAdd();
                }
            }));
            s.Join(FromLeak.transform.DOScale(1.5f, 0.3f).SetEase(Ease.InBack));
            s.AppendCallback(() =>
            {
                
                //收尾
                s.Kill();
                Destroy(FromLeak);
                if (t == a - 1)
                {
                    finish();
                }
                if (t%3==0) 
                {
                    RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_GoldCoin);
                }
            });
        }
    }

    /// <summary>
    /// 收金币-其他类型
    /// </summary>
    /// <param name="GoldImage"></param>
    /// <param name="a"></param>
    /// <param name="StartTF"></param>
    /// <param name="EndTF"></param>
    /// <param name="TextAdd"></param>
    /// <param name="finish"></param>
    public static void HardyRayFromAvid(GameObject GoldImage, int a, Vector3 StartTF, Vector3 EndTF, System.Action TextAdd, System.Action finish)
    {
        //每个金币的间隔
        float Delaytime = 0;
        for (int i = 0; i < a; i++)
        {
            int t = i;
            //每次延迟+1
            Delaytime += 0.05f;
            //复制一个图标
            GameObject FromLeak= Instantiate(GoldImage, GoldImage.transform.parent);
            //初始化
            FromLeak.transform.position = StartTF;
            float A = Random.Range(-1f, 1f);
            float B = Random.Range(-1f, 1f);

            FromLeak.transform.localScale = new Vector3(0f, 0f, 0f);
            FromLeak.transform.DOScale(new Vector3(1.5f, 1.5f, 1.5f), 0.4f).SetEase(Ease.OutBack).SetDelay(Delaytime);

            FromLeak.transform.DOMove(new Vector3(StartTF.x + A, StartTF.y + B, 0), 0.4f).SetEase(Ease.OutSine).SetDelay(Delaytime).OnComplete(() =>
            {
                float MidOffset = 0;
                if (FromLeak.transform.position.x > EndTF.x)
                {
                    MidOffset = 1;
                }
                else
                {
                    MidOffset = -1;
                }
                Vector3 MidPos = new Vector3((FromLeak.transform.position.x + EndTF.x) / 2 + MidOffset, (FromLeak.transform.position.y + EndTF.y) / 2 + 1, 0);
                Vector3[] path = PrettyAgent.HisBeizerName(FromLeak.transform.position, MidPos, EndTF, 6);

                FromLeak.transform.DOScale(1f, 0.6f).SetEase(Ease.InBack);
                FromLeak.transform.DOPath(path, 0.6f).OnComplete(() =>
                {
                    if (t == 0)
                    {
                        TextAdd();
                    }
                    Destroy(FromLeak);
                    if (t == a - 1)
                    {
                        finish();
                    }
                    if (t % 3 == 0)
                    {
                        RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_GoldCoin);
                    }
                });
            });
        }
    }
    /// <summary>
    /// 收金币-游戏内类型
    /// </summary>
    /// <param name="GoldImage"></param>
    /// <param name="a"></param>
    /// <param name="StartTF"></param>
    /// <param name="EndTF"></param>
    /// <param name="TextAdd"></param>
    /// <param name="ancu"></param>
    /// <param name="finish"></param>
    public static void HardyRayFromScan(GameObject GoldImage, int a, Vector3 StartTF, Vector3 EndTF, Vector3 BottomTF, System.Action TextAdd, AnimationCurve ancu, System.Action finish, bool isGuide = false)
    {
        //每个金币的间隔
        float Delaytime = 0;
        for (int i = 0; i < a; i++)
        {
            int t = i;
            //每次延迟+1
            Delaytime += 0.15f;
            //复制一个图标
            GameObject FromLeak= Instantiate(GoldImage, GoldImage.transform.parent);
            //初始化
            float A = Random.Range(-0.5f, 0.5f);
            FromLeak.transform.position = new Vector3(StartTF.x + A, StartTF.y, 0);
            BottomTF = new Vector3(StartTF.x, BottomTF.y - 0.5f, StartTF.z);

            float Time = Vector3.Distance(BottomTF, StartTF) / 2;
            float TimeRandom = Random.Range(-0.1f, 0.1f);
            Sequence Jumpani = DOTween.Sequence();
            if (isGuide)
                FromLeak.transform.localScale = new Vector3(1.4f, 1.4f, 1.4f);
            else
                FromLeak.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            Jumpani.Append(FromLeak.transform.DOMove(new Vector3(FromLeak.transform.position.x, BottomTF.y - 0.5f, 0), (0.285f * Time) + 0.43f + TimeRandom).
                SetEase(ancu).OnComplete((() =>
                {
                    //RaiseEka.GetInstance().PlayEffect(RaiseWell.UIMusic.Sound_DropCash);
                })));


            Jumpani.Append(FromLeak.transform.DOMove(EndTF, 0.6f).SetDelay(Delaytime).OnComplete((() =>
            {
                if (t % 3 == 0)
                {
                    RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_GoldCoin);
                }
            })));
            Jumpani.Join(FromLeak.transform.DOScale(1f, 0.6f).SetDelay(Delaytime));
            Jumpani.AppendCallback(() =>
            {
                if (t == 0)
                {
                    TextAdd();
                }
                Destroy(FromLeak);
                if (t == a - 1)
                {
                    finish();
                }

            });
        }
    }
    /// <summary>
    /// 横向滚动
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="addPosition"></param>
    /// <param name="Finish"></param>
    public static void PersuasiveMaiden(GameObject obj, float addPosition, System.Action Finish)
    {
        float positionX = obj.transform.localPosition.x;
        float endPostion = positionX + addPosition;
        obj.transform.DOLocalMoveX(endPostion, 2f).SetEase(Ease.InOutQuart).OnComplete(() => {
            Finish?.Invoke();
        });
    }
    /// <summary>
    /// 消除动画
    /// </summary>
    /// <param name="ClearList"></param>
    /// <param name="finish"></param>
    public static void VirgoSun(GameObject Item, List<GameObject> InsTF, System.Action finish = null)
    {
        Item.GetComponent<HardyDesignHardyLizard>().VirgoFlowerbed(InsTF, finish);
    }
    /// <summary>
    /// 游戏失败
    /// </summary>
    /// <param name="BlockGroup"></param>
    /// <param name="finish"></param>
    public static void WhenFaildSun(List<GameObject> BlockGroup, System.Action finish = null) 
    {
        for (int i = 0; i < BlockGroup.Count; i++) 
        {
            int a = i;
            float delayTime = Random.Range(0.1f, 0.3f);
            float shakeRange = Random.Range(1, 2);
            float RangeX = Random.Range(-1f, 1f);
            GameObject Item = BlockGroup[i];
            GameObject Image = Item.transform.GetChild(0).GetComponent<HardyDesignHardyLizard>().HardyKnife.gameObject;
            Item.transform.DOShakePosition(shakeRange, new Vector3(2, 2, 2)).SetEase(Ease.Linear);
            Image.transform.DOMoveY(-6,0.8f).SetEase(Ease.InQuart).SetDelay(delayTime).OnComplete(()=> 
            {
                if (a == BlockGroup.Count - 1)
                {
                    finish();
                }
            });
        }
    }


    public static IEnumerator CrudeRote(Transform ItemPrefab,float time) 
    {
        yield return new WaitForSeconds(time);
        float R = Random.Range(-30, 30);
        
        GameObject Utah= Instantiate(Resources.Load<GameObject>("Prefab/CashPop"), WhenSpear.Instance.Dolphin.transform);
        string Whip= MindGazeFaculty.GetString("SuccessInfoType");
        Utah.transform.Find("cash").gameObject.SetActive(Whip == "cash");
        Utah.transform.Find("coin").gameObject.SetActive(Whip == "coin");
        Utah.transform.position = ItemPrefab.position;
        SafeUnfold(Utah,R);
        Destroy(Utah, 5);
        
    }
    static void SafeUnfold(GameObject bubble, float A)
    {
        Vector2 v2 = EnigmaReform(Vector2.up, A);
        bubble.GetComponent<Rigidbody2D>().gravityScale = 2f;
        //bubble.GetComponent<Collider2D>().isTrigger = false;
        bubble.GetComponent<Rigidbody2D>().AddForce(v2 * UnityEngine.Random.Range(200f, 300f));
    }
    static Vector2 EnigmaReform(Vector2 vector, float degrees)
    {
        float angle = degrees * Mathf.Deg2Rad; // 将角度转换为弧度
        float cos = Mathf.Cos(angle);
        float sin = Mathf.Sin(angle);
        return new Vector2(vector.x * cos - vector.y * sin, vector.x * sin + vector.y * cos);
    }

    public static IEnumerator RoteVirgoSun(GameObject item,float Time,System.Action finish = null)
    {
        SkeletonGraphic spineover = item.GetComponent<HardyDesignHardyLizard>().Venue;
        Image blockImage = item.GetComponent<HardyDesignHardyLizard>().HardyKnife;
        GameObject clearObj = item.GetComponent<HardyDesignHardyLizard>().VirgoPut;
        yield return new WaitForSeconds(Time);
        clearObj.gameObject.SetActive(true);
        spineover.gameObject.SetActive(true);
        spineover.AnimationState.SetEmptyAnimation(0, 0);
        spineover.AnimationState.SetAnimation(0, "animation", true);
        spineover.Update(0);
        //PrpoTwo.GetComponent<Renderer>().material.SetFloat("_Fill", (float)BombSch);
        blockImage.transform.DOScale(1.1f, 0.1f).SetEase(Ease.InOutSine).OnComplete(() =>
        {
            blockImage.transform.DOScale(0, 0.2f).SetEase(Ease.InOutSine).OnComplete(() =>
            {
                spineover.gameObject.SetActive(false);
                clearObj.gameObject.SetActive(false);

                //blockImage.transform.localScale = new Vector3(1, 1, 1);
                //blockImage.color = new Color(1, 1, 1, 1);
                finish?.Invoke();
            });
        });
    }

}
