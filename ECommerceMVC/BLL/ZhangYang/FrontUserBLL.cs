using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDCKClient.ZhangYang.Request;
using SDCKClient.ZhangYang.Response;

namespace BLL.ZhangYang
{
    public class FrontUserBLL
    {
        public FrontUserShowResp FrontUserFenye(FrontUserShowReq ssr, string GetApiName)
        {
            return ApiRequestHelper.Post<FrontUserShowReq, FrontUserShowResp>(ssr, GetApiName);
        }
    }
}
