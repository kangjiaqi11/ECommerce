using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace SDCKClient
{
    /// <summary>
    /// 显示商品返回值
    /// </summary>
   public class ActivityGoodShowResponse:BaseResponse
    {
        /// <summary>
        /// 数据集合
        /// </summary>
        public List<GoodsModel> DateList { get; set; }
    }
}
