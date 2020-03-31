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
        [HttpPost]
        public BUserLoginResponse UserLogin(BUserLoginRequst bUserLoginRequst)
        {
            return BUserBll.UserLogin(bUserLoginRequst);
        }
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="bUserAddRequst"></param>
        /// <returns></returns>
        [HttpPost]
        public BUserAddResponse UserAdd(BUserAddRequst bUserAddRequst)
        {
            return BUserBll.UserAdd(bUserAddRequst);
        }
        /// <summary>
        /// 部门表显示
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public DepartmentResponse DepartmentShow(DepartmentRequst departmentRequst)
        {
            return BUserBll.DepartmentShow(departmentRequst);
        }
        /// <summary>
        /// 获取用户名 随机数
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public GetUserNameResponse GetUserName(GetUserNameRequest getUserNameRequest)
        {
            return BUserBll.GetUserName(getUserNameRequest);
        }
        /// <summary>
        /// 锁屏解锁
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Userpwd"></param>
        /// <returns></returns>
        [HttpPost]
        public LockedResponse Locked(LockedRequest lockedRequest)
        {
            return BUserBll.Locked(lockedRequest);
        }
        /// <summary>
        /// 个人信息
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public personageResponse personage(personageRequest personageRequest)
        {
            return BUserBll.personage(personageRequest);
        }
    }
}
