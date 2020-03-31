using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using SDCKClient;
using MODEL;

namespace ECommerceMVC
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

        public ActionResult ActivityAdd()
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
        ///好物推荐 状态
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult RecommendIs(int RecommendId)
        {
            RecommendIsRequest recommendIsRequest = new RecommendIsRequest();
            recommendIsRequest.RecommendId = RecommendId;
            var ser = promotionBll.RecommendIs(recommendIsRequest, "api/Promotion/RecommendIs");
            return Json(ser.IsSuccess);
        }
        /// <summary>
        ///好物推荐下架
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult RecommendNO(int RecommendId)
        {
            RecommendNoRequest recommendNoRequest = new RecommendNoRequest();
            recommendNoRequest.RecommendId = RecommendId;
            var ser = promotionBll.RecommendNO(recommendNoRequest, "api/Promotion/RecommendNO");
            return Json(ser.IsSuccess);
        }
        /// <summary>
        /// 好物推荐删除
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult RecommendDelete(int RecommendId)
        {
            RecommendDeleteRequest recommendDeleteRequest = new RecommendDeleteRequest();
            recommendDeleteRequest.RecommendId = RecommendId;
            var ser = promotionBll.RecommendDelete(recommendDeleteRequest, "api/Promotion/RecommendDelete");
            return Json(ser.IsSuccess);
        }
        #region 时间段相关信息
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
        /// <summary>
        /// 删除时间段
        /// </summary>
        /// <param name="timeQDeleteRequest"></param>
        /// <param name="GetApiName"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult TimeQDelete(int Tid)
        {
            TimeQDeleteRequest timeQDeleteRequest = new TimeQDeleteRequest();
            timeQDeleteRequest.TimeQId = Tid;
            var ser = promotionBll.TimeQDelete(timeQDeleteRequest, "api/Promotion/TimeQdelete");
            return Json(ser.IsSuccess);
        }
        /// <summary>
        ///已启用 
        /// </summary>
        /// <param name="timeQUpdate2Request"></param>
        /// <param name="GetApiName"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult TimeQUpdate2(int Tid)
        {
            TimeQUpdate2Request timeQUpdate2Request = new TimeQUpdate2Request();
            timeQUpdate2Request.TimeQId = Tid;
            var ser = promotionBll.TimeQUpdate2(timeQUpdate2Request, "api/Promotion/TimeQUpdate2");
            return Json(ser.IsSuccess);
        }
        /// <summary>
        /// 未启用
        /// </summary>
        /// <param name="timeQUpdate2Request"></param>
        /// <param name="GetApiName"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult TimeQUpdate3(int Tid)
                     {
            TimeQUpdate3Request timeQUpdate3Request = new TimeQUpdate3Request();
            timeQUpdate3Request.TimeQId = Tid;
            var ser = promotionBll.TimeQUpdate3(timeQUpdate3Request, "api/Promotion/TimeQUpdate3");
            return Json(ser.IsSuccess);
        } 
        #endregion
    }
}