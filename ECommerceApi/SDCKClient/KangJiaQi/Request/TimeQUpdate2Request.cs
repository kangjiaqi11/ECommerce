﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
    /// <summary>
    /// 修改状态
    /// </summary>
   public class TimeQUpdate2Request:BaseRequest
    {
        /// <summary>
        /// 时间段id
        /// </summary>
        public long TimeQId { get; set; }
    }
}
