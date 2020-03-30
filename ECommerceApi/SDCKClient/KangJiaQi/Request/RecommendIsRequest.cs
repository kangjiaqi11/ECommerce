using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
    /// <summary>
    /// 改变为推荐
    /// </summary>
   public class RecommendIsRequest:BaseRequest
    {
        /// <summary>
        /// 好物推荐id
        /// </summary>
        public int RecommendId { get; set; }
    }
}
