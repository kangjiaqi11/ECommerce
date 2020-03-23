using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
    /// <summary>
    /// 用户登录的参数
    /// </summary>
  public  class BUserLoginRequst:BaseRequest
    {
        /// <summary>
        /// 账户，手机号，邮箱
        /// </summary>
        public string Register { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPwd { get; set; }
        /// <summary>
        /// api路径
        /// </summary>
        /// <returns></returns>

        public override string GetApiName()
        {
            throw new NotImplementedException();
        }
    }
}         
