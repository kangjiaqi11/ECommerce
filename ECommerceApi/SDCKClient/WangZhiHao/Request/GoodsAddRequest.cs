using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.WangZhiHao.Request
{
    public class GoodsAddRequest
    {
        /// <summary>
        /// 商品编号
        /// </summary>
        public int GoodId { get; set; }
        /// <summary>
        /// 品牌编号
        /// </summary>
        public int BrandId { get; set; }
        /// <summary>
        /// 商品类型 1赠品 2电商销售 3专柜销售 4活动售卖 5正常售卖
        /// </summary>
        public int GoodsType { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 商品简介
        /// </summary>
        public string GoodsBrief { get; set; }
        /// <summary>
        /// 商品介绍
        /// </summary>
        public string GoodsIntro { get; set; }
        /// <summary>
        /// 市场价格 吊牌价
        /// </summary>
        public decimal MarketPrice { get; set; }
        /// <summary>
        /// 销售价
        /// </summary>
        public decimal SalePrice { get; set; }
        /// <summary>
        /// 成本价
        /// </summary>
        public decimal CostPrice { get; set; }
        /// <summary>
        /// 浏览数
        /// </summary>
        public int BrowseCount { get; set; }
        /// <summary>
        /// 评论数
        /// </summary>
        public int CommentCount { get; set; }
        /// <summary>
        /// 收藏数
        /// </summary>
        public int CollectCount { get; set; }
        /// <summary>
        /// 分享数量
        /// </summary>
        public int ShareCount { get; set; }
        /// <summary>
        /// 上架时间
        /// </summary>
        public DateTime PutawayTime { get; set; }
        /// <summary>
        /// 商品状态 1=上架 2=下架
        /// </summary>
        public int GoodsState { get; set; }
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
        public long CreaterId { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public long UpdaterId { get; set; }
    }
}
