using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sistema_CECEES.Startup))]
namespace Sistema_CECEES
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
