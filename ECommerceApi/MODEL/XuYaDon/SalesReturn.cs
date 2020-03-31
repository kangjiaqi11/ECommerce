using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.XuYaDon
{
    /// <summary>
    /// 退货信息表
    /// </summary>
   public class SalesReturn
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
        /// <summary>
        /// 退货原因
        /// </summary>
        public string ReturnName { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 商品价格
        /// </summary>
        public decimal MarketPrice { get; set; }
        /// <summary>
        /// 商品类型Name
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 品牌名称
        /// </summary>
        public string BrandName { get; set; }
    }                 
}
