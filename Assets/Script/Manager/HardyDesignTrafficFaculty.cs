using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class HardyDesignTrafficFaculty : MonoBehaviour
{
    public static HardyDesignTrafficFaculty instance;

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Bank();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
[UnityEngine.Serialization.FormerlySerializedAs("ChapterCount")]
    public List<int> TrafficExtol;
    public void Bank()
    {
        //章节信息
        for (int i = 0; i < TrafficExtol.Count; i++)
        {
            //这个章节里面没有值
            if (MindGazeFaculty.GetIntArray("Chapter" + i).Length == 0)
            {
                MindGazeFaculty.SetIntArray("Chapter" + i, HisTrafficComa(TrafficExtol[i], i));
            }
        }
    }

    public void FactorHomelessTrafficShare()
    {
        int sum = 0;
        for (int i = 0; i < TrafficExtol.Count; i++)
        {
            sum += TrafficExtol[i];
            if (sum == HardyDesignCrudeFaculty.Instance.HisPryCrude())
            {
                MindGazeFaculty.SetInt(CChoppy.Of_MyHomelessTraffic, 1);
            }
        }
    }

    public bool HisHomelessTrafficShare()
    {
        return  MindGazeFaculty.GetInt(CChoppy.Of_MyHomelessTraffic) == 1;
    }
    public bool HisMyHomeless(int index)
    {
        //位置章节
        var chapter = HisSourceUpTraffic(index);
        int frontchapter = 0;
        for (int i = 0; i < chapter; i++)
        {
            frontchapter += TrafficExtol[i];
        }

        //var intArray = MindGazeFaculty.GetIntArray("Chapter" + chapter);
        if (HardyDesignCrudeFaculty.Instance.HisPryCrude() > index)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public int HisSourceUpTraffic(int curLevel)
    {
        int sum = 0;
        for (int i = 0; i < TrafficExtol.Count; i++)
        {
            sum += TrafficExtol[i];
            if (curLevel < sum)
                return i;
        }
        return 0;
    }

    private int[] HisTrafficComa(int intCount, int chapterID)
    {
        int[] chapters = new int[intCount];
        int startID = 0; 
        for (int i = 0; i < chapterID; i++)
        {
            startID += TrafficExtol[i];
        }
        
        for (int i = 0; i < chapters.Length; i++)
        {
            chapters[i] = i + startID;
        }
        chapters = HardyDesignDeftFaculty.instance.LuxuryWin(chapters);
        return chapters;
    }
    
    
}
