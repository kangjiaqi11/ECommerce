using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using SDCKClient;

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
        public ActionResult Goods()
        {
            return View();
        }
        
    }
}