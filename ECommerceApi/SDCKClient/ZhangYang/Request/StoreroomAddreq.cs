using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.ZhangYang.Request
{
    public class StoreroomAddReq : BaseRequest  //出库表
    {
        //商品名称
        public string ShoopName { get; set; }
        //货号属性
        public string Hhsx { get; set; }
        //订单号
        public int Ddh { get; set; }
        //库存数量
        public string Kcsl { get; set; }
        //库存类型
        public string Kclx { get; set; }
        public int State { get; set; }
        public int CreateId { get; set; }
        public int UpdateId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public override string GetApiName()
        {
            throw new NotImplementedException();
        }
    }
}
