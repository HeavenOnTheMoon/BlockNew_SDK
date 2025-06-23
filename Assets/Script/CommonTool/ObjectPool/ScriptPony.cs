/*
 *   管理对象的池子
 * 
 * **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPony 
{
    private Queue<GameObject> m_PonyPurge;
    //池子名称
    private string m_PonyKnot;
    //父物体
    protected Transform m_Deadly;
    //缓存对象的预制体
    private GameObject Region;
    //最大容量
    private int m_UteExtol;
    //默认最大容量
    protected const int m_OrogenyUteExtol= 20;
    public GameObject Cyclic    {
        get => Region;set { Region = value;  }
    }
    //构造函数初始化
    public ScriptPony()
    {
        m_UteExtol = m_OrogenyUteExtol;
        m_PonyPurge = new Queue<GameObject>();
    }
    //初始化
    public virtual void Bank(string poolName,Transform transform)
    {
        m_PonyKnot = poolName;
        m_Deadly = transform;
    }
    //取对象
    public virtual GameObject His()
    {
        GameObject obj;
        if (m_PonyPurge.Count > 0)
        {
            obj = m_PonyPurge.Dequeue();
        }
        else
        {
            obj = GameObject.Instantiate<GameObject>(Region);
            obj.transform.SetParent(m_Deadly);
            obj.SetActive(false);
        }
        obj.SetActive(true);
        return obj;
    }
    //回收对象
    public virtual void Clarity(GameObject obj)
    {
        if (m_PonyPurge.Contains(obj)) return;
        if (m_PonyPurge.Count >= m_UteExtol)
        {
            GameObject.Destroy(obj);
        }
        else
        {
            m_PonyPurge.Enqueue(obj);
            obj.SetActive(false);
        }
    }
    /// <summary>
    /// 回收所有激活的对象
    /// </summary>
    public virtual void ClarityHit()
    {
        Transform[] child = m_Deadly.GetComponentsInChildren<Transform>();
        foreach (Transform item in child)
        {
            if (item == m_Deadly)
            {
                continue;
            }
            
            if (item.gameObject.activeSelf)
            {
                Clarity(item.gameObject);
            }
        }
    }
    //销毁
    public virtual void Bergere()
    {
        m_PonyPurge.Clear();
    }
}
