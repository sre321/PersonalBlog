using Common;
using System;

namespace Domain
{
    public class Picture:Entity
    {
        /// <summary>
        /// 图片类型
        /// </summary>
        public PictureType PictureType { get; set; }
        /// <summary>
        /// 图片格式
        /// </summary>
        public string MimeType { get; set; }
        /// <summary>
        /// Alt属性
        /// </summary>
        public string AltAttribute { get; set; }
        /// <summary>
        /// 上传人
        /// </summary>
        public Guid OwnerId { get; set; }
        /// <summary>
        /// 文件名
        /// </summary>
        public string PictureName { get; set; }
        /// <summary>
        /// 原文件名
        /// </summary>
        public string OwnPicName { get; set; }
        /// <summary>
        /// 文件大小
        /// </summary>
        public long PictureLength { get; set; }
        /// <summary>
        /// 上传时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
