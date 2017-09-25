using System;

namespace Domain
{
    public class Life : Entity
    {
        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// 发表日期
        /// </summary>
        public string PublicationDate { get; set; }
        /// <summary>
        /// 内容 
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// 点攒数
        /// </summary>
        public int? PointCount { get; set; }
        /// <summary>
        /// 类别Id
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// 评论数
        /// </summary>
        public int? CommentCount { get; set; }
    }
}
