using Best.HTTP;
using Best.HTTP.JSON.LitJson;
using Best.HTTP.Request.Upload;
using Cysharp.Threading.Tasks;
using System;
using System.Net;
using UnityEngine;

public class LimeRootBifocal
{
    private double CurtainUnaided= 30f;

    public async UniTask<RootFlourish> His(string url, bool retry = true, float? timeout = null, object headers = null)
    {
        // 判断当前是否正在登录，如果正在登录，则等待登录完成
        await PHVolt.IconDusty(url);

        // Create request
        var request = HTTPRequest.CreateGet(url);
        TugIsotopeForever(request, timeout, headers);

        //Debug.Log($"Send [Get] Request: Url:{request.Uri}");

        int retryCount = 0; // 请求超时重试次数
        RootFlourish response = null;
        while (retryCount < 3)
        {
            response = await DramIsotope(request);
            if (response.IsSuccess || !DeftSheep(retry, response.StatusCode))
            {
                return response;
            }
            else
            {
                if (response.StatusCode == (long)HttpStatusCode.RequestTimeout)
                {
                    // 处理超时
                    retryCount++;
                    Debug.LogWarning("Request timeout, retrying... retryCount:" + retryCount);
                    await UniTask.Delay(1000);
                }
                else if (response.StatusCode == 599)
                {
                    // token过期，先重新登录
                    bool loginSuccess = await DustyPeat.Equality.Dusty();
                    if (loginSuccess)
                    {
                        return await His(url, retry, timeout, headers);
                    }
                }
                else
                {
                    return response;
                }
            }
        }
        return response;
    }

    public async UniTask<RootFlourish> Harm(string url, object data, bool retry = true, float? timeout = null, object headers = null)
    {
        // 判断当前是否正在登录，如果正在登录，则等待登录完成
        await PHVolt.IconDusty(url);

        // Create request
        var request = HTTPRequest.CreatePost(url);
        TugIsotopeForever(request, timeout, headers);

        if (data is string)
        {
            JsonData jsonData = JsonMapper.ToObject((string)data);
            request.UploadSettings.UploadStream = new JSonDataStream<JsonData>(jsonData);
            Debug.Log($"Send [Post] Request: Url:{request.Uri}, data: {(string)data}");
        }
        else
        {
            JsonData jsonData = JsonMapper.ToObject(JsonMapper.ToJson(data));
            request.UploadSettings.UploadStream = new JSonDataStream<JsonData>(jsonData);
            Debug.Log($"Send [Post] Request: Url:{request.Uri}, data: {JsonMapper.ToJson(data)}");
        }
        

        int retryCount = 0;
        RootFlourish response = null;
        while (retryCount < 3)
        {
            response = await DramIsotope(request);
            if (response.IsSuccess || !DeftSheep(retry, response.StatusCode))
            {
                return response;
            }
            else
            {
                if (response.StatusCode == (long)HttpStatusCode.RequestTimeout)
                {
                    // 处理超时
                    retryCount++;
                    Debug.LogWarning("Request timeout, retrying... retryCount:" + retryCount);
                    await UniTask.Delay(1000);
                }
                else if (response.StatusCode == 599)
                {
                    // token过期，先重新登录
                    bool loginSuccess = await DustyPeat.Equality.Dusty();
                    if (loginSuccess)
                    {
                        return await Harm(url, data, retry, timeout, headers);
                    }
                }
                else
                {
                    return response;
                }
            }
        }
        return response;
    }


