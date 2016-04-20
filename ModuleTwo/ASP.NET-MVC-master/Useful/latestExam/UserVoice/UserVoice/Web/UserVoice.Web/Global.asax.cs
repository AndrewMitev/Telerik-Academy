using UserVoice.Data.Migrations;
using UserVoice.Data;
using UserVoice.Web.App_Start;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using UserVoice.Web.Infrastructure.Mapping;
using System.Reflection;

namespace UserVoice.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
            AutofacConfig.RegisterAutofac();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var autoMapper = new AutoMapperConfig();
            autoMapper.Execute(Assembly.GetExecutingAssembly());
        }
    }
}
