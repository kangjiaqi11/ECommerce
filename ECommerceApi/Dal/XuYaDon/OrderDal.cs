using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.XuYaDon;
using System.Data.SqlClient;
namespace Dal
{
    /// <summary>
    /// 订单显示
    /// </summary>
  public  class OrderDal
    {
        SqlConnection connetion = new SqlConnection("Data Source=.;Initial Catalog=ECommerce1;Integrated Security=True");
        public PageModel OrderShow(string OrderNumber,string GoodsName,string AddrName,string AddrPhone,int State,string puttime,int pageindex,int pagesize)
        {
          
            PageModel page = new PageModel();
     
            connetion.Open();
            var sql = "exec OrderShow @OrderNumber,@GoodsName,@AddrName,@AddrPhone,@State,@puttime,@pageindex,@pagesize,@totalcount out";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = connetion;
            SqlParameter[] Parameters = new SqlParameter[] {
                new SqlParameter(){ ParameterName="@OrderNumber",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=OrderNumber},
                new SqlParameter(){ ParameterName="@GoodsName",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=GoodsName},
                 new SqlParameter(){ ParameterName="@AddrName",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=AddrName},
                new SqlParameter(){ ParameterName="@AddrPhone",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=AddrPhone},
                new SqlParameter(){ ParameterName="@State",SqlDbType=System.Data.SqlDbType.Int,SqlValue=State},
                new SqlParameter(){ ParameterName="@puttime",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=puttime},
                new SqlParameter(){ ParameterName="@pageindex",SqlDbType=System.Data.SqlDbType.Int,SqlValue=pageindex},
                new SqlParameter(){ ParameterName="@pagesize",SqlDbType=System.Data.SqlDbType.Int,SqlValue=pagesize},
                 new SqlParameter(){ ParameterName="@totalcount",SqlDbType=System.Data.SqlDbType.Int,Direction=System.Data.ParameterDirection.Output},
            };
            cmd.Parameters.AddRange(Parameters);
            var res = cmd.ExecuteReader();
            var read = DataReadHelp.DataRead<OrderModel>(res);
            page.totalcount= Convert.ToInt32(cmd.Parameters["@totalcount"].Value);
            page.list = read;
            connetion.Close();
            return page;
        }
    }
}
