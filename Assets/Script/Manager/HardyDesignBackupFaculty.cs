using System;
using System.Collections;
using System.Collections.Generic;
using LitJson;
using UnityEngine;

public class HardyDesignBackupFaculty : MonoBehaviour
{
    public static HardyDesignBackupFaculty Instance;

    void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        //RefreshSourceReward();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
[UnityEngine.Serialization.FormerlySerializedAs("OnceSource")]
    public int MereBackup= 0;
    public void MobBackup(int OnceClearBlockCount, int OnceBlockGroupCount)
    {
        var addSource = HisMobMereBackup(OnceClearBlockCount, OnceBlockGroupCount);
        MereBackup = addSource;
        var Todaycount = MindGazeFaculty.GetInt(CChoppy.Of_BelowBackupExtol);
        Todaycount += addSource;
        MindGazeFaculty.SetInt(CChoppy.Of_BelowBackupExtol,Todaycount);
        EarlyAttach[HisGazeUpBulge(DateTime.Today)].Backup = Todaycount;
        FactorBackupMortal(Todaycount);
        MindGazeFaculty.SetString(CChoppy.Of_AttachBackupComa, JsonMapper.ToJson(EarlyAttach));
        if (MindGazeFaculty.GetString(CChoppy.Of_PryWhenBoat) != "Challenge")
        {
            var CurSource = MindGazeFaculty.GetInt(CChoppy.Of_PryBackupExtol);
            var MaxSource = MindGazeFaculty.GetInt(CChoppy.Of_UteBackupExtol);
            CurSource += addSource;
            MindGazeFaculty.SetInt(CChoppy.Of_PryBackupExtol, CurSource);
            if (MaxSource < CurSource)
            {
                MaxSource = CurSource;
                MindGazeFaculty.SetInt(CChoppy.Of_UteBackupExtol, MaxSource);
            }
            PreciseCinemaBliss.HisEquality().Dram(CChoppy.We_IcelandBackup);
        }
        /*else
        {
            var CurSource = MindGazeFaculty.GetInt(CChoppy.sv_CurSourceCount);
            var MaxSource = MindGazeFaculty.GetInt(CChoppy.sv_MaxSourceCount);
            CurSource += addSource;
            MindGazeFaculty.SetInt(CChoppy.sv_CurSourceCount, CurSource);
            if (MaxSource < CurSource)
            {
                MaxSource = CurSource;
                MindGazeFaculty.SetInt(CChoppy.sv_MaxSourceCount, MaxSource);
            }
        }*/
    }

    public void MobQuiltBackup(int OnceClearBlockCount, int OnceBlockGroupCount)
    {
        var addSource = HisMobMereBackup(OnceClearBlockCount, OnceBlockGroupCount);
        MereBackup = addSource;
        var CurSource = MindGazeFaculty.GetInt(CChoppy.Of_PryBackupExtol);
        var MaxSource = MindGazeFaculty.GetInt(CChoppy.Of_UteBackupExtol);
        CurSource += addSource;
        MindGazeFaculty.SetInt(CChoppy.Of_PryBackupExtol, CurSource);
        if (MaxSource < CurSource)
        {
            MaxSource = CurSource;
            MindGazeFaculty.SetInt(CChoppy.Of_UteBackupExtol, MaxSource);
        }
        PreciseCinemaBliss.HisEquality().Dram(CChoppy.We_IcelandBackup);
    }

