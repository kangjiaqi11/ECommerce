using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SDCKClient.ZhangYang.Request;
using SDCKClient.ZhangYang.Response;
using BLL.ZhangYang;

namespace ECommerceMVC.Controllers.ZhangYang
{
    public class StoController : Controller
    {
        StoreroomBLL bll = new StoreroomBLL();
        // GET: Sto
        public ActionResult StoreroomFenye(int PageIndex=1, int PageSize=2, string ShoopName=null)
        {
            StoreroomShowReq Ssr = new StoreroomShowReq();

            var ser = bll.StoreroomFenye(Ssr, "api/Sto/StoreroomFenye");
            return View(ser.StoList);
        }
        public ActionResult StoreroomRu(int PageIndex = 1, int PageSize = 2, string ShoopName = null)
        {
            StoreroomShowReq Ssr = new StoreroomShowReq();

            var ser = bll.StoreroomFenye(Ssr, "api/Sto/StoreroomFenye");
            return View(ser.StoList);
        }
    }
    public class ForController : Controller
    {
        FrontUserBLL bll = new FrontUserBLL();

        public ActionResult FrontUserFenye(int PageIndex = 1, int PageSize = 2, string UserName = null)
        {
            FrontUserShowReq Ssr = new FrontUserShowReq();

            var ser = bll.FrontUserFenye(Ssr, "api/Sto/StoreroomFenye");
            return View(ser.Frolist);
        }
    }
}