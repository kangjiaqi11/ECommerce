using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDCKClient;
namespace BLL
{
    /// <summary>
    /// 用户相关的mvcbll
    /// </summary>
   public class BUserBll
    {
        public BUserLoginResponse<int> UserLogin(BUserLoginRequst bUserLoginRequst)
        {
            return ApiRequestHelper.Post<BUserLoginRequst, BUserLoginResponse<int>>(bUserLoginRequst);
        }
    }
}
