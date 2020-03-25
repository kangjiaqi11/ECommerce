using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.ZhangYang;
using SDCKClient.ZhangYang.Request;
using SDCKClient.ZhangYang.Response;

namespace ECommerceApi.Controllers.ZhangYang
{
    public class StoController : ApiController
    {
        StoreroomBLL bll = new StoreroomBLL();
        public StoreroomShowResp StoreroomFenye(StoreroomShowReq Ssrq)
        {
            return bll.StoreroomFenye(Ssrq);
        }
    }
}
