/*
 * 
 *  管理多个对象池的管理类
 * 
 * **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ScriptPonyFaculty : RomeEndocrine<ScriptPonyFaculty>
{
    //管理objectpool的字典
    private Dictionary<string, ScriptPony> m_PonySay;
    private Transform m_KiwiLiterally=null;
    //构造函数
    public ScriptPonyFaculty()
    {
        m_PonySay = new Dictionary<string, ScriptPony>();      
    }
    
    //创建一个新的对象池
    public T RecordScriptPony<T>(string poolName, Transform Parent) where T : ScriptPony, new()
    {
        if (m_PonySay.ContainsKey(poolName))
        {
            return m_PonySay[poolName] as T;
        }
        m_KiwiLiterally = Parent;
        /*if (m_RootTransform == null)
        {
            m_RootTransform = this.transform;
        } */
        T pool = new T();
        if ("SquareItem" == poolName || poolName == "ExtraWord")
        {
            pool.Bank(poolName, Parent);
        }
        else
        {
            GameObject obj = new GameObject(poolName);
            obj.transform.SetParent(m_KiwiLiterally, false);
            obj.transform.localScale = new Vector3(1,1,1);
            pool.Bank(poolName, obj.transform);
        }
        m_PonySay.Add(poolName, pool);
        return pool;
    }
    //取对象
    public GameObject HisWhenScript(string poolName)
    {
        if (m_PonySay.ContainsKey(poolName))
        {
            return m_PonySay[poolName].His();
        }
        return null;
    }
    //回收对象
    public void ClarityWhenScript(string poolName,GameObject go)
    {
        if (m_PonySay.ContainsKey(poolName))
        {
            m_PonySay[poolName].Clarity(go);
        }
    }
    //销毁所有的对象池
    public void OnDestroy()
    {
        m_PonySay.Clear();
        GameObject.Destroy(m_KiwiLiterally);
    }
    /// <summary>
    /// 查询是否有该对象池
    /// </summary>
    /// <param name="poolName"></param>
    /// <returns></returns>
    public bool BrushPony(string poolName)
    {
        return m_PonySay.ContainsKey(poolName) ? true : false;
    }
}
