using System.Threading.Tasks;
using UnityEngine;

public class RunoffChoppyPeat
{
    private static RunoffChoppyPeat instance;
    public static RunoffChoppyPeat Equality    {
        get
        {
            instance ??= new RunoffChoppyPeat();
            return instance;
        }
    }

    public RunoffChoppyStorm RunoffChoppy{ get; private set; }

    public async Task<bool> AsideRunoffChoppy()
    {
        int appBuildVersion = NativePeat.Equality.OilBladeBeg;
        string Fox= $"{PHCrest.BASE_URL}/api/game/appversionconfig/ph?appBuildVersion={appBuildVersion}";
        var response = await RootIsotopePeat.Equality.His(Fox, true, false);
        if (response.IsSuccess)
        {
            var responseData = response.GetData<HttpResponseData<HttpReponseServerConfigModel>>();
            HttpReponseServerConfigModel config = responseData.data;
            if(config == null || config.list == null || config.list.Count == 0)
            {
                Debug.LogError("未正常获取配置");
                return false;
            }
            RunoffChoppy = new RunoffChoppyStorm(config.list);
            return true;
        }
        else
        {
            return false;
        }
    }
}
