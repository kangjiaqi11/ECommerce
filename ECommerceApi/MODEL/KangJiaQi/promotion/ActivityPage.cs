using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
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
