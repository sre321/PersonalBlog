using Domain;
using Service;
using Spring.Context;
using Spring.Context.Support;

namespace Common
{
    /// <summary>
    /// 用户上下文
    /// </summary>
    public static class UserContext
    {
        /// <summary>
        /// 获取当前用户
        /// </summary>
        public static UserInfo CurrentUser
        {
            get
            {
                //单独注入
                IApplicationContext ctx = ContextRegistry.GetContext();
                IUserInfoManage userInfoManage = (IUserInfoManage)ctx.GetObject("Service.UserInfo");

                //从Session中获取用户对象
                var user = SessionHelper.GetSession("CurrentUser");
                if (user != null)
                    return user as UserInfo;
                //Session过期 通过Cookies中的信息 重新获取用户对象 并存储于Session中
                user = userInfoManage.GetUserByCookie();
                SessionHelper.SetSession("CurrentUser", user);
                return user as UserInfo;
            }
        }
    }
}