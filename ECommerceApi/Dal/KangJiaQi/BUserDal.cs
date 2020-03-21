
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class BUserDal
    {
        DBHelper DBHelper = new DBHelper();
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
    }
}
