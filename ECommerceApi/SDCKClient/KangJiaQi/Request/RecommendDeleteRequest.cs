using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
    /// <summary>
    /// 删除好物推荐
    /// </summary>
   public class RecommendDeleteRequest:BaseRequest
    {
        /// <summary>
        /// 好物推荐id
        /// </summary>
        public int RecommendId { get; set; }
    }
}
