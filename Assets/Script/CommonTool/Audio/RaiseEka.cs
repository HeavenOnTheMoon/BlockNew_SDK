/***
 * 
 * 音乐管理器
 * 
 * **/
using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseEka : RomeEndocrine<RaiseEka>
{
    //音频组件管理队列的对象
    private CanalBackupPurge CanalPurge;
    // 用于播放背景音乐的音乐源
    private AudioSource m_IDRaise=null;
    //播放音效的音频组件管理列表
    private List<AudioSource> ItemCanalBackupName;
    //检查已经播放的音频组件列表中没有播放的组件的更新频率
    private float RouteIsotopic= 2f; 
    //背景音乐开关
    private bool _OfRaiseClimax;
    //音效开关
    private bool _PuffinRaiseClimax;
    //音乐音量
    private float _OfStarch=1f;
    //音效音量
    private float _PuffinStarch=1f;
    string BGM_Knot= "";

    public Dictionary<string, CanalStorm> CanalForeverFarm;

    // 控制背景音乐音量大小
    public float OfStarch    {
        get { 
            return OfRaiseClimax ? DigStarch(BGM_Knot) : 0f; 
        }
        set {
            _OfStarch = value;
            //背景音乐开的状态下，声音随控制调节
        }
    }

    //控制音效音量的大小
    public float PuffinRegard    {
        get { return _PuffinStarch; }
        set { 
            _PuffinStarch = value;
            TugHitPuffinStarch();
        }
    }
    //控制背景音乐开关
    public bool OfRaiseClimax    {
        get {

            _OfRaiseClimax = MindGazeFaculty.GetBool("_BgMusicSwitch");
            return _OfRaiseClimax; 
        }
        set {
            if(m_IDRaise)
            {
                _OfRaiseClimax = value;
                MindGazeFaculty.SetBool("_BgMusicSwitch", _OfRaiseClimax);
                m_IDRaise.volume = OfStarch; 
            }
        }
    }
    public void TapBuySpoonDamPort()
    {
        m_IDRaise.volume = 0;
    }
    public void TapBuyStewpotDamPort()
    {
        m_IDRaise.volume = OfStarch;
    }
    //控制音效开关
    public bool PuffinRaiseClimax    {
        get {
            _PuffinRaiseClimax = MindGazeFaculty.GetBool("_EffectMusicSwitch");
            return _PuffinRaiseClimax; 
        }
        set {
            _PuffinRaiseClimax = value;
            MindGazeFaculty.SetBool("_EffectMusicSwitch", _PuffinRaiseClimax);
            
        }
    }
    public RaiseEka()
    {
        ItemCanalBackupName = new List<AudioSource>();      
    }
    protected override void Awake()
    {
        if (!PlayerPrefs.HasKey("first_music_setBool") || !MindGazeFaculty.GetBool("first_music_set"))
        {
            MindGazeFaculty.SetBool("first_music_set", true);
            MindGazeFaculty.SetBool("_BgMusicSwitch", true);
            MindGazeFaculty.SetBool("_EffectMusicSwitch", true);
        }
        CanalPurge = new CanalBackupPurge(this);

        TextAsset Pool= Resources.Load<TextAsset>("Audio/AudioInfo");
        CanalForeverFarm = JsonMapper.ToObject<Dictionary<string, CanalStorm>>(Pool.text);
    }
    private void Start()
    {
        StartCoroutine("RouteHeMawCanalKilometer");
    }
    /// <summary>
    /// 定时检查没有使用的音频组件并回收
    /// </summary>
    /// <returns></returns>
    IEnumerator RouteHeMawCanalKilometer()
    {
        while (true)
        {
            //定时更新
            yield return new WaitForSeconds(RouteIsotopic);
            for (int i = 0; i < ItemCanalBackupName.Count; i++)
            {
                //防止数据越界
                if (i < ItemCanalBackupName.Count)
                {
                    //确保物体存在
                    if (ItemCanalBackupName[i])
                    {
                        //音频为空或者没有播放为返回队列条件
                        if ((ItemCanalBackupName[i].clip == null || !ItemCanalBackupName[i].isPlaying))
                        {
                            //返回队列
                            CanalPurge.HeMawCanalKilometer(ItemCanalBackupName[i]);
                            //从播放列表中删除
                            ItemCanalBackupName.Remove(ItemCanalBackupName[i]);
                        }
                    }
                    else
                    {
                        //移除在队列中被销毁但是是在list中存在的垃圾数据
                        ItemCanalBackupName.Remove(ItemCanalBackupName[i]);
                    }                 
                }            
               
            }
        }
    }
    /// <summary>
    /// 设置当前播放的所有音效的音量
    /// </summary>
    private void TugHitPuffinStarch()
    {
        for (int i = 0; i < ItemCanalBackupName.Count; i++)
        {
            if (ItemCanalBackupName[i] && ItemCanalBackupName[i].isPlaying)
            {
                ItemCanalBackupName[i].volume = _PuffinRaiseClimax ? _PuffinStarch : 0f;
            }
        }
    }
    /// <summary>
    /// 播放背景音乐，传进一个音频剪辑的name
    /// </summary>
    /// <param name="bgName"></param>
    /// <param name="restart"></param>
    private void ItemOfAlga(object bgName, bool restart = false)
    {

        BGM_Knot = bgName.ToString();
        if (m_IDRaise == null)
        {
            //拿到一个音频组件  背景音乐组件在某一时间段唯一存在
            m_IDRaise = CanalPurge.HisCanalKilometer();
            //开启循环
            m_IDRaise.loop = true;
            //开始播放
            m_IDRaise.playOnAwake = false;
            //加入播放列表
            //PlayAudioSourceList.Add(m_bgMusic);
        }

        if (!OfRaiseClimax)
        {
            m_IDRaise.volume = 0;
        }

        //定义一个空的字符串
        string curBgName = string.Empty;
        //如果这个音乐源的音频剪辑不为空的话
        if (m_IDRaise.clip != null)
        {
            //得到这个音频剪辑的name
            curBgName = m_IDRaise.clip.name;
        }

        // 根据用户的音频片段名称, 找到AuioClip, 然后播放,
        //ResourcesMgr是提前定义好的查找音频剪辑对应路径的单例脚本，并动态加载出来
        AudioClip clip = Resources.Load<AudioClip>(CanalForeverFarm[BGM_Knot].SodaOdor);
        //如果找到了，不为空
        if (clip != null)
        {
            //如果这个音频剪辑已经复制给类音频源，切正在播放，那么直接跳出
            if (clip.name == curBgName && !restart)
            {
                return;
            }
            //否则，把改音频剪辑赋值给音频源，然后播放
            m_IDRaise.clip = clip;
            m_IDRaise.volume = OfStarch;
            m_IDRaise.Play();
        }
        else
        {
            //没找到直接报错
            // 异常, 调用写日志的工具类.
            //UnityEngine.Debug.Log("没有找到音频片段");
            if (m_IDRaise.isPlaying)
            {
                m_IDRaise.Stop();
            }
            m_IDRaise.clip = null;
        }
    }
    /// <summary>
    /// 播放音效
    /// </summary>
    /// <param name="effectName"></param>
    /// <param name="defAudio"></param>
    /// <param name="volume"></param>
    private void ItemPuffinAlga(object effectName, bool defAudio = true, float volume = 1f)
    {
        if (!PuffinRaiseClimax)
        {
            return;
        }
        //获取音频组件
        AudioSource m_effectMusic = CanalPurge.HisCanalKilometer();
        if (m_effectMusic.isPlaying) {
            //Debug.Log("-------------------------------当前音效正在播放,直接返回");
            return;
        };
        m_effectMusic.loop = false;
        m_effectMusic.playOnAwake = false;
        m_effectMusic.volume = DigStarch(effectName.ToString());
        //Debug.Log(m_effectMusic.volume);
        //根据查找路径加载对应的音频剪辑
        AudioClip clip = Resources.Load<AudioClip>(CanalForeverFarm[effectName.ToString()].SodaOdor);
        //如果为空的话，直接报错，然后跳出
        if (clip == null)
        {
            //UnityEngine.Debug.Log("没有找到音效片段");
            //没加入播放列表直接返回给队列
            CanalPurge.HeMawCanalKilometer(m_effectMusic);
            return;
        }
        m_effectMusic.clip = clip;
        //加入播放列表
        ItemCanalBackupName.Add(m_effectMusic);
        //否则，就是clip不为空的话，如果defAudio=true，直接播放
        if (defAudio)
        {
            m_effectMusic.PlayOneShot(clip, volume);
        }
        else
        {
            //指定点播放
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, volume);
        }
    }

    //播放各种音频剪辑的调用方法，MusicType是提前写好的存放各种音乐名称的枚举类，便于外面直接调用
    public void ItemOf(RaiseWell.UIMusic bgName, bool restart = false)
    {
        ItemOfAlga(bgName, restart);
    }

    public void ItemOf(RaiseWell.SceneMusic bgName, bool restart = false)
    {
        ItemOfAlga(bgName, restart);
    }

    //播放各种音频剪辑的调用方法，MusicType是提前写好的存放各种音乐名称的枚举类，便于外面直接调用
    public void ItemPuffin(RaiseWell.UIMusic effectName, bool defAudio = true, float volume = 1f)
    {
        ItemPuffinAlga(effectName, defAudio, volume);
    }

    public void ItemPuffin(RaiseWell.SceneMusic effectName, bool defAudio = true, float volume = 1f)
    {
        ItemPuffinAlga(effectName, defAudio, volume);
    }
    float DigStarch(string name)
    {
        if (CanalForeverFarm == null)
        {
            TextAsset Pool= Resources.Load<TextAsset>("Audio/AudioInfo");
            CanalForeverFarm = JsonMapper.ToObject<Dictionary<string, CanalStorm>>(Pool.text);
        }

        if (CanalForeverFarm.ContainsKey(name))
        {
             return (float)CanalForeverFarm[name].Attest;

        }
        else
        {
            return 1;
        }
    }

}