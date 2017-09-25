using Common;
using Domain;
using System;
using System.Linq;

namespace Service
{
    /// <summary>
    /// 用户操作实现类
    /// </summary>
    public class UserInfoManage : EFRepository<UserInfo>, IUserInfoManage
    {
        /// <summary>
        /// 是否是博主
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool IsBolgger(Guid Id)
        {
            if (string.IsNullOrEmpty(Id.ToString()))
                return false;
            UserInfo user = GetById(Id);
            if (user == null)
                return false;
            return user.IsBlogger;
        }

        /// <summary>
        /// 用户登录验证
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public LoginResults UserLogin(string accountOrEmail, string password)
        {
            if (string.IsNullOrEmpty(accountOrEmail) || string.IsNullOrEmpty(password))
                return LoginResults.NotExist;
            var user = GetUserByAccount(accountOrEmail);
            if (user == null)
                user = GetUserByEmail(accountOrEmail);
            if (user == null)
                return LoginResults.NotExist;
            if (user.PassWord != password)
                return LoginResults.WrongPassword;
            if (user.IsLock)
                return LoginResults.Locked;
            else
                return LoginResults.Successful;
        }
        /// <summary>
        /// 从Cookie中获取用户
        /// </summary>
        /// <returns></returns>
        public UserInfo GetUserByCookie()
        {
            //var cookie = CookieHelper.GetCookie("UserGuid");
            //if (cookie != null && !string.IsNullOrEmpty(cookie.Value))
            //    return this.GetById(cookie);
            //return null;
            return GetById(new Guid("31758c3d-8933-4ca1-8780-8a4477fb5517"));
        }
        /// <summary>
        /// 根据帐号获取用户
        /// </summary>
        /// <param name="account">账号</param>
        /// <returns></returns>
        public UserInfo GetUserByAccount(string account)
        {
            var userAll = from u in LoadAll()
                          orderby u.Id
                          where u.Account == account
                          select u;
            return userAll.FirstOrDefault();
        }
        #region Utilitis
        /// <summary>
        /// 根据邮箱获取用户
        /// </summary>
        /// <param name="Email">邮箱</param>
        /// <returns></returns>
        private UserInfo GetUserByEmail(string email)
        {
            var userAll = from u in LoadAll()
                          orderby u.Id
                          where u.Email == email
                          select u;
            return userAll.FirstOrDefault();
        }
        #endregion
    }
}
