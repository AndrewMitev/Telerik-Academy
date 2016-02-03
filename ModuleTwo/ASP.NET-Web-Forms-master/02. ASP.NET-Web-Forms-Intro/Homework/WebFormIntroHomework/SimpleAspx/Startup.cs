using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleAspx.Startup))]
namespace SimpleAspx
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
