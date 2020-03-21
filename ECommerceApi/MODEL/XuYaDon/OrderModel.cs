using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.XuYaDon
{
    /// <summary>
    /// 订单表
    /// </summary>
  public  class OrderModel
    {
        /// <summary>
        /// 订单Id
        /// </summary>
        public int OrderId       { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderNumber   { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public int FrontUserid   { get; set; }
        /// <summary>
        /// 发票信息Id
        /// </summary>
        public int invoice       { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary>
        public string payment       { get; set; }
        /// <summary>
        /// 订单来源
        /// </summary>
        public string Ordersource   { get; set; }
        /// <summary>
        /// 订单类型
        /// </summary>
        public string OrderType { get; set; }
        /// <summary>
        /// 物流信息Id
        /// </summary>
        public int expressId     { get; set; }
        /// <summary>
        /// 物流单号
        /// </summary>
        public int expressNumber { get; set; }
        /// <summary>
        /// 订单可得成长值
        /// </summary>
        public int Growthvalue   { get; set; }
        /// <summary>
        /// 自动确定收货时
        /// </summary>
        public int TakeGoods     { get; set; }
        /// <summary>
        /// 活动信息
        /// </summary>
        public int Activity      { get; set; }
        /// <summary>
        /// 商品Id信息
        /// </summary>
        public int GoodId        { get; set; }
        /// <summary>
        /// 费用信息Id
        /// </summary>
        public int MoneyId       { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public int Oderstate     { get; set; }
        /// <summary>
        /// 提交时间
        /// </summary>
        public DateTime SubmitTime    { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime EditTime      { get; set; }
        /// <summary>
        /// 提交人
        /// </summary>
        public int CreatId { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public int EditId { get; set; }
    }                     
}
