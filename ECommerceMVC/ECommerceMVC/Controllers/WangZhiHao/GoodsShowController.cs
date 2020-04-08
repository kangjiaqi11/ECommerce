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

        public ActionResult GoodsDelete()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GoodsDelete(UpdateGoodsRequest goodsupdate)
        {
            var res = goodsBll.GoodsDelete(goodsupdate, "api/Goods/GoodsDelete");
            return Json(res); 
        }
        /// <summary>
        /// 商品审核页面
        /// </summary>
        /// <returns></returns>
        public ActionResult audit()
        {
            return View();
        }
    }
}