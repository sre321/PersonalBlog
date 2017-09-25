using System;

namespace Domain
{
    public class Module : Entity
    {
        /// <summary>
        /// 模块名
        /// </summary>
        public string ModuleName { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string HeadLine { get; set; }
    }
}
