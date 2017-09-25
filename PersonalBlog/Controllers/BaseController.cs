using Common;
using Domain;
using System.Web.Mvc;

namespace PersonalBlog.Controllers
{
    public class BaseController : Controller
    {
        UserInfo currentUser = UserContext.CurrentUser;
        //public UserInfo CurrentUser
        //{
        //    get
        //    {
        //        //父类使用spring.NET要单独注入
        //        IApplicationContext ctx = ContextRegistry.GetContext();
        //        IUserInfoManage UserInfoManage = (IUserInfoManage)ctx.GetObject("Service.UserInfo");

        //        //从Session中获取用户对象
        //        var user = SessionHelper.GetSession("CurrentUser");
        //        if (user != null)
        //            return user as UserInfo;
        //        //Session过期 通过Cookies中的信息 重新获取用户对象 并存储于Session中
        //        user = UserInfoManage.GetUserByCookie();
        //        SessionHelper.SetSession("CurrentUser", user);
        //        return user as UserInfo;
        //    }
        //}
    }
}