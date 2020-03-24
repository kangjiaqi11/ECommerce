using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.ZhangYang
{
    public class Shipping   //收货地址
    {
        //收货地址id
        public int ShippingId { get; set; }
        //手机号
        public string Photo { get; set; }
        //收货人姓名
        public string Consignee { get; set; }
        //邮政编码
        public string Email { get; set; }
        //详细地址
        public string Address { get; set; }
        //数据状态
        public int State { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public int UpdateId { get; set; }
        //省
        public int province { get; set; }
        //市
        public int City { get; set; }
        //区
        public int District { get; set; }
    }
}
