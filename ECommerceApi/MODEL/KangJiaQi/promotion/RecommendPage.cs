using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
   /// <summary>
   /// 首页推荐显示
   /// </summary>
   public class RecommendPage
    {
        /// <summary>
        /// 数据集合
        /// </summary>
        public List<Recommend> DateList { get; set; }
        /// <summary>
        /// 总条数
        /// </summary>
        public int TotaCount { get; set; }
    }
}
