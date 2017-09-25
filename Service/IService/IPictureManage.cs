using Domain;
using System;

namespace Service
{
    /// <summary>
    /// 图片操作接口
    /// </summary>
    public interface IPictureManage : IRepository<Picture>
    {
        /// <summary>
        /// 获取图片路径
        /// </summary>
        /// <param name="picture">图片</param>
        /// <param name="key"></param>
        /// <returns></returns>
        string GetPictureUrl(Picture picture,string key);
        /// <summary>
        /// 根据图片Id获取图片路径
        /// </summary>
        /// <param name="pictureId"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        string GetPictureUrlById(string pictureId,string key);
    }
}
