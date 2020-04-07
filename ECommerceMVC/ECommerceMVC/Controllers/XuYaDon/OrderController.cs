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
        public ActionResult Index()
        {
     
            return View();
             
        }
        [HttpPost]
        public JsonResult Index(OrderShowrequeset order)
        {
            var res = bll.OrderShow(order,"api/Order/OrderShow");
            return Json(res.Datalist);

        }
        public ActionResult ShowOrderALL(string OrderNumber)
        {
            ViewBag.ordernumber = OrderNumber;
            return View();

        }
        [HttpPost]
        /// <summary>
        /// 显示详情
        /// </summary>
        /// <rereturns>
        public JsonResult ShowOrderALL(ShowOrderALLrequest show,string UrlName)
        {
            
            var res= bll.ShowOrderALL(show, "api/Order/ShowOrderALL");
            return Json(res.Datalist);
        }
        [HttpPost]
        public JsonResult UpdateState(OrderStaterequest order, string UrlName)
        {
              var res=bll.UpdateState(order, "api/Order/UpdateState");
            return Json(res);

        }
        public ActionResult expressShow()
        {

            return View();

        }
        /// <summary>
        /// 发货显示
        /// </summary>
        /// <param name="exper"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult expressShow(ExperShowrequeset exper)
        {
            var res= bll.expressShow(exper, "api/Order/expressShow");
            return Json(res.Datalist);

        }
        public ActionResult ExperBind()
        {

            return View();

        }
        [HttpPost]
        /// <summary>
        /// 快递绑定下拉
        /// </summary>
        /// <rereturns>
        public JsonResult ExperBind(ExperBindrequeset exper, string UrlName)
        {
            var res = bll.ExperBind(exper, "api/Order/ExperBind");
            return Json(res.Datalist);
        }
        [HttpPost]
        /// <summary>
        /// 修改状态发货
        /// </summary>
        public JsonResult UpdateStateExper(UpdateStateExperrequest update, string UrlName)
        {
            var res=bll.UpdateStateExper(update, "api/Order/UpdateStateExper");
            return Json(res);
        }
        public ActionResult TakeGood()
        {

            return View();

        }
        [HttpPost]
        /// <summary>
        /// 订单显示
        /// </summary>
        /// <param name="order"></param>
        /// <param name="UrlName"></param>
        /// <returns></returns>
        public JsonResult TakeGood(TakeGoodRequest take, string UrlName)
        {
           var res= bll.TakeGood(take, "api/Order/TakeGood");
            return Json(res.Datalist);
        }
        /// 退货申请表
        public ActionResult ReturnGoods()
        {

            return View();

        }
        [HttpPost]
        /// <summary>
        /// 退货申请表
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public JsonResult ReturnGoods(ReturnGoodsRequest returnGoods, string UrlName)
        {
            var res= bll.ReturnGoods(returnGoods, "api/Order/ReturnGoods");
            return Json(res.Datalist);
        }
        public ActionResult shenReturns(int id)
        {
            ViewBag.id = id;
             return View();

        }
        [HttpPost]
        ///退户详细显示
        ///
        public JsonResult shenReturns(ReturnShenReuqest returnShen,string UrlName)
        {
            var res= bll.shenReturns(returnShen, "api/Order/shenReturns");
            return Json(res.list);
        }
        [HttpPost]
        /// <summary>
        /// 确定收货拒绝收货
        /// </summary>
        public JsonResult UpdateRetutn(UpdateReturnRequest updateReturn, string UrlName)
        {
            var res= bll.UpdateRetutn(updateReturn, "api/Order/UpdateRetutn");
            return Json(res);
        }
        public ActionResult returnType()
        {
         
            return View();

        }
        [HttpPost]
        /// <summary>
        /// 退货设置显示
        /// </summary>
        /// <param name="typeRequest"></param>
        /// <returns></returns>
        public JsonResult returnType(ReturnTypeRequest returnType, string UrlName)
        {
            var res = bll.returnType(returnType, "api/Order/returnType");
            return Json(res.list);
        }
    }
}