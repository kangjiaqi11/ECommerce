
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
        public int GetState(string Register)
        {
            string sql = $"select  top 1 state from UserInfo where(UserEmil collate Chinese_PRC_CS_AS = '{Register}' or UserPhoto collate Chinese_PRC_CS_AS ='{Register}'  or UserAccount collate Chinese_PRC_CS_AS = '{Register}')";
            return Convert.ToInt32(DBHelper.ExecuteScalar(sql));
        }
        #endregion
        /// <summary>
        /// 用户添加
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int UserAdd(UserInfo info)
        {
            string sql = $"insert into UserInfo (UserName,UserAccount ,Salt,UserPhoto,DepartmentId,state,CeateTime,UpdateTime,CreateId,UpdateId,UserPwd,UserEmil,RoleId) values('{info.UserName}','{info.UserAccount}','{info.Salt}','{info.UserPhoto}',{info.DepartmentId},{info.state},'{info.CeateTime}','{info.UpdateTime}',{info.CreateId},{info.UpdateId},'{info.UserPwd}','{info.UserEmil}',{info.RoleId})";
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
