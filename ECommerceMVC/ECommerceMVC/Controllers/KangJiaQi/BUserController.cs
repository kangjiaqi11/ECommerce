using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using SDCKClient;

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
        /// 显示部门
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DepartmentShow()
        {
            DepartmentRequst departmentRequst = new DepartmentRequst();
            var list = BUserBll.DepartmentShow(departmentRequst, "api/BUser/DepartmentShow");
            return Json(list.DateList);
        }
        /// <summary>
        ///测试 
        /// </summary>
        /// <returns></returns>
        public ActionResult aaa()
        {
            return View();
        }
        /// <summary>
        /// 登录方法
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public void UserLogin(string UserName, String UserPwd)
        {
            BUserLoginRequst bUserLoginRequst = new BUserLoginRequst();
            bUserLoginRequst.Register = UserName;
            bUserLoginRequst.UserPwd = UserPwd;
            var ser = BUserBll.BUserLogin(bUserLoginRequst, "api/BUser/UserLogin");
            if (ser.Status > 0)
            {
                if (ser.IsSuccess)
                {
                    Response.Write("<script>alert('登录成功');location.href='/BUser/Index'</script>");
                    Session["BUserId"] = ser.Info;
                }
                else
                {
                    Response.Write("<script>alert('登录失败');</script>");
                }
            }
            else
            {
                Response.Write($"<script>alert('{ser.Msg}');</script>");
            }
        }
        /// <summary>
        /// 添加方法
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public void UserRegista(string UserName, string UserAccount, string UsrPwd, string UserConPwd, int Department, string UserPhoto, string UserEmil)
        {
            if (UsrPwd == UserConPwd)
            {
                BUserAddRequst bUserAddRequst = new BUserAddRequst();
                bUserAddRequst.UserName = UserName;
                bUserAddRequst.UserAccount = UserAccount;
                bUserAddRequst.UserPwd = UsrPwd;
                bUserAddRequst.DepartmentId = Department;
                bUserAddRequst.UserPhoto = UserPhoto;
                bUserAddRequst.UserEmil = UserEmil;
                var ser = BUserBll.BUseradd(bUserAddRequst, "api/BUser/UserAdd");
                if (ser.Status > 0)
                {
                    if (ser.IsSuccess)
                    {
                        Response.Write("<script>alert('注册成功');location.href='/BUser/UserLogin'</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('注册失败');</script>");
                    }
                }
                else
                {
                    Response.Write($"<script>alert('{ser.Msg}');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('验证失败');</script>");
            }
        }
        /// <summary>
        /// 锁屏
        /// </summary>
        /// <returns></returns>
        public ActionResult Lock()
        {
            return View();
        }
        /// <summary>
        /// 获取用户名 随机数
        /// </summary>
        /// <returns></returns>
        public JsonResult GetUserName(int UserId)
        {
            GetUserNameRequest getUserNameRequest = new GetUserNameRequest();
            getUserNameRequest.UserId = UserId;
            var list = BUserBll.GetUserName(getUserNameRequest, "api/BUser/GetUserName");
            return Json(list.info);
        }
        /// <summary>
        /// 锁屏解锁
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Userpwd"></param>
        /// <returns></returns>
        public JsonResult Lockedshow(string UserName,string UserPwd,string salt)
        {
            LockedRequest lockedRequest = new LockedRequest();
            lockedRequest.UserName = UserName;
            lockedRequest.UserPwd = UserPwd;
            lockedRequest.Salt = salt;
            var ser = BUserBll.Locked(lockedRequest, "api/BUser/Locked");
            return Json(ser.IsSuccess);
        }
        /// <summary>
        /// 个人信息
        /// </summary>
        /// <returns></returns>
        public ActionResult personage()
        {

            return View();
        }
        /// <summary>
        /// 个人信息显示
        /// </summary>
        /// <returns></returns>
        public JsonResult PesonageShow(int UserId)
        {
            personageRequest personageRequest = new personageRequest();
            personageRequest.UserId = UserId;
            var ser = BUserBll.personage(personageRequest, "api/BUser/personage");
            return Json(ser.info);
        }

    }
}