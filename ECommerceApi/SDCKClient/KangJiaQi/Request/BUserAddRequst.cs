using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient
{
    /// <summary>
    /// 用户添加的参数
    /// </summary>
    public class BUserAddRequst : BaseRequest
    {
       
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 账户
        /// </summary>
        public string UserAccount { get; set; }
        /// <summary>
        /// 盐
        /// </summary>
        public string Salt { get; set; }
        /// <summary>
        /// 用户手机号
        /// </summary>
        public string UserPhoto { get; set; }
        /// <summary>
        /// 用户年龄
        /// </summary>
        public int UserAge { get; set; }
        /// <summary>
        /// 部门id
        /// </summary>
        public int DepartmentId { get; set; }
        /// <summary>
        /// 数据状态
        /// </summary>
        public int state { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CeateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public int CreateId { get; set; }
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
        public int UpdateId { get; set; }
        /// <summary>
        /// 角色id
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// 获取api路径
        /// </summary>
        /// <returns></returns>
        public override string GetApiName()
        {
            throw new NotImplementedException();
        }
    }
}         
