using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_5.WebCalculator.Startup))]
namespace _5.WebCalculator
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
