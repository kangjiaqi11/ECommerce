using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDCKClient.XuYaDon;
namespace BLL.XuYaDon
{
   public class OrderShowBll
    {
        /// <summary>
        /// 订单显示
        /// </summary>
        /// <param name="order"></param>
        /// <param name="UrlName"></param>
        /// <returns></returns>
        public OrderShowResponse OrderShow(OrderShowrequeset order,string UrlName)
        {
            return ApiRequestHelper.Post<OrderShowrequeset,OrderShowResponse>(order,UrlName);
        }


        public OrderStateresponse UpdateState(OrderStaterequest order,string UrlName)
        {
            return ApiRequestHelper.Post<OrderStaterequest, OrderStateresponse>(order, UrlName);

        }
        public ExperShowresponse expressShow(ExperShowrequeset exper, string UrlName)
        {
            return ApiRequestHelper.Post<ExperShowrequeset, ExperShowresponse>(exper, UrlName);

        }
        /// <summary>
        /// 快递绑定下拉
        /// </summary>
        /// <rereturns>
        public ExperBindresponse ExperBind(ExperBindrequeset exper,string UrlName)
        {
            return ApiRequestHelper.Post<ExperBindrequeset, ExperBindresponse>(exper, UrlName);
        }
        /// <summary>
        /// 修改状态发货
        /// </summary>
        public UpdateStateExperresponse UpdateStateExper(UpdateStateExperrequest update,string UrlName)
        {
            return ApiRequestHelper.Post<UpdateStateExperrequest, UpdateStateExperresponse>(update, UrlName);
        }
        /// <summary>
        /// 显示详情
        /// </summary>
        /// <rereturns>
        public ShowOrderALLresponse ShowOrderALL(ShowOrderALLrequest  show, string UrlName)
        {
            return ApiRequestHelper.Post<ShowOrderALLrequest, ShowOrderALLresponse>(show, UrlName);
        }
        /// <summary>
        /// 订单显示
        /// </summary>
        /// <param name="order"></param>
        /// <param name="UrlName"></param>
        /// <returns></returns>
        public TakeGoodrespnse TakeGood(TakeGoodRequest  take, string UrlName)
        {
            return ApiRequestHelper.Post<TakeGoodRequest, TakeGoodrespnse>(take, UrlName);
        }
        /// <summary>
        /// 退货申请表
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public ReturnGoodsResponse ReturnGoods(ReturnGoodsRequest returnGoods, string UrlName)
        {
            return ApiRequestHelper.Post<ReturnGoodsRequest, ReturnGoodsResponse>(returnGoods, UrlName);
        }
        ///退户详细显示
        ///
        public ReturnShenresponse shenReturns(ReturnShenReuqest returnShen, string UrlName)
        {
            return ApiRequestHelper.Post<ReturnShenReuqest,ReturnShenresponse>(returnShen,UrlName);
        }
        /// <summary>
        /// 确定收货拒绝收货
        /// </summary>
        public UpdateReturnResponse UpdateRetutn(UpdateReturnRequest updateReturn, string UrlName)
        {
             return ApiRequestHelper.Post<UpdateReturnRequest, UpdateReturnResponse>(updateReturn, UrlName);
        }
        /// <summary>
        /// 退货设置显示
        /// </summary>
        /// <param name="typeRequest"></param>
        /// <returns></returns>
        public ReturnTypeResponse returnType(ReturnTypeRequest request,string UrlName)
        {
            return ApiRequestHelper.Post<ReturnTypeRequest, ReturnTypeResponse>(request, UrlName);
        }

    }
}
