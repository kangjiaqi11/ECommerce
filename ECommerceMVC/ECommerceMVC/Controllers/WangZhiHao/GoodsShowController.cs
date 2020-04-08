using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using SDCKClient.WangZhiHao.Request;
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
        public JsonResult GoodsAdd(GoodsAddRequest goodsAdd)
        {
            var res = goodsBll.GoodsAdd(goodsAdd, "api/Goods/GoodAdd");
            return Json(res.goods);
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