using SDCKClient;
using SDCKClient.WangZhiHao.Request;
using SDCKClient.WangZhiHao.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class BGoodsBll
    {
        
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="goodsAddRequest"></param>
        /// <param name="GetApiName"></param>
        /// <returns></returns>
        public GoodsAddResponse GoodsShow(GoodsAddRequest goodsAddRequest,string GetApiName)
        {
            return ApiRequestHelper.Post<GoodsAddRequest, GoodsAddResponse>(goodsAddRequest, GetApiName);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="goodsAddRequest"></param>
        /// <param name="GetApiName"></param>
        /// <returns></returns>
        public AddGoodResponse GoodsAdd(AddGoodRequest addGoodRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<AddGoodRequest, AddGoodResponse>(addGoodRequest, GetApiName);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="goodsAddRequest"></param>
        /// <param name="GetApiName"></param>
        /// <returns></returns>
        public UpdateGoodsResponse GoodsDelete(UpdateGoodsRequest updateGoodsRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<UpdateGoodsRequest, UpdateGoodsResponse>(updateGoodsRequest, GetApiName);
        }

        /// <summary>
        /// 商品审核通过
        /// </summary>
        /// <param name="goodsPutawayRequest"></param>
        /// <param name="GetApiName"></param>
        /// <returns></returns>
        public GoodsPutawayResponse GoodsPutaway(GoodsPutawayRequest goodsPutawayRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<GoodsPutawayRequest, GoodsPutawayResponse>(goodsPutawayRequest, GetApiName);
        }

        /// <summary>
        /// 商品未审核通过
        /// </summary>
        /// <param name="goodsPutawayRequest"></param>
        /// <param name="GetApiName"></param>
        /// <returns></returns>
        public GoodsSoldOutResponse GoodsSold(GoodsSoldOutRequest goodsSoldOutRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<GoodsSoldOutRequest, GoodsSoldOutResponse>(goodsSoldOutRequest, GetApiName);
        }

        /// <summary>
        /// 显示要添加的审核商品
        /// </summary>
        /// <param name="auditShowRequest"></param>
        /// <returns></returns>
        public AuditShowResponse GoodsAudit(AuditShowRequest auditShowRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<AuditShowRequest, AuditShowResponse>(auditShowRequest, GetApiName);
        }
    }
}
