using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
    /// <summary>
    /// 获取用户名参数
    /// </summary>
   public class GetUserNameRequest:BaseRequest
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public int UserId { get; set; }
    }
}
