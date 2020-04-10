using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using SDCKClient.WangZhiHao.Request;
using MODEL;
using SDCKClient.XuYaDon;
using SDCKClient;
namespace ECommerceMVC
{
    public class GoodsShowController : Controller
    {
        BGoodsBll goodsBll = new BGoodsBll();
        promotionBll promotionBll = new promotionBll();
        // GET: GoodsShow
        public ActionResult GoodsShow()
        {
            return View();
        }
        [HttpPost]
        public JsonResult ActiviryGoodShow()
        {
            ActivityGoodShowRequest activityGoodShowRequest = new ActivityGoodShowRequest();
            var ser = promotionBll.ActivityGoodShow(activityGoodShowRequest, "api/Promotion/ActivityGoodShow");
            return Json(ser.DateList);
        }

        //添加
        public ActionResult GoodsAdd()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GoodsAdd(GoodsModel goods)
        {
            AddGoodRequest goodAdd = new AddGoodRequest();
            goodAdd.BrandId = goods.BrandId;
            goodAdd.GoodsName = goods.GoodsName;
            goodAdd.SalePrice = goods.SalePrice;
            goodAdd.GoodsState = goods.GoodsState;
            goodAdd.GoodsBrief = goods.GoodsBrief;
            var res = goodsBll.GoodsAdd(goodAdd, "api/Goods/GoodAdd");
            return Json(res);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="goodsupdate"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GoodsDelete(int GoodId)
        {
            UpdateGoodsRequest updateGoodsRequest = new UpdateGoodsRequest();
            updateGoodsRequest.GoodId = GoodId;
            var ser = goodsBll.GoodsDelete(updateGoodsRequest, "api/Goods/GoodsDelete");
            return Json(ser.IsSuccess);
        }
        /// <summary>
        /// 商品审核页面
        /// </summary>
        /// <returns></returns>
        public ActionResult audit()
        {
            return View();
        }

        /// <summary>
        /// 商品审核通过
        /// </summary>
        /// <param name="GoodId"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GoodsPutaway(int GoodId)
        {
            GoodsPutawayRequest goodsPutawayRequest = new GoodsPutawayRequest();
            goodsPutawayRequest.GoodId = GoodId;
            var ser = goodsBll.GoodsPutaway(goodsPutawayRequest, "api/Goods/GoodsPutaway");
            return Json(ser.IsSuccess);
        }

        /// <summary>
        /// 商品审核未通过
        /// </summary>
        /// <param name="GoodId"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GoodsSold(int GoodId)
        {
            GoodsSoldOutRequest goodsSoldOutRequest = new GoodsSoldOutRequest();
            goodsSoldOutRequest.GoodId = GoodId;
            var ser = goodsBll.GoodsSold(goodsSoldOutRequest, "api/Goods/GoodsSold");
            return Json(ser.IsSuccess);
        }

        /// <summary>
        /// 显示要添加的审核商品
        /// </summary>
        /// <param name="auditShowRequest"></param>
        /// <returns></returns>
        public JsonResult GoodsAudit()
        {
            AuditShowRequest auditShowRequest = new AuditShowRequest();
            var ser = goodsBll.GoodsAudit(auditShowRequest, "api/Goods/GoodsAudit");
            return Json(ser.DateList);
        }

    }
}