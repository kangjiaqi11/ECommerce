using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.ZhangYang.Request
{
    public class FrontUserShowReq : BaseRequest //用户表
    {
        //页数
        public int PageIndex { get; set; }
        //总页数
        public int PageSize { get; set; }
        public int FrontUserid { get; set; }
        public string Account { get; set; }
        public string UserName { get; set; }
        public string MembersId { get; set; }
        public string Consumption { get; set; }
        public int Number { get; set; }
        public override string GetApiName()
        {
            throw new NotImplementedException();
        }
    }
}
