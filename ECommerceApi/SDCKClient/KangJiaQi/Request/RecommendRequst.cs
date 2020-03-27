using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
   /// <summary>
   /// 首页推荐的参数
   /// </summary>
  public  class RecommendRequst:BaseRequest
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 是否推荐
        /// </summary>
        public int IsRecommend { get; set; }
        /// <summary>
        /// 页数
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 每页多少条
        /// </summary>
        public int PageSize { get; set; }
    }
}
