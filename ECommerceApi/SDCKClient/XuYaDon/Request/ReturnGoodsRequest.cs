using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.XuYaDon
{
    /// <summary>
    /// 申请退货显示
    /// </summary>
   public class ReturnGoodsRequest:BaseRequest
    {
        public string OrderNumber { get; set; }
        public string AddrPhone { get; set; }
        public int State { get; set; }
        public string puttime { get; set; }
        public int pageindex { get; set; }
        public int pagesize { get; set; }
        
    }
}
