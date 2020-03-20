using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.KangJiaQi.BUser
{
    /// <summary>
    /// 菜单表
    /// </summary>
   public class MenusInfo
    {
        /// <summary>
        /// 菜单id
        /// </summary>
        public int  MenusId   { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string  MenusName { get; set; }
        /// <summary>
        /// 菜单Url
        /// </summary>
        public string MenusUrl { get; set; }
        /// <summary>
        /// 父级地址
        /// </summary>
        public string FatherUrl { get; set; }
    }
}
