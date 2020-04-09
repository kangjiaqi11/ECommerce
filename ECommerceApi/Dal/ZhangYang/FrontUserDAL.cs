using System;
using System.Collections.Generic;
using System.Configuration;
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
            string token = ConfigurationManager.AppSettings["sql"];
            List<FrontUser> list = new List<FrontUser>();
            SqlConnection scon = new SqlConnection(token);
            SqlCommand scom = new SqlCommand("Fenye2", scon);

            scom.CommandType = System.Data.CommandType.StoredProcedure;
            scom.Parameters.Add(new SqlParameter("@PageIndex", PageIndex));
            scom.Parameters.Add(new SqlParameter("@PageSize", PageSize));
            scom.Parameters.Add(new SqlParameter("@UserName", UserName));
            scom.Parameters.Add(new SqlParameter("@PageCount",0));
            scom.Parameters[3].Direction = System.Data.ParameterDirection.Output;
            scon.Open();
            SqlDataReader reader = scom.ExecuteReader();
            while (reader.Read())
            {
                FrontUser s = new FrontUser();
                s.FrontUserid = (long)reader["FrontUserid"];
                s.Account = (string)reader["Account"];
                s.UserName = (string)reader["UserName"];
                s.MembersId = (string)reader["MembersId"];
                s.Consumption = (string)reader["Consumption"];
                s.Number = (long)reader["Number"];

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
        //详情1
        public List<FrontUser> FrontUserShow1()
        {
            string token = ConfigurationManager.AppSettings["sql"];
            List<FrontUser> list = new List<FrontUser>();
            string sql = "select FrontUserid,UserName,Baddy,Grqm,professional,Age from FrontUser where FrontUserid = 1";
            SqlConnection scon = new SqlConnection(token);
            SqlCommand scom = new SqlCommand(sql, scon);

            scon.Open();
            SqlDataReader reader = scom.ExecuteReader();
            FrontUser f = new FrontUser();
            while (reader.Read())
            {
                f.FrontUserid = (long)reader["FrontUserid"];
                f.UserName = (string)reader["UserName"];
                f.Baddy = (string)reader["Baddy"];
                f.Grqm = (string)reader["Grqm"];
                f.professional = (string)reader["professional"];
                f.Age = (string)reader["Age"];

                list.Add(f);
            }
            reader.Close();
            scon.Close();

            return list;
        }
        //详情2
        public List<FrontUser> FrontUserShow2()
        {
            string token = ConfigurationManager.AppSettings["sql"];
            List<FrontUser> list = new List<FrontUser>();
            string sql = "select FrontUserid,Consumption,Number,Czz,Yhj,Scht from FrontUser where FrontUserid = 1";
            SqlConnection scon = new SqlConnection(token);
            SqlCommand scom = new SqlCommand(sql, scon);

            scon.Open();
            SqlDataReader reader = scom.ExecuteReader();
            FrontUser f = new FrontUser();
            while (reader.Read())
            {
                f.FrontUserid = (long)reader["FrontUserid"];       
                f.Consumption = (string)reader["Consumption"];
                f.Number = (long)reader["Number"];
                f.Czz = (long)reader["Czz"];
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
