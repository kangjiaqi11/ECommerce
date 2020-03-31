using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.XuYaDon;
namespace SDCKClient.XuYaDon
{
   public class ExperShowresponse:BaseResponse
    {
        public List<ExpressShowModel> Datalist { get; set; }
    }
}
