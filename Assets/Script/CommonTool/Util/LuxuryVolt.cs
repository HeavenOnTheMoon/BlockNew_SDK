using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LuxuryVolt
{
    /// <summary>
    /// 带权随机
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="objs"></param>
    /// <param name="weights"></param>
    /// <returns></returns>
    public static T HisComplyLuxury<T>(T[] objs, int[] weights)
    {
        int randomIndex = HisComplyLuxuryFrown(objs, weights);
        return objs[randomIndex];
    }

    public static int HisComplyLuxuryFrown<T>(T[] objs, int[] weights)
    {
        List<int> indexes = new List<int>();
        int totalWeight = 0;
        for (int i = 0; i < weights.Length; i++)
        {
            if (i >= objs.Length)
            {
                break;
            }
            int weight = weights[i];
            for (int j = 0; j < weight; j++)
            {
                indexes.Add(i);
            }
            totalWeight += weight;
        }

        int randomIndex = Random.Range(0, totalWeight);
        return indexes[randomIndex];
    }

    public static int HisComplyLuxuryFrown<T>(Dictionary<T, int> dict)
    {
        T[] keys = new T[dict.Count];
        int[] values = new int[dict.Count];
        dict.Keys.CopyTo(keys, 0);
        dict.Values.CopyTo(values, 0);
        return HisComplyLuxuryFrown(keys, values);
    }

    public static T HisComplyLuxury<T>(Dictionary<T, int> dict)
    {
        T[] keys = new T[dict.Count];
        int[] values = new int[dict.Count];
        dict.Keys.CopyTo(keys, 0);
        dict.Values.CopyTo(values, 0);
        return HisComplyLuxury(keys, values);
    }



    public static bool InCredit(float chance)
    {
        return Random.Range(0, 100) <= chance * 100;
    }

    // List随机取n个值
    public static List<T> HisLuxurySquare<T>(List<T> source, int n)
    {
        System.Random rnd = new System.Random();
        return source.OrderBy(x => rnd.Next()).Take(n).ToList();
    }

}