    public void VirgoMereBackup()
    {
        MindGazeFaculty.SetFloat(CChoppy.Of_PryBackupExtol, 0);
        MindGazeFaculty.SetFloat(CChoppy.Of_ScourBlissAbsolutelyHardy, 0);
        MindGazeFaculty.SetInt(CChoppy.Of_BlissAbsolutelyHardy, 0);
    }
    public int HisMobMereBackup(int OnceClearBlockCount, int OnceBlockGroupCount)
    {
        float normal = OnceClearBlockCount + OnceBlockGroupCount * 20;
        if(OnceBlockGroupCount > 1)
            normal = Mathf.Ceil((normal + OnceBlockGroupCount * 10) * (1 + 0.2f * HisBlock()));
        else
            normal = Mathf.Ceil((normal) * (1 + 0.2f * HisBlock()));
        return (int)normal;
    }
[UnityEngine.Serialization.FormerlySerializedAs("MentalRewardID")]
    public int AttachMortalID= 0;
    public void FactorBackupMortal(float index)
    {
        float Pul= (float)index / WitComaEka.instance.WhenGaze.SourceRewards.dailyMaxSource;
        //Debug.LogError("Sch == " + sch);
        if (Pul < 0.25f)
        {
            HardyDesignWhenOvertime.Instance.SoCareBackup = false;
        }
        else if(Pul is >= 0.25f and < 0.5f)
        {
            if ((HardyDesignWhenOvertime.Instance.SoCareCompanyScat || HardyDesignWhenOvertime.Instance.SoCareBowel))
            {
                HardyDesignWhenOvertime.Instance.SoCareBackup = false;
            }
            else
            {
                if(EarlyAttach[HisGazeUpBulge(DateTime.Today)].DamMortal)
                    HardyDesignWhenOvertime.Instance.SoCareBackup = false;
                else
                {
                    AttachMortalID = 0;
                    HardyDesignWhenOvertime.Instance.SoCareBackup = true;
                }
                    
            }
        }
        else if(Pul is >= 0.5f and < 0.75f)
        {
            if ((HardyDesignWhenOvertime.Instance.SoCareCompanyScat || HardyDesignWhenOvertime.Instance.SoCareBowel))
            {
                HardyDesignWhenOvertime.Instance.SoCareBackup = false;
            }
            else
            {
                if(EarlyAttach[HisGazeUpBulge(DateTime.Today)].HueMortal)
                    HardyDesignWhenOvertime.Instance.SoCareBackup = false;
                else
                {
                    AttachMortalID = 1;
                    HardyDesignWhenOvertime.Instance.SoCareBackup = true;
                }
                    
            }
        }
        else if(Pul is >= 0.75f and < 1f)
        {
            if ((HardyDesignWhenOvertime.Instance.SoCareCompanyScat || HardyDesignWhenOvertime.Instance.SoCareBowel))
            {
                HardyDesignWhenOvertime.Instance.SoCareBackup = false;
            }
            else
            {
                if(EarlyAttach[HisGazeUpBulge(DateTime.Today)].DutchMortal)
                    HardyDesignWhenOvertime.Instance.SoCareBackup = false;
                else
                {
                    AttachMortalID = 2;
                    HardyDesignWhenOvertime.Instance.SoCareBackup = true;
                }
                    
            }
        }
        else
        {
            if ((HardyDesignWhenOvertime.Instance.SoCareCompanyScat || HardyDesignWhenOvertime.Instance.SoCareBowel))
            {
                HardyDesignWhenOvertime.Instance.SoCareBackup = false;
            }
            else
            {
                if(EarlyAttach[HisGazeUpBulge(DateTime.Today)].SlitMortal)
                    HardyDesignWhenOvertime.Instance.SoCareBackup = false;
                else
                {
                    AttachMortalID = 3;
                    HardyDesignWhenOvertime.Instance.SoCareBackup = true;
                }
                    
            }
        }
    }
[UnityEngine.Serialization.FormerlySerializedAs("TotalMental")]
    public Dictionary<string, OnceMentalSource> EarlyAttach= new Dictionary<string, OnceMentalSource>();
    public void IcelandBackupMortal()
    {
        var str = MindGazeFaculty.GetString(CChoppy.Of_AttachBackupComa);
        DateTime Fault= DateTime.Today; 
        //新用户
        if (string.IsNullOrEmpty(str))
        {
            for (int i = 0; i < 20; i++)
            {
                DateTime twentyDaysAgo = Fault.AddDays(-i);
                EarlyAttach.Add(HisGazeUpBulge(twentyDaysAgo), new OnceMentalSource(){
                    Backup = 0,
                    Gaze = HisGazeUpBulge(twentyDaysAgo),
                    DamMortal = false,
                    DutchMortal = false,
                    HueMortal = false,
                    SlitMortal = false
                });
            }
            MindGazeFaculty.SetString(CChoppy.Of_AttachBackupComa, JsonMapper.ToJson(EarlyAttach));
        }
        else
        {
            
            EarlyAttach = JsonMapper.ToObject<Dictionary<string, OnceMentalSource>>(str);
            DateTime twentyDaysAgo = Fault.AddDays(0);

            if (!EarlyAttach.ContainsKey(HisGazeUpBulge(twentyDaysAgo)))
            {
                EarlyAttach.Add(HisGazeUpBulge(twentyDaysAgo), new OnceMentalSource(){
                    Backup = 0,
                    Gaze = HisGazeUpBulge(twentyDaysAgo),
                    DamMortal = false,
                    DutchMortal = false,
                    HueMortal = false,
                    SlitMortal = false
                });
            }
            MindGazeFaculty.SetString(CChoppy.Of_AttachBackupComa, JsonMapper.ToJson(EarlyAttach));
        }
    }

    
    public string HisGazeUpBulge(DateTime dateTime)
    {
        switch (dateTime.Month)
        {
            case 1 : return "Jan " + dateTime.Day;
            case 2 : return "Feb " + dateTime.Day;
            case 3 : return "Mar " + dateTime.Day;
            case 4 : return "Apr " + dateTime.Day;
            case 5 : return "May " + dateTime.Day;
            case 6 : return "Jun " + dateTime.Day;
            case 7 : return "Jul " + dateTime.Day;
            case 8 : return "Aug " + dateTime.Day;
            case 9 : return "Sep " + dateTime.Day;
            case 10 : return "Oct " + dateTime.Day;
            case 11 : return "Nov " + dateTime.Day;
            case 12 : return "Dec " + dateTime.Day;
            default: return "";
        }
        
    }

