using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SDCKClient;
using BLL;
namespace ECommerceApi
{
    /// <summary>
    /// 菜单子级显示
    /// </summary>
    public class MenusController : ApiController
    {
        MenusBll MenusBll = new MenusBll();
        /// <summary>
        /// 菜单显示
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public MenusResponse MenusShow(MenusRequest menusRequest)
        {
            return MenusBll.MenusShow(menusRequest);

        }
        /// <summary>
        /// 菜单子级的显示
        /// </summary>
        /// <param name="menusRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public MenusSublevelResponse MenusSublevel(MenusSublevelRequest menusSublevelRequest)
        {
            return MenusBll.MenusSublevel(menusSublevelRequest);
        }
    }
}
