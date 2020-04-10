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

        /// <summary>
        /// 商品显示
        /// </summary>
        /// <param name="goods"></param>
        /// <returns></returns>
        [HttpPost]
        public GoodsAddResponse GoodsShow(GoodsAddRequest goods)
        {
            return goodsBll.GoodsShow(goods);
        }

        /// <summary>
        /// 商品添加
        /// </summary>
        /// <param name="addGoodRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public AddGoodResponse GoodAdd( AddGoodRequest addGoodRequest)
        {
            return goodsBll.GoodAdd(addGoodRequest);
        }

        /// <summary>
        /// 商品删除
        /// </summary>
        /// <param name="updateGoodsRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public UpdateGoodsResponse GoodsDelete(UpdateGoodsRequest updateGoodsRequest)
        {
            return goodsBll.GoodsDelete(updateGoodsRequest);
        }

        /// <summary>
        /// 商品审核通过
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public GoodsPutawayResponse GoodsPutaway(GoodsPutawayRequest goodsPutawayRequest)
        {
            return goodsBll.GoodsPutaway(goodsPutawayRequest);
        }
        /// <summary>
        /// 商品审核未通过
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public GoodsSoldOutResponse GoodsSold(GoodsSoldOutRequest goodsSoldOutRequest)
        {
            return goodsBll.GoodsSold(goodsSoldOutRequest);
        }

        /// <summary>
        /// 显示要添加的审核商品
        /// </summary>
        /// <param name="auditShowRequest"></param>
        /// <returns></returns>
        public AuditShowResponse GoodsAudit(AuditShowRequest auditShowRequest)
        {
            return goodsBll.GoodsAudit(auditShowRequest);
        }
    }
}
