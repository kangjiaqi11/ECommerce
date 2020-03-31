using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace SDCKClient
{
    /// <summary>
    ///部门显示返回值
    /// </summary>
   public class DepartmentResponse:BaseResponse
    {
        /// <summary>
        /// 返回一个集合 
        /// </summary>
        public List<Department> DateList { get; set; }
    }
}
