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
        #region 时间段相关
        /// <summary>
        /// 时间段的显示
        /// </summary>
        /// <returns></returns>
        public TimeQShowResponse TimeQShow(TimeQShowRequest timeQShowRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<TimeQShowRequest, TimeQShowResponse>(timeQShowRequest, GetApiName);
        }
        /// <summary>
        /// 删除时间段
        /// </summary>
        /// <param name="timeQDeleteRequest"></param>
        /// <param name="GetApiName"></param>
        /// <returns></returns>
        public TimeQDeleteResponse TimeQDelete(TimeQDeleteRequest timeQDeleteRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<TimeQDeleteRequest, TimeQDeleteResponse>(timeQDeleteRequest, GetApiName);
        }
        /// <summary>
        ///已启用 
        /// </summary>
        /// <param name="timeQUpdate2Request"></param>
        /// <param name="GetApiName"></param>
        /// <returns></returns>
        public TimeQUpdate2Response TimeQUpdate2(TimeQUpdate2Request timeQUpdate2Request, string GetApiName)
        {
            return ApiRequestHelper.Post<TimeQUpdate2Request, TimeQUpdate2Response>(timeQUpdate2Request, GetApiName);
        }
        /// <summary>
        /// 未启用
        /// </summary>
        /// <param name="timeQUpdate2Request"></param>
        /// <param name="GetApiName"></param>
        /// <returns></returns>
        public TimeQUpdate3Response TimeQUpdate3(TimeQUpdate3Request timeQUpdate3Request, string GetApiName)
        {
            return ApiRequestHelper.Post<TimeQUpdate3Request, TimeQUpdate3Response>(timeQUpdate3Request, GetApiName);
        } 
        #endregion
    }
}
