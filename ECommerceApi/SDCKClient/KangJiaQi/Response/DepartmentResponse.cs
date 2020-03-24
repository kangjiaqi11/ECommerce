using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace SDCKClient
{
   public class DepartmentResponse:BaseResponse
    {
        /// <summary>
        /// 返回一个集合 比如下课绑定
        /// </summary>
        public List<Department> DateList { get; set; }
    }
}
