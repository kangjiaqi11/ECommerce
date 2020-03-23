using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDCKClient;
namespace BLL
{
    /// <summary>
    /// 用户相关的mvcbll
    /// </summary>
    public class BUserBll
    {
        /// <summary>
        /// 登录
        /// 
        /// </summary>
        /// <param name="bUserLoginRequst"></param>
        /// <returns></returns>
        public BUserLoginResponse BUserLogin(BUserLoginRequst bUserLoginRequst,string GetApiName)
        {
            return ApiRequestHelper.Post<BUserLoginRequst, BUserLoginResponse>(bUserLoginRequst, GetApiName);
        }
        /// <summary>
        ///用户添加
        /// </summary>
        /// <param name="bUserAddRequst"></param>
        /// <returns></returns>
        public BUserAddResponse BUseradd(BUserAddRequst bUserAddRequst,string GetApiName)
        {
            return ApiRequestHelper.Post<BUserAddRequst,BUserAddResponse > (bUserAddRequst,GetApiName);
        }
        /// <summary>
        /// 部门显示
        /// </summary>
        /// <returns></returns>
        public DepartmentResponse DepartmentShow(DepartmentRequst departmentRequst,string GetApiName)
        {
            return ApiRequestHelper.Post<DepartmentRequst, DepartmentResponse>(departmentRequst,GetApiName);
        }
        //        <!-- BEGIN LOGIN FORM -->
        //<form class="login-form" action="/BUser/UserLogin" method="post">
        //    <h3 class="form-title">登录</h3>
        //    <div class="alert alert-danger display-hide">
        //        <button class="close" data-close="alert"></button>
        //        <span>
        //            Enter any username and password.
        //        </span>
        //    </div>
        //    <div class="form-group">
        //        <!--ie8, ie9 does not support html5 placeholder, so we just show field title for that-->
        //        <label class="control-label visible-ie8 visible-ie9">用户名</label>
        //        <input class="form-control form-control-solid placeholder-no-fix" type="text" autocomplete="off" placeholder="Username" name="UserName" />
        //    </div>
        //    <div class="form-group">
        //        <label class="control-label visible-ie8 visible-ie9">密码</label>
        //        <input class="form-control form-control-solid placeholder-no-fix" type="password" autocomplete="off" placeholder="UserPwd" name="UserPwd"/>
        //    </div>
        //    <div class="form-actions">
        //        <a href = "/BUser/UserRegist" > 登录 </ a >
        //        < label class="rememberme check">
        //            <input type = "checkbox" name="remember" value="1" />记住
        //          </label>
        //    </div>
        //    <div class="login-options">

        //    </div>
        //    <div class="create-account">
        //        <p>
        //            <a href = "javascript:;" id="register-btn" class="uppercase">创建一个账户</a>
        //        </p>
        //    </div>
        //</form>
        //<!-- END LOGIN FORM -->
        //<!-- BEGIN REGISTRATION FORM -->
        //<form class="register-form" action="/BUser/UserRegista" method="post" >
        //    <h3>注册</h3>
        //    <p class="hint">
        //        请输入您的账户信息
        //    </p>
        //    <div class="form-group">
        //        <label class="control-label visible-ie8 visible-ie9">用户名称</label>
        //        <input class="form-control placeholder-no-fix" type="text" placeholder="用户名称" name="UserName" />
        //    </div>
        //    <div class="form-group">
        //        <!--ie8, ie9 does not support html5 placeholder, so we just show field title for that-->
        //        <label class="control-label visible-ie8 visible-ie9">账户</label>
        //        <input class="form-control placeholder-no-fix" type="text" placeholder="账户" name="UserAccount" />
        //    </div>
        //    <div class="form-group">
        //        <label class="control-label visible-ie8 visible-ie9">密码</label>
        //        <input class="form-control placeholder-no-fix" type="password" placeholder="密码" name="UsrPwd" />
        //    </div> 
        //    <div class="form-group">
        //        <label class="control-label visible-ie8 visible-ie9">确认密码</label>
        //        <input class="form-control placeholder-no-fix" type="password" placeholder="确认密码" name="UserConPwd" />
        //    </div>
        //    <div class="form-group">
        //        <label class="control-label visible-ie8 visible-ie9">部门</label>
        //        <select name = "Department" class="form-control">
        //            <option value = "0" > 请选择 </ option >
        //        </ select >
        //    </ div >
        //    < p class="hint">
        //        在下面输入您的详细信息
        //    </p>
        //    <div class="form-group">
        //        <label class="control-label visible-ie8 visible-ie9">手机号</label>
        //        <input class="form-control placeholder-no-fix" type="text" placeholder="手机号" name="UserPhoto" />
        //    </div>
        //    <div class="form-group">
        //        <label class="control-label visible-ie8 visible-ie9">邮箱</label>
        //        <input class="form-control placeholder-no-fix" type="text" placeholder="邮箱" name="UserEmil" />
        //    </div>
        //    <div class="form-group margin-top-20 margin-bottom-20">
        //        <label class="check">
        //            <input type = "checkbox" name="tnc" /> I agree to the<a href= "javascript:;" >
        //                  Terms of Service
        //            </a>
        //            & <a href = "javascript:;" >
        //                  Privacy Policy
        //              </a>
        //          </label>
        //        <div id = "register_tnc_error" >


        //          </ div >


        //      </ div >


        //      < div class="form-actions">
        //        <button type = "button" id="register-back-btn" class="btn btn-default">Back</button>
        //        <button type = "submit" id="register-submit-btn" class="btn btn-success uppercase pull-right">Submit</button>
        //    </div>
        //</form>
        //<!-- END REGISTRATION FORM -->

    }
}
