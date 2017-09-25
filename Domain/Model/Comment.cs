using System;

namespace Domain
{
    public class Comment : Entity
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 父评论Id
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime PostTime { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// 模块Id
        /// </summary>
        public int ModuleId { get; set; }
    }
}
