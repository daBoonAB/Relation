using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Relation.Web.Helpers
{
    public static class MenuExtensions
    {
        public static MvcHtmlString MenuItem(
            this HtmlHelper htmlHelper,
            string text,
            string action,
            string controller
        )
        {
            var li = new TagBuilder("li");
            var routeData = htmlHelper.ViewContext.RouteData;
            var currentAction = routeData.GetRequiredString("action");
            var currentController = routeData.GetRequiredString("controller");
            //string.Equals(currentAction, action, StringComparison.OrdinalIgnoreCase) &&
            if (
                string.Equals(currentController, controller, StringComparison.OrdinalIgnoreCase))
            {
                li.AddCssClass("active");
            }
            li.InnerHtml = htmlHelper.ActionLink(text, action, controller).ToHtmlString();
            return MvcHtmlString.Create(li.ToString());
        }
    }
}
