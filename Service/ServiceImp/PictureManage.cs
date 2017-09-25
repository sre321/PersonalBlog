using Common;
using Domain;
using System;

namespace Service
{
    public class PictureManage : EFRepository<Picture>, IPictureManage
    {
        /// <summary>
        /// 获取图片路径
        /// </summary>
        /// <param name="picture">图片</param>
        /// <param name="key">图片</param>
        /// <returns></returns>
        public string GetPictureUrl(Picture picture, string key)
        {
            //图片格式
            var suffix = "jpg";
            var mimeType = picture.MimeType.Split('/')[1];
            if (!string.IsNullOrEmpty(mimeType))
                suffix = mimeType;
            if (picture.PictureType == PictureType.HeadImage)
                return string.Format("/Uploads/HeadImage/{0}_{1}.{2}", picture.PictureName, key != null ? key : "", suffix);
            else
                return string.Format("/Uploads/Content/{0}_{1}.{2}", picture.PictureName, key != null ? key : "", suffix);
        }
        /// <summary>
        /// 根据图片Id获取图片路径
        /// </summary>
        /// <param name="pictureId"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetPictureUrlById(string pictureId, string key)
        {
            Guid pictureGuid = new Guid();
            Guid.TryParse(pictureId, out pictureGuid);
            var picture = GetById(pictureGuid);
            if (picture == null)
                return "";
            else
                return GetPictureUrl(picture, key);
        }
    }
}
