using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 消息传递的参数
/// </summary>
public class PreciseGaze
{
    /*
     *  1.创建独立的消息传递数据结构，而不使用object，是为了避免数据传递时的类型强转
     *  2.制作过程中遇到实际需要传递的数据类型，在这里定义即可
     *  3.实际项目中需要传递参数的类型其实并没有很多种，这种方式基本可以满足需求
     */
    public bool StyleDeck;
    public bool StyleDeck2;
    public int StyleWin;
    public int StyleWin2;
    public int StyleWin3;
    public float StyleScour;
    public float StyleScour2;
    public double StyleEthnic;
    public double StyleEthnic2;
    public string StyleHuddle;
    public string StyleHuddle2;
    public GameObject StyleWhenScript;
    public GameObject StyleWhenScript2;
    public GameObject StyleWhenScript3;
    public GameObject StyleWhenScript4;
    public Transform StyleTransform;
    public Transform Style2Literally;
    public List<string> StyleHuddleName;
    public List<Vector2> StyleBis2Name;
    public List<int> StyleWinName;
    public System.Action OutcomeWeftGood;
    public Vector2 Him2_1;
    public Vector2 Him2_2;
    public PreciseGaze()
    {
    }
    public PreciseGaze(Vector2 v2_1)
    {
        Him2_1 = v2_1;
    }
    public PreciseGaze(Vector2 v2_1, Vector2 v2_2)
    {
        Him2_1 = v2_1;
        Him2_2 = v2_2;
    }
    /// <summary>
    /// 创建一个带bool类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public PreciseGaze(bool value)
    {
        StyleDeck = value;
    }
    public PreciseGaze(bool value, bool value2)
    {
        StyleDeck = value;
        StyleDeck2 = value2;
    }
    /// <summary>
    /// 创建一个带int类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public PreciseGaze(int value)
    {
        StyleWin = value;
    }
    public PreciseGaze(int value, int value2)
    {
        StyleWin = value;
        StyleWin2 = value2;
    }
    public PreciseGaze(int value, int value2, int value3)
    {
        StyleWin = value;
        StyleWin2 = value2;
        StyleWin3 = value3;
    }
    public PreciseGaze(List<int> value,List<Vector2> value2)
    {
        StyleWinName = value;
        StyleBis2Name = value2;
    }
    /// <summary>
    /// 创建一个带float类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public PreciseGaze(float value)
    {
        StyleScour = value;
    }
    public PreciseGaze(float value,float value2)
    {
        StyleScour = value;
        StyleScour = value2;
    }
    /// <summary>
    /// 创建一个带double类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public PreciseGaze(double value)
    {
        StyleEthnic = value;
    }
    public PreciseGaze(double value, double value2)
    {
        StyleEthnic = value;
        StyleEthnic = value2;
    }
    /// <summary>
    /// 创建一个带string类型的数据
    /// </summary>
    /// <param name="value"></param>
    public PreciseGaze(string value)
    {
        StyleHuddle = value;
    }
    /// <summary>
    /// 创建两个带string类型的数据
    /// </summary>
    /// <param name="value1"></param>
    /// <param name="value2"></param>
    public PreciseGaze(string value1,string value2)
    {
        StyleHuddle = value1;
        StyleHuddle2 = value2;
    }
    public PreciseGaze(GameObject value1)
    {
        StyleWhenScript = value1;
    }

    public PreciseGaze(Transform transform)
    {
        StyleTransform = transform;
    }
}

