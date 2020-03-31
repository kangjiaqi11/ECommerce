using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
    /// <summary>
    /// 显示个人信息
    /// </summary>
   public class personageRequest:BaseRequest
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public int UserId { get; set; }
    }
}
