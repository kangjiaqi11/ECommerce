using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.XuYaDon
{
    /// <summary>
    /// 退货类型信息
    /// </summary>
   public class RetutnType
    {
        public int Id          { get; set; }
       /// <summary>
       /// 退货原因
       /// </summary>
        public string ReturnName  { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int RetuemState { get; set; }
        public DateTime CreateTimes { get; set; }
        public int State       { get; set; }
        public DateTime UpdateTime  { get; set; }
        public int CreateId    { get; set; }
        public int UpdateId { get; set; }
    }
}
