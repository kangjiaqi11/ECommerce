using MODEL.ZhangYang;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.ZhangYang
{
    public class MemberDAL
    {
        public List<FrontUser> FrontUserShow()
        {
            List<FrontUser> list = new List<FrontUser>();
            string sql = "select FrontUserid,Consumption,Number,Czz,Yhj,Scht from FrontUser";
            SqlConnection scon = new SqlConnection("server=.;uid=sa;pwd=1234;database=ECommerce");
            SqlCommand scom = new SqlCommand("sql", scon);

            scon.Open();
            SqlDataReader reader = scom.ExecuteReader();
            FrontUser f = new FrontUser();
            while (reader.Read())
            {
                f.FrontUserid = (int)reader["FrontUserid"];
                f.Consumption = (string)reader["Consumption"];
                f.Number = (int)reader["Number"];
                f.Czz = (int)reader["Czz"];
                f.Yhj = (string)reader["Yhj"];
                f.Scht = (string)reader["Scht"];

                list.Add(f);
            }
            reader.Close();
            scon.Close();

            return list;
        }
    }
}
