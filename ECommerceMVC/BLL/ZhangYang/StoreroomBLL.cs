using SDCKClient.ZhangYang.Request;
using SDCKClient.ZhangYang.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ZhangYang
{
    public class StoreroomBLL
    {
        public StoreroomShowResp StoreroomFenye(StoreroomShowReq ssr,string GetApiName)
        {
            return ApiRequestHelper.Post<StoreroomShowReq,StoreroomShowResp>(ssr, GetApiName);
        }
    }
}