using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using System.Data.SqlClient;
namespace Dal
{
   public class promotionDal
    {
        DBHelper DBHelper = new DBHelper();
        SqlConnection SqlConnection = new SqlConnection("Data Source=.;Initial Catalog=ECommerce;Integrated Security=True");
        /// <summary>
        /// 秒杀活动
        /// </summary>
        /// <param name="ActivityTitle"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public ActivityPage ActivityShow(string ActivityTitle,int PageIndex,int PageSize)
        {
            List<Activity> list = new List<Activity>();
            ActivityPage activityPage = new ActivityPage();
            if (SqlConnection!=null)
            {
                if (SqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    SqlConnection.Open();
                }
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText= "exec P_Activity @ActivityTitle,@PageIndex,@PageSize,@TotaCount out";
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
                    Activity info= new Activity();
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
        /// 推荐好的物品
        /// </summary>
        /// <param name="GoodsName"></param>
        /// <param name="IsRecommend"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public RecommendPage RecommendShow(string GoodsName,int IsRecommend, int PageIndex, int PageSize)
        {
            List<Recommend> list = new List<Recommend>();
            RecommendPage recommendPage = new RecommendPage();
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
                    new SqlParameter(){ ParameterName="@ActivityTitle",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=GoodsName},
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
                    info.Statel = Convert.ToInt32(reader["Statel"]);
                    list.Add(info);
                }
                reader.Close();
                recommendPage.TotaCount = Convert.ToInt32(sqlCommand.Parameters["@TotaCount"].Value);
                recommendPage.DateList = list;
                SqlConnection.Close();
            }
            return recommendPage;
        }
        /// <summary>
        /// 时间段的显示
        /// </summary>
        /// <returns></returns>
        public List<TimeQ> TimeQShow()
        {
            string sql = "select * from TimeQ";
            return DBHelper.GetToList<TimeQ>(sql);
        }
    }
}
