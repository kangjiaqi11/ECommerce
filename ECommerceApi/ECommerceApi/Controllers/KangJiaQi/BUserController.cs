﻿using System;
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
        public BUserLoginResponse UserLogin(BUserLoginRequst bUserLoginRequst)
        {
            return BUserBll.UserLogin(bUserLoginRequst);
        }
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="bUserAddRequst"></param>
        /// <returns></returns>
        public BUserAddResponse UserAdd(BUserAddRequst bUserAddRequst)
        {
            return BUserBll.UserAdd(bUserAddRequst);
        }
        /// <summary>
        /// 部门表显示
        /// </summary>
        /// <returns></returns>
        public DepartmentResponse DepartmentShow(DepartmentRequst departmentRequst)
        {
            return BUserBll.DepartmentShow(departmentRequst);
        }
    }
}