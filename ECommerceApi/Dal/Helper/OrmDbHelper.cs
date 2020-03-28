using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace Dal
{
    public static class OrmDbHelper
    {
        /// <summary>
        /// 此处是连接字符串
        /// </summary>
        private const string ConnStr = "Data Source=.;Initial Catalog=ECommerce;Integrated Security=True";

        /// <summary>
        /// 获取集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static List<T> GetList<T>(string sql) where T : class, new()
        {
            List<T> list = new List<T>();
            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                list = connection.Query<T>(sql).ToList();
            }
            return list;
        }

        /// <summary>
        /// 获取一条信息
        /// 使用此方法时，需要判断返回值是否为null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static T GetInfo<T>(string sql) where T : class, new()
        {
            T info = new T();
            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                info = connection.QueryFirstOrDefault<T>(sql);
            }
            return info;
        }

        /// <summary>
        /// 执行sql语句
        /// 添加、删除、修改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteSql(string sql)
        {
            int res = 0;
            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                res = connection.Execute(sql);
            }
            return res;
        }


    }
}
