using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using MODEL.ZhangYang;

namespace SDCKClient.ZhangYang.Response
{
    public class StoreroomShowResp : BaseResponse
    {
        public Fenye StoList { get; set; }
    }
}
