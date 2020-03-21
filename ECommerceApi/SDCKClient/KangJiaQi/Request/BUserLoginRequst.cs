using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
  public  class BUserLoginRequst
    {
        /// <summary>
        /// 账户，手机号，邮箱
        /// </summary>
        public string Register { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPwd { get; set; }
    }
}
