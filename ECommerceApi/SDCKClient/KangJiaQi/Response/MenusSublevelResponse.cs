using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace SDCKClient
{
    /// <summary>
    /// 菜单子级显示
    /// </summary>
   public class MenusSublevelResponse:BaseResponse
    {
        /// <summary>
        /// 时间段集合
        /// </summary>
        public List<MenusInfo> DateList { get; set; }
    }
}
