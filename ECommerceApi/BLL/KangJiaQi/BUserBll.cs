using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDCKClient;
using Dal;
using Common;
namespace BLL
{
   public class BUserBll
    {
        BUserDal BUserDal = new BUserDal();
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="bUserLoginRequst"></param>
        /// <returns></returns>
        public BUserLoginResponse<int> UserLogin(BUserLoginRequst bUserLoginRequst)
        {
            BUserLoginResponse<int> bUserLoginResponse = new BUserLoginResponse<int>();
            if (string.IsNullOrEmpty( bUserLoginRequst.Register)&& string.IsNullOrEmpty(bUserLoginRequst.Register) && string.IsNullOrEmpty(bUserLoginRequst.Register) && string.IsNullOrEmpty(bUserLoginRequst.UserPwd))
            {
                bUserLoginResponse.Status = -1;
                bUserLoginResponse.Msg = "数据又为空项";
                return bUserLoginResponse; 
             }
            //获取盐
            var state = BUserDal.GetState(bUserLoginRequst.Register);
            //给密码加密
            var Pwd= MD5Encrypt.MD5Encrypt32( bUserLoginRequst.UserPwd+state);
            var ser = BUserDal.UserLogin(bUserLoginRequst.Register, Pwd);
            if (ser>0)
            {
                bUserLoginResponse.Info = ser;
            }
            return bUserLoginResponse;
        }
    }
}