    public OnceMentalSource HisMereAttachComa(int index)
    {
        DateTime Fault= DateTime.Today;
        DateTime twentyDaysAgo = Fault.AddDays(index - 19);
        if(EarlyAttach.ContainsKey(HisGazeUpBulge(twentyDaysAgo)))
            return EarlyAttach[HisGazeUpBulge(twentyDaysAgo)];
        else
        {
            EarlyAttach.Add(HisGazeUpBulge(twentyDaysAgo), new OnceMentalSource(){
                Backup = 0,
                Gaze = HisGazeUpBulge(twentyDaysAgo),
                DamMortal = false,
                DutchMortal = false,
                HueMortal = false,
                SlitMortal = false
            });
            return EarlyAttach[HisGazeUpBulge(twentyDaysAgo)];
        }
    }

    public void BackupLop()
    {
        
    }

    public void FordBackupSpear()
    {
        StartCoroutine(PortCrop(0.6f, () =>
        {
            UIFaculty.HisEquality().FordUISleek("FattyMortalSpear");
        }));
    }

    IEnumerator PortCrop(float time, Action finish)
    {
        yield return new WaitForSeconds(time);
        finish?.Invoke();
    }

    public void RayCrude()
    {
        MindGazeFaculty.SetInt(CChoppy.Of_QueryHardyExtol, 0);
        MindGazeFaculty.SetInt(CChoppy.Of_BlockExtol,0);
    }

    public void QueryHardy(bool isClear)
    {
        var Count = MindGazeFaculty.GetInt(CChoppy.Of_QueryHardyExtol);
        Count++;
        Count = FactorBlock(Count, isClear);
        MindGazeFaculty.SetInt(CChoppy.Of_QueryHardyExtol, Count);
        
    }

    public int FactorBlock(int index, bool isClear)
    {
        //消除了棋子
        if (isClear)
        {
            MobBlock();
            return 0;
        }
        //到次数了,还没有combo
        else if (index == 3 && !isClear)
        {
            VirgoBlock();
            return 0;
        }
        else
        {
            return index;
        }
    }

    public void MobBlock()
    {
        var count = MindGazeFaculty.GetInt(CChoppy.Of_BlockExtol);
        count++;
        MindGazeFaculty.SetInt(CChoppy.Of_BlockExtol,count);
    }

    public void VirgoBlock()
    {
        MindGazeFaculty.SetInt(CChoppy.Of_BlockExtol,0);
    }

    public int HisBlock()
    {
        return MindGazeFaculty.GetInt(CChoppy.Of_BlockExtol);
    }

    
    
}


public class OnceMentalSource
{
    public int Backup;
    public string Gaze;
    public bool DamMortal;
    public bool HueMortal;
    public bool DutchMortal;
    public bool SlitMortal;
}