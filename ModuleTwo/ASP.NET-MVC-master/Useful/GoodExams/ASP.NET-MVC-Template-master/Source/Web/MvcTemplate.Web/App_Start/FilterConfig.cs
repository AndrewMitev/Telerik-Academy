namespace MvcTemplate.Web
{
    using System.Web.Mvc;
    using CustomFilters;

    public static class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new AddIPHeaderFilter());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
