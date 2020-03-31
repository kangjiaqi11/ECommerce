using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using BLL.WangZhiHao;
using SDCKClient.WangZhiHao.Request;
using SDCKClient.WangZhiHao.Response;
namespace ECommerceApi.Controllers.WangZhiHao
{
    public class GoodsController : ApiController
    {
        GoodsBll goodsBll = new GoodsBll();

        public GoodsAddResponse GoodsShow(GoodsAddRequest goods)
        {
            return goodsBll.GoodsShow(goods);
        }
    }
}
