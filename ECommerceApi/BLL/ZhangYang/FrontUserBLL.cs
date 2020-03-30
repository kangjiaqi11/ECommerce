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
    }
}
