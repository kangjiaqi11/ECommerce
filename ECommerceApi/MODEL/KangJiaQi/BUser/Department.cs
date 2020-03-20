using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.KangJiaQi.BUser
{
    /// <summary>
    /// 部门表
    /// </summary>
   public class Department
    {
        /// <summary>
        /// 部门id
        /// </summary>
        public int DepartmentId   { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// 数据状态
        /// </summary>
        public int state { get; set; }
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
        public int CreateId { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public int UpdateId { get; set; }
    }
}
