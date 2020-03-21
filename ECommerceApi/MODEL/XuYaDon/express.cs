using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.XuYaDon
{
    /// <summary>
    /// 物流信息表 此表与订单信息里面的物流相连接
    /// </summary>
  public  class express
    {
        /// <summary>
        /// 物流Idhgh
        /// </summary>
        public int expressId    { get; set; }
   
        /// <summary>
        /// 物流公司名称
        /// </summary>
        public string expressName  { get; set; }
        /// <summary>
        /// 物流状态是否启用
        /// </summary>
        public int expressState { get; set; }
        /// <summary>
        /// 物流状态是否启用
        /// </summary>
        public int State        { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime   { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime   { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public int CreateId { get; set; }
        /// <summary>
        /// 更新人
        /// </summary>
        public int UpdateId { get; set; }
    }                  
}
