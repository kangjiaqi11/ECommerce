using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceMVC.Controllers.KangJiaQi
{
    public class BUserController : Controller
    {
        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        // GET: BUser
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 登录页面
        /// </summary>
        /// <returns></returns>
        public ActionResult UserLogin()
        {
            return View();
        }
    }
}