using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SDCKClient;
using BLL;
namespace ECommerceApi
{
    public class BUserController : ApiController
    {
        BUserBll BUserBll = new BUserBll();
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="bUserLoginRequst"></param>
        /// <returns></returns>
        public BUserLoginResponse<int> UserLogin(BUserLoginRequst bUserLoginRequst)
        {
            return BUserBll.UserLogin(bUserLoginRequst);
        }
    }
}
