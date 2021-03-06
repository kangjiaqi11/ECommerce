﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BLL.ZhangYang;
using SDCKClient.ZhangYang.Request;
using SDCKClient.ZhangYang.Response;
namespace ECommerceMVC.Controllers.ZhangYang
{
    public class StoController : Controller
    {
        StoreroomBLL bll = new StoreroomBLL();
        // GET: Sto
        public ActionResult StoreroomFenye(int PageIndex=1, int PageSize=20, string ShoopName=null)
        {
            StoreroomShowReq Ssr = new StoreroomShowReq();
            Ssr.PageIndex = PageIndex;
            Ssr.PageSize = PageSize;
            Ssr.ShoopName = ShoopName;
            
            var ser = bll.StoreroomFenye(Ssr, "api/Sto/StoreroomFenye");
            return View(ser.StoList);
        }
        public ActionResult StoreroomRu(int PageIndex = 1, int PageSize = 20, string ShoopName = null)
        {
            StoreroomShowReq Ssr = new StoreroomShowReq();
            Ssr.PageIndex = PageIndex;
            Ssr.PageSize = PageSize;
            Ssr.ShoopName = ShoopName;

            var ser = bll.StoreroomFenye(Ssr, "api/Sto/StoreroomFenye");
            return View(ser.StoList);
        }
    }
    public class ForController : Controller
    {
        FrontUserBLL bll = new FrontUserBLL();

        public ActionResult FrontUserFenye(int PageIndex = 1, int PageSize = 20, string UserName = null)
        {
            FrontUserShowReq Ssr = new FrontUserShowReq();
            Ssr.PageIndex = PageIndex;
            Ssr.PageSize = PageSize;
            Ssr.UserName = UserName;

            var ser = bll.FrontUserFenye(Ssr, "api/Fro/FrontUserFenye");
            return View(ser.Frolist);
        }

        //详情1//详情2
        public ActionResult FrontUserShow1()
        {

            FrontUserShow1Req Ssr = new FrontUserShow1Req();
            FrontUserShow2Req Ssrr = new FrontUserShow2Req();

            var ser = bll.FrontUserShow1(Ssr, "api/Fro/FrontUserShow1");
            var serr = bll.FrontUserShow2(Ssrr, "api/Fro/FrontUserShow2");
            
            return View(ser.FrontUser1);  
        }
        public JsonResult show2()
        {
            FrontUserShow2Req Ssrr = new FrontUserShow2Req();


            var serr = bll.FrontUserShow2(Ssrr, "api/Fro/FrontUserShow2");
            return Json(serr.FrontUser2);
        }
    }
    public class MemController : Controller
    {
        MemberBLL bll = new MemberBLL();

        public ActionResult MemberShow()
        {
            MemberShowReq Ssr = new MemberShowReq();

            var ser = bll.MemberShow(Ssr, "api/Fro/MemberShow");
            return View(ser.Members);
        }
    }
}