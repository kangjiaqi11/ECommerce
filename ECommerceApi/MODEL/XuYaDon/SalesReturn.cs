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
        /// <summary>
        /// 退货信息Id
        /// </summary>
        public int ReturnId      { get; set; }
        /// <summary>
        /// 退货信息编号
        /// </summary>
        public string ReturnNumber  { get; set; }
        /// <summary>
        /// 退货信息进行状态
        /// </summary>
        public int ReturnState   { get; set; }
        /// <summary>
        /// 订单Id
        /// </summary>
        public int OrderId       { get; set; }
        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime ReturmTime    { get; set; }
        /// <summary>
        /// 退货原因Id
        /// </summary>
        public int ReturmRemark  { get; set; }
        /// <summary>
        /// 问题描述
        /// </summary>
        public int Remark        { get; set; }
        /// <summary>
        /// 凭证照片
        /// </summary>
        public string picture       { get; set; }
        /// <summary>
        /// 是否退运费
        /// </summary>
        public int freightMoney  { get; set; }
        /// <summary>
        /// 收货人姓名
        /// </summary>
        public string consigneeName { get; set; }
        /// <summary>
        /// 省
        /// </summary>
        public int province      { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        public int City          { get; set; }
        /// <summary>
        /// 区
        /// </summary>
        public int district      { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        public string address       { get; set; }
        /// <summary>
        /// 练习电话
        /// </summary>
        public string PersonPhone   { get; set; }
        /// <summary>
        /// 处理备注
        /// </summary>
        public string comment       { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int State         { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public int CreateId      { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public int UpdateId      { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }                 
}
