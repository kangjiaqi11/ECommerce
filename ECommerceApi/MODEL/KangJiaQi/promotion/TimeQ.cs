using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    /// <summary>
    /// 时间段
    /// </summary>
   public class TimeQ
    {
        /// <summary>
        /// 时间段id
        /// </summary>
        public long TimeQId    { get; set; }
        /// <summary>
        /// 秒杀时间名称
        /// </summary>
        public string TimeQName  { get; set; }
        /// <summary>
        /// 每日开始时间
        /// </summary>
        public DateTime StartTime  { get; set; }
        /// <summary>
        /// 每日结束时间
        /// </summary>
        public DateTime EenTime    { get; set; }
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