    public async UniTask<RootFlourish> Roe(string url, object data, bool retry = true, float? timeout = null, object headers = null)
    {
        // 判断当前是否正在登录，如果正在登录，则等待登录完成
        await PHVolt.IconDusty(url);

        // Create request
        var request = HTTPRequest.CreatePut(url);
        TugIsotopeForever(request, timeout, headers);

        if (data is string)
        {
            JsonData jsonData = JsonMapper.ToObject((string)data);
            request.UploadSettings.UploadStream = new JSonDataStream<JsonData>(jsonData);
            Debug.Log($"Send [Put] Request: Url:{request.Uri}, data: {(string)data}");
        }
        else
        {
            JsonData jsonData = JsonMapper.ToObject(JsonMapper.ToJson(data));
            request.UploadSettings.UploadStream = new JSonDataStream<JsonData>(jsonData);
            Debug.Log($"Send [Put] Request: Url:{request.Uri}, data: {JsonMapper.ToJson(data)}");
        }

        int retryCount = 0;
        RootFlourish response = null;
        while (retryCount < 3)
        {
            response = await DramIsotope(request);
            if (response.IsSuccess || !DeftSheep(retry, response.StatusCode))
            {
                return response;
            }
            else
            {
                if (response.StatusCode == (long)HttpStatusCode.RequestTimeout)
                {
                    // 处理超时
                    retryCount++;
                    Debug.LogWarning("Request timeout, retrying... retryCount:" + retryCount);
                    await UniTask.Delay(1000);
                }
                else if (response.StatusCode == 599)
                {
                    // token过期，先重新登录
                    bool loginSuccess = await DustyPeat.Equality.Dusty();
                    if (loginSuccess)
                    {
                        return await Roe(url, data, retry, timeout, headers);
                    }
                }
                else
                {
                    return response;
                }
            }
        }
        return response;
    }

    private bool DeftSheep(bool retry, long statusCode)
    {
        return retry || statusCode == 599;
    }

    private void TugIsotopeForever(HTTPRequest request, float? timeout = null, object headers = null)
    {
        request.TimeoutSettings.Timeout = TimeSpan.FromSeconds(timeout == null ? CurtainUnaided : (double)timeout);
        request.RetrySettings.MaxRetries = 0;
        // add headers
        // 添加token
        DeftStorm PuffComa= DustyPeat.Equality.DeftComa;
        if (PuffComa != null && !string.IsNullOrEmpty(PuffComa.token))
        {
            request.SetHeader("Authorization", PuffComa.token);
        }
        if (headers != null)
        {
            JsonData jsonData = JsonMapper.ToObject(JsonMapper.ToJson(headers));
            foreach (string key in jsonData.Keys)
            {
                request.SetHeader(key, jsonData[key].ToString());
            }
        }
    }

    private async UniTask<RootFlourish> DramIsotope(HTTPRequest request)
    {
        try
        {
            // Send & wait for completion
            var response = await request.GetHTTPResponseAsync();
            // Process response
            if (response.IsSuccess)
            {
                // 收到返回结果
                HttpResponseData<object> responseData = JsonMapper.ToObject<HttpResponseData<object>>(response.DataAsText);
                if (responseData == null)
                {
                    return new RootFlourish
                    {
                        IsSuccess = false,
                        StatusCode = (long)HttpStatusCode.RequestTimeout,
                        Data = response.DataAsText,
                        ErrorMessage = "Failed to parse response data"
                    };
                }

                if (responseData.code == 0 || responseData.code == 200)
                {
                    Debug.Log($"Request success! RequestUrl:{request.Uri}, Response: {response.DataAsText}");
                    return new RootFlourish
                    {
                        IsSuccess = true,
                        StatusCode = responseData.code,
                        Data = response.DataAsText,
                        ErrorMessage = null
                    };
                }
                else
                {
                    Debug.LogError($"Request failed! {request.MethodType} RequestUrl:{request.Uri}, Response: {response.DataAsText}");
                    return new RootFlourish
                    {
                        IsSuccess = false,
                        StatusCode = responseData.code,
                        Data = response.DataAsText,
                        ErrorMessage = responseData.message
                    };
                }
            }
            else
            {
                // 请求错误
                Debug.LogError($"Request failed! Error: {response.StatusCode} - {response.Message}");
                return new RootFlourish
                {
                    IsSuccess = false,
                    StatusCode = response.StatusCode,
                    Data = null,
                    ErrorMessage = response.Message
                };
            }
        }
        catch (AsyncHTTPException e)
        {
            // 4. Error handling
            Debug.LogError($"Request finished with error! Error: {e.Message}");
            return new RootFlourish
            {
                IsSuccess = false,
                StatusCode = 0,
                Data = null,
                ErrorMessage = e.Message
            };
        }
    }
}
