using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using MODEL.ZhangYang;
using SDCKClient;

namespace BLL.ZhangYang
{
    public class StoreroomBLL
    {
        public Fenye StoreroomFenye(int PageIndex, int PageSize, string ShoopName)
        {
            BUserAddResponse sar = new BUserAddResponse();
            return dal.StoreroomFenye(PageIndex, PageSize, ShoopName);
        }
    }
}
