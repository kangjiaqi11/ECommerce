using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.XuYaDon;
namespace SDCKClient.XuYaDon
{
    /// <summary>
    /// 退货申请详细
    /// </summary>
   public class ReturnShenresponse:BaseResponse
    {
        public List<SalesReturn> list { get; set; }
    }
}
