
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
            string sql = $"insert into GoodsModel (BrandId,GoodsName,SalePrice,GoodsState,GoodsBrief,Status,CreateTime,UpdateTime,CreaterId,UpdaterId) values({good.BrandId},'{good.GoodsName}',{good.SalePrice},{good.GoodsState},'{good.GoodsBrief}',{good.Status},'{good.CreateTime}','{good.UpdateTime}',{good.CreaterId},{good.UpdaterId})";
            return OrmDbHelper.ExecuteSql(sql);
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
