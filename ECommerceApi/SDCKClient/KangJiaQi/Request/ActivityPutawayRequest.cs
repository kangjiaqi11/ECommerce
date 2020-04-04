using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
    /// <summary>
    /// 活动上架参数
    /// </summary>
   public class ActivityPutawayRequest:BaseRequest
    {
        /// <summary>
        /// 活动id
        /// </summary>
        public int ActivityId { get; set; }
    }
}
