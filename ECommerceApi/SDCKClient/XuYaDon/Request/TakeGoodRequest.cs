using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.XuYaDon
{
    /// <summary>
    /// 确定收货
    /// </summary>
  public  class TakeGoodRequest:BaseRequest
    {
        public string OrderNumberGoodsName { get; set; }
        public string AddrNameAddrPhone { get; set; }
   
        public string puttime { get; set; }
        public string endtimes { get; set; }
        public int pageindex { get; set; }
        public int pagesize { get; set; }
    }
}
