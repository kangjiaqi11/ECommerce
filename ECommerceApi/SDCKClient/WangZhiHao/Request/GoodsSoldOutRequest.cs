using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.WangZhiHao.Request
{
    /// <summary>
    /// 商品审核未通过
    /// </summary>
    public class GoodsSoldOutRequest:BaseRequest
    {
        /// <summary>
        /// 商品id
        /// </summary>
        public int GoodId { get; set; }
    }
}
