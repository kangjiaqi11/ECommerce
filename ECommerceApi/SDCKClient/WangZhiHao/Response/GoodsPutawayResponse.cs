using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.WangZhiHao.Response
{
    /// <summary>
    /// 商品审核通过返回值
    /// </summary>
    public class GoodsPutawayResponse:BaseResponse
    {
        /// <summary>
        /// 状态返回值
        /// </summary>
        public int GoodsState { get; set; }
    }
}
