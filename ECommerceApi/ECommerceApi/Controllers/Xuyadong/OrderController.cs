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
    }
}
