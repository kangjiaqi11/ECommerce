using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using Dal.WangZhiHao;
using SDCKClient;
using Common;
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
        public int GoodsDelete(int id)
        {
            return dal.GoodsDelete(id);
        }
    }
}
