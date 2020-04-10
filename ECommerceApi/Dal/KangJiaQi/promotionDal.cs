using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using System.Data.SqlClient;
using System.Configuration;

namespace Dal
{
    public class promotionDal
    {
        DBHelper DBHelper = new DBHelper();
     
        /// <summary>
        /// 秒杀活动
        /// </summary>
        /// <param name="ActivityTitle"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public ActivityPage ActivityShow(string ActivityTitle, int PageIndex, int PageSize)
        {
            string token = ConfigurationManager.AppSettings["sql"];
        SqlConnection SqlConnection = new SqlConnection(token);
            List<Activity> list = new List<Activity>();
            ActivityPage activityPage = new ActivityPage();

            if (SqlConnection != null)
            {
                if (SqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    SqlConnection.Open();
                }
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = "exec P_Activity @ActivityTitle,@PageIndex,@PageSize,@TotaCount out";
                sqlCommand.Connection = SqlConnection;
                SqlParameter[] sqlParameters = new SqlParameter[] {
                    new SqlParameter(){ ParameterName="@ActivityTitle",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=ActivityTitle},
                    new SqlParameter(){ ParameterName="@PageIndex",SqlDbType=System.Data.SqlDbType.Int,SqlValue=PageIndex},
                    new SqlParameter(){ ParameterName="@PageSize",SqlDbType=System.Data.SqlDbType.Int,SqlValue=PageSize},
                        new SqlParameter(){ ParameterName="@TotaCount",SqlDbType=System.Data.SqlDbType.Int,Direction=System.Data.ParameterDirection.Output},
               };
                sqlCommand.Parameters.AddRange(sqlParameters);
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Activity info = new Activity();
                    info.ActivityId = Convert.ToInt32(reader["ActivityId"]);
                    info.ActivityTitle = Convert.ToString(reader["ActivityTitle"]);
                    info.ActivityStatel = Convert.ToInt32(reader["ActivityStatel"]);
                    info.TimeQId = Convert.ToInt32(reader["TimeQId"]);
                    info.GoodId = Convert.ToInt32(reader["GoodId"]);
                    info.Statel = Convert.ToInt32(reader["Statel"]);
                    info.AStartTime = Convert.ToDateTime(reader["AStartTime"]);
                    info.AEenTime = Convert.ToDateTime(reader["AEenTime"]);
                    info.CreateTime = Convert.ToDateTime(reader["CreateTime"]);
                    info.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                    info.CreateId = Convert.ToInt32(reader["CreateId"]);
                    info.UpdateId = Convert.ToInt32(reader["UpdateId"]);
                    list.Add(info);
                }
                reader.Close();
                activityPage.TotaCount = Convert.ToInt32(sqlCommand.Parameters["@TotaCount"].Value);
                activityPage.DateList = list;
                SqlConnection.Close();
            }
            return activityPage;
        }

        /// <summary>
        /// 添加秒杀
        /// </summary>
        /// <returns></returns>
        public int ActivityAdd(Activity activity)
        {
            string sql= $"insert into Activity( ActivityTitle ,ActivityStatel,TimeQId,GoodId, Statel ,AStartTime ,AEenTime ,CreateTime, UpdateTime , CreateId  ,UpdateId) values ('{activity.ActivityTitle}',{activity.ActivityStatel},{activity.TimeQId},{activity.GoodId},{activity.Statel},'{activity.AStartTime}','{activity.AEenTime}','{activity.CreateTime}','{activity.UpdateTime}','{activity.CreateId}','{activity.UpdateId}') ";
            return OrmDbHelper.ExecuteSql(sql); 
        }
        /// <summary>
        ///活动秒杀 上架
        /// </summary>
        /// <returns></returns>
        public int ActivityPutaway(int ActivityId)
        {
            string sql = $"update Activity  set Statel=1 where  ActivityId={ActivityId}";
            return OrmDbHelper.ExecuteSql(sql);
        }
        /// <summary>
        ///活动秒杀下架
        /// </summary>
        /// <returns></returns>
        public int ActivitySoldOut(int ActivityId)
        {
            string sql = $"update Activity  set Statel=2 where  ActivityId={ActivityId}";
            return OrmDbHelper.ExecuteSql(sql);
        }
        /// <summary>
        /// 活动秒杀删除
        /// </summary>
        /// <returns></returns>
        public int ActivityDelete(int ActivityId)
        {
            string sql = $"update Activity  set Statel=0 where  ActivityId={ActivityId}";
            return OrmDbHelper.ExecuteSql(sql);
        }
        /// <summary>
        /// 显示要添加的商品
        /// </summary>
        /// <returns></returns>
        public List<GoodsModel> ActivityGoodShow()
        {
            string sql = "select * from GoodsInfo where Status=1";
            return OrmDbHelper.GetList<GoodsModel>(sql);
        }
        /// <summary>
        /// 活动添加商品
        /// </summary>
        /// <returns></returns>
        public int ActivityGoodAdd(int Timeid,int goodid,int activityid)
        {
            string sql = $"update Activity set TimeQId={Timeid} , GoodId={goodid} where ActivityId={activityid}";
            return OrmDbHelper.ExecuteSql(sql);
        }

