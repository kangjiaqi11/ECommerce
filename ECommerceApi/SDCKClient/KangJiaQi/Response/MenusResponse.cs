using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace SDCKClient
{
   public class MenusResponse:BaseResponse
    {
        /// <summary>
        /// 时间段集合
        /// </summary>
        public List<Jurisdiction> DateList { get; set; }
    }
}
