using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
    /// <summary>
    /// 删除
    /// </summary>
   public class TimeQDeleteRequest:BaseRequest
    { 
        /// <summary>
       /// 时间段id
       /// </summary>
        public long TimeQId { get; set; }
    }
}
