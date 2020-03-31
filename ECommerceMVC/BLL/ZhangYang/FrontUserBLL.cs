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
        public FrontUserShow1Resp FrontUserShow1(FrontUserShow1Req ssr, string GetApiName)
        {
            return ApiRequestHelper.Post<FrontUserShow1Req, FrontUserShow1Resp>(ssr, GetApiName);
        }
        public FrontUserShow2Resp FrontUserShow2(FrontUserShow2Req ssr, string GetApiName)
        {
            return ApiRequestHelper.Post<FrontUserShow2Req, FrontUserShow2Resp>(ssr, GetApiName);
        }
    }
}
