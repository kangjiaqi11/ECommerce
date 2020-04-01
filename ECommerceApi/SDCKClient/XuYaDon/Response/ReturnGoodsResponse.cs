using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.XuYaDon;
namespace SDCKClient.XuYaDon
{
    /// <summary>
    /// 申请退货显示
    /// </summary>
   public class ReturnGoodsResponse:BaseResponse
    {
        public List<ReturnGoodsModel> Datalist { get; set; }
        public int totalcount { get; set; }
    }
}
