using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using SDCKClient.XuYaDon;

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
            var res = dal.OrderShow(order.OrderNumber="", order.GoodsName="", order.AddrName="", order.AddrPhone="", order.State, order.puttime="", order.pageindex=1, order.pagesize=8);
            if (res!=null)
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
    }
}
