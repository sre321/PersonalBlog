using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace PersonalBlog
{
    /// <summary>
    /// html扩展类
    /// </summary>
    public static class HtmlExtensions
    {
        /// <summary>
        /// 通过枚举类生成RadioButton
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static MvcHtmlString RadioButtonForEnum<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
        {
            var metaData = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            //var names = Enum.GetNames(metaData.ModelType);
            var enumsList = Tools.BindEnumsList(metaData.ModelType);
            var sb = new StringBuilder();
            foreach (var item in enumsList)
            {
                var id = string.Format(
                    "{0}_{1}_{2}",
                    htmlHelper.ViewData.TemplateInfo.HtmlFieldPrefix,
                    metaData.PropertyName,
                    item.Name
                );

                var radio = htmlHelper.RadioButtonFor(expression, item.Name, new { id = id, value = item.Name }).ToHtmlString();
                sb.AppendFormat(
                    "<div class=\"radio radio-success\">{0} <label for=\"{1}\">{2}</label></div>",
                    radio,
                    id,
                    HttpUtility.HtmlEncode(item.Text)
                );
            }
            return MvcHtmlString.Create(sb.ToString());
        }
        /// <summary>
        /// 日期选择器
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="htmlAttributes">表单html属性集合</param>
        /// <returns></returns>
        public static MvcHtmlString LayerDateFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, object htmlAttributes = null)
        {
            var sb = new StringBuilder();
            string stringDate = "";
            RouteValueDictionary newAttributes = null;
            var attributes = new StringBuilder();
            var metaData = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            var date = metaData.Model as DateTime?;
            if (date != null)
                stringDate = date.Value.ToString("yyyy-MM-dd");
            if (htmlAttributes != null)
                newAttributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
            foreach (var attribute in newAttributes)
            {
                attributes.AppendFormat(attribute.Key + "=" + "\"" + attribute.Value + "\"");
            }

            sb.AppendFormat("<input value=\"{0}\" {1} id=\"{2}\" name=\"{2}\" placeholder=\"请选择日期\">", stringDate, attributes, metaData.PropertyName);
            return MvcHtmlString.Create(sb.ToString());
        }
        /// <summary>
        /// 省市选择器
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="level">几级选择</param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MvcHtmlString PCAlinkageFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, int level, object htmlAttributes = null)
        {
            var sb = new StringBuilder();
            RouteValueDictionary newAttributes = null;
            var attributes = new StringBuilder();
            var metaData = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            if (htmlAttributes != null)
                newAttributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
            foreach (var attribute in newAttributes)
            {
                attributes.AppendFormat(attribute.Key + "=" + "\"" + attribute.Value + "\"");
            }
            if (level == 1)
            {
                sb.AppendFormat("<select name=\"province\" id=\"{0}province\" {1}><option value=\"请选择\">请选择</option></select>", metaData.PropertyName, attributes);
            }
            else if (level == 2)
            {
                sb.AppendFormat("<select name=\"province\" id=\"{0}province\" {1}><option value=\"请选择\">请选择</option></select> <select name=\"city\" id=\"{0}city\" {1}></select>", metaData.PropertyName, attributes);
            }
            else
            {
                sb.AppendFormat("<select name=\"province\" id=\"{0}province\" {1}><option value=\"请选择\">请选择</option></select> <select name=\"city\" id=\"{0}city\" {1}></select> <select name=\"town\" id=\"{0}area\" {1}></select>", metaData.PropertyName, attributes);
            }
            sb.AppendFormat("<input type=\"hidden\" id=\"{0}\" name=\"{0}\" value=\"{1}\"/>", metaData.PropertyName, metaData.Model!=null?metaData.Model.ToString():"");
            return MvcHtmlString.Create(sb.ToString());
        }
    }
}