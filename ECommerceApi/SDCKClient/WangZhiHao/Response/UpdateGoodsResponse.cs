using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.WangZhiHao.Response
{
    public class UpdateGoodsResponse:BaseResponse
    {
        public List<GoodsModel> goodsupdate { get; set; }
        
       
    }
}
