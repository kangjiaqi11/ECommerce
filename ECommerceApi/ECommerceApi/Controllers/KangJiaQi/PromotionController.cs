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
        public ActivityShowRespnse ActivityShow(ActivityShowRequst activityShowRequst)
        {
            return promotionBll.ActivityShow(activityShowRequst);
        }
        /// <summary>
        /// 推荐首页的物品
        /// </summary>
        /// <param name="recommendRequst"></param>
        /// <returns></returns>
        public RecommendResponse RecommendShow(RecommendRequst recommendRequst)
        {
            return promotionBll.RecommendShow(recommendRequst);
        }
        #region 时间段相关
        /// <summary>
        /// 时间段的显示
        /// </summary>
        /// <returns></returns>
        public TimeQShowResponse TimeQShow(TimeQShowRequest timeQShowRequest)
        {
            return promotionBll.TimeQShow(timeQShowRequest);
        }
        /// <summary>
        /// 删除时间段状态
        /// </summary>
        /// <param name="Tid"></param>
        /// <returns></returns>
        public TimeQDeleteResponse TimeQdelete(TimeQDeleteRequest timeQDeleteRequest)
        {
            return promotionBll.TimeQdelete(timeQDeleteRequest);
        }
        /// <summary>
        /// 未启用时间段状态
        /// </summary>
        /// <param name="Tid"></param>
        /// <returns></returns>
        public TimeQUpdate3Response TimeQUpdate3(TimeQUpdate3Request timeQUpdate3Request)
        {
            return promotionBll.TimeQUpdate3(timeQUpdate3Request);
        }
        /// <summary>
        /// 已启用经时间段状态
        /// </summary>
        /// <param name="Tid"></param>
        /// <returns></returns>
        public TimeQUpdate2Response TimeQUpdate2(TimeQUpdate2Request timeQUpdate2Request)
        {

            return promotionBll.TimeQUpdate2(timeQUpdate2Request); ;
        } 
        #endregion
    }
}
