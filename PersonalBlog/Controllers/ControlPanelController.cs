using Common;
using Domain;
using Service;
using System;
using System.Web.Mvc;

namespace PersonalBlog.Controllers
{
    /// <summary>
    /// 后台管理控制器
    /// </summary>
    public class ControlPanelController : BaseController
    {
        #region 声明容器
        /// <summary>
        /// 用户管理
        /// </summary>
        IUserInfoManage UserInfoManage { get; set; }
        #endregion
        /// <summary>
        /// 后台首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Home()
        {
            //if (!CurrentUser.IsBlogger)
            //    return Redirect("Front/Home");
            return View();
        }
        /// <summary>
        /// 用户资料
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        public ActionResult ShowUserInfo(string userId)
        {
            Guid userGuid = new Guid();
            Guid.TryParse(userId, out userGuid);
            var user = UserInfoManage.GetById(userGuid);
            if (user == null)
                return Redirect(Url.Action("NotFound", "Common"));
            return View(user);
        }
        /// <summary>
        /// 编辑用户资料
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        public ActionResult EditUserInfo(string userId)
        {
            UserInfoEditModel userEditModel = null;
            Guid userGuid = new Guid();
            Guid.TryParse(userId, out userGuid);
            var user = UserInfoManage.GetById(userGuid);
            userEditModel = user.MapTo(userEditModel);
            if (userEditModel == null)
                return Redirect(Url.Action("NotFound", "Common"));
            return View(userEditModel);
        }
        /// <summary>
        /// 保存用户资料
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult EditUserInfo(UserInfoEditModel model)
        {
            var json = new JsonHelper { Status = "0", Msg = "保存失败！" };
            UserInfo user = null;
            if (model.Id != null)
                user = UserInfoManage.GetById(model.Id);
            if (user != null)
            {
                user = model.MapTo(user);
                //账号必须唯一
                var userByAccount = UserInfoManage.GetUserByAccount(user.Account);
                if (userByAccount == null || userByAccount.Id == model.Id)
                {
                    if (UserInfoManage.Update(user))
                    {
                        json.Status = "1";
                        json.Msg = "保存成功！";
                    }
                }
                else
                {
                    json.Msg = "该账号已存在！";
                    return Json(json);
                }
            }
            return Json(json);
        }
        /// <summary>
        /// 修改用户头像
        /// </summary>
        /// <param name="imageId"></param>
        /// <returns></returns>
        public PartialViewResult _EditHeadImage(string imageId)
        {
            return PartialView();
        }
        /// <summary>
        /// 保存用户头像
        /// </summary>
        /// <param name="imageId"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult _EditHeadImage(Picture model)
        {
            return Json(new { n=1});
        }
    }
}