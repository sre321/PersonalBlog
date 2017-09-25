using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalBlog.Controllers
{
    public class CommonController : BaseController
    {
        /// <summary>
        /// 404
        /// </summary>
        /// <returns></returns>
        public ActionResult NotFound()
        {
            return View();
        }
    }
}