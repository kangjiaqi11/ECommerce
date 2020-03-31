using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace SDCKClient
{
    /// <summary>
    /// 秒删活动显示的返回值
    /// </summary>
   public class RecommendResponse:BaseResponse
    {        /// <summary>
             /// 数据集合
             /// </summary>
        public List<Recommend> DateList { get; set; }
        /// <summary>
        /// 总条数
        /// </summary>
        public int TotaCount { get; set; }
    }
}
