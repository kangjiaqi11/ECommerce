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
        public OrderShowResponse OrderShow(OrderShowrequeset order,string UrlName)
        {
            return ApiRequestHelper.Post<OrderShowrequeset,OrderShowResponse>(order,UrlName);
        }
    }
}
