using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    /// <summary>
    /// 首页推荐
    /// </summary>
   public class Recommend
    {
        /// <summary>
        /// 推荐id
        /// </summary>
        public long RecommendId { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        public long GoodId      { get; set; }
        /// <summary>
        /// 是否推荐
        /// </summary>
        public int IsRecommend { get; set; }
        /// <summary>
        /// 数据状态
        /// </summary>
        public int Statel { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public long CreateId { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public long UpdateId { get; set; }
    }
}
