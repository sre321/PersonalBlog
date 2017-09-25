using System.Web;
using System.Web.Optimization;

namespace PersonalBlog
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Bundles/Jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/Bundles/Modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/Bundles/Bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            #region 后台

            bundles.Add(new StyleBundle("~/Bundles/BackCss").Include(
                         "~/Content/css/bootstrap.min14ed.css",
                         "~/Content/css/font-awesome.min93e3.css",
                         "~/Content/css/animate.min.css",
                         "~/Content/css/style.min862f.css"
                         ));
            bundles.Add(new ScriptBundle("~/Bundles/BackJquery").Include(
                        "~/js/jquery.min.js",
                        "~/js/bootstrap.min.js"
                        ));
            bundles.Add(new ScriptBundle("~/Bundles/HPlus").Include(
                        "~/js/hplus.min.js"
                        ));
            bundles.Add(new ScriptBundle("~/Bundles/Content").Include(
                        "~/js/content.min.js"
                        ));
            #endregion

            #region 前台

            #endregion

            #region 插件
            //metisMenu(侧边栏插件)
            bundles.Add(new ScriptBundle("~/Bundles/MetisMenu").Include(
                        "~/js/metisMenu/jquery.metisMenu.js"
                        ));
            //slimscroll(滚动条插件)
            bundles.Add(new ScriptBundle("~/Bundles/Slimscroll").Include(
                        "~/js/slimscroll/jquery.slimscroll.min.js"
                        ));
            //layer(弹出层插件)
            bundles.Add(new ScriptBundle("~/Bundles/Layer").Include(
                        "~/js/layer/layer.js"
                        ));
            //pace(网页自动加载进度条插件)
            bundles.Add(new ScriptBundle("~/Bundles/Pace").Include(
                        "~/js/pace/pace.min.js"
                        ));
            //peity(图表插件）
            bundles.Add(new ScriptBundle("~/Bundles/Peity").Include(
                        "~/js/peity/jquery.peity.min.js",
                        "~/js/demo/peity-demo.min.js"
                        ));
            //validate(表单验证）
            bundles.Add(new ScriptBundle("~/Bundles/Jqueryval").Include(
                        "~/js/jquery.validate*"));
            //Ajax(异步提交）
            bundles.Add(new ScriptBundle("~/Bundles/Ajax").Include(
                        "~/js/jquery.unobtrusive-ajax.min.js"));
            //layerDate(日期选择器）
            bundles.Add(new ScriptBundle("~/Bundles/Laydate").Include(
                        "~/js/laydate/laydate.js"));
            //pcalinkage(省市区联动插件）
            bundles.Add(new ScriptBundle("~/Bundles/PCAlinkage").Include(
                        "~/js/pcalinkage/pcalinkage.js"
                        ));
            //awesome-checkbox(checkbox和radio样式）
            bundles.Add(new StyleBundle("~/Bundles/Checkbox").Include(
                        "~/Content/css/awesome-checkbox/awesome-bootstrap-checkbox.css"
                        ));
            //cropper(图片剪裁插件）
            bundles.Add(new StyleBundle("~/Bundles/Cropper").Include(
                        "~/js/cropper/cropper.css"
                        ));
            bundles.Add(new ScriptBundle("~/Bundles/Cropper").Include(
                        "~/js/cropper/cropper.js"
                        ));
            #endregion
        }
    }
}
