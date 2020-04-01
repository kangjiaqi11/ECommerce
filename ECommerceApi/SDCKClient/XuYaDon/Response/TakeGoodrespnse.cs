using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.XuYaDon;
namespace SDCKClient.XuYaDon
{
    /// <summary>
    /// 确定收货
    /// </summary>
  public  class TakeGoodrespnse:BaseResponse
    {
        public List<TakeGood> Datalist { get; set; }
        public int totalcount { get; set; }
    }
}
