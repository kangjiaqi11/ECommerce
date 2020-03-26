using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.XuYaDon;
using SDCKClient.XuYaDon;
namespace ECommerceMVC.Controllers.XuYaDon
{
    public class OrderController : Controller
    {
        OrderShowBll bll = new OrderShowBll();
        // GET: Order
        public ActionResult Index(OrderShowrequeset order)
        {
            var res = bll.OrderShow(order, "api/Order/OrderShow");
            return View(res.Datalist);
             
        }
    }
}