using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.XuYaDon
{
  public  class UpdateStateExperrequest:BaseRequest
    {
        public string OderNumber { get; set; }
        public int experId { get; set; }
    }
}
