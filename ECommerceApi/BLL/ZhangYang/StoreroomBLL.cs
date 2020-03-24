using Dal;
using MODEL.ZhangYang;
using SDCKClient;

namespace BLL.ZhangYang
{
    public class StoreroomBLL
    {
        StoreroomDal dal = new StoreroomDal();
        public Fenye StoreroomFenye(int PageIndex, int PageSize, string ShoopName)
        {
            BUserAddResponse sar = new BUserAddResponse();
            return dal.StoreroomFenye(PageIndex, PageSize, ShoopName);
        }
    }
}
