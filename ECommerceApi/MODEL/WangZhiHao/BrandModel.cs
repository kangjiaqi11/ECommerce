using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.WangZhiHao
{
    /// <summary>
    /// 商品品牌
    /// </summary>
    public class BrandModel
    {
        /// <summary>
        /// 品牌编号
        /// </summary>
        public int DrandId { get; set; }
        /// <summary>
        /// 品牌名称
        /// </summary>
        public string BrandName   { get; set; }
        /// <summary>
        /// 数据状态 1正常 2删除
        /// </summary>
        public int State       { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime  { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime  { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public int CreateId    { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public int UpdateId    { get; set; }
    }
}
