
using System.ComponentModel;

namespace Common
{
    /// <summary>
    /// 枚举独特类
    /// </summary>
    public class EnumsClass
    {
        /// <summary>
        /// 枚举value
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// 枚举显示值
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 枚举说明
        /// </summary>
        public string Text { get; set; }
    }
    /// <summary>
    /// 登录返回类型
    /// </summary>
    public enum LoginResults
    {
        /// <summary>
        /// 用户不存在！
        /// </summary>
        NotExist = 0,
        /// <summary>
        /// 登录成功！
        /// </summary>
        Successful = 1,
        /// <summary>
        /// 密码错误！
        /// </summary>
        WrongPassword = 2,
        /// <summary>
        /// 用户已锁定！
        /// </summary>
        Locked = 3,
    }
    /// <summary>
    /// 性别
    /// </summary>
    public enum Gender
    {

        /// <summary>
        /// 王子
        /// </summary>
        [Description("王子")]
        Male = 2,
        /// <summary>
        /// 公主
        /// </summary>
        [Description("公主")]
        Female = 1,
        /// <summary>
        /// 不告诉你
        /// </summary>
        [Description("不告诉你")]
        Secret = 0,
    }
    /// <summary>
    /// 图片类型
    /// </summary>
    public enum PictureType
    {
        /// <summary>
        /// 头像
        /// </summary>
        [Description("头像")]
        HeadImage =1,
        /// <summary>
        /// 其它
        /// </summary>
        [Description("其它")]
        Content = 2,
    }
}
