using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MODEL;
using System.Threading.Tasks;
namespace SDCKClient
{
    /// <summary>
    /// 返回用户的值
    /// </summary>
   public class GetUserNameResponse:BaseResponse
    {
        /// <summary>
        /// 用户名 随机数
        /// </summary>
        public UserInfo  info { get; set; }
    }
}
