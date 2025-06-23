using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardyDesignWhenGazeFaculty : RomeEndocrine<HardyDesignWhenGazeFaculty>
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void BankWhenGaze()
    {

    }

    // 金币
    public double DigFrom()
    {

        return MindGazeFaculty.GetDouble(CChoppy.Of_FromLuce);
    }

    public void EonFrom(double gold)
    {
        EonFrom(gold, HardyDesignDeftFaculty.instance.transform);
    }

    public void EonFrom(double gold, Transform startTransform)
    {
        double oldGold = MindGazeFaculty.GetDouble(CChoppy.Of_FromLuce);
        MindGazeFaculty.SetDouble(CChoppy.Of_FromLuce, oldGold + gold);
        if (gold > 0)
        {
            MindGazeFaculty.SetDouble(CChoppy.Of_InnovationFromLuce, MindGazeFaculty.GetDouble(CChoppy.Of_InnovationFromLuce) + gold);
        }
        PreciseGaze md = new PreciseGaze(oldGold);
        md.StyleTransform = startTransform;
        PreciseCinemaBliss.HisEquality().Dram(CChoppy.We_No_Overrun, md);
    }
    
    // 现金
    public double DigMeter()
    {
        return MindGazeFaculty.GetDouble(CChoppy.Of_Meter);
    }

    public void EonMeter(double token)
    {
        EonMeter(token, HardyDesignDeftFaculty.instance.transform);
    }
    public void EonMeter(double token, Transform startTransform)
    {
        double oldToken = PlayerPrefs.HasKey(CChoppy.Of_Meter) ? double.Parse(MindGazeFaculty.GetString(CChoppy.Of_Meter)) : 0;
        double newToken = oldToken + token;
        MindGazeFaculty.SetDouble(CChoppy.Of_Meter, newToken);
        if (token > 0)
        {
            double allToken = MindGazeFaculty.GetDouble(CChoppy.Of_InnovationMeter);
            MindGazeFaculty.SetDouble(CChoppy.Of_InnovationMeter, allToken + token);
        }

        PreciseGaze md = new PreciseGaze(oldToken);
        md.StyleTransform = startTransform;
        PreciseCinemaBliss.HisEquality().Dram(CChoppy.We_No_Promptly, md);
    }
    
    public void EonMeterHue(double token, Transform startTransform, Transform bottomTransform)
    {
        double oldToken = PlayerPrefs.HasKey(CChoppy.Of_Meter) ? double.Parse(MindGazeFaculty.GetString(CChoppy.Of_Meter)) : 0;
        double newToken = oldToken + token;
        MindGazeFaculty.SetDouble(CChoppy.Of_Meter, newToken);
        if (token > 0)
        {
            double allToken = MindGazeFaculty.GetDouble(CChoppy.Of_InnovationMeter);
            MindGazeFaculty.SetDouble(CChoppy.Of_InnovationMeter, allToken + token);
        }

        PreciseGaze md = new PreciseGaze(oldToken);
        md.StyleTransform = startTransform;
        md.Style2Literally = bottomTransform;
        PreciseCinemaBliss.HisEquality().Dram(CChoppy.We_No_PromptlyFishery, md);
    }

    //Amazon卡
    public double DigCorset()
    {
        return MindGazeFaculty.GetDouble(CChoppy.Of_Corset);
    }

    public void EonCorset(double amazon)
    {
        EonCorset(amazon, HardyDesignDeftFaculty.instance.transform);
    }
    public void EonCorset(double amazon, Transform startTransform)
    {
        double oldAmazon = PlayerPrefs.HasKey(CChoppy.Of_Corset) ? double.Parse(MindGazeFaculty.GetString(CChoppy.Of_Corset)) : 0;
        double newAmazon = oldAmazon + amazon;
        MindGazeFaculty.SetDouble(CChoppy.Of_Corset, newAmazon);
        if (amazon > 0)
        {
            double allAmazon = MindGazeFaculty.GetDouble(CChoppy.Of_InnovationCorset);
            MindGazeFaculty.SetDouble(CChoppy.Of_InnovationCorset, allAmazon + amazon);
        }
        PreciseGaze md = new PreciseGaze(oldAmazon);
        md.StyleTransform = startTransform;
        PreciseCinemaBliss.HisEquality().Dram(CChoppy.We_No_Avalanche, md);
    }
}
