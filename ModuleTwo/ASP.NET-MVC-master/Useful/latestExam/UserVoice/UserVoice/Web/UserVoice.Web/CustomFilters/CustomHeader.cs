using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserVoice.Web.CustomFilters
{
    public class CustomHeader : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Headers.Add("X-ROSES-ARE-RED-VIOLETS-ARE-BLUE", filterContext.RequestContext.HttpContext.User.Identity.Name);
        }
    }
}