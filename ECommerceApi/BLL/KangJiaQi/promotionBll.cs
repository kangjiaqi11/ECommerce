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
        DBHelper DBHelper=new  DBHelper();
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
            if (ser!=null)
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
        /// 推荐首页的物品
        /// </summary>
        /// <param name="recommendRequst"></param>
        /// <returns></returns>
        public RecommendResponse  RecommendShow(RecommendRequst recommendRequst)
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
