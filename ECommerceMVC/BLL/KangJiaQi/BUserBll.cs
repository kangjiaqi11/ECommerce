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
        public BUserLoginResponse BUserLogin(BUserLoginRequst bUserLoginRequst,string GetApiName)
        {
            return ApiRequestHelper.Post<BUserLoginRequst, BUserLoginResponse>(bUserLoginRequst, GetApiName);
        }
        /// <summary>
        ///用户添加
        /// </summary>
        /// <param name="bUserAddRequst"></param>
        /// <returns></returns>
        public BUserAddResponse BUseradd(BUserAddRequst bUserAddRequst,string GetApiName)
        {
            return ApiRequestHelper.Post<BUserAddRequst,BUserAddResponse > (bUserAddRequst,GetApiName);
        }
        /// <summary>
        /// 部门显示
        /// </summary>
        /// <returns></returns>
        public DepartmentResponse DepartmentShow(DepartmentRequst departmentRequst,string GetApiName)
        {
            return ApiRequestHelper.Post<DepartmentRequst, DepartmentResponse>(departmentRequst,GetApiName);
        }
        /// <summary>
        /// 获取用户名 随机数
        /// </summary>
        /// <returns></returns>
        public GetUserNameResponse GetUserName(GetUserNameRequest getUserNameRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<GetUserNameRequest, GetUserNameResponse>(getUserNameRequest, GetApiName);
        }
        /// <summary>
        /// 锁屏解锁
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Userpwd"></param>
        /// <returns></returns>
        public LockedResponse Locked(LockedRequest lockedRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<LockedRequest, LockedResponse>(lockedRequest, GetApiName);
        }
        /// <summary>
        /// 个人信息
        /// </summary>
        /// <returns></returns>
        public personageResponse personage(personageRequest personageRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<personageRequest, personageResponse>(personageRequest, GetApiName);
        }
    }
}
