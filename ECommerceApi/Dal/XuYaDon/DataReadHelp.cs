using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Dal
{
   public static class DataReadHelp
    {
        public static List<T> DataRead<T>(this SqlDataReader reader) where T : new()
        {
            List<T> list= new List<T>();
            while (reader.Read())
            {
                T t = new T();
                var res = t.GetType().GetProperties();
                foreach (var item in res)
                {
                    item.SetValue(t, reader[item.Name]);
                }
                list.Add(t);
            }
            return list ;
        }
    }
}
