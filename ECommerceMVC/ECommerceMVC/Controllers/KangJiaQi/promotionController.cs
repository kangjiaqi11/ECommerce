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
        #region 秒杀相关
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
        /// 添加活动页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ActivityAdd()
        {
            return View();
        }
        
        /// <summary>
        /// 为活动添加时间段页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ActivityTimeAdd(int ActivityId)
        {
           ViewBag.ActivityId = ActivityId;
            return View();
        }
        /// <summary>
        /// 为活动添加商品页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ActivityGoodAdd(int TimeQId,int ActivityId)
        {
            ViewBag.TimeQId= TimeQId;
            ViewBag.ActivityId1 = ActivityId;
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
        public JsonResult PageActivityShow(int PageIndex, int PageSize, string ActivityTitle)
        {
            ActivityShowRequst activityShowRequst = new ActivityShowRequst();
            activityShowRequst.PageIndex = PageIndex;
            activityShowRequst.PageSize = PageSize;
            activityShowRequst.ActivityTitle = ActivityTitle;
            var list = promotionBll.ActivityShow(activityShowRequst, "api/Promotion/ActivityShow");
            return Json(list);
        }
        /// <summary>
        ///秒杀活动 状态
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult ActivityPutaway(int ActivityId)
        {
            ActivityPutawayRequest activityPutawayRequest = new ActivityPutawayRequest();
            activityPutawayRequest.ActivityId = ActivityId;
            var ser = promotionBll.ActivityPutaway(activityPutawayRequest, "api/Promotion/ActivityPutaway");
            return Json(ser.IsSuccess);
        }
        /// <summary>
        ///秒杀活动下架
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult ActivitySoldOut(int ActivityId)
        {
            ActivitySoldOutRequest activitySoldOutRequest = new ActivitySoldOutRequest();
            activitySoldOutRequest.ActivityId = ActivityId;
            var ser = promotionBll.ActivitySoldOut(activitySoldOutRequest, "api/Promotion/ActivitySoldOut");
            return Json(ser.IsSuccess);
        }
        /// <summary>
        /// 秒杀活动删除
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult ActivityDelete(int ActivityId)
        {
            ActivityDeleteRequest activityDeleteRequest = new ActivityDeleteRequest();
            activityDeleteRequest.ActivityId = ActivityId;
            var ser = promotionBll.ActivityDelete(activityDeleteRequest, "api/Promotion/ActivityDelete");
            return Json(ser.IsSuccess);
        }
        /// <summary>
        /// 添加活动
        /// </summary>
        /// <param name="ActiviryName"></param>
        /// <param name="AEenTime"></param>
        /// <param name="AStartTime"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult ActiviryAdd(string ActiviryName,string AEenTime,string userid,string StarTime)
        {
            ActivityAddRequest activityAddRequest = new ActivityAddRequest();
            activityAddRequest.ActivityTitle = ActiviryName;
            activityAddRequest.AEenTime =Convert.ToDateTime(  AEenTime) ;
            activityAddRequest.AStartTime =Convert.ToDateTime( StarTime);
            activityAddRequest.UpdateId =Convert.ToInt32( userid);
            activityAddRequest.CreateId = Convert.ToInt32(userid);
            var ser = promotionBll.ActivityAdd(activityAddRequest, "api/Promotion/ActivityAdd");
            return Json(ser);
        }
        /// <summary>
        /// 活动添加商品显示
        /// </summary>
        /// <returns></returns>
        public JsonResult ActiviryGoodShow()
        {
            ActivityGoodShowRequest activityGoodShowRequest = new ActivityGoodShowRequest();  
            var ser = promotionBll.ActivityGoodShow(activityGoodShowRequest, "api/Promotion/ActivityGoodShow");
            return Json(ser.DateList);
        }
        /// <summary>
        /// 为活动添加商品
        /// </summary>
        /// <param name="TimeId"></param>
        /// <param name="GoodId"></param>
        /// <param name="Activiryid"></param>
        /// <returns></returns>
        public JsonResult ActiviryGoodAdd(int GoodId,int TimeQId,int ActivityId)
        {
            ActivityGoodAddRequest activityGoodAddRequest = new ActivityGoodAddRequest();
            activityGoodAddRequest.TimeQId = TimeQId;
            activityGoodAddRequest.GoodId = GoodId;
            activityGoodAddRequest.ActivityId = ActivityId;
            var ser = promotionBll.ActivityGoodAdd(activityGoodAddRequest, "api/Promotion/ActivityGoodAdd");
            return Json(ser.IsSuccess);
        }
        #endregion
        #region 首页图推荐相关
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
        public JsonResult PageRecommendShow(int PageIndex, int PageSize, string GoodName, int IsRecommend)
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
        /// 为活动添加商品
        /// </summary>
        /// <returns></returns>
        public ActionResult PageRecommendGoodAdd()
        {
            return View();
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
        #endregion
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