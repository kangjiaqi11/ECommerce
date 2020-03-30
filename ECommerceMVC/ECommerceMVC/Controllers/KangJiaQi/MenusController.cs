using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SDCKClient;
using BLL;
namespace ECommerceMVC.Controllers.KangJiaQi
{
    public class MenusController : Controller
    {
        MenusBll MenusBll = new MenusBll();
        // GET: Menus
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 菜单显示
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult MenusShow(int UserId)
        {
            MenusRequest menusRequest = new MenusRequest();
            menusRequest.Userid = UserId;
            var ser = MenusBll.MenusShow(menusRequest, "api/Menus/MenusShow");
            return Json(ser.DateList);
        }
        /// <summary>
        /// 菜单自己家显示
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult MenusSublevel(int FatherUrl)
        {
            MenusSublevelRequest menusSublevelRequest = new MenusSublevelRequest();
            menusSublevelRequest.FatherUrl = FatherUrl;
            var ser = MenusBll.MenusSublevel(menusSublevelRequest, "api/Menus/MenusSublevel");
            return Json(ser.DateList);
        }
    }
}