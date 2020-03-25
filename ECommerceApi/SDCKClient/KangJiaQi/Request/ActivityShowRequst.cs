using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
   public class ActivityShowRequst:BaseRequest
    {
       
        /// <summary>
        /// 活动标题
        /// </summary>
        public string ActivityTitle { get; set; }
        /// <summary>
        /// 页数
        /// </summary>
        public int PageIndex     { get; set; }
        /// <summary>
        /// 每页多少条
        /// </summary>
        public int PageSize { get; set; }
    }
}
