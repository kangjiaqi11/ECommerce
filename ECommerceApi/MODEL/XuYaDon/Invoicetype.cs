using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.XuYaDon
{
    /// <summary>
    /// 发票类型表
    /// </summary>
   public class Invoicetype
    {
        /// <summary>
        /// 发票类型Id
        /// </summary>
        public int InvoicetypeId  { get; set; }
        /// <summary>
        /// 发票类型名称
        /// </summary>
        public string InvoieTypeName { get; set; }
        public int State          { get; set; }
        public DateTime CreateTime     { get; set; }
        public DateTime UpdateTime     { get; set; }
        public int CreateId { get; set; }
        public int UpdateId { get; set; }
    }                    
}
