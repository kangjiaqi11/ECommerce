using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace Dal
{
    /// <summary>
    /// 菜单dal
    /// </summary>
   public class MenusDal
    {
        /// <summary>
        /// 菜单栏的显示
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public List<Jurisdiction> MenusShow(int UserId)
        {
            string sql = $"select * from Jurisdiction as j join Department as d on  j.DepartmentId=d.DepartmentId  join MenusInfo as m on j.MenusId = m.MenusId join UserInfo as u  on u.DepartmentId=d.DepartmentId where u.UserId={UserId}";
            return OrmDbHelper.GetList<Jurisdiction>(sql);
        }
        /// <summary>
        /// 子级菜单的显示
        /// </summary>
        /// <param name="MenusId"></param>
        /// <returns></returns>
        public List<MenusInfo> MenusSublevel(int FatherUrl)
        {
            string sql = $"select * from MenusInfo where FatherUrl={FatherUrl}";
            return OrmDbHelper.GetList<MenusInfo>(sql);
        }
    }
     
}
