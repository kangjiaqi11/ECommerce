using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
   public class RecommendNoRequest:BaseRequest
    {
        /// <summary>
        /// 好物推荐id
        /// </summary>
        public int RecommendId { get; set; }
    }
}
