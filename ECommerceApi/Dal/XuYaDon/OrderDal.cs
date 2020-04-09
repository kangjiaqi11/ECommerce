using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.XuYaDon;
using System.Data.SqlClient;
using DAL.XuYaDon.DB;
using System.Configuration;
using Dal.XuyaDon;
using Dapper;
using System.Data;

namespace Dal
{
    /// <summary>
    /// 订单显示
    /// </summary>
  public  class OrderDal
    {
       static  string token = ConfigurationManager.AppSettings["sql"];
        SDBHelper DBHelper = new SDBHelper();
       SqlConnection connetion = new SqlConnection(token);
        public PageModel OrderShow(string OrderNumberGoodsName="", string AddrNameAddrPhone="",int State=0,string puttime="",string endtime="", int pageindex=1,int pagesize=6)
        {
            if (string.IsNullOrEmpty(OrderNumberGoodsName))
            {
                OrderNumberGoodsName = "";
            }
            if (string.IsNullOrEmpty(AddrNameAddrPhone))
            {
                AddrNameAddrPhone = "";
            }
            if (State==0)
            {
                State = 0;
            }
            if (string.IsNullOrEmpty(puttime))
            {
                puttime = "";
            }
            if (string.IsNullOrEmpty(endtime))
            {
                endtime = "";
            }
            if (pageindex==0)
            {
                pageindex = 1;
            }
            if (pagesize == 0)
            {
                pagesize = 6;
            }


            PageModel page = new PageModel();
            if (connetion.State==System.Data.ConnectionState.Closed)
            {
                connetion.Open();
            }
           
            var sql = "exec OrderShow22 @OrderNumberGoodsName,@AddrNameAddrPhone,@State,@puttime,@endtime,@pageindex,@pagesize,@totalcount out";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = connetion;
            SqlParameter[] Parameters = new SqlParameter[] {
                new SqlParameter(){ ParameterName="@OrderNumberGoodsName",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=OrderNumberGoodsName},
                new SqlParameter(){ ParameterName="@AddrNameAddrPhone",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=AddrNameAddrPhone},
                new SqlParameter(){ ParameterName="@State",SqlDbType=System.Data.SqlDbType.Int,SqlValue=State},
                new SqlParameter(){ ParameterName="@puttime",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=puttime},
                new SqlParameter(){ ParameterName="@endtime",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=endtime},
                new SqlParameter(){ ParameterName="@pageindex",SqlDbType=System.Data.SqlDbType.Int,SqlValue=pageindex},
                new SqlParameter(){ ParameterName="@pagesize",SqlDbType=System.Data.SqlDbType.Int,SqlValue=pagesize},
                 new SqlParameter(){ ParameterName="@totalcount",SqlDbType=System.Data.SqlDbType.Int,Direction=System.Data.ParameterDirection.Output},
            };
            cmd.Parameters.AddRange(Parameters);
            var res = cmd.ExecuteReader();
          
            var read = DataReadHelp.DataRead<OrderModel>(res);
            connetion.Close();
            page.totalcount= Convert.ToInt32(cmd.Parameters["@totalcount"].Value);
            page.list = read;
           
            return page;
        }
        /// <summary>
        /// 修改订单状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdateState(int id,int state)
        {
            string sql = $"update OrderTable set Oderstate={state} where OrderId={id}";
            return xDBHelper.ExecuteNonQuery(sql);
        }
      
