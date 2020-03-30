using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.ZhangYang;

namespace Dal.ZhangYang
{
    public class FrontUserDAL
    {
        public Fenye1 FrontUserFenye(int PageIndex, int PageSize, string UserName)
        {
            List<FrontUser> list = new List<FrontUser>();
            SqlConnection scon = new SqlConnection("server=.;uid=sa;pwd=1234;database=ECommerce");
            SqlCommand scom = new SqlCommand("Fenye1", scon);

            scom.CommandType = System.Data.CommandType.StoredProcedure;
            scom.Parameters.Add(new SqlParameter("@PageIndex", PageIndex));
            scom.Parameters.Add(new SqlParameter("@PageSize", PageSize));
            scom.Parameters.Add(new SqlParameter("@UserName", UserName));
            scom.Parameters.Add(new SqlParameter("@PageCount", 0));
            scom.Parameters[3].Direction = System.Data.ParameterDirection.Output;
            scon.Open();
            SqlDataReader reader = scom.ExecuteReader();
            while (reader.Read())
            {
                FrontUser s = new FrontUser();
                s.FrontUserid = (int)reader["FrontUserid"];
                s.Account = (string)reader["Account"];
                s.UserName = (string)reader["UserName"];
                s.MembersId = (string)reader["MembersId"];
                s.Consumption = (string)reader["Consumption"];
                s.Number = (int)reader["Number"];

                list.Add(s);
            }
            reader.Close();
            scon.Close();
            int result = 0;
            result = int.Parse(scom.Parameters[3].Value.ToString());
            Fenye1 f = new Fenye1();
            f.FrontUsers = list;
            f.Count = result;
            return f;
        }
    }
}
