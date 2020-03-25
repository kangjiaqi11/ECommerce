using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.XuYaDon
{
    /// <summary>
    /// 查询参数
    /// </summary>
   public class OrderShowrequeset:BaseRequest
    {
        public string OrderNumber { get; set; }
        public string GoodsName { get; set; }
        public string AddrName { get; set; }
        public string AddrPhone { get; set; }
        public int State { get; set; }
        public string puttime { get; set; }
        public int pageindex { get; set; }
        public int pagesize { get; set; }
    }
}