        /// <summary>
        /// 显示待发货信息
        /// </summary>
        /// <returns></returns>
        public List<ExpressShowModel> expressShow()
        {
            string sql = "select o.OrderNumber,s.Consignee,s.Photo,s.Email,s.Address from OrderTable as o join FrontUser as f on o.FrontUserid=f.FrontUserid join Shipping as s on s.ShippingId=f.FrontUserid where o.Oderstate=2";
            return DBHelper.GetToList<ExpressShowModel>(sql);
        }
        /// <summary>
        /// 快递绑定下拉
        /// </summary>
        /// <returns></returns>
        public List<express> ExperBind()
        {
            List<express> list = new List<express>();
            using (IDbConnection dbConnection=new SqlConnection(token))
            {
              list= dbConnection.Query<express>("select * from express where expressId > 1").ToList();
            }
            return list;
        }
        /// <summary>
        /// 修改状态发货
        /// </summary>
        public int UpdateStateExper(string OderNumber,int experId)
        {
            string sql =$"update OrderTable  set  Oderstate=3,expressId={experId} where OrderNumber='{OderNumber}'";
            return xDBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 显示商品详细
        /// </summary>
        /// <returns></returns>
        public List<OrderModel> ShowOrderALL(string OderNumber)
        {
            if (connetion.State == System.Data.ConnectionState.Closed)
            {
                connetion.Open();
            }

            string sql = $"select o.*,g.GoodsName,g.BrandId,b.BrandName,c.TypeName,g.MarketPrice,f.Account,sh.Photo,sh.Consignee,sh.Email,sh.Address,itype.InvoieTypeName,i.InvoiceHead,i.Invoicecontent,ex.expressName from  OrderTable as o join GoodsInfo as g on o.GoodId=g.GoodId join BrandInfo as b on g.BrandId = b.DrandId join CommodityType as c on c.TypeId = g.GoodsType join FrontUser as f on f.FrontUserid = o.FrontUserid join Shipping as sh on sh.ShippingId = f.ShdzId join invoice as i on i.OrderId = o.invoice join invoicetype as itype on itype.InvoicetypeId = i.InvoiceType join express as ex on o.expressId = ex.expressId  where o.OrderNumber = '{OderNumber}'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = connetion;
            var res = cmd.ExecuteReader();

            var read = DataReadHelp.DataRead<OrderModel>(res);
            connetion.Close();

            return read;
        }
        /// <summary>
        /// 订单确认收货
        /// </summary>
        /// <param name="OrderNumberGoodsName"></param>
        /// <param name="AddrNameAddrPhone"></param>
        /// <param name="State"></param>
        /// <param name="puttime"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public PageModel2 TakeGood(string OrderNumberGoodsName = "", string AddrNameAddrPhone = "", string puttime = "", string endtimes="", int pageindex = 1, int pagesize = 50)
        {
            if (string.IsNullOrEmpty(OrderNumberGoodsName))
            {
                OrderNumberGoodsName = "";
            }
            if (string.IsNullOrEmpty(AddrNameAddrPhone))
            {
                AddrNameAddrPhone = "";
            }
            if (string.IsNullOrEmpty(puttime))
            {
                puttime = "";
            }
            if (string.IsNullOrEmpty(endtimes))
            {
                endtimes = "";
            }
            if (pageindex == 0)
            {
                pageindex = 1;
            }
            if (pagesize == 0)
            {
                pagesize = 50;
            }


            PageModel2 page = new PageModel2();
            if (connetion.State == System.Data.ConnectionState.Closed)
            {
                connetion.Open();
            }


            var sql = "exec MakeGodd @OrderNumberGoodsName,@AddrNameAddrPhone,@puttime,@endtimes,@pageindex,@pagesize,@totalcount out";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = connetion;
            SqlParameter[] Parameters = new SqlParameter[] {
                new SqlParameter(){ ParameterName="@OrderNumberGoodsName",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=OrderNumberGoodsName},
                new SqlParameter(){ ParameterName="@AddrNameAddrPhone",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=AddrNameAddrPhone},
                new SqlParameter(){ ParameterName="@puttime",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=puttime},
                   new SqlParameter(){ ParameterName="@endtimes",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=endtimes},
                new SqlParameter(){ ParameterName="@pageindex",SqlDbType=System.Data.SqlDbType.Int,SqlValue=pageindex},
                new SqlParameter(){ ParameterName="@pagesize",SqlDbType=System.Data.SqlDbType.Int,SqlValue=pagesize},
                 new SqlParameter(){ ParameterName="@totalcount",SqlDbType=System.Data.SqlDbType.Int,Direction=System.Data.ParameterDirection.Output},
            };
            cmd.Parameters.AddRange(Parameters);
            var res = cmd.ExecuteReader();

            var read = DataReadHelp.DataRead<TakeGood>(res);
            connetion.Close();
            page.totalcount = Convert.ToInt32(cmd.Parameters["@totalcount"].Value);
            page.Datalist= read;

            return page;
        }
        /// <summary>
        /// 退货申请显示
        /// </summary>
        /// <param name="OrderNumberGoodsName"></param>
        /// <param name="AddrNameAddrPhone"></param>
        /// <param name="State"></param>
        /// <param name="puttime"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public PageModel3 ReturnGoods(string OrderName = "", string AddrPhone = "",int State = 0, string puttime = "",string endtimes="", int pageindex = 1, int pagesize = 6)
        {
            if (string.IsNullOrEmpty(OrderName))
            {
                OrderName = "";
            }
            if (string.IsNullOrEmpty(AddrPhone))
            {
                AddrPhone = "";
            }
            if (State == 0)
            {
                State = 0;
            }
            if (string.IsNullOrEmpty(puttime))
            {
                puttime = "";
            }
            if (string.IsNullOrEmpty(endtimes))
            {
                endtimes = "";
            }
            if (pageindex == 0)
            {
                pageindex = 1;
            }
            if (pagesize == 0)
            {
                pagesize = 6;
            }


            PageModel3 page = new PageModel3();
            if (connetion.State == System.Data.ConnectionState.Closed)
            {
                connetion.Open();
            }

            var sql = "exec ReturnGoods @OrderNumber,@AddrPhone,@State,@puttime,@endtimes,@pageindex,@pagesize,@totalcount out";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = connetion;
            SqlParameter[] Parameters = new SqlParameter[] {
                new SqlParameter(){ ParameterName="@OrderNumber",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=OrderName},
                new SqlParameter(){ ParameterName="@AddrPhone",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=AddrPhone},
                   new SqlParameter(){ ParameterName="@State",SqlDbType=System.Data.SqlDbType.Int,SqlValue=State},
                new SqlParameter(){ ParameterName="@puttime",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=puttime},
                     new SqlParameter(){ ParameterName="@endtimes",SqlDbType=System.Data.SqlDbType.VarChar,SqlValue=endtimes},
                new SqlParameter(){ ParameterName="@pageindex",SqlDbType=System.Data.SqlDbType.Int,SqlValue=pageindex},
                new SqlParameter(){ ParameterName="@pagesize",SqlDbType=System.Data.SqlDbType.Int,SqlValue=pagesize},
                 new SqlParameter(){ ParameterName="@totalcount",SqlDbType=System.Data.SqlDbType.Int,Direction=System.Data.ParameterDirection.Output},
            };
            cmd.Parameters.AddRange(Parameters);
            var res = cmd.ExecuteReader();

            var read = DataReadHelp.DataRead<ReturnGoodsModel>(res);
            connetion.Close();
            page.totalcount = Convert.ToInt32(cmd.Parameters["@totalcount"].Value);
            page.list = read;

            return page;
        }
        public List<SalesReturn> shenReturns(int id)
        {
            string sql =$"select s.*,t.ReturnName,g.GoodsName,g.MarketPrice,ct.TypeName,b.BrandName from SalesReturn as s join RetutnType as t on s.ReturmRemark=t.Id  join  GoodsInfo  as g on g.GoodId=s.GoodsId  join CommodityType as ct on ct.TypeId=g.GoodsType join BrandInfo as b on b.DrandId=g.BrandId where s.ReturnId={id}";
            return DBHelper.GetToList<SalesReturn>(sql);

        }
        /// <summary>
        /// 确定收货拒绝收货
        /// </summary>
        public int UpdateRetutn(int state,int Id)
        {
            string sql = $"update SalesReturn  set ReturnState = {state} where ReturnId={Id}";
            return xDBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 退货原因设置
        /// </summary>
        /// <returns></returns>
        public List<RetutnType> retutnTypes()
        {
            string sql = "select * from RetutnType where State = 1";
            return DBHelper.GetToList<RetutnType>(sql);
        }
        /// <summary>
        /// 退货原因操作
        /// </summary>
        /// <param name="id"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public int DeleteType(string id)
        {
            string sql =$"update RetutnType set State=2 where Id in ({id})";
            return xDBHelper.ExecuteNonQuery(sql);
        }

        
    }
}
