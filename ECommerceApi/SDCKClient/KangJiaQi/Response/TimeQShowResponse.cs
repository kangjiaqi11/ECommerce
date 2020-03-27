using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace SDCKClient
{
    /// <summary>
    /// 时间段的时间的返回值
    /// </summary>
   public class TimeQShowResponse:BaseResponse
    {
        /// <summary>
        /// 时间段集合
        /// </summary>
        public List<TimeQ> DateList { get; set; }
    }
}
