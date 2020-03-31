using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.ZhangYang
{
    public class FrontUser //用户表
    {
        //用户id
        public long FrontUserid { get; set; }
        //用户账户
        public string Account        { get; set; }
        //用户密码
        public string UserPwd        { get; set; }
        //用户昵称
        public string UserName       { get; set; }
        //会员等级
        public string MembersId      { get; set; }
        //消费金额
        public string Consumption    { get; set; }
        //订单数量
        public long Number         { get; set; }
        //用户职业
        public string professional   { get; set; }
        //用户性别
        public string Age            { get; set; }
        //城市
        public string city           { get; set; }
        //生日
        public string Baddy          { get; set; }
        //喜欢分类
        public string classification { get; set; }
        //个性签名
        public string Grqm           { get; set; }

        //商品评价
        public string Sppj           { get; set; }
        //关注
        public string Gz             { get; set; }
        //粉丝
        public string Fs             { get; set; }
        //收藏商品
        public string Sc             { get; set; }
        //退货记录
        public string Thjl           { get; set; }
        //成长值
        public long Czz            { get; set; }
        //优惠卷
        public string Yhj            { get; set; }
        //收藏话题
        public string Scht           { get; set; }
        //订单id
        public long Ddid           { get; set; }
        //收货地址id
        public long ShdzId         { get; set; }
        public long State          { get; set; }
        public DateTime CTime          { get; set; }
        public DateTime XTime          { get; set; }
        public long Modifier       { get; set; }
        public long Founder        { get; set; }
    }
}
