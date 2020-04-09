using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using BLL.WangZhiHao;
using MODEL;
using SDCKClient.WangZhiHao.Request;
using SDCKClient.WangZhiHao.Response;

namespace ECommerceApi.Controllers.WangZhiHao
{
    public class GoodsController : ApiController
    {
        GoodsBll goodsBll = new GoodsBll();

        [HttpPost]
        public GoodsAddResponse GoodsShow(GoodsAddRequest goods)
        {
            return goodsBll.GoodsShow(goods);
        }
        [HttpPost]
        public AddGoodResponse GoodAdd( AddGoodRequest addGoodRequest)
        {
            return goodsBll.GoodAdd(addGoodRequest);
        }
        [HttpPost]
        public UpdateGoodsResponse GoodsDelete(UpdateGoodsRequest updateGoodsRequest)
        {
            return goodsBll.GoodsDelete(updateGoodsRequest);
        }
    }
}
