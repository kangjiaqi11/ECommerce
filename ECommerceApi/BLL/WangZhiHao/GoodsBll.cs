using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using Dal;
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
        public List<GoodsModel> GoodsShow()
        {
            return dal.GoodsShow();
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
