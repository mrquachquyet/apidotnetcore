using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace VNCDCL.Core.Extensions
{
    public static class HtmlExtensions
    {
        public static string IsSelected(this IHtmlHelper html, string controllers = null, string action = null, string cssClass = null)
        {

            if (string.IsNullOrEmpty(cssClass))
                cssClass = "active";

            var currentAction = (string)html.ViewContext.RouteData.Values["action"];
            var currentController = (string)html.ViewContext.RouteData.Values["controller"];

            if (string.IsNullOrEmpty(controllers))
                controllers = currentController;

            if (string.IsNullOrEmpty(action))
                action = currentAction;

            currentAction = currentAction.ToLower();
            action = action.ToLower();
            currentController = currentController.ToLower();
            controllers = controllers.ToLower();

            var list = controllers.Split(new[] { "::" }, StringSplitOptions.RemoveEmptyEntries);
            if (list.Contains(currentController) && action == currentAction && (currentController.ToLower() == "Dashboard".ToLower() || currentController.ToLower() == "Setting".ToLower()))
            {
                return cssClass;
            }
            else if (list.Contains(currentController) && (currentController.ToLower() != "Dashboard".ToLower() && currentController.ToLower() != "Setting".ToLower()))
            {
                return cssClass;
            }
            return string.Empty;
        }
    }
}
