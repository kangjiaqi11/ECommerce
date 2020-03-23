
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
    /// <summary>
    ///用户登录的返回值
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public class BUserLoginResponse:BaseResponse
    {
        /// <summary>
        ///返回一条数据 比如说查询一条消息
        /// </summary>
        public int Info { get; set; }
    }
}
