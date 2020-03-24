﻿using System;
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
        /// 创建时间
        /// </summary>
        public DateTime CeateTime { get; set; }
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