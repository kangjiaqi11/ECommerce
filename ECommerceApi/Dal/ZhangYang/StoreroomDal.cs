using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.ZhangYang;
using System.Data.SqlClient;

namespace Dal.ZhangYang
{
    public class StoreroomDal
    {
        DBHelper db = new DBHelper();
        public Fenye StoreroomFenye(int PageIndex,int PageSize, string ShoopName)
        {
            List<Storeroom> list = new List<Storeroom>();
            SqlConnection scon = new SqlConnection("server=.;uid=sa;pwd=1234;database=ECommerce");
            SqlCommand scom = new SqlCommand("Fenye1", scon);
            
            scom.CommandType = System.Data.CommandType.StoredProcedure;
            scom.Parameters.Add(new SqlParameter("@PageIndex", PageIndex));
            scom.Parameters.Add(new SqlParameter("@PageSize", PageSize));
            scom.Parameters.Add(new SqlParameter("@ShoopName",ShoopName));
            scom.Parameters.Add(new SqlParameter("@PageCount",0));
            scom.Parameters[3].Direction = System.Data.ParameterDirection.Output;
            scon.Open();
            SqlDataReader reader = scom.ExecuteReader();
            while (reader.Read())
            {
                Storeroom s = new Storeroom();
                s.CkId = (int)reader["CkId"];
                s.ShoopName = (string)reader["ShoopName"];
                s.Hhsx = (string)reader["Hhsx"];
                s.Ddh = (int)reader["Ddh"];
                s.Kcsl = (string)reader["Kcsl"];
                s.Kclx = (string)reader["Kclx"];
                s.State = (int)reader["State"];
                s.CreateId = (int)reader["CreateId"];
                s.UpdateId = (int)reader["UpdateId"];
                s.CreateTime = (DateTime)reader["CreateTime"];
                s.UpdateTime = (DateTime)reader["UpdateTime"];

                list.Add(s);
            }
            reader.Close();
            scon.Close();
            int result = 0;
            result = int.Parse(scom.Parameters[3].Value.ToString());
            Fenye f = new Fenye();
            f.Storerooms = list;
            f.Count = result;
            return f;

        }
    }
}
