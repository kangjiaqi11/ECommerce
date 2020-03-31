using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    /// <summary>
    /// 秒杀活动表
    /// </summary>
   public class Activity
    {
        /// <summary>
        /// 活动id
        /// </summary>
        public long ActivityId     { get; set; }
        /// <summary>
        /// 活动标题
        /// </summary>
        public string ActivityTitle  { get; set; }
        /// <summary>
        /// 活动状态
        /// </summary>
        public int ActivityStatel { get; set; }
        /// <summary>
        /// 时间段id
        /// </summary>
        public long TimeQId        { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        public long GoodId { get; set; }
        /// <summary>
        /// 活动开始时间
        /// </summary>
        public DateTime AStartTime	 { get; set; }
        /// <summary>
        /// 显示开始时间
        /// </summary>
        public string AStartTimeStr { get { return AStartTime.ToString(); } }
        /// <summary>
        /// 活动结束时间
        /// </summary>
        public DateTime AEenTime { get; set; }
        /// <summary>
        /// 结束显示时间
        /// </summary>
        public string AEenTimeStr { get { return AEenTime.ToString(); } }
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
