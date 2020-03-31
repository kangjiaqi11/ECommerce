using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using Dal.WangZhiHao;
using SDCKClient.WangZhiHao.Request;
using SDCKClient.WangZhiHao.Response;
using Common;

namespace BLL.WangZhiHao
{
    
    public class GoodsBll
    {
        /// <summary>
        /// 实例化dal
        /// </summary>
        GoodsDal dal = new GoodsDal();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="good"></param>
        /// <returns></returns>
        public int GoodsAdd(GoodsModel good)
        {
            return dal.GoodsAdd(good);
        }
        
        /// <summary>
        /// 商品显示
        /// </summary>
        /// <returns></returns>
        public GoodsAddResponse GoodsShow(GoodsAddRequest goodsAddRequest)
        {
            GoodsAddResponse goodsAddResponse = new GoodsAddResponse();
            var ser = dal.GoodsShow();
            if (ser!=null)
            {
                goodsAddResponse.goods = ser;
                goodsAddResponse.IsSuccess = true;
            }
            else
            {
                goodsAddResponse.Status = -1;
                goodsAddResponse.Msg = "显示失败";
            }
            return goodsAddResponse;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GoodsDelete(int id)
        {
            return dal.GoodsDelete(id);
        }
    }
}
