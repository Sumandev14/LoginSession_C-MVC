﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SchoolManagement_380.SessionHelper
{
    public class ActionFilter: ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (SessionHelper.Email == "")
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "CreateLogin", controller = "Login" }));
            }
            base.OnActionExecuting(filterContext);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }

    }
}