        #region 好物推荐
        /// <summary>
        /// 推荐好的物品
        /// </summary>
        /// <param name="GoodsName"></param>
        /// <param name="IsRecommend"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public RecommendPage RecommendShow(string GoodsName, int IsRecommend, int PageIndex, int PageSize)
        {
            string token = ConfigurationManager.AppSettings["sql"];
            SqlConnection SqlConnection = new SqlConnection(token);
            List<Recommend> list = new List<Recommend>();
            RecommendPage recommendPage = new RecommendPage();
            try
            {
                if (SqlConnection != null)
                {
                    if (SqlConnection.State == System.Data.ConnectionState.Closed)
                    {
                        SqlConnection.Open();
                    }
                    SqlCommand sqlCommand = new SqlCommand();

                    sqlCommand.CommandText = "exec p_Recommend @GoodsName,@IsRecommend,@PageIndex,@PageSize,@TotaCount out";
                    sqlCommand.Connection = SqlConnection;
                    SqlParameter[] sqlParameters = new SqlParameter[] {
                    new SqlParameter(){ ParameterName="@GoodsName",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=GoodsName},
                     new SqlParameter(){ ParameterName="@IsRecommend",SqlDbType=System.Data.SqlDbType.Int,SqlValue=IsRecommend},
                    new SqlParameter(){ ParameterName="@PageIndex",SqlDbType=System.Data.SqlDbType.Int,SqlValue=PageIndex},
                    new SqlParameter(){ ParameterName="@PageSize",SqlDbType=System.Data.SqlDbType.Int,SqlValue=PageSize},
                     new SqlParameter(){ ParameterName="@TotaCount",SqlDbType=System.Data.SqlDbType.Int,Direction=System.Data.ParameterDirection.Output},
               };
                    sqlCommand.Parameters.AddRange(sqlParameters);
                    var reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Recommend info = new Recommend();
                        info.RecommendId = Convert.ToInt32(reader["RecommendId"]);
                        info.IsRecommend = Convert.ToInt32(reader["IsRecommend"]);
                        info.GoodsName = Convert.ToString(reader["GoodsName"]);
                        info.GoodsIntro = Convert.ToString(reader["GoodsIntro"]);
                        info.Statel = Convert.ToInt32(reader["State"]);
                        list.Add(info);
                    }
                    reader.Close();
                    recommendPage.TotaCount = Convert.ToInt32(sqlCommand.Parameters["@TotaCount"].Value);
                    recommendPage.DateList = list;
                    SqlConnection.Close();
                }
                return recommendPage;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        /// <summary>
        ///好物推荐 状态
        /// </summary>
        /// <returns></returns>
        public int RecommendIs(int RecommendId)
        {
            string sql = $"update Recommend  set IsRecommend=1 where  RecommendId={RecommendId}";
            return OrmDbHelper.ExecuteSql(sql);
        }
        /// <summary>
        ///好物推荐下架
        /// </summary>
        /// <returns></returns>
        public int RecommendNO(int RecommendId)
        {
            string sql = $"update Recommend  set IsRecommend=2 where  RecommendId={RecommendId}";
            return OrmDbHelper.ExecuteSql(sql);
        }
        /// <summary>
        /// 好物推荐删除
        /// </summary>
        /// <returns></returns>
        public int RecommendDelete(int RecommendId)
        {
            string sql = $"update Recommend  set State=0 where  RecommendId={RecommendId}";
            return OrmDbHelper.ExecuteSql(sql);
        } 
        #endregion
        #region 时间段相关 
        /// <summary>
        /// 时间段的显示
        /// </summary>
        /// <returns></returns>
        public List<TimeQ> TimeQShow()
        {
            string sql = "select * from TimeQ where Statel>0";
            return OrmDbHelper.GetList<TimeQ>(sql);
        }
        /// <summary>
        /// 删除时间段状态
        /// </summary>
        /// <param name="Tid"></param>
        /// <returns></returns>
        public int TimeQdelete(long Tid)
        {
            string sql = $"update TimeQ  set Statel=0 where  TimeQId={Tid}";
            return OrmDbHelper.ExecuteSql(sql);
        }
        /// <summary>
        /// 为启用时间段状态
        /// </summary>
        /// <param name="Tid"></param>
        /// <returns></returns>
        public int TimeQUpdate2(long Tid)
        {
            string sql = $"update TimeQ  set Statel=1 where  TimeQId={Tid}";
            return OrmDbHelper.ExecuteSql(sql);
        }
        /// <summary>
        /// 已启用经时间段状态
        /// </summary>
        /// <param name="Tid"></param>
        /// <returns></returns>
        public int TimeQUpdate3(long Tid)
        {
            string sql = $"update TimeQ  set Statel=2 where  TimeQId={Tid}";
            return OrmDbHelper.ExecuteSql(sql);
        }
        #endregion
    }
}
