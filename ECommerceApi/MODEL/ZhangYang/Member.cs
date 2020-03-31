using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.ZhangYang
{
    public class Member //会员
    {
        //会员id
        public long MembersId  { get; set; }
        //会员名称
        public string members    { get; set; }
        //成长值满电
        public string Growth     { get; set; }
        //评价奖励
        public string Evaluation { get; set; }
        //免运费标准
        public string Freight    { get; set; }
        //备注
        public string Note       { get; set; }
        //数据状态
        public string State      { get; set; }
        //创建时间
        public string CTime      { get; set; }
        //修改时间
        public string XTime      { get; set; }
        //创建人
        public long Founder    { get; set; }
        //修改人
        public long UpdateId   { get; set; }
    }
}
