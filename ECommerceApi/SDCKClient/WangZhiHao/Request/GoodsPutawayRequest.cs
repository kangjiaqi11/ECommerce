using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.WangZhiHao.Request
{
    /// <summary>
    /// 商品审核通过
    /// </summary>
    public class GoodsPutawayRequest:BaseRequest
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public int GoodId { get; set; }
    }
}
