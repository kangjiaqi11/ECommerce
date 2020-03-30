using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDCKClient;
namespace BLL
{
   public class MenusBll
    {
        /// <summary>
        /// 菜单显示
        /// </summary>
        /// <returns></returns>
        public MenusResponse MenusShow(MenusRequest menusRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<MenusRequest, MenusResponse>(menusRequest,GetApiName);
        }
        /// <summary>
        /// 菜单子级显示
        /// </summary>
        /// <returns></returns>
        public MenusSublevelResponse MenusSublevel( MenusSublevelRequest menusSublevelRequest, string GetApiName)
        {
            return ApiRequestHelper.Post<MenusSublevelRequest, MenusSublevelResponse>(menusSublevelRequest, GetApiName);
        }
    }
}
