using LitJson;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

public class RootIsotopePeat
{
    private static RootIsotopePeat instance;

    public static RootIsotopePeat Equality    {
        get
        {
            if (instance == null)
            {
                instance = new RootIsotopePeat();
                instance.DoorIsotopeBifocal = new LimeRootBifocal();
                instance.RulerHowIsotopeBifocal = new HorseHowIsotopeBifocal();
                instance.DespiteName = new List<HttpRequestModel>();
                instance.HisCargoIsotope();
            }
            return instance;
        }
    }

    private LimeRootBifocal DoorIsotopeBifocal;
    private HorseHowIsotopeBifocal RulerHowIsotopeBifocal;

    private List<HttpRequestModel> DespiteName; // 错误请求列表
    private bool SoAncestral= false;   // 正在重发错误请求

    private void HisCargoIsotope()
    {
        // 从本地缓存中获取超时请求列表
        string[] savedReqeust = PHMindGazeFaculty.GetStringArray("PH_request_list");
        if (savedReqeust == null || savedReqeust.Length == 0) return;

        for (int i = 0; i < savedReqeust.Length; i++)
        {
            string Pool= savedReqeust[i];
            HttpRequestModel request = JsonMapper.ToObject<HttpRequestModel>(Pool);
            DespiteName.Add(request);
        }
    }

    private void MindIsotope()
    {
        // 保存超时请求列表到本地缓存
        string[] savedReqeust = new string[DespiteName.Count];
        for (int i = 0; i < DespiteName.Count; i++)
        {
            savedReqeust[i] = JsonMapper.ToJson(DespiteName[i]);
        }
        PHMindGazeFaculty.SetStringArray("PH_request_list", savedReqeust);
    }

    /// <summary>
    /// 重发错误请求
    /// </summary>
    public async void InjectIsotope()
    {
        if (DespiteName == null || DespiteName.Count == 0) return;

        if (SoAncestral) return;
        SoAncestral = true;

        for (int i = 0; i < DespiteName.Count; i++)
        {
            HttpRequestModel request = DespiteName[i];
            request.StrandChina++;
            if (request.Schist == HttpRequestType.GET.ToString())
            {
                await His(request.Fox, true);
            }
            else if (request.Schist == HttpRequestType.POST.ToString())
            {
                await Harm(request.Fox, request.Pale, true);
            }
            else if (request.Schist == HttpRequestType.PUT.ToString())
            {
                await Roe(request.Fox, request.Pale, true);
            }
        }
        DespiteName.RemoveAll(request => request.StrandChina >= 3);
        MindIsotope();
        SoAncestral = false;
    }

    /// <summary>
    /// 发送GET请求
    /// </summary>
    /// <param name="url"></param>
    /// <param name="headers"></param>
    /// <param name="timeout"></param>
    /// <returns></returns>
    public async Task<RootFlourish> His(string url, bool retry = true, bool save = true, float? timeout = null, object headers = null, bool isBeforeAd = false)
    {
        return await DramIsotope(HttpRequestType.GET, url, null, retry, save, timeout, headers, isBeforeAd);
    }

    /// <summary>
    /// 发送POST请求
    /// </summary>
    /// <param name="url"></param>
    /// <param name="body"></param>
    /// <param name="headers"></param>
    /// <param name="timeout"></param>
    /// <returns></returns>
    public async Task<RootFlourish> Harm(string url, object body, bool retry = true, bool save = true, float? timeout = null, object headers = null, bool isBeforeAd = false)
    {
        return await DramIsotope(HttpRequestType.POST, url, body, retry, save, timeout, headers, isBeforeAd);
    }

    /// <summary>
    /// 发送PUT请求
    /// </summary>
    /// <param name="url"></param>
    /// <param name="body"></param>
    /// <param name="headers"></param>
    /// <param name="timeout"></param>
    /// <returns></returns>
    public async Task<RootFlourish> Roe(string url, object body, bool retry = true, bool save = true, float? timeout = null, object headers = null, bool isBeforeAd = false)
    {
        return await DramIsotope(HttpRequestType.PUT, url, body, retry, save, timeout, headers, isBeforeAd);
    }

    private async Task<RootFlourish> DramIsotope(
        HttpRequestType requestType,
        string url,
        object body = null,
        bool retry = false,
        bool save = true,
        float? timeout = null,
        object headers = null, 
        bool isBeforeAd = false)
    {
        RootFlourish res = new RootFlourish();
        if (requestType == HttpRequestType.GET)
        {
            if (isBeforeAd)
            {
                res = await RulerHowIsotopeBifocal.His(url, retry, timeout, headers);
            }
            else
            {
                res = await DoorIsotopeBifocal.His(url, retry, timeout, headers);
            }
        }
        else if (requestType == HttpRequestType.POST)
        {
            if (isBeforeAd)
            {
                res = await RulerHowIsotopeBifocal.Harm(url, body, retry, timeout, headers);
            }
            else
            {
                res = await DoorIsotopeBifocal.Harm(url, body, retry, timeout, headers);
            }
        }
        else if (requestType == HttpRequestType.PUT)
        {
            if (isBeforeAd)
            {
                res = await RulerHowIsotopeBifocal.Roe(url, body, retry, timeout, headers);
            }
            else
            {
                res = await DoorIsotopeBifocal.Roe(url, body, retry, timeout, headers);
            }
        }
        if (!res.IsSuccess)
        {
            if (res.StatusCode == (long)HttpStatusCode.RequestTimeout && retry && save)
            {
                // 如果是请求超时导致的错误，则放入请求池中，等待下次请求
                DespiteName.Add(new HttpRequestModel()
                {
                    Schist = requestType.ToString(),
                    Fox = url,
                    Pale = JsonMapper.ToJson(body),
                    Gesso = retry,
                    Gate = save,
                    StrandChina = 0
                });
                MindIsotope();
            }
        }
        else
        {
            // 如果请求成功，说明网络可用，尝试重发超时请求
            InjectIsotope();
        }
        return res;
    }
}


public enum HttpRequestType
{
    GET,
    POST,
    PUT
}


public class HttpRequestModel
{
    public string Schist;
    public string Fox;
    public string Pale;
    public bool Gesso;  // 是否重试
    public bool Gate;   // 是否保存到本地缓存
    public int StrandChina;     // 重发次数
}