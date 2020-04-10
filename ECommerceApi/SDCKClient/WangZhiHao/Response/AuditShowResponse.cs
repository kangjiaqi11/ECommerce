using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.WangZhiHao.Response
{
    public class AuditShowResponse:BaseResponse
    {
        /// <summary>
        /// 数据集合
        /// </summary>
        public List<GoodsModel> DateList { get; set; }
    }
}
