using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 广告管理
/// </summary>
public class ByFaculty : MonoBehaviour
{
    public static ByFaculty Instance;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 游戏前后台切换，自动播放广告
    /// </summary>
    /// <param name="pause"></param>
    private void OnApplicationPause(bool pause)
    {
        if (!pause)
        {
            ByPeat.Equality.MobNeedyChina();
        }
    }

    private bool OxDayPlague= false;

    /// <summary>
    /// 开始广告管理
    /// </summary>
    public void SewerBy()
    {
        if (OxDayPlague) return;
        
        OxDayPlague = true;
        ByPeat.Equality.BankBy();
        // 更新用户在线时长，自动播放广告
        InvokeRepeating(nameof(MobSupplyExtinct), 1, 1);
    }

    public void MobSupplyExtinct()
    {
        ByPeat.Equality.MobSupplyExtinct();
    }
}
