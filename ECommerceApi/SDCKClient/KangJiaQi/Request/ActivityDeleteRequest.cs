using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
    /// <summary>
    /// 删除活动参数
    /// </summary>
   public class ActivityDeleteRequest:BaseRequest
    {
        /// <summary>
        /// 活动id
        /// </summary>
        public int ActivityId { get; set; }
    }
}
