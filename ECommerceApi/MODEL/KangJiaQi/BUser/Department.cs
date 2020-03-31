using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    /// <summary>
    /// 部门表
    /// </summary>
   public class Department
    {
        /// <summary>
        /// 部门id
        /// </summary>
        public long DepartmentId   { get; set; }
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
        public DateTime CreateTime { get; set; }
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
