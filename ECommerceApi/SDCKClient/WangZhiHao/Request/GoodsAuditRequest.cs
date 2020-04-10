using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.WangZhiHao.Request
{
    /// <summary>
    /// 商品未审核
    /// </summary>
    public class GoodsAuditRequest:BaseRequest
    {
        public int GoodId { get; set; }
    }
}
