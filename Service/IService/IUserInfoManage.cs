using Common;
using Domain;
using System;

namespace Service
{
    /// <summary>
    /// 用户操作接口
    /// </summary>
    public interface IUserInfoManage : IRepository<UserInfo>
    {
        /// <summary>
        /// 用户登录验证
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        LoginResults UserLogin(string account, string password);
        /// <summary>
        /// 是否是博主
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        bool IsBolgger(Guid Id);
        /// <summary>
        /// 从Cookie中获取用户
        /// </summary>
        /// <returns></returns>
        UserInfo GetUserByCookie();
        /// <summary>
        /// 根据帐号获取用户
        /// </summary>
        /// <param name="account">账号</param>
        /// <returns></returns>
        UserInfo GetUserByAccount(string account);
    }
}
