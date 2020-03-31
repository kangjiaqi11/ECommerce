using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.ZhangYang;
using SDCKClient.ZhangYang.Request;
using SDCKClient.ZhangYang.Response;

namespace BLL.ZhangYang
{
    public class FrontUserBLL
    {
        public FrontUserShowResp FrontUserFenye(FrontUserShowReq Ssrq)
        {
            FrontUserDAL dal = new FrontUserDAL();
            FrontUserShowResp Ssr = new FrontUserShowResp();
            var ser = dal.FrontUserFenye(Ssrq.PageIndex, Ssrq.PageSize, Ssrq.UserName);

            if (ser != null)
            {
                Ssr.Frolist = ser;
                Ssr.IsSuccess = true;
            }
            else
            {
                Ssr.Status = -1;
                Ssr.Msg = "显示失败";
            }
            return Ssr;
        }
        //详情1
        public FrontUserShow1Resp FrontUserShow1()
        {
            FrontUserDAL dal = new FrontUserDAL();
            FrontUserShow1Resp Ssr = new FrontUserShow1Resp();
            var ser = dal.FrontUserShow1();

            if (ser != null)
            {
                Ssr.FrontUser1 = ser;
                Ssr.IsSuccess = true;
            }
            else
            {
                Ssr.Status = -1;
                Ssr.Msg = "显示失败";
            }
            return Ssr;
        }
        //详情2
        public FrontUserShow2Resp FrontUserShow2()
        {
            FrontUserDAL dal = new FrontUserDAL();
            FrontUserShow2Resp Ssr = new FrontUserShow2Resp();
            var ser = dal.FrontUserShow2();

            if (ser != null)
            {
                Ssr.FrontUser2 = ser;
                Ssr.IsSuccess = true;
            }
            else
            {
                Ssr.Status = -1;
                Ssr.Msg = "显示失败";
            }
            return Ssr;
        }
    }
}
