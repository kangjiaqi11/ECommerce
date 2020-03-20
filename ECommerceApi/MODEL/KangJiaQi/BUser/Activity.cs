using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.KangJiaQi.BUser
{
    /// <summary>
    /// 秒杀活动表
    /// </summary>
   public class Activity
    {
        /// <summary>
        /// 
        /// </summary>
        public int ActivityId     { get; set; }
        public string ActivityTitle  { get; set; }
        public int ActivityStatel { get; set; }
        public int TimeQId        { get; set; }
        public int GoodId { get; set; }

    }
}
