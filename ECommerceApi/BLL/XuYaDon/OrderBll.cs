using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using SDCKClient.XuYaDon;
using MODEL.XuYaDon;
namespace BLL.XuYaDon
{
    /// <summary>
    /// 订单显示BLL
    /// </summary>
    public class OrderBll
    {
        OrderDal dal = new OrderDal();
        /// <summary>
        /// 订单的显示
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public OrderShowResponse OrderShow(OrderShowrequeset order)
        {



            OrderShowResponse orderShowResponse = new OrderShowResponse();
            var res = dal.OrderShow(order.OrderNumberGoodsName, order.AddrNameAddrPhone, order.State, order.puttime,order.Endtime,order.pageindex, order.pagesize);

            if (res != null)
            {

                orderShowResponse.Datalist = res.list;
                orderShowResponse.totalcount = res.totalcount;
                orderShowResponse.IsSuccess = true;

            }
            else
            {
                orderShowResponse.Msg = "显示失败";
                orderShowResponse.Status = -1;
            }
            return orderShowResponse;
        }
        /// <summary>
        /// 修改订单状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderStateresponse UpdateState(OrderStaterequest order)
        {
            OrderStateresponse response = new OrderStateresponse();
            var res = dal.UpdateState(order.id,order.State);
            if (res > 0)
            {
                response.Msg = "修改成功";
                response.IsSuccess = true;
            }
            else
            {
                response.Msg = "修改失败";
                response.IsSuccess = false;
            }
            return response;
        }

        /// <summary>
        /// 显示待发货信息
        /// </summary>
        /// <returns></returns>
        public ExperShowresponse expressShow()
        {
            ExperShowresponse exper = new ExperShowresponse();
            var res = dal.expressShow();
            if (res != null)
            {
                exper.Datalist = res;
                exper.Msg = "显示成功";
                exper.IsSuccess = true;
            }
            else
            {
                exper.Msg = "显示失败";
                exper.IsSuccess = false;
            }
            return exper;

        }
        /// <summary>
        /// 快递绑定下拉
        /// </summary>
        /// <rereturns>
        public ExperBindresponse ExperBind()
        {
            ExperBindresponse exper = new ExperBindresponse();
            var res = dal.ExperBind();
            if (res != null)
            {
                exper.Datalist = res;
                exper.IsSuccess = true;

            }
            else
            {
                exper.Msg = "绑定失败";
                exper.IsSuccess = true;
            }
            return exper;
        }
        /// <summary>
        /// 修改状态发货
        /// </summary>
        public UpdateStateExperresponse UpdateStateExper(UpdateStateExperrequest update)
        {
            UpdateStateExperresponse updateState = new UpdateStateExperresponse();
            var res = dal.UpdateStateExper(update.OderNumber,update.experId);
            if (res > 0)
            {
                updateState.Msg = "发货成功!";
                updateState.IsSuccess = true;

            }
            else
            {
                updateState.Msg = "发货异常!";
                updateState.IsSuccess = false;

            }
            return updateState;
        }
        /// <summary>
        /// 显示订单详情
        /// </summary>
        /// <rereturns>
        public ShowOrderALLresponse ShowOrderALL(ShowOrderALLrequest show)
        {
            ShowOrderALLresponse showOrder = new ShowOrderALLresponse();
            var res = dal.ShowOrderALL(show.OderNumber);
            if (res != null)
            {
                showOrder.Datalist = res;
                showOrder.IsSuccess = true;

            }
            else
            {
                showOrder.Msg = "显示";
                showOrder.IsSuccess = true;
            }
            return showOrder;
        }
        /// <summary>
        /// 确定收货
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public TakeGoodrespnse TakeGood(TakeGoodRequest take)
        {
            TakeGoodrespnse takeGoodrespnse = new TakeGoodrespnse();
            var res = dal.TakeGood(take.OrderNumberGoodsName, take.AddrNameAddrPhone, take.puttime, take.endtimes,take.pageindex, take.pagesize);

            if (res != null)
            {

                takeGoodrespnse.Datalist = res.Datalist;
                takeGoodrespnse.totalcount = res.totalcount;
                takeGoodrespnse.IsSuccess = true;

            }
            else
            {
                takeGoodrespnse.Msg = "显示失败";
                takeGoodrespnse.Status = -1;
            }
            return takeGoodrespnse;
        }
        /// <summary>
        /// 退货申请表
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public ReturnGoodsResponse ReturnGoods(ReturnGoodsRequest returnGoods)
        {
            ReturnGoodsResponse returngoodsresponse = new ReturnGoodsResponse();
            var res = dal.ReturnGoods(returnGoods.OrderNumber, returnGoods.AddrPhone, returnGoods.State,returnGoods.puttime,returnGoods.endtimes,returnGoods.pageindex, returnGoods.pagesize);

            if (res != null)
            {

                returngoodsresponse.Datalist = res.list;
                returngoodsresponse.totalcount = res.totalcount;
                returngoodsresponse.IsSuccess = true;

            }
            else
            {
                returngoodsresponse.Msg = "显示失败";
                returngoodsresponse.Status = -1;
            }
            return returngoodsresponse;
        }
        ///退户详细显示
        ///
        public ReturnShenresponse shenReturns(ReturnShenReuqest returnShen)
        {
            ReturnShenresponse shen = new ReturnShenresponse();
            var res = dal.shenReturns(returnShen.id);
            if (res!=null)
            {
                shen.list = res;
                shen.IsSuccess = true;
            }
            else
            {
                shen.Msg = "显示失败";
                shen.Status = -1;
            }
            return shen;
        }
        /// <summary>
        /// 确定收货拒绝收货
        /// </summary>
        public UpdateReturnResponse UpdateRetutn(UpdateReturnRequest updateReturn)
        {
            UpdateReturnResponse update = new UpdateReturnResponse();
            var res = dal.UpdateRetutn(updateReturn.state, updateReturn.Id);
            if (updateReturn.state<4)
            {
                update.Status = 1;
                update.Msg = "收货成功";
                update.IsSuccess = true;
            }
            else
            {
                update.Status = 2;
                update.Msg = "拒绝成功";
            }
            return update;
        }
        /// <summary>
        /// 退货设置显示
        /// </summary>
        /// <param name="typeRequest"></param>
        /// <returns></returns>
        public ReturnTypeResponse returnType()
        {
            ReturnTypeResponse Type = new ReturnTypeResponse();
            var res = dal.retutnTypes();
            if (res != null)
            {
                Type.list = res;
                Type.Status = 1;
                Type.Msg = "显示成功";
                Type.IsSuccess = true;
            }
            else
            {
                Type.Status = -1;
                Type.Msg = "显示失败";
            }
            return Type;
        }
        /// <summary>
        /// 退货删除操作
        /// </summary>
        /// <returns></returns>
        public UpdateReturnRespnse Updatereturntype(UpadteReturnTypeRequest request)
        {
            UpdateReturnRespnse returnType = new UpdateReturnRespnse();
            var res = dal.DeleteType(request.Id);
            if (res>0)
            {
                returnType.IsSuccess = true;
                returnType.Msg = "删除成功";
            }
            else
            {
                returnType.IsSuccess = false;
                returnType.Msg = "删除失败";
            }
            return returnType;
        }

    }


}


