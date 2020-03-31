using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
    /// <summary>
    /// 添加秒删活动参数
    /// </summary>
   public class ActivityAddRequest:BaseRequest
    {
        /// <summary>
        /// 活动标题
        /// </summary>
        public string ActivityTitle { get; set; }
        /// <summary>
        /// 活动状态
        /// </summary>
        public int ActivityStatel { get; set; }
        /// <summary>
        /// 活动开始时间
        /// </summary>
        public DateTime AStartTime { get; set; }
        /// <summary>
        /// 活动结束时间
        /// </summary>
        public DateTime AEenTime { get; set; }
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
