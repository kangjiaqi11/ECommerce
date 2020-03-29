using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.ZhangYang.Request
{
    public class MemberShowReq : BaseRequest
    {
        //会员id
        public int MembersId { get; set; }
        //会员名称
        public string members { get; set; }
        //成长值满电
        public string Growth { get; set; }
        //评价奖励
        public string Evaluation { get; set; }
        //免运费标准
        public string Freight { get; set; }
        //备注
        public string Note { get; set; }
        public override string GetApiName()
        {
            throw new NotImplementedException();
        }
    }
}
