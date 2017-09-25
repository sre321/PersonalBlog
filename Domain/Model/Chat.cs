using System;

namespace Domain
{
    public class Chat : Entity
    {
        /// <summary>
        /// 图片
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// 点攒数
        /// </summary>
        public int? PointCount { get; set; }
        /// <summary>
        /// 发表日期
        /// </summary>
        public DateTime? PublicationDate { get; set; }

    }
}
