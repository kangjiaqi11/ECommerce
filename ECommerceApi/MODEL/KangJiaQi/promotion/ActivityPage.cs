using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{

    /// <summary>
    ///促销活动显示
    /// </summary>
   public class ActivityPage
    {
        /// <summary>
        /// 数据集合
        /// </summary>
        public List<Activity> DateList { get; set; }
        /// <summary>
        /// 总条数
        /// </summary>
        public int TotaCount { get; set; }
    }
}
