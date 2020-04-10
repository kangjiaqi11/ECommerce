using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.XuYaDon
{
  public  class OrderStaterequest:BaseRequest
    {
        public int id { get; set; }
        public int State { get; set; }
    }
}
