using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDCKClient;
using MODEL;
using Dal;
namespace BLL
{
   public class promotionBll
    {
        #region 秒删活动相关
        promotionDal promotionDal = new promotionDal();
        /// <summary>
        /// 秒杀活动显示
        /// </summary>
        /// <param name="activityShowRequst"></param>
        /// <returns></returns>
        public ActivityShowRespnse ActivityShow(ActivityShowRequst activityShowRequst)
        {
            ActivityShowRespnse activityShowRespnse = new ActivityShowRespnse();
            var ser = promotionDal.ActivityShow(activityShowRequst.ActivityTitle, activityShowRequst.PageIndex, activityShowRequst.PageSize);
            if (ser != null)
            {
                activityShowRespnse.DateList = ser.DateList;
                activityShowRespnse.TotaCount = ser.TotaCount;
                activityShowRespnse.IsSuccess = true;

            }
            else
            {
                activityShowRespnse.Status = -1;
                activityShowRespnse.Msg = "显示失败";
            }
            return activityShowRespnse;
        }

        /// <summary>
        /// 添加秒杀
        /// </summary>
        /// <returns></returns>
        public ActivityAddResponse  ActivityAdd(ActivityAddRequest activityAddRequest)
        {
            ActivityAddResponse activityAddResponse = new ActivityAddResponse();
            if (string.IsNullOrEmpty( activityAddRequest.ActivityTitle))
            {
                activityAddResponse.Status = -1;
                activityAddResponse.Msg = "标题不能为空";
                return activityAddResponse;
            }
            if (activityAddRequest.AStartTime==null)
            {
                activityAddResponse.Status = -1;
                activityAddResponse.Msg = "开始时间不能为空";
                return activityAddResponse;
            }
            if (activityAddRequest.AEenTime==null)
            {
                activityAddResponse.Status = -1;
                activityAddResponse.Msg = "结束时间不能为空";
                return activityAddResponse;
            }
            Activity activity = new Activity();
            activity.ActivityTitle = activityAddRequest.ActivityTitle;
            activity.ActivityStatel = activityAddRequest.ActivityStatel;
            activity.Statel = 1;
            activity.AStartTime = activityAddRequest.AStartTime;
            activity.AEenTime = activityAddRequest.AEenTime;
            activity.CreateTime = DateTime.Now;
            activity.UpdateTime = DateTime.Now;
            activity.CreateId = activityAddRequest.CreateId;
            activity.UpdateId = activityAddRequest.UpdateId;
            var ser = promotionDal.ActivityAdd(activity);
            if (ser>0)
            {
                activityAddResponse.IsSuccess = true;
            } 
            else
            {
                activityAddResponse.Status = -1;
                activityAddResponse.Msg = "添加失败";
                return activityAddResponse;
            }
           return activityAddResponse;
        }
        /// <summary>
        ///活动秒杀 上架
        /// </summary>
        /// <returns></returns>
        public ActivityPutawayResponse ActivityPutaway(ActivityPutawayRequest activityPutawayRequest)
        {
            ActivityPutawayResponse activityPutawayResponse = new ActivityPutawayResponse();
            if (activityPutawayRequest.ActivityId == 0)
            {
                activityPutawayResponse.Status = -1;
                activityPutawayResponse.Msg = "id为空";
                return activityPutawayResponse;
            }
            var ser = promotionDal.ActivityPutaway(activityPutawayRequest.ActivityId);
            if (ser > 0)
            {
                activityPutawayResponse.IsSuccess = true;

            }
            else
            {
                activityPutawayResponse.Status = -1;
                activityPutawayResponse.Msg = "修改失败";
            }
            return activityPutawayResponse;
        }
        /// <summary>
        ///活动秒杀下架
        /// </summary>
        /// <returns></returns>
        public ActivitySoldOutResponse  ActivitySoldOut(ActivitySoldOutRequest activitySoldOutRequest)
        {
            ActivitySoldOutResponse activitySoldOutResponse = new ActivitySoldOutResponse();
            if (activitySoldOutRequest.ActivityId == 0)
            {
                activitySoldOutResponse.Status = -1;
                activitySoldOutResponse.Msg = "id为空";
                return activitySoldOutResponse;
            }
            var ser = promotionDal.ActivitySoldOut(activitySoldOutRequest.ActivityId);
            if (ser > 0)
            {
                activitySoldOutResponse.IsSuccess = true;

            }
            else
            {
                activitySoldOutResponse.Status = -1;
                activitySoldOutResponse.Msg = "修改失败";
            }
            return activitySoldOutResponse;
        }
        /// <summary>
        /// 活动秒杀删除
        /// </summary>
        /// <returns></returns>
        public ActivityDeleteResponse ActivityDelete(ActivityDeleteRequest activityDeleteRequest)
        {
            ActivityDeleteResponse activityDeleteResponse = new ActivityDeleteResponse();
            if (activityDeleteRequest.ActivityId == 0)
            {
                activityDeleteResponse.Status = -1;
                activityDeleteResponse.Msg = "id为空";
                return activityDeleteResponse;
            }
            var ser = promotionDal.ActivityDelete(activityDeleteRequest.ActivityId);
            if (ser > 0)
            {
                activityDeleteResponse.IsSuccess = true;

            }
            else
            {
                activityDeleteResponse.Status = -1;
                activityDeleteResponse.Msg = "修改失败";
            }
            return activityDeleteResponse;
        }
        #endregion
        #region 好物推荐相关
        /// <summary>
        /// 推荐首页的物品
        /// </summary>
        /// <param name="recommendRequst"></param>
        /// <returns></returns>
        public RecommendResponse RecommendShow(RecommendRequst recommendRequst)
        {
            RecommendResponse recommendResponse = new RecommendResponse();
            var ser = promotionDal.RecommendShow(recommendRequst.GoodsName, recommendRequst.IsRecommend, recommendRequst.PageIndex, recommendRequst.PageSize);
            if (ser != null)
            {
                recommendResponse.DateList = ser.DateList;
                recommendResponse.TotaCount = ser.TotaCount;
                recommendResponse.IsSuccess = true;

            }
            else
            {
                recommendResponse.Status = -1;
                recommendResponse.Msg = "显示失败";
            }
            return recommendResponse;
        }
        /// <summary>
        ///好物推荐 状态
        /// </summary>
        /// <returns></returns>
        public RecommendIsResponse RecommendIs(RecommendIsRequest recommendIsRequest)
        {
            RecommendIsResponse recommendIsResponse = new RecommendIsResponse();
            if (recommendIsRequest.RecommendId == 0)
            {
                recommendIsResponse.Status = -1;
                recommendIsResponse.Msg = "id为空";
                return recommendIsResponse;
            }
            var ser = promotionDal.RecommendIs(recommendIsRequest.RecommendId);
            if (ser > 0)
            {
                recommendIsResponse.IsSuccess = true;

            }
            else
            {
                recommendIsResponse.Status = -1;
                recommendIsResponse.Msg = "修改失败";
            }
            return recommendIsResponse;
        }
        /// <summary>
        ///好物推荐下架
        /// </summary>
        /// <returns></returns>
        public RecommenNodRequest RecommendNO(RecommendNoRequest recommendNoRequest)
        {
            RecommenNodRequest recommenNodRequest = new RecommenNodRequest();
            if (recommendNoRequest.RecommendId == 0)
            {
                recommenNodRequest.Status = -1;
                recommenNodRequest.Msg = "id为空";
                return recommenNodRequest;
            }
            var ser = promotionDal.RecommendNO(recommendNoRequest.RecommendId);
            if (ser > 0)
            {
                recommenNodRequest.IsSuccess = true;

            }
            else
            {
                recommenNodRequest.Status = -1;
                recommenNodRequest.Msg = "修改失败";
            }
            return recommenNodRequest;
        }
        /// <summary>
        /// 好物推荐删除
        /// </summary>
        /// <returns></returns>
        public RecommendDeleteResponse RecommendDelete(RecommendDeleteRequest recommendDeleteRequest)
        {
            RecommendDeleteResponse recommendDeleteResponse = new RecommendDeleteResponse();
            if (recommendDeleteRequest.RecommendId == 0)
            {
                recommendDeleteResponse.Status = -1;
                recommendDeleteResponse.Msg = "id为空";
                return recommendDeleteResponse;
            }
            var ser = promotionDal.RecommendDelete(recommendDeleteRequest.RecommendId);
            if (ser > 0)
            {
                recommendDeleteResponse.IsSuccess = true;

            }
            else
            {
                recommendDeleteResponse.Status = -1;
                recommendDeleteResponse.Msg = "修改失败";
            }
            return recommendDeleteResponse;
        } 
        #endregion
        #region 时间段相关
        /// <summary>
        /// 时间段的显示
        /// </summary>
        /// <returns></returns>
        public TimeQShowResponse TimeQShow(TimeQShowRequest timeQShowRequest)
        {
            TimeQShowResponse timeQShowResponse = new TimeQShowResponse();
            var ser = promotionDal.TimeQShow();
            if (ser != null)
            {
                timeQShowResponse.DateList = ser;
                timeQShowResponse.IsSuccess = true;
            }
            else
            {
                timeQShowResponse.Status = -1;
                timeQShowResponse.Msg = "显示失败";
            }
            return timeQShowResponse;
        }
        /// <summary>
        /// 删除时间段状态
        /// </summary>
        /// <param name="Tid"></param>
        /// <returns></returns>
        public TimeQDeleteResponse TimeQdelete(TimeQDeleteRequest timeQDeleteRequest)
        {
            TimeQDeleteResponse timeQDeleteResponse = new TimeQDeleteResponse();
            if (timeQDeleteRequest.TimeQId == 0)
            {
                timeQDeleteResponse.Status = -1;
                timeQDeleteResponse.Msg = "id为空";
                return timeQDeleteResponse;
            }
            var ser = promotionDal.TimeQdelete(timeQDeleteRequest.TimeQId);
            if (ser > 0)
            {
                timeQDeleteResponse.IsSuccess = true;

            }
            else
            {
                timeQDeleteResponse.Status = -1;
                timeQDeleteResponse.Msg = "删除失败";
            }
            return timeQDeleteResponse;
        }
        /// <summary>
        /// 未启用时间段状态
        /// </summary>
        /// <param name="Tid"></param>
        /// <returns></returns>
        public TimeQUpdate3Response TimeQUpdate3(TimeQUpdate3Request timeQUpdate3Request)
        {
            TimeQUpdate3Response timeQUpdate3Response = new TimeQUpdate3Response();
            if (timeQUpdate3Request.TimeQId == 0)
            {
                timeQUpdate3Response.Status = -1;
                timeQUpdate3Response.Msg = "id为空";
                return timeQUpdate3Response;
            }
            var ser = promotionDal.TimeQUpdate3(timeQUpdate3Request.TimeQId);
            if (ser > 0)
            {
                timeQUpdate3Response.IsSuccess = true;

            }
            else
            {
                timeQUpdate3Response.Status = -1;
                timeQUpdate3Response.Msg = "修改失败";
            }
            return timeQUpdate3Response;
        }
        /// <summary>
        /// 已启用经时间段状态
        /// </summary>
        /// <param name="Tid"></param>
        /// <returns></returns>
        public TimeQUpdate2Response TimeQUpdate2(TimeQUpdate2Request timeQUpdate2Request)
        {
            TimeQUpdate2Response timeQUpdate2Response = new TimeQUpdate2Response();
            if (timeQUpdate2Request.TimeQId == 0)
            {
                timeQUpdate2Response.Status = -1;
                timeQUpdate2Response.Msg = "id为空";
                return timeQUpdate2Response;
            }
            var ser = promotionDal.TimeQUpdate2(timeQUpdate2Request.TimeQId);
            if (ser > 0)
            {
                timeQUpdate2Response.IsSuccess = true;

            }
            else
            {
                timeQUpdate2Response.Status = -1;
                timeQUpdate2Response.Msg = "修改失败";
            }
            return timeQUpdate2Response;
        } 
        #endregion
    }
}
