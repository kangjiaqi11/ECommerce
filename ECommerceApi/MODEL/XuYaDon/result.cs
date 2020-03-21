using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.XuYaDon
{
    /// <summary>
    /// 处理结果信息
    /// </summary>
   public class result
    {
        public int ReturnId      { get; set; }
        public string disposeName   { get; set; }
        public DateTime disposeTime   { get; set; }
        public string disposeRemark { get; set; }
    }
}
