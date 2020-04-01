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
        public List<Member> MemberShow()
        {
            List<Member> list = new List<Member>();
            string sql = "select MembersId,members,Growth,Evaluation,Freight,Note from Member";
            SqlConnection scon = new SqlConnection("ata Source=.;Initial Catalog=ECommerce;Integrated Security=True");
            SqlCommand scom = new SqlCommand(sql, scon);

            scon.Open();
            SqlDataReader reader = scom.ExecuteReader();
            Member f = new Member();
            while (reader.Read())
            {
                f.MembersId = (long)reader["MembersId"];
                f.members = (string)reader["members"];
                f.Growth = (string)reader["Growth"];
                f.Evaluation = (string)reader["Evaluation"];
                f.Freight = (string)reader["Freight"];
                f.Note = (string)reader["Note"];

                list.Add(f);
            }
            reader.Close();
            scon.Close();

            return list;
        }
    }
}
