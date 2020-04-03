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
        MemberBLL blll = new MemberBLL();
        public FrontUserShowResp FrontUserFenye(FrontUserShowReq Ssrq)
        {
            return bll.FrontUserFenye(Ssrq);
        }
        //详情1 v     
        public FrontUserShow1Resp FrontUserShow1()
        {
            return bll.FrontUserShow1();
        }
        //详情2
        public FrontUserShow2Resp FrontUserShow2()
        {
            return bll.FrontUserShow2();
        }
        //会员
        public MemberShowResp MemberShow()
        {
            return blll.MemberShow();
        }
    }
}
