using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDCKClient;
using Dal;
using MODEL;
namespace BLL.KangJiaQi
{
    /// <summary>
    /// 菜单bll'
    /// </summary>
   public class MenusBll
    {
        MenusDal MenusDal = new MenusDal();
        /// <summary>
        /// 菜单显示
        /// </summary>
        /// <returns></returns>
        public MenusResponse MenusShow(MenusRequest menusRequest)
        {
            MenusResponse menusResponse = new MenusResponse();
            var ser = MenusDal.MenusShow(menusRequest.Userid);
            if (ser!=null)
            {
                menusResponse.DateList = ser;
                menusResponse.IsSuccess = true;
            }
            else
            {
                menusResponse.Status = -1;
                menusResponse.Msg = "显示失败";
                return menusResponse;
            }
            return menusResponse;

        }
    }
}
