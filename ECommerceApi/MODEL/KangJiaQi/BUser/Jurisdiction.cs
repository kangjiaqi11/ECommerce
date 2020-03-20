using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.KangJiaQi.BUser
{
    /// <summary>
    /// 权限表
    /// </summary>
   public class Jurisdiction
    {
        /// <summary>
        /// 权限id
        /// </summary>
        public int  JurisdictionId  { get; set; }
        /// <summary>
        /// 部门id
        /// </summary>
        public int  DepartmentId    { get; set; }
        /// <summary>
        ///菜单id
        /// </summary>
        public int  MenusId         { get; set; }
    }
}
