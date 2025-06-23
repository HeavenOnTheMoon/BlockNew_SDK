/*
 * 
 * 多语言
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreelessEka 
{
    public static TreelessEka _Cooperate;
    //语言翻译的缓存集合
    private Dictionary<string, string> _SayTreelessCoach;

    private TreelessEka()
    {
        _SayTreelessCoach = new Dictionary<string, string>();
        //初始化语言缓存集合
        BankTreelessCoach();
    }

    /// <summary>
    /// 获取实例
    /// </summary>
    /// <returns></returns>
    public static TreelessEka HisEquality()
    {
        if (_Cooperate == null)
        {
            _Cooperate = new TreelessEka();
        }
        return _Cooperate;
    }

    /// <summary>
    /// 得到显示文本信息
    /// </summary>
    /// <param name="lauguageId">语言id</param>
    /// <returns></returns>
    public string FordTear(string lauguageId)
    {
        string strQueryResult = string.Empty;
        if (string.IsNullOrEmpty(lauguageId)) return null;
        //查询处理
        if(_SayTreelessCoach!=null && _SayTreelessCoach.Count >= 1)
        {
            _SayTreelessCoach.TryGetValue(lauguageId, out strQueryResult);
            if (!string.IsNullOrEmpty(strQueryResult))
            {
                return strQueryResult;
            }
        }
        Debug.Log(GetType() + "/ShowText()/ Query is Null!  Parameter lauguageID: " + lauguageId);
        return null;
    }

    /// <summary>
    /// 初始化语言缓存集合
    /// </summary>
    private void BankTreelessCoach()
    {
        //LauguageJSONConfig_En
        //LauguageJSONConfig
        IChoppyFaculty config = new ChoppyFacultyHeRoam("LauguageJSONConfig");
        if (config != null)
        {
            _SayTreelessCoach = config.AppSetting;
        }
    }
}
