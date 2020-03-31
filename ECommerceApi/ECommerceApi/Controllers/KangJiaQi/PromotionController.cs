using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SDCKClient;
using BLL;
namespace ECommerceApi.Controllers.KangJiaQi
{
    public class PromotionController : ApiController
    {
        promotionBll promotionBll = new promotionBll();
        /// <summary>
        /// 秒杀活动显示
        /// </summary>
        /// <param name="activityShowRequst"></param>
        /// <returns></returns>
        [HttpPost]
        public ActivityShowRespnse ActivityShow(ActivityShowRequst activityShowRequst)
        {
            return promotionBll.ActivityShow(activityShowRequst);
        }
        /// <summary>
        /// 添加秒杀
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActivityAddResponse ActivityAdd(ActivityAddRequest activityAddRequest)
        {
            return promotionBll.ActivityAdd(activityAddRequest);
        }
        #region 好物推荐相关
        /// <summary>
        /// 推荐首页的物品
        /// </summary>
        /// <param name="recommendRequst"></param>
        /// <returns></returns>
        [HttpPost]
        public RecommendResponse RecommendShow(RecommendRequst recommendRequst)
        {
            return promotionBll.RecommendShow(recommendRequst);
        }
        /// <summary>
        ///好物推荐 状态
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public RecommendIsResponse RecommendIs(RecommendIsRequest recommendIsRequest)
        {
            return promotionBll.RecommendIs(recommendIsRequest);
        }
        /// <summary>
        ///好物推荐下架
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public RecommenNodRequest RecommendNO(RecommendNoRequest recommendNoRequest)
        {
            return promotionBll.RecommendNO(recommendNoRequest);
        }
        /// <summary>
        /// 好物推荐删除
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public RecommendDeleteResponse RecommendDelete(RecommendDeleteRequest recommendDeleteRequest)
        {
            return promotionBll.RecommendDelete(recommendDeleteRequest);
        }
        #endregion
        #region 时间段相关
        /// <summary>
        /// 时间段的显示
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public TimeQShowResponse TimeQShow(TimeQShowRequest timeQShowRequest)
        {
            return promotionBll.TimeQShow(timeQShowRequest);
        }
        /// <summary>
        /// 删除时间段状态
        /// </summary>
        /// <param name="Tid"></param>
        /// <returns></returns>
        [HttpPost]
        public TimeQDeleteResponse TimeQdelete(TimeQDeleteRequest timeQDeleteRequest)
        {
            return promotionBll.TimeQdelete(timeQDeleteRequest);
        }
        /// <summary>
        /// 未启用时间段状态
        /// </summary>
        /// <param name="Tid"></param>
        /// <returns></returns>
        [HttpPost]
        public TimeQUpdate3Response TimeQUpdate3(TimeQUpdate3Request timeQUpdate3Request)
        {
            return promotionBll.TimeQUpdate3(timeQUpdate3Request);
        }
        /// <summary>
        /// 已启用经时间段状态
        /// </summary>
        /// <param name="Tid"></param>
        /// <returns></returns>
        [HttpPost]
        public TimeQUpdate2Response TimeQUpdate2(TimeQUpdate2Request timeQUpdate2Request)
        {
            return promotionBll.TimeQUpdate2(timeQUpdate2Request); ;
        } 
        #endregion
    }
}
