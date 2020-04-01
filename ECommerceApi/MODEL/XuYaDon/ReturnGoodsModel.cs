using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.XuYaDon
{
    /// <summary>
    /// 退货申请显示表
    /// </summary>
   public class ReturnGoodsModel
    {
        public int ReturnId { get; set; }
        public string ReturnNumber { get; set; }
        public int ReturnState { get; set; }
        public string UserAcco { get; set; }
        public decimal Money { get; set; }
        public int GoodsId { get; set; }
        public string OrderId { get; set; }
        public DateTime ReturmTime { get; set; }
        public string SubmitTimeST { get { return ReturmTime.ToString(); } }
        public int ReturmRemark { get; set; }
        public string SubmitTime { get { return CreateTime.ToString(); } }
        public string Remark { get; set; }
        public int freightMoney { get; set; }
        public long CreateId { get; set; }
        public long UpdateId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }            
}                
                   
                   
                   
                   
                   