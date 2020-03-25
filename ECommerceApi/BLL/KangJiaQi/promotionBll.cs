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
    }
}
