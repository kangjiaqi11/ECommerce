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
    }
}
