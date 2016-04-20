namespace MvcTemplate.Web.CustomFilters
{
    using System.Web.Mvc;

    public class AddIPHeaderFilter : ActionFilterAttribute
    {
        private const string Key = "X-ROSES-ARE-RED-VIOLETS-ARE-BLUE-I-KNOW-EVERYTHING-ABOUT-YOU";

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string ip = filterContext.HttpContext.Request.UserHostAddress;
            filterContext.HttpContext.Response.Headers.Add(Key, ip);
        }
    }
}
