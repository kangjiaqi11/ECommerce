
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using MODEL.WangZhiHao;

namespace Dal.WangZhiHao
{
    public class GoodsDal
    {
        DBHelper db = new DBHelper();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="good"></param>
        /// <returns></returns>
        public int GoodAdd(GoodsModel good)
        {
            string sql = $"insert into GoodsModel (GoodId,BrandId,CategoryId,GoodsType,GoodsName,GoodsBinef,GoodsIntro,MarketPrice,SalePrice,CostPrice,CreateTime,UpdateTime,CreateId,UpdaterId) values('{good.GoodId}''{good.BrandId}','{good.CategoryId}','{good.GoodsType}','{good.GoodsName}','{good.GoodsBrief}','{good.GoodsIntro}','{good.MarketPrice}','{good.SalePrice}','{good.CostPrice}','{good.CreateTime}','{good.UpdateTime}','{good.CreaterId}','{good.UpdaterId}')";
            return db.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<GoodsModel> GoodsShow()
        {
            string sql = "select * from GoodsInfo";
            return  OrmDbHelper.GetList<GoodsModel>(sql);
        }

        /// <summary>
        /// 删除 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GoodsDelete(int id)
        {
            string sql = $"update GoodsInfo set Status=0 where GoodId={id}";
            return db.ExecuteNonQuery(sql);
        }
    }
}
