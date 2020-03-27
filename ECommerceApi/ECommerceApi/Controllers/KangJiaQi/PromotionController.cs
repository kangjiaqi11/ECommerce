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
        /// <summary>
        /// 时间段的显示
        /// </summary>
        /// <returns></returns>
        public TimeQShowResponse TimeQShow(TimeQShowRequest timeQShowRequest)
        {
            return promotionBll.TimeQShow(timeQShowRequest);
        }
    }
}
