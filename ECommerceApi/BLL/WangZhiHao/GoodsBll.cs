using MODEL;
using Dal.WangZhiHao;
using SDCKClient;
using SDCKClient.WangZhiHao.Response;
using SDCKClient.WangZhiHao.Request;
using System;

namespace BLL.WangZhiHao
{

    public class GoodsBll
    {
        /// <summary>
        /// 实例化dal
        /// </summary>
        GoodsDal dal = new GoodsDal();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="good"></param>
        /// <returns></returns>
        public AddGoodResponse GoodAdd(AddGoodRequest addGoodRequest)
        {
            AddGoodResponse addGoodResponse = new AddGoodResponse();
            if (string.IsNullOrEmpty(addGoodRequest.GoodsName))
            {
                addGoodResponse.Status = -1;
                addGoodResponse.Msg = "名称不能为空";
                return addGoodResponse;
            }
            if (addGoodRequest.PutawayTime==null)
            {
                addGoodResponse.Status = -1;
                addGoodResponse.Msg = "上架时间不能为空";
                return addGoodResponse;
            } 
            
            GoodsModel goodsModel = new GoodsModel();
            goodsModel.BrandId = addGoodRequest.BrandId;
            goodsModel.CategoryId = 1;
            goodsModel.GoodsType = addGoodRequest.GoodsType;
            goodsModel.GoodsName = addGoodRequest.GoodsName;
            goodsModel.GoodsBrief = addGoodRequest.GoodsBrief;
            goodsModel.GoodsIntro = addGoodRequest.GoodsIntro;
            goodsModel.MarketPrice = addGoodRequest.MarketPrice;
            goodsModel.SalePrice = addGoodRequest.SalePrice;
            goodsModel.CostPrice = addGoodRequest.CostPrice;
            goodsModel.BrowseCount = addGoodRequest.BrowseCount;
            goodsModel.CommentCount = addGoodRequest.CommentCount;
            goodsModel.CollectCount = addGoodRequest.CollectCount;
            goodsModel.ShareCount = addGoodRequest.ShareCount;
            goodsModel.PutawayTime = addGoodRequest.PutawayTime;
            goodsModel.GoodsState = addGoodRequest.GoodsState;
            goodsModel.Status = 1;
            goodsModel.CreateTime = DateTime.Now;
            goodsModel.UpdateTime = DateTime.Now;
            goodsModel.CreaterId = 0;
            goodsModel.UpdaterId = 0;
            var ser = dal.GoodAdd(goodsModel);
            if (ser>0)
            {
                addGoodResponse.IsSuccess = true;
            }
            else
            {
                addGoodResponse.Status = -1;
                addGoodResponse.Msg = "添加失败";
                return addGoodResponse;
            }
            return addGoodResponse;
        }
        
        /// <summary>
        /// 商品显示
        /// </summary>
        /// <returns></returns>
        public GoodsAddResponse GoodsShow(GoodsAddRequest goodsAddRequest)
        {
            GoodsAddResponse goodsAddResponse = new GoodsAddResponse();
            var ser = dal.GoodsShow();
            if (ser!=null)
            {
                goodsAddResponse.goods = ser;
                goodsAddResponse.IsSuccess = true;
            }
            else
            {
                goodsAddResponse.Status = -1;
                goodsAddResponse.Msg = "显示失败";
            }
            return goodsAddResponse;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UpdateGoodsResponse GoodsDelete(UpdateGoodsRequest updateGoodsRequest)
        {
            UpdateGoodsResponse updateGoodsResponse = new UpdateGoodsResponse();
            if (updateGoodsRequest.GoodId==1)
            {
                updateGoodsResponse.Status = -1;
                updateGoodsResponse.Msg = "id为空";
                return updateGoodsResponse;
            }
            var ser = dal.GoodsDelete(updateGoodsRequest.GoodId);
            if (ser>0)
            {
                updateGoodsResponse.IsSuccess = true;
            }
            else
            {
                updateGoodsResponse.Status = -1;
                updateGoodsResponse.Msg = "修改失败";
            }
            return updateGoodsResponse;
        }
        /// <summary>
        /// 商品审核通过
        /// </summary>
        /// <param name="goodsPutawayRequest"></param>
        /// <returns></returns>
        public GoodsPutawayResponse GoodsPutaway(GoodsPutawayRequest goodsPutawayRequest)
        {
            GoodsPutawayResponse goodsPutawayResponse = new GoodsPutawayResponse();
            if (goodsPutawayRequest.GoodId==0)
            {
                goodsPutawayResponse.GoodsState = -1;
                goodsPutawayResponse.Msg = "id为空";
                return goodsPutawayResponse;
            }
            var ser = dal.GoodsPutaway(goodsPutawayRequest.GoodId);
            if (ser>0)
            {
                goodsPutawayResponse.IsSuccess = true;
            }
            else
            {
                goodsPutawayResponse.GoodsState = -1;
                goodsPutawayResponse.Msg = "修改失败";
            }
            return goodsPutawayResponse;
        }
        /// <summary>
        /// 商品审核未通过
        /// </summary>
        /// <param name="goodsPutawayRequest"></param>
        /// <returns></returns>
        public GoodsSoldOutResponse GoodsSold(GoodsSoldOutRequest goodsSoldOutRequest)
        {
            GoodsSoldOutResponse goodsSoldOutResponse = new GoodsSoldOutResponse();
            if (goodsSoldOutRequest.GoodId == 0)
            {
                goodsSoldOutResponse.GoodsState = -1;
                goodsSoldOutResponse.Msg = "id为空";
                return goodsSoldOutResponse;
            }
            var ser = dal.GoodsPutaway(goodsSoldOutRequest.GoodId);
            if (ser > 0)
            {
                goodsSoldOutResponse.IsSuccess = true;
            }
            else
            {
                goodsSoldOutResponse.GoodsState = -1;
                goodsSoldOutResponse.Msg = "修改失败";
            }
            return goodsSoldOutResponse;
        }

        /// <summary>
        /// 显示要添加的审核商品
        /// </summary>
        /// <param name="auditShowRequest"></param>
        /// <returns></returns>
        public AuditShowResponse GoodsAudit(AuditShowRequest auditShowRequest)
        {
            AuditShowResponse auditShowResponse = new AuditShowResponse();
            var ser = dal.GoodsAudit();
            if (ser!=null)
            {
                auditShowResponse.DateList = ser;
                auditShowResponse.IsSuccess = true;
            }
            else
            {
                auditShowResponse.Status = -1;
                auditShowResponse.Msg = "显示失败";
            }
            return auditShowResponse;
        }
    }
}
