using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.WangZhiHao.Response
{
    public class GoodsAddResponse:BaseResponse
    {
        public List<GoodsModel> goods { get; set; }
    }
}
