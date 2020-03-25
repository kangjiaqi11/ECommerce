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
    }
}
