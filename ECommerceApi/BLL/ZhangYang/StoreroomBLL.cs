using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using MODEL.ZhangYang;
using SDCKClient.ZhangYang.Request;
using SDCKClient.ZhangYang.Response;

namespace BLL.ZhangYang
{
    public class StoreroomBLL
    {
        //
        public StoreroomShowResp StoreroomFenye(StoreroomShowReq Ssrq)
        {
            StoreroomDal dal = new StoreroomDal();
            StoreroomShowResp Ssr = new StoreroomShowResp();
            var ser = dal.StoreroomFenye( Ssrq.PageIndex, Ssrq.PageSize, Ssrq.ShoopName);

            if (ser!=null)
            {
                Ssr.StoList = ser;
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