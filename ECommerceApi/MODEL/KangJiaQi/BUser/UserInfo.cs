using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    /// <summary>
    /// 用户表
    /// </summary>
   public class UserInfo
    {
        /// <summary>
        /// 后台用户表id
        /// </summary>
        public long UserId       { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string UserName     { get; set; }
        /// <summary>
        /// 账户
        /// </summary>
        public string UserAccount  { get; set; }
        /// <summary>
        /// 盐
        /// </summary>
        public string Salt         { get; set; }
        /// <summary>
        /// 用户手机号
        /// </summary>
        public string UserPhoto    { get; set; }
        /// <summary>
        /// 用户年龄
        /// </summary>
        public int UserAge      { get; set; }
        /// <summary>
        /// 部门id
        /// </summary>
        public long DepartmentId { get; set; }
        /// <summary>
        /// 数据状态
        /// </summary>
        public int state        { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime   { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public long CreateId     { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
      public string UserEmil { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPwd { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public long UpdateId     { get; set; }
        /// <summary>
        /// 角色id
        /// </summary>
        public long RoleId       { get; set; }
    }
}
