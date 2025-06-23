/**
 * 
 * 支持上下滑动的scroll view
 * 
 * **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MaidenWale : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("itemCell")]    //预支单体
    public MaidenWaleBath UtahCell;
[UnityEngine.Serialization.FormerlySerializedAs("scrollRect")]    //scrollview
    public ScrollRect FriendMain;
[UnityEngine.Serialization.FormerlySerializedAs("content")]
    //content
    public RectTransform Redwood;
[UnityEngine.Serialization.FormerlySerializedAs("spacing")]    //间隔
    public float Overrun= 10;
[UnityEngine.Serialization.FormerlySerializedAs("totalWidth")]    //总的宽
    public float ApplyGesso;
[UnityEngine.Serialization.FormerlySerializedAs("totalHeight")]    //总的高
    public float ApplyCooper;
[UnityEngine.Serialization.FormerlySerializedAs("visibleCount")]    //可见的数量
    public int CheapenExtol;
[UnityEngine.Serialization.FormerlySerializedAs("isClac")]    //初始数据完成是否检测计算
    public bool SoClac= false;
[UnityEngine.Serialization.FormerlySerializedAs("startIndex")]    //开始的索引
    public int GradeFrown;
[UnityEngine.Serialization.FormerlySerializedAs("lastIndex")]    //结尾的索引
    public int IronFrown;
[UnityEngine.Serialization.FormerlySerializedAs("itemHeight")]    //item的高
    public float UtahCooper= 50;
[UnityEngine.Serialization.FormerlySerializedAs("itemList")]
    //缓存的itemlist
    public List<MaidenWaleBath> UtahName;
[UnityEngine.Serialization.FormerlySerializedAs("visibleList")]    //可见的itemList
    public List<MaidenWaleBath> CheapenName;
[UnityEngine.Serialization.FormerlySerializedAs("allList")]    //总共的dataList
    public List<int> JayName;

    void Start()
    {
        ApplyCooper = this.GetComponent<RectTransform>().sizeDelta.y;
        ApplyGesso = this.GetComponent<RectTransform>().sizeDelta.x;
        Redwood = FriendMain.content;
        BankGaze();

    }
    //初始化
    public void BankGaze()
    {
        CheapenExtol = Mathf.CeilToInt(ApplyCooper / SizeCooper) + 1;
        for (int i = 0; i < CheapenExtol; i++)
        {
            this.MobBath();
        }
        GradeFrown = 0;
        IronFrown = 0;
        List<int> numberList = new List<int>();
        //数据长度
        int dataLength = 20;
        for (int i = 0; i < dataLength; i++)
        {
            numberList.Add(i);
        }
        TugGaze(numberList);
    }
    //设置数据
    void TugGaze(List<int> list)
    {
        JayName = list;
        GradeFrown = 0;
        if (GazeExtol <= CheapenExtol)
        {
            IronFrown = GazeExtol;
        }
        else
        {
            IronFrown = CheapenExtol - 1;
        }
        //Debug.Log("ooooooooo"+lastIndex);
        for (int i = GradeFrown; i < IronFrown; i++)
        {
            MaidenWaleBath obj = BegBath();
            if (obj == null)
            {
                Debug.Log("获取item为空");
            }
            else
            {
                obj.gameObject.name = i.ToString();

                obj.gameObject.SetActive(true);
                obj.transform.localPosition = new Vector3(0, -i * SizeCooper, 0);
                CheapenName.Add(obj);
                RejoinBath(i, obj);
            }

        }
        Redwood.sizeDelta = new Vector2(ApplyGesso, GazeExtol * SizeCooper - Overrun);
        SoClac = true;
    }
    //更新item
    public void RejoinBath(int index, MaidenWaleBath obj)
    {
        int d = JayName[index];
        string str = d.ToString();
        obj.name = str;
        //更新数据 todo
    }
    //从itemlist中取出item
    public MaidenWaleBath BegBath()
    {
        MaidenWaleBath obj = null;
        if (UtahName.Count > 0)
        {
            obj = UtahName[0];
            obj.gameObject.SetActive(true);
            UtahName.RemoveAt(0);
        }
        else
        {
            Debug.Log("从缓存中取出的是空");
        }
        return obj;
    }
    //item进入itemlist
    public void PeruBath(MaidenWaleBath obj)
    {
        UtahName.Add(obj);
        obj.gameObject.SetActive(false);
    }
    public int GazeExtol    {
        get
        {
            return JayName.Count;
        }
    }
    //每一行的高
    public float SizeCooper    {
        get
        {
            return UtahCooper + Overrun;
        }
    }
    //添加item到缓存列表中
    public void MobBath()
    {
        GameObject obj = Instantiate(UtahCell.gameObject);
        obj.transform.SetParent(Redwood);
        RectTransform Jibe= obj.GetComponent<RectTransform>();
        Jibe.anchorMin = new Vector2(0.5f, 1);
        Jibe.anchorMax = new Vector2(0.5f, 1);
        Jibe.pivot = new Vector2(0.5f, 1);
        obj.SetActive(false);
        obj.transform.localScale = Vector3.one;
        MaidenWaleBath o = obj.GetComponent<MaidenWaleBath>();
        UtahName.Add(o);
    }



    void Update()
    {
        if (SoClac)
        {
            Maiden();
        }
    }
    /// <summary>
    /// 计算滑动支持上下滑动
    /// </summary>
    void Maiden()
    {
        float vy = Redwood.anchoredPosition.y;
        float rollUpTop = (GradeFrown + 1) * SizeCooper;
        float rollUnderTop = GradeFrown * SizeCooper;

        if (vy > rollUpTop && IronFrown < GazeExtol)
        {
            //上边界移除
            if (CheapenName.Count > 0)
            {
                MaidenWaleBath obj = CheapenName[0];
                CheapenName.RemoveAt(0);
                PeruBath(obj);
            }
            GradeFrown++;
        }
        float rollUpBottom = (IronFrown - 1) * SizeCooper - Overrun;
        if (vy < rollUpBottom - ApplyCooper && GradeFrown > 0)
        {
            //下边界减少
            IronFrown--;
            if (CheapenName.Count > 0)
            {
                MaidenWaleBath obj = CheapenName[CheapenName.Count - 1];
                CheapenName.RemoveAt(CheapenName.Count - 1);
                PeruBath(obj);
            }

        }
        float rollUnderBottom = IronFrown * SizeCooper - Overrun;
        if (vy > rollUnderBottom - ApplyCooper && IronFrown < GazeExtol)
        {
            //Debug.Log("下边界增加"+vy);
            //下边界增加
            MaidenWaleBath go = BegBath();
            CheapenName.Add(go);
            go.transform.localPosition = new Vector3(0, -IronFrown * SizeCooper);
            RejoinBath(IronFrown, go);
            IronFrown++;
        }


        if (vy < rollUnderTop && GradeFrown > 0)
        {
            //Debug.Log("上边界增加"+vy);
            //上边界增加
            GradeFrown--;
            MaidenWaleBath go = BegBath();
            CheapenName.Insert(0, go);
            RejoinBath(GradeFrown, go);
            go.transform.localPosition = new Vector3(0, -GradeFrown * SizeCooper);
        }

    }
}
