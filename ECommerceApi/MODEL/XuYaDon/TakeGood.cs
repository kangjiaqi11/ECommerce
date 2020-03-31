using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.XuYaDon
{
    /// <summary>
    /// 确定收货表
    /// </summary>
  public  class TakeGood
    {
        public long OrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime SubmitTime { get; set; }
        public string SubmitTimeST { get { return SubmitTime.ToString(); } }
        public decimal MarketPrice { get; set; }
        public string Account { get; set; }
        public int Oderstate { get; set; }
        public string Consignee { get; set; }
        public int TakeGoods { get; set; }
    }
}
