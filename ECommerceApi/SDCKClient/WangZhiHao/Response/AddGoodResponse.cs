
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.WangZhiHao.Response
{
    public class AddGoodResponse:BaseResponse
    {
       
        public List<GoodsModel> goodAdd { get; set; }
        /// <summary>
        /// 状态
        /// 表示请求状态
        /// 默认为1 表示正常
        /// 为-1时 表示错误
        /// </summary>
        public int Status = 1;
        /// <summary>
        /// 消息
        /// 指的时返回的一些消息消息 当状态-1 时显示此消息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 一种状态返回
        /// 比如 ，添加是否成功，删除是否成功
        /// </summary>
        public bool IsSuccess { get; set; }
  
    }
}
