using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    /// <summary>
    /// 菜单表
    /// </summary>
   public class MenusInfo
    {
        /// <summary>
        /// 菜单id
        /// </summary>
        public long MenusId   { get; set; }
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
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CeateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public long CreateId { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public long UpdateId { get; set; }
    }
}
