using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using MODEL.ZhangYang;
using SDCKClient;
using SDCKClient.ZhangYang.Response;

namespace BLL.ZhangYang
{
    public class StoreroomBLL
    {
        //
        public Fenye StoreroomFenye(int PageIndex, int PageSize, string ShoopName)
        {
            
            StoreroomShowResp Ssr = new StoreroomShowResp();
            var ser = StoreroomDal.StoreroomFenye(int PageIndex, int PageSize, string ShoopName);
        }
    }
}