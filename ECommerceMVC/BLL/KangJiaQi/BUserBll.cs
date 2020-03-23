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
        /// <summary>
        /// 登录
        /// 
        /// </summary>
        /// <param name="bUserLoginRequst"></param>
        /// <returns></returns>
        //public BUserLoginResponse<int> BUserLogin(BUserLoginRequst bUserLoginRequst)
        //{

        //}
        /// <summary>
        ///用户添加
        /// </summary>
        /// <param name="bUserAddRequst"></param>
        /// <returns></returns>
        public BUserAddResponse BUseradd(BUserAddRequst bUserAddRequst)
        {
            return ApiRequestHelper.Post<BUserAddRequst,BUserAddResponse > (bUserAddRequst);
        }
        
    }
}
