using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
    /// <summary>
    /// 锁屏返回值
    /// </summary>
   public class LockedResponse:BaseResponse
    {
        /// <summary>
        ///登录成功
        /// </summary>
        public int GetLockedrow { get; set; }
    }
}
