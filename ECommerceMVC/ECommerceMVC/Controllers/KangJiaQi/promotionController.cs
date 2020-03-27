using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webdiyer.WebControls.Mvc;
using BLL;
using SDCKClient;
using MODEL;

namespace ECommerceMVC.Controllers.KangJiaQi
{
    public class promotionController : Controller
    {
        promotionBll promotionBll = new promotionBll();
        // GET: promotion
        public ActionResult Show()
        {
           
            return View();
        }
        /// <summary>
        /// 秒删活动显示
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="ActivityTitle"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult PageActivityShow(int PageIndex,int PageSize,string ActivityTitle)
        {
         ActivityShowRequst activityShowRequst = new ActivityShowRequst();
            activityShowRequst.PageIndex = PageIndex;
            activityShowRequst.PageSize = PageSize;
            activityShowRequst.ActivityTitle = ActivityTitle;
          var list= promotionBll.ActivityShow(activityShowRequst, "api/Promotion/ActivityShow");
            return Json( list);
        }
    }
}