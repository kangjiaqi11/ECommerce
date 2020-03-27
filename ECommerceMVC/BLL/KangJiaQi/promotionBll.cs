using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDCKClient;
namespace BLL
{
    public class promotionBll
    {
        /// <summary>
        /// 秒杀活动
        /// </summary>
        /// <param name="activityShowRequst"></param>
        /// <param name="GetApiName"></param>
        /// <returns></returns>
        public ActivityShowRespnse ActivityShow(ActivityShowRequst activityShowRequst,string GetApiName)
        {
            return ApiRequestHelper.Post<ActivityShowRequst, ActivityShowRespnse>(activityShowRequst, GetApiName);
        }
        /// <summary>
        /// 首页推荐显示
        /// </summary>
        /// <param name="recommendRequst"></param>
        /// <param name="GetApiName"></param>
        /// <returns></returns>
        public RecommendResponse PageRecommendShow(RecommendRequst recommendRequst,string GetApiName)
        {
            return ApiRequestHelper.Post<RecommendRequst, RecommendResponse>(recommendRequst, GetApiName);
        }
        /// <summary>
        /// 事件段的显示
        /// </summary>
        /// <returns></returns>
        public TimeQShowResponse TimeQShow(TimeQShowRequest timeQShowRequest,string GetApiName)
        {
            return ApiRequestHelper.Post<TimeQShowRequest, TimeQShowResponse>(timeQShowRequest, GetApiName);
        }
    }
}
