using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDCKClient;
using Dal;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 菜单bll'
    /// </summary>
   public class MenusBll
    {
        #region 菜单相关显示
        MenusDal MenusDal = new MenusDal();
        /// <summary>
        /// 菜单显示
        /// </summary>
        /// <returns></returns>
        public MenusResponse MenusShow(MenusRequest menusRequest)
        {
            MenusResponse menusResponse = new MenusResponse();
            var ser = MenusDal.MenusShow(menusRequest.Userid);
            if (ser != null)
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
        /// <summary>
        /// 菜单子级的显示
        /// </summary>
        /// <param name="menusRequest"></param>
        /// <returns></returns>
        public MenusSublevelResponse MenusSublevel(MenusSublevelRequest menusSublevelRequest)
        {
            MenusSublevelResponse menusSublevelResponse = new MenusSublevelResponse();
            var ser = MenusDal.MenusSublevel(menusSublevelRequest.FatherUrl);
            if (ser != null)
            {
                menusSublevelResponse.DateList = ser;
                menusSublevelResponse.IsSuccess = true;
            }
            else
            {
                menusSublevelResponse.Status = -1;
                menusSublevelResponse.Msg = "显示失败";
                return menusSublevelResponse;
            }
            return menusSublevelResponse;
        } 
        #endregion
    }
}
