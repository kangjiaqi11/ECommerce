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
        /// <summary>
        /// 时间段的显示
        /// </summary>
        /// <returns></returns>
        public TimeQShowResponse  TimeQShow( TimeQShowRequest timeQShowRequest)
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
    }
}
