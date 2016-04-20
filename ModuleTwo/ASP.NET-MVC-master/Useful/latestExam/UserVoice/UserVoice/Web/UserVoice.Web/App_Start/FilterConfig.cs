using System.Web;
using System.Web.Mvc;
using UserVoice.Web.CustomFilters;

namespace UserVoice.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomHeader());
        }
    }
}
