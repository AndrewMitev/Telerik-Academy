using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxHomework.Startup))]
namespace AjaxHomework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
