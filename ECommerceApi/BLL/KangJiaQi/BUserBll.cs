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
        #region 用户登录
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="bUserLoginRequst"></param>
        /// <returns></returns>
        public BUserLoginResponse UserLogin(BUserLoginRequst bUserLoginRequst)
        {
            BUserLoginResponse bUserLoginResponse = new BUserLoginResponse();
            if (string.IsNullOrEmpty(bUserLoginRequst.Register) && string.IsNullOrEmpty(bUserLoginRequst.Register) && string.IsNullOrEmpty(bUserLoginRequst.Register) && string.IsNullOrEmpty(bUserLoginRequst.UserPwd))
            {
                bUserLoginResponse.Status = -1;
                bUserLoginResponse.Msg = "数据又为空项";
                return bUserLoginResponse;
            }
            //获取盐
            var state = BUserDal.GetState(bUserLoginRequst.Register);
            //给密码加密
            var Pwd = MD5Encrypt.MD5Encrypt32(bUserLoginRequst.UserPwd + state);
            var ser = BUserDal.UserLogin(bUserLoginRequst.Register, Pwd);
            if (ser > 0)
            {
                bUserLoginResponse.Info = ser;
                bUserLoginResponse.IsSuccess = true;
            }
            else
            {
                bUserLoginResponse.Status = -1;
                bUserLoginResponse.Msg = "登录失败";
            }
            return bUserLoginResponse;
        }
        #endregion
        #region 用户相关
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
            if (bUserAddRequst.DepartmentId == 0)
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
            userInfo.CreateTime = DateTime.Now;
            userInfo.UpdateTime = DateTime.Now;
            userInfo.CreateId = 0;
            userInfo.UpdateId = 0;
            userInfo.UserPwd = passwoed;
            userInfo.UserEmil = bUserAddRequst.UserEmil;
            userInfo.RoleId = 1;
            var ser = BUserDal.UserAdd(userInfo);
            if (ser > 0)
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
        /// <summary>
        /// 部门表显示
        /// </summary>
        /// <returns></returns>
        public DepartmentResponse DepartmentShow(DepartmentRequst departmentRequst)
        {
            DepartmentResponse departmentResponse = new DepartmentResponse();
            var ser = BUserDal.DepartmentShow();
            if (ser != null)
            {
                departmentResponse.DateList = ser;
                departmentResponse.IsSuccess = true;
            }
            else
            {
                departmentResponse.Status = -1;
                departmentResponse.Msg = "显示失败";
            }
            return departmentResponse;
        }
        /// <summary>
        /// 获取用户名
        /// </summary>
        /// <returns></returns>
        public GetUserNameResponse GetUserName(GetUserNameRequest getUserNameRequest)
        {
            GetUserNameResponse getUserNameResponse = new GetUserNameResponse();
            if (getUserNameRequest.UserId == 0)
            {
                getUserNameResponse.Status = -1;
                getUserNameResponse.Msg = "数据又为空项";
                return getUserNameResponse;
            }
            var ser = BUserDal.GetUserName(getUserNameRequest.UserId);
            if (ser != null)
            {
                getUserNameResponse.info = ser;
                getUserNameResponse.IsSuccess = true;
            }
            else
            {
                getUserNameResponse.Status = -1;
                getUserNameResponse.Msg = "获取失败";
            }
            return getUserNameResponse;
        }

        /// <summary>
        /// 锁屏解锁
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Userpwd"></param>
        /// <returns></returns>
        public LockedResponse Locked(LockedRequest lockedRequest)
        {
            LockedResponse lockedResponse = new LockedResponse();
            if (string.IsNullOrEmpty(lockedRequest.Salt) && string.IsNullOrEmpty(lockedRequest.UserPwd) && string.IsNullOrEmpty(lockedRequest.UserName))
            {
                lockedResponse.Status = -1;
                lockedResponse.Msg = "数据又为空项";
                return lockedResponse;
            }
            //给密码加密
            var Pwd = MD5Encrypt.MD5Encrypt32(lockedRequest.UserPwd + lockedRequest.Salt);
            var ser = BUserDal.Locked(lockedRequest.UserName, Pwd);
            if (ser > 0)
            {
                lockedResponse.IsSuccess = true;
            }
            else
            {
                lockedResponse.Status = -1;
                lockedResponse.Msg = "登录失败";
            }
            return lockedResponse;
        }
        /// <summary>
        /// 个人信息
        /// </summary>
        /// <returns></returns>
        public personageResponse personage(personageRequest personageRequest)
        {
            personageResponse personageResponse = new personageResponse();
            if (personageRequest.UserId == 0)
            {
                personageResponse.Status = -1;
                personageResponse.Msg = "显示失败";
            }
            var ser = BUserDal.personage(personageRequest.UserId);
            if (ser != null)
            {
                personageResponse.info = ser;
                personageResponse.IsSuccess = true;
            }
            else
            {
                personageResponse.Status = -1;
                personageResponse.Msg = "显示失败";
            }
            return personageResponse;
        } 
        #endregion

    }
}
