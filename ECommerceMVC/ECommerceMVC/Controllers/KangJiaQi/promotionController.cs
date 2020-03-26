using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using SDCKClient;
using MODEL;

namespace ECommerceMVC.Controllers.KangJiaQi
{
    public class promotionController : Controller
    {
        promotionBll promotionBll = new promotionBll();
        // GET: promotion
        /// <summary>
        /// 秒删活动页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ActivityShow()
        {
           
            return View();
        }
        /// <summary>
        /// 秒删活动显示方法
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
       /// <summary>
       /// 首页推荐页面
       /// </summary>
       /// <returns></returns>
        public ActionResult RecommendShow()
        {
            return View();
        }
        /// <summary>
        /// 首页推荐显示方法
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="GoodName"></param>
        /// <param name="IsRecommend"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult PageRecommendShow(int PageIndex, int PageSize, string GoodName,int IsRecommend)
        {
            RecommendRequst recommendRequst = new RecommendRequst();
            recommendRequst.GoodsName = GoodName;
            recommendRequst.IsRecommend = IsRecommend;
            recommendRequst.PageIndex = PageIndex;
            recommendRequst.PageSize = PageSize;
            var list = promotionBll.PageRecommendShow(recommendRequst, "api/Promotion/RecommendShow");
            return Json(list);
        }
        /// <summary>
        /// 时间段的显示
        /// </summary>
        /// <returns></returns>
        public ActionResult TimeShow()
        {
            return View();
        }
        /// <summary>
        /// 时间段显示的方法
        /// </summary>
        /// <returns></returns>
        public JsonResult TimeQShow()
        {
            TimeQShowRequest timeQShowRequest = new TimeQShowRequest();
            var list = promotionBll.TimeQShow(timeQShowRequest, "api/Promotion/TimeQShow");
            return Json(list);
        }
    }
}