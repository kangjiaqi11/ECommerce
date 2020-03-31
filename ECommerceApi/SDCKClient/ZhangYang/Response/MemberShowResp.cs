using MODEL.ZhangYang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.ZhangYang.Response
{
    public class MemberShowResp : BaseResponse
    {
        public List<Member> Members { get; set; }
    }
}
