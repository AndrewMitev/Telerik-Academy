using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YoutubeSystem.Startup))]
namespace YoutubeSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
