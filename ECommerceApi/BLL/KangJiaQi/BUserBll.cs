using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDCKClient;
using Dal;
using Common;
using MODEL;

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
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="bUserAddRequst"></param>
        /// <returns></returns>
        public BUserAddResponse UserAdd(BUserAddRequst bUserAddRequst)
        {
            BUserAddResponse bUserAddResponse = new BUserAddResponse();
            //判断账户
            if (string.IsNullOrEmpty(bUserAddRequst.UserAccount))
            {
                bUserAddResponse.Status = -1;
                bUserAddResponse.Msg = "账户不能为空";
                return bUserAddResponse;
            }
            //判断用户名
            if (string.IsNullOrEmpty(bUserAddRequst.UserName))
            {
                bUserAddResponse.Status = -1;
                bUserAddResponse.Msg = "用户名不能为空";
                return bUserAddResponse;
            }
            //判断手机号
            if (string.IsNullOrEmpty(bUserAddRequst.UserPhoto))
            {
                bUserAddResponse.Status = -1;
                bUserAddResponse.Msg = "手机号不能为空";
                return bUserAddResponse;
            }
            //判断部门
            if (bUserAddRequst.DepartmentId==0)
            {
                bUserAddResponse.Status = -1;
                bUserAddResponse.Msg = "部门不能为空";
                return bUserAddResponse;
            }
            //判断密码
            if (string.IsNullOrEmpty(bUserAddRequst.UserPwd))
            {
                bUserAddResponse.Status = -1;
                bUserAddResponse.Msg = "密码不能为空";
                return bUserAddResponse;
            }
            //判断邮箱
             if (string.IsNullOrEmpty(bUserAddRequst.UserEmil))
            {
                bUserAddResponse.Status = -1;
                bUserAddResponse.Msg = "邮箱不能为空";
                return bUserAddResponse;
            }
             //密码加密
             //获取盐
            var salt = Generate.GenerateSalt();
            //密码加密
            var passwoed = MD5Encrypt.MD5Encrypt32(bUserAddRequst.UserPwd + salt);
            UserInfo userInfo = new UserInfo();
            userInfo.UserName = bUserAddRequst.UserName;
            userInfo.UserAccount = bUserAddRequst.UserAccount;
            userInfo.Salt = salt;
            userInfo.UserPhoto = bUserAddRequst.UserPhoto;
            userInfo.DepartmentId = bUserAddRequst.DepartmentId;
            userInfo.state = 1;
            userInfo.CeateTime = DateTime.Now;
            userInfo.UpdateTime = DateTime.Now;
            userInfo.CreateId = 0;
            userInfo.UpdateId = 0;
            userInfo.UserPwd = passwoed;
            userInfo.UserEmil = bUserAddRequst.UserEmil;
            userInfo.RoleId = 1;
            var ser = BUserDal.UserAdd(userInfo);
            if (ser>0)
            {
                bUserAddResponse.IsSuccess = true;
            }
            else
            {
                bUserAddResponse.Status = -1;
                bUserAddResponse.Msg = "注册失败";
            }
            return bUserAddResponse;
        }
    }
}
