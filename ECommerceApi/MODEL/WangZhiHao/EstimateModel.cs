using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.WangZhiHao
{
    /// <summary>
    /// 评论信息表
    /// </summary>
    public class EstimateModel
    {
        /// <summary>
        /// 评论编号
        /// </summary>
        public int EstimateId { get; set; }
        /// <summary>
        /// 用户编号
        /// </summary>
        public int FrontUserid { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        public int CommodityId { get; set; }
        /// <summary>
        /// 评价状态 1=好评 2=中评 3=差评
        /// </summary>
        public int EstimateState { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string EstimateContent { get; set; }
        /// <summary>
        /// 数据状态 1正常 2删除
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public int CreaterId { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public int UpdaterId { get; set; }
    }
}
