using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using SDCKClient.WangZhiHao.Request;
using SDCKClient.XuYaDon;

namespace ECommerceMVC
{
    public class GoodsShowController : Controller
    {
        BGoodsBll goodsBll = new BGoodsBll();
        // GET: GoodsShow
        public ActionResult GoodsShow()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GoodsShow(GoodsAddRequest goods)
        {
            var res = goodsBll.GoodsAdd(goods,"api/Goods/GoodsShow");
            return Json(res.goods);
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
    }
}