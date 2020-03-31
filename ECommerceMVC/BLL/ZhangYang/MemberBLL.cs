using SDCKClient.ZhangYang.Request;
using SDCKClient.ZhangYang.Request;
using SDCKClient.ZhangYang.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ZhangYang
{
    public class MemberBLL
    {
        public MemberShowResp MemberShow(MemberShowReq ssr, string GetApiName)
        {
            return ApiRequestHelper.Post<MemberShowReq, MemberShowResp>(ssr, GetApiName);
        }
        
    }
}
