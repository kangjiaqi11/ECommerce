using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.XuYaDon
{
  public  class UpdateReturnRequest:BaseRequest
    {
        public int state { get; set; }
        public int Id { get; set; }
    }
}
