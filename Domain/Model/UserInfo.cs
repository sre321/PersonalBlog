using Common;
using System;

namespace Domain
{
    public class UserInfo: Entity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 登录账号
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string PassWord { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime? BirthDate { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// 籍贯
        /// </summary>
        public string NativePlace { get; set; }
        /// <summary>
        /// 现居地
        /// </summary>
        public string PresentAdd { get; set; }
        /// <summary>
        /// 职业
        /// </summary>
        public string Career { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public Guid HeadImage { get; set; }
        /// <summary>
        /// 兴趣爱好
        /// </summary>
        public string Interest { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 是否博主
        /// </summary>
        public bool IsBlogger { get; set; }
        /// <summary>
        /// 是否锁定
        /// </summary>
        public bool IsLock { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 最后一次登录时间
        /// </summary>
        public DateTime? LastLoginTime { get; set; }
        /// <summary>
        /// 最后一次登录IP
        /// </summary>
        public string LastLoginIP { get; set; }
    }
}
