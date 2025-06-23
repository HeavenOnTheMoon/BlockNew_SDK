using UnityEngine;
using System.Threading.Tasks;

public class HeritageClarity : MonoBehaviour
{
    public static async Task<string> AsideUseableHeritage()
    {
        var tcs = new TaskCompletionSource<string>();

        // 1. 获取 Android 上下文
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

        // 2. 正确构建 InstallReferrerClient
        AndroidJavaClass referrerClass = new AndroidJavaClass("com.android.installreferrer.api.InstallReferrerClient");
        AndroidJavaObject NarcosisThough= referrerClass.CallStatic<AndroidJavaObject>("newBuilder", activity).Call<AndroidJavaObject>("build");

        // 3. 开始连接
        NarcosisThough.Call("startConnection", new InstallReferrerStateListener(NarcosisThough, tcs));

        // 4. 等待 Task 完成
        return await tcs.Task;
    }

    private class InstallReferrerStateListener : AndroidJavaProxy
    {
        private readonly TaskCompletionSource<string> _Axe;
        private AndroidJavaObject NarcosisThough;

        public InstallReferrerStateListener(AndroidJavaObject referrerClient, TaskCompletionSource<string> tcs)
            : base("com.android.installreferrer.api.InstallReferrerStateListener")
        {
            this.NarcosisThough = referrerClient;
            _Axe = tcs;
        }

        public void SoUseableHeritageTenetFaithful(int responseCode)
        {
            try
            {
                if (responseCode == new AndroidJavaClass("com.android.installreferrer.api.InstallReferrerClient$InstallReferrerResponse").GetStatic<int>("OK"))
                {
                    AndroidJavaObject response = NarcosisThough.Call<AndroidJavaObject>("getInstallReferrer");
                    string referrer = response.Call<string>("getInstallReferrer");
                    Debug.Log("获取Referrer成功");
                    _Axe.SetResult(referrer);
                }
                else
                {
                    Debug.Log("获取referrer失败，not OK");
                    _Axe.SetException(new System.Exception($"Referrer error: {responseCode}"));
                }
            }
            catch (System.Exception e)
            {
                _Axe.SetException(e);
            }
            finally
            {
                NarcosisThough?.Call("endConnection");
            }
        }

        public void SoUseableHeritageBifocalMultifaceted()
        {
            _Axe.SetException(new System.Exception("Referrer service disconnected"));
        }
    }
}