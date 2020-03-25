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
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 商品品牌号
        /// </summary>
        public int BrandId { get; set; }
        /// <summary>
        /// 品牌名称
        /// </summary>
        public string BrandName { get; set; }
        /// <summary>
        /// 商品类型名称
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 销售价格
        /// </summary>
        public decimal MarketPrice { get; set; }
        /// <summary>
        /// 前台账号
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 收货人手机号
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// 收货人名称
        /// </summary>
        public string Consignee { get; set; }
        /// <summary>
        /// 收货人邮编
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 收货人详细地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 发票类型
        /// </summary>
        public string InvoieTypeName { get; set; }
        /// <summary>
        /// 发票抬头
        /// </summary>
        public string InvoiceHead { get; set; }
        /// <summary>
        /// 发票内容
        /// </summary>
        public string Invoicecontent { get; set; }
    }                     
}
