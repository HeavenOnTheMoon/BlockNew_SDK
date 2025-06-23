/***
 * 
 * AudioSource组件管理(音效，背景音乐除外)
 * 
 * **/
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CanalBackupPurge 
{
    //音乐的管理者
    private GameObject CanalEka;
    //音乐组件管理队列
    private List<AudioSource> CanalKilometerPurge;
    //音乐组件默认容器最大值  
    private int UteExtol= 25;
    public CanalBackupPurge(RaiseEka audioMgr)
    {
        CanalEka = audioMgr.gameObject;
        BankCanalBackupPurge();
    }
  
    /// <summary>
    /// 初始化队列
    /// </summary>
    private void BankCanalBackupPurge()
    {
        CanalKilometerPurge = new List<AudioSource>();
        for(int i = 0; i < UteExtol; i++)
        {
            MobCanalBackupSewReadEka();
        }
    }
    /// <summary>
    /// 给音乐的管理者添加音频组件，同时组件加入队列
    /// </summary>
    private AudioSource MobCanalBackupSewReadEka()
    {
        AudioSource audio = CanalEka.AddComponent<AudioSource>();
        CanalKilometerPurge.Add(audio);
        return audio;
    }
    /// <summary>
    /// 获取一个音频组件
    /// </summary>
    /// <param name="audioMgr"></param>
    /// <returns></returns>
    public AudioSource HisCanalKilometer()
    {
        if (CanalKilometerPurge.Count > 0)
        {
            AudioSource audio = CanalKilometerPurge.Find(t => !t.isPlaying);
            if (audio)
            {
                CanalKilometerPurge.Remove(audio);
                return audio;
            }
            //队列中没有了，需额外添加
            return MobCanalBackupSewReadEka();
            //直接返回队列中存在的组件
            //return AudioComponentQueue.Dequeue();
        }
        else
        {
            //队列中没有了，需额外添加
            return  MobCanalBackupSewReadEka();
        }
    }
    /// <summary>
    /// 没有被使用的音频组件返回给队列
    /// </summary>
    /// <param name="audio"></param>
    public void HeMawCanalKilometer(AudioSource audio)
    {
        if (CanalKilometerPurge.Contains(audio)) return;
        if (CanalKilometerPurge.Count >= UteExtol)
        {
            GameObject.Destroy(audio);
            //Debug.Log("删除组件");
        }
        else
        {
            audio.clip = null;
            CanalKilometerPurge.Add(audio);
        }

        //Debug.Log("队列长度是" + AudioComponentQueue.Count);
    }
    
}
