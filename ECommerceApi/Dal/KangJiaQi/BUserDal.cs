
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace Dal
{
    public class BUserDal
    {
        DBHelper DBHelper = new DBHelper();
        #region 用户登录
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="Register"></param>
        /// <param name="UserPwd"></param>
        /// <returns></returns>
        public int UserLogin(string Register, string UserPwd)
        {
            string sql = $"select  top 1 UserId from UserInfo where(UserEmil collate Chinese_PRC_CS_AS = '{Register}' or UserPhoto collate Chinese_PRC_CS_AS ='{Register}'  or UserAccount collate Chinese_PRC_CS_AS = '{Register}') and UserPwd = '{UserPwd}'";
            return Convert.ToInt32(DBHelper.ExecuteScalar(sql));
        }
        /// <summary>
        /// 获取用户的盐
        /// </summary>
        /// <param name="Register"></param>
        /// <returns></returns>
        public string GetState(string Register)
        {
            string sql = $"select  top 1 Salt from UserInfo where(UserEmil collate Chinese_PRC_CS_AS = '{Register}' or UserPhoto collate Chinese_PRC_CS_AS ='{Register}'  or UserAccount collate Chinese_PRC_CS_AS = '{Register}')";
            return Convert.ToString(DBHelper.ExecuteScalar(sql));
        }

        #endregion
        #region 用户相关的
        /// <summary>
        /// 用户添加
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int UserAdd(UserInfo info)
        {
            string sql = $"insert into UserInfo (UserName,UserAccount ,Salt,UserPhoto,DepartmentId,state,CreateTime,UpdateTime,CreateId,UpdateId,UserPwd,UserEmil,RoleId) values('{info.UserName}','{info.UserAccount}','{info.Salt}','{info.UserPhoto}',{info.DepartmentId},{info.state},'{info.CreateTime}','{info.UpdateTime}',{info.CreateId},{info.UpdateId},'{info.UserPwd}','{info.UserEmil}',{info.RoleId})";
            return OrmDbHelper.ExecuteSql(sql);
        }
        /// <summary>
        /// 部门表显示
        /// </summary>
        /// <returns></returns>
        public List<Department> DepartmentShow()
        {
            string sql = "select * from Department";
            return OrmDbHelper.GetList<Department>(sql);
        }
        /// <summary>
        /// 获取用户名
        /// </summary>
        /// <returns></returns>
        public UserInfo GetUserName(int UserId)
        {
            string sql = $"select UserName,Salt from UserInfo where UserId={UserId}";
            return OrmDbHelper.GetInfo<UserInfo>(sql);
        }
        /// <summary>
        /// 锁屏解锁
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Userpwd"></param>
        /// <returns></returns>
        public int Locked(string UserName,string Userpwd)
        {
            string sql = $"select Count(1) from UserInfo where UserName='{UserName}' and UserPwd='{Userpwd}'";
            return Convert.ToInt32( DBHelper.ExecuteScalar(sql));
        }
        /// <summary>
        /// 个人信息
        /// </summary>
        /// <returns></returns>
        public UserInfo personage(int UserId)
        {
            string sql = $"select * from UserInfo as u join Department as d on u.DepartmentId=d.DepartmentId join Role as r on r.RoleId=u.RoleId where UserId={UserId}";
            return OrmDbHelper.GetInfo<UserInfo>(sql);
        }
        #endregion

    }
}
