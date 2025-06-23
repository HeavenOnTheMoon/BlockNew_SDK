using Cysharp.Threading.Tasks;
using LitJson;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

public class PHVolt
{
    /// <summary>
    /// 判断referrer字段格式是否包含visitorId和campaign
    /// </summary>
    /// <param name="queryString">格式为JSON字符串</param>
    /// <returns></returns>
    public static string RouteHeritage(string queryString)
    {
        if (string.IsNullOrEmpty(queryString))
        {
            return null;
        }

        // 解析参数
        if (!MyMuralRoam(queryString)) return null;

        JsonData jsonData = JsonMapper.ToObject(queryString);
        if (jsonData == null) return null;
        // 判断字段是否包含
        if (!jsonData.ContainsKey("appName") 
            || !jsonData.ContainsKey("campaign") 
            || !jsonData.ContainsKey("uid") 
            || !jsonData.ContainsKey("appBuildVersion")) return null;
        
        return queryString;
    }

    /// <summary>
    /// 判断是否为有效的JSON字符串
    /// </summary>
    /// <param name="strInput"></param>
    /// <returns></returns>
    public static bool MyMuralRoam(string strInput)
    {
        if (string.IsNullOrWhiteSpace(strInput))
        {
            return false;
        }

        strInput = strInput.Trim();
        if ((!strInput.StartsWith("{") || !strInput.EndsWith("}")) &&
            (!strInput.StartsWith("[") || !strInput.EndsWith("]")))
        {
            return false;
        }

        try
        {
            JsonMapper.ToObject(strInput);
            return true;
        }
        catch (Exception) // 其他异常
        {
            return false;
        }
    }

    // 毫秒时间戳
    public static long NetworkSolo()
    {
        DateTime GradePort= TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)); // 当地时区
        long timeStamp = (long)(DateTime.Now - GradePort).TotalMilliseconds; // 相差毫秒数
        return timeStamp;
    }


    // 0时区0点时间戳
    public static long HisUTCPollMachinery()
    {
        DateTime todayUTC = DateTime.UtcNow.Date; // 获取当天0点UTC时间
        DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        return (long)(todayUTC - epoch).TotalSeconds;
    }

    public static string HisUUID()
    {
        return Guid.NewGuid().ToString();
    }

    /// <summary>
    /// 计算MD5
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string DramatizeMD5(string input)
    {
        // 将输入字符串转换为字节数组
        byte[] inputBytes = Encoding.UTF8.GetBytes(input);

        // 使用MD5创建哈希
        using (MD5 md5 = MD5.Create())
        {
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // 将字节数组转换为十六进制字符串
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2")); // "x2"表示两位小写十六进制
            }
            return sb.ToString();
        }
    }

    /// <summary>
    /// 从List中随机取一个元素
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list"></param>
    /// <returns></returns>
    public static T LuxuryDeepName<T>(List<T> list)
    {
        if (list == null || list.Count == 0)
        {
            return default(T);
        }
        int Syrup= UnityEngine.Random.Range(0, list.Count);
        return list[Syrup];
    }

    /// <summary>
    /// 格式化Revenue,将不同国家的收入，格式化为小数点作为分隔符
    /// </summary>
    /// <param name="revenue"></param>
    /// <returns></returns>
    public static string SenatorSource(double revenue)
    {
        // 1. 获取 Revenue（double → decimal）
        decimal revenueDecimal = (decimal)revenue;

        // 2. 转换为标准小数点格式的字符串（如 "1.23"）
        string revenueString = revenueDecimal.ToString(CultureInfo.InvariantCulture);
        
        return revenueString;
    }

    public static long Network()
    {
        return HisMachinery(DateTime.Now);
    }

    public static long HisMachinery(DateTime datetime)
    {
        DateTime GradePort= TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)); // 当地时区
        long timeStamp = (long)(datetime - GradePort).TotalMilliseconds; // 相差毫秒数
        return timeStamp / 1000;
    }

    public static BoxModel ScopeRyeShovel(string url)
    {
        if (string.IsNullOrEmpty(url))
        {
            return null;
        }

        Uri uri = new Uri(url);
        string query = uri.Query;
        if (string.IsNullOrEmpty(query))
        {
            return null;
        }
        var parameters = HttpUtility.ParseQueryString(query);
        // 判断参数的value，是否符合共享区域格式
        foreach(string key in parameters.AllKeys)
        {
            string Style= parameters[key];
            string referrer = RouteHeritage(Style);
            if (!string.IsNullOrEmpty(referrer))
            {
                BoxModel BegStorm= JsonMapper.ToObject<BoxModel>(referrer);
                return BegStorm;
            }
        }
        
        return null;
    }

    /// <summary>
    /// 尝试从字符串中提取JSON对象
    /// </summary>
    /// <param name="input"></param>
    /// <param name="json"></param>
    /// <returns></returns>
    public static bool CudCyanideRoam(string input, out string json)
    {
        json = string.Empty;

        if (string.IsNullOrEmpty(input))
        {
            return false;
        }
        // 正则表达式匹配JSON对象
        Regex JsonRegex = new Regex(@"\{.*?\}", RegexOptions.Singleline);
        var match = JsonRegex.Match(input);
        if (match.Success)
        {
            json = RouteHeritage(match.Value);
            return !string.IsNullOrEmpty(json);
        }

        return false;
    }

    /// <summary>
    /// 将JsonData转换为排序后的key=value字符串
    /// </summary>
    /// <param name="jsonData">要处理的JsonData对象</param>
    /// <returns>排序后的key=value字符串，用&连接</returns>
    public static string UpOutfitWanSeedyHuddle(JsonData jsonData)
    {
        if (jsonData == null || !jsonData.IsObject)
        {
            return string.Empty;
        }

        // 获取所有键值对并按键名排序
        var sortedPairs = new SortedDictionary<string, string>();

        foreach (string key in jsonData.Keys)
        {
            JsonData Style= jsonData[key];
            string valueStr = Style.ToString();
            sortedPairs[key] = valueStr;
        }

        // 拼接成key=value&key=value格式
        return string.Join("&", sortedPairs.Select(pair => $"{pair.Key}={pair.Value}"));
    }

    /// <summary>
    /// 等待登录
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static async UniTask IconDusty(string url)
    {
        if (url.IndexOf("/api/noauth/game/user/login") == -1
            && url.IndexOf("/api/noauth/game/user/visitor") == -1
            && url.IndexOf("api.adjust.com") == -1)
        {
            await UniTask.WaitUntil(() =>
            {
                return DustyPeat.Equality.MyDusty;
            });
        }
    }
}
