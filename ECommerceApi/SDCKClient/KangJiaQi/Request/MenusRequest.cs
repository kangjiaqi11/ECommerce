using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
   public class MenusRequest:BaseRequest
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public int Userid  { get; set; }
    }
}
