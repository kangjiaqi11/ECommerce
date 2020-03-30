using BLL.ZhangYang;
using SDCKClient.ZhangYang.Request;
using SDCKClient.ZhangYang.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ECommerceApi.Controllers.ZhangYang
{
    public class FroController : ApiController
    {
        FrontUserBLL bll = new FrontUserBLL();
        public FrontUserShowResp StoreroomFenye(FrontUserShowReq Ssrq)
        {
            return bll.StoreroomFenye(Ssrq);
        }
    }
}
