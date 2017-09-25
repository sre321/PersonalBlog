using Domain;
using Service;
using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalBlog.Extensions
{
    /// <summary>
    /// 用户信息扩展
    /// </summary>
    public static class UserInfoExtension
    {
        static IApplicationContext ctx = ContextRegistry.GetContext();
        static IPictureManage pictureManage = (IPictureManage)ctx.GetObject("Service.Picture");
        /// <summary>
        /// 获取用户头像
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public static string GetHeadImage(this UserInfo userInfo,string key)
        {
            if (userInfo!=null&&!string.IsNullOrEmpty(userInfo.HeadImage.ToString()))
                return pictureManage.GetPictureUrlById(userInfo.HeadImage.ToString(),key);
            else
                return "";
        }
    }
}