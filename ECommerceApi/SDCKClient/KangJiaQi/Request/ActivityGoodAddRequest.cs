using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
   public class ActivityGoodAddRequest:BaseRequest
    {
        /// <summary>
        /// 时间段id
        /// </summary>
        public int TimeQId { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        public int GoodId { get; set; }
        /// <summary>
        /// 秒杀id
        /// </summary>
        public int ActivityId { get; set; }
    }
}
