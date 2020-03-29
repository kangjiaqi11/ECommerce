using SDCKClient;
using SDCKClient.WangZhiHao.Request;
using SDCKClient.WangZhiHao.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BGoodsBll
    {
        
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="goodsAddRequest"></param>
        /// <param name="GetApiName"></param>
        /// <returns></returns>
        public GoodsAddResponse GoodsAdd(GoodsAddRequest goodsAddRequest,string GetApiName)
        {
            return ApiRequestHelper.Post<GoodsAddRequest, GoodsAddResponse>(goodsAddRequest, GetApiName);
        }
    }
}
