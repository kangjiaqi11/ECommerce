using MODEL;
using Dal.WangZhiHao;
using SDCKClient;
using SDCKClient.WangZhiHao.Response;
using SDCKClient.WangZhiHao.Request;

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
            goodsModel.GoodId = addGoodRequest.GoodId;
            goodsModel.BrandId = addGoodRequest.BrandId;
            goodsModel.CategoryId = addGoodRequest.CategoryId;
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
            goodsModel.CreateTime = addGoodRequest.CreateTime;
            goodsModel.UpdateTime = addGoodRequest.UpdateTime;
            goodsModel.CreaterId = addGoodRequest.CreaterId;
            goodsModel.UpdaterId = addGoodRequest.UpdaterId;
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
                updateGoodsResponse.Msg = "名称不能为空";
                return updateGoodsResponse;
            }
            if (updateGoodsRequest.GoodsState ==1 )
            {
                updateGoodsResponse.Status = 2;
                updateGoodsResponse.Msg = "审核不通过";
                return updateGoodsResponse;
            }
            if (updateGoodsRequest.PutawayTime == null)
            {
                updateGoodsResponse.Status = -1;
                updateGoodsResponse.Msg = "上架时间不能为空";
                return updateGoodsResponse;
            }
            GoodsModel goodsModel = new GoodsModel();
            goodsModel.GoodId = updateGoodsRequest.GoodId;
            goodsModel.BrandId = updateGoodsRequest.BrandId;
            goodsModel.CategoryId = updateGoodsRequest.CategoryId;
            goodsModel.GoodsType = updateGoodsRequest.GoodsType;
            goodsModel.GoodsName = updateGoodsRequest.GoodsName;
            goodsModel.GoodsBrief = updateGoodsRequest.GoodsBrief;
            goodsModel.GoodsIntro = updateGoodsRequest.GoodsIntro;
            goodsModel.MarketPrice = updateGoodsRequest.MarketPrice;
            goodsModel.SalePrice = updateGoodsRequest.SalePrice;
            goodsModel.CostPrice = updateGoodsRequest.CostPrice;
            goodsModel.BrowseCount = updateGoodsRequest.BrowseCount;
            goodsModel.CommentCount = updateGoodsRequest.CommentCount;
            goodsModel.CollectCount = updateGoodsRequest.CollectCount;
            goodsModel.ShareCount = updateGoodsRequest.ShareCount;
            goodsModel.PutawayTime = updateGoodsRequest.PutawayTime;
            goodsModel.GoodsState = updateGoodsRequest.GoodsState;
            goodsModel.Status = 1;
            goodsModel.CreateTime = updateGoodsRequest.CreateTime;
            goodsModel.UpdateTime = updateGoodsRequest.UpdateTime;
            goodsModel.CreaterId = updateGoodsRequest.CreaterId;
            goodsModel.UpdaterId = updateGoodsRequest.UpdaterId;
            
            return updateGoodsResponse;
        }
    }
}
