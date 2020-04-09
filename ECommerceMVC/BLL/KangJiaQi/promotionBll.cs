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
        #region 秒杀相关
        /// <summary>
        /// 秒杀活动
        /// </summary>
        /// <param name="activityShowRequst"></param>
        /// <param name="GetApiName"></param>
        /// <returns></returns>
        public ActivityShowRespnse ActivityShow(ActivityShowRequst activityShowRequst, string GetApiName)
        {
            return ApiRequestHelper.Post<ActivityShowRequst, ActivityShowRespnse>(activityShowRequst, GetApiName);
        }
        /// <summary>
        /// 添加秒杀
        /// </summary>
        /// <returns></returns>
        public ActivityAddResponse ActivityAdd(ActivityAddRequest activityAddRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<ActivityAddRequest, ActivityAddResponse>(activityAddRequest, GetApiName);
        }

        /// <summary>
        ///活动秒杀 上架
        /// </summary>
        /// <returns></returns>
        public ActivityPutawayResponse ActivityPutaway(ActivityPutawayRequest activityPutawayRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<ActivityPutawayRequest, ActivityPutawayResponse>(activityPutawayRequest, GetApiName);
        }
        /// <summary>
        ///活动秒杀下架
        /// </summary>
        /// <returns></returns>
        public ActivitySoldOutResponse ActivitySoldOut(ActivitySoldOutRequest activitySoldOutRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<ActivitySoldOutRequest, ActivitySoldOutResponse>(activitySoldOutRequest, GetApiName);
        }
        /// <summary>
        /// 活动秒杀删除
        /// </summary>
        /// <returns></returns>
        public ActivityDeleteResponse ActivityDelete(ActivityDeleteRequest activityDeleteRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<ActivityDeleteRequest, ActivityDeleteResponse>(activityDeleteRequest, GetApiName);
        }
        /// <summary>
        /// 显示要添加的商品
        /// </summary>
        /// <returns></returns>
        public ActivityGoodShowResponse ActivityGoodShow(ActivityGoodShowRequest activityGoodShowRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<ActivityGoodShowRequest, ActivityGoodShowResponse>(activityGoodShowRequest, GetApiName);
        }
        /// <summary>
        /// 活动添加商品
        /// </summary>
        /// <returns></returns>
        public ActivityGoodAddResponse ActivityGoodAdd(ActivityGoodAddRequest activityGoodAddRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<ActivityGoodAddRequest, ActivityGoodAddResponse>(activityGoodAddRequest, GetApiName);
        }
        #endregion
        #region 好物推荐相关
        /// <summary>
        /// 首页推荐显示
        /// </summary>
        /// <param name="recommendRequst"></param>
        /// <param name="GetApiName"></param>
        /// <returns></returns>
        public RecommendResponse PageRecommendShow(RecommendRequst recommendRequst, string GetApiName)
        {
            return ApiRequestHelper.Post<RecommendRequst, RecommendResponse>(recommendRequst, GetApiName);
        }
        /// <summary>
        ///好物推荐 状态
        /// </summary>
        /// <returns></returns>
        public RecommendIsResponse RecommendIs(RecommendIsRequest recommendIsRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<RecommendIsRequest, RecommendIsResponse>(recommendIsRequest, GetApiName);
        }
        /// <summary>
        ///好物推荐下架
        /// </summary>
        /// <returns></returns>
        public RecommenNodRequest RecommendNO(RecommendNoRequest recommendNoRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<RecommendNoRequest, RecommenNodRequest>(recommendNoRequest, GetApiName);
        }
        /// <summary>
        /// 好物推荐删除
        /// </summary>
        /// <returns></returns>
        public RecommendDeleteResponse RecommendDelete(RecommendDeleteRequest recommendDeleteRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<RecommendDeleteRequest, RecommendDeleteResponse>(recommendDeleteRequest, GetApiName);
        } 
        #endregion
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
