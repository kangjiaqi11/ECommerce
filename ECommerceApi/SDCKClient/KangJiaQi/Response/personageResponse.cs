using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace SDCKClient
{
    /// <summary>
    /// 个人信息返回值
    /// </summary>
   public class personageResponse:BaseResponse
    {
        /// <summary>
        /// 返回集合
        /// </summary>
        public UserInfo info { get; set; }
    }
}
