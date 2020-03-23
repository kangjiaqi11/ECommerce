using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SDCKClient;
using BLL;
namespace ECommerceMVC.Controllers.KangJiaQi
{
    public class BUserController : Controller
    {
        BUserBll BUserBll = new BUserBll();
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
        /// 登录页面包含用户注册，邮箱
        /// </summary>
        /// <returns></returns>
        public ActionResult UserLogin()
        {
            return View();
        }
        /// <summary>
        /// 登录方法
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult UserLogin(string UserName, String UserPwd)
        {
            BUserLoginRequst bUserLoginRequst = new BUserLoginRequst();
            bUserLoginRequst.Register = UserPwd;
            bUserLoginRequst.UserPwd = UserPwd;
            return Json(12);

        }
        /// <summary>
        /// 添加方法
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult UserRegista(string UserName, string UserAccount ,string UsrPwd,string UserConPwd ,int Department,string UserPhoto,string UserEmil)
        {
            if (UsrPwd==UserConPwd)
            {
            BUserAddRequst bUserAddRequst = new BUserAddRequst();
            bUserAddRequst.UserName = UserName;
            bUserAddRequst.UserAccount = UserAccount;
            bUserAddRequst.UserPwd = UsrPwd;
            bUserAddRequst.DepartmentId = Department;
            bUserAddRequst.UserPhoto = UserPhoto;
            bUserAddRequst.UserEmil = UserEmil;
                var ser = BUserBll.BUseradd(bUserAddRequst);
                if (ser.Status>0)
                {
                    if (ser.IsSuccess)
                    {
                        Response.Write("<script>alert('注册成功');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('注册失败');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('{0}');</script>"+ser.Msg);
                }
            }
            else
            {
                Response.Write("<script>alert('验证失败');</script>");
            }
            return Json(12);
   
        }
        /// <summary>
        /// 注册页面
        /// </summary>
        /// <returns></returns>
        //public ActionResult UserRegist()
        //{
        //    return View();
        //}
    }
}