using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Web.Mvc;
using System.Web.Routing;

namespace oleg_izolation.Framework
{
    public class CustomAuthorize : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            var skipAuthorization = filterContext.ActionDescriptor.IsDefined(typeof(AllowAnonymousAttribute), false);
            if (skipAuthorization)
            {
                return;
            }


            var actionAttribute = (CustomAuthorize)filterContext.ActionDescriptor.GetCustomAttributes(typeof(CustomAuthorize), false).FirstOrDefault();
            var hasAccessToAction = actionAttribute != null;
            filterContext.Result = hasAccessToAction ? null : new RedirectToRouteResult(new RouteValueDictionary(new { controller = "CallBack", action = "LogIn" }));
        }
    }
}