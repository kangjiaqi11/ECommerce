using Dal.ZhangYang;
using MODEL.ZhangYang;
using SDCKClient.ZhangYang.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ZhangYang
{
    public class MemberBLL
    {
        public MemberShowResp MemberShow()
        {
            MemberDAL dal = new MemberDAL();
            MemberShowResp Ssr = new MemberShowResp();
            var ser = dal.MemberShow();

            if (ser != null)
            {
                Ssr.Members = ser;
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
