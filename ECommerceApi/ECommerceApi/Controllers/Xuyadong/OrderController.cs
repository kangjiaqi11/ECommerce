using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.XuYaDon;
using SDCKClient.XuYaDon;
namespace ECommerceApi.Controllers.Xuyadong
{
    public class OrderController : ApiController
    {
        OrderBll bll = new OrderBll();
        
        public OrderShowResponse OrderShow(OrderShowrequeset order)
        {
            return bll.OrderShow(order);
        }
        /// <summary>
        /// 修改订单状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderShowResponse UpdateState(OrderStaterequest order)
        {
            return bll.UpdateState(order);
        }
        /// <summary>
        /// 显示待发货信息
        /// </summary>
        /// <returns></returns>
        public ExperShowresponse expressShow()
        {
            return bll.expressShow();

        }
        /// <summary>
        /// 快递绑定下拉
        /// </summary>
        /// <rereturns>
        public ExperBindresponse ExperBind()
        {
            return bll.ExperBind();
        }
        /// <summary>
        /// 修改状态发货
        /// </summary>
        public UpdateStateExperresponse UpdateStateExper(UpdateStateExperrequest update)
        {
            return bll.UpdateStateExper(update);
        }
        /// <summary>
        /// 显示订单详情
        /// </summary>
        /// <rereturns>
        public ShowOrderALLresponse ShowOrderALL(ShowOrderALLrequest show)
        {
            return bll.ShowOrderALL(show);
        }
        /// <summary>
        /// 确定收货
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public TakeGoodrespnse TakeGood(TakeGoodRequest take)
        {
            return bll.TakeGood(take);
        }
        /// <summary>
        /// 退货申请表
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public ReturnGoodsResponse ReturnGoods(ReturnGoodsRequest returnGoods)
        {
            return bll.ReturnGoods(returnGoods);
        }
        ///退户详细显示
        ///
        public ReturnShenresponse shenReturns(ReturnShenReuqest returnShen)
        {
            return bll.shenReturns(returnShen);
        }
        /// <summary>
        /// 确定收货拒绝收货
        /// </summary>
        public UpdateReturnResponse UpdateRetutn(UpdateReturnRequest updateReturn)
        {
            return bll.UpdateRetutn(updateReturn);
        }
    }
}
