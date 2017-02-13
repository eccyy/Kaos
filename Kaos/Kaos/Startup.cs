using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kaos.Startup))]
namespace Kaos
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
