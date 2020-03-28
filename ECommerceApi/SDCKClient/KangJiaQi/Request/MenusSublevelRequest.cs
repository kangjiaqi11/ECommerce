using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
    /// <summary>
    /// 菜单子级显示
    /// </summary>
   public class MenusSublevelRequest:BaseRequest
    {
        /// <summary>
        /// 父级id
        /// </summary>
        public int FatherUrl { get; set; }
    }
}
