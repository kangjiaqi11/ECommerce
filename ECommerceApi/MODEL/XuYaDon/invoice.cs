using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.XuYaDon
{
    /// <summary>
    /// 发票信息表
    /// </summary>
 public   class invoice
    {
        /// <summary>
        /// 订单Id
        /// </summary>
        public int OrderId        { get; set; }
        /// <summary>
        /// 发票类型Id
        /// </summary>
        public int InvoiceType    { get; set; }
        /// <summary>
        /// 发票抬头
        /// </summary>
        public string InvoiceHead    { get; set; }
        /// <summary>
        /// 发票内容
        /// </summary>
        public string Invoicecontent { get; set; }
        /// <summary>
        /// 收货人账号
        /// </summary>
        public string PersonName     { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int State          { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CreateId   { get; set; }
        public int UpdateId { get; set; }
    }                  
}                      
                       