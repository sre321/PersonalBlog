using AutoMapper;
using Domain;
using PersonalBlog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Common
{
    /// <summary>
    /// 基础映射类配置
    /// </summary>
    public class SourceProfile:Profile
    {
        public SourceProfile()
        {
            //用户信息映射
            base.CreateMap<UserInfo, UserInfoEditModel>();
            base.CreateMap<UserInfoEditModel, UserInfo>();
        }
    }
}