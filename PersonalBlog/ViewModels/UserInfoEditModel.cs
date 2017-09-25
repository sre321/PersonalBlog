using Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalBlog
{
    public class UserInfoEditModel
    {
        public Guid Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Required(ErrorMessage ="请输入姓名")]
        [Display(Name = "姓名")]
        public string Name { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        [Required(ErrorMessage = "请输入昵称")]
        [Display(Name = "昵称")]
        public string NickName { get; set; }
        /// <summary>
        /// 登录账号
        /// </summary>
        [Required(ErrorMessage = "请输入账号")]
        [Display(Name = "账号")]
        public string Account { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        [Required(ErrorMessage = "请选择出生日期")]
        [Display(Name = "出生日期")]
        public DateTime? BirthDate { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [Required(ErrorMessage = "请选择性别")]
        [Display(Name = "性别")]
        public Gender Gender { get; set; }
        /// <summary>
        /// 籍贯
        /// </summary>
        [Display(Name = "籍贯")]
        public string NativePlace { get; set; }
        /// <summary>
        /// 现居地
        /// </summary>
        [Display(Name = "现居地")]
        public string PresentAdd { get; set; }
        /// <summary>
        /// 职业
        /// </summary>
        [Display(Name = "职业")]
        public string Career { get; set; }
        /// <summary>
        /// 兴趣爱好
        /// </summary>
        [Display(Name = "兴趣爱好")]
        public string Interest { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [Display(Name = "关于我")]
        public string Description { get; set; }
    }
}
