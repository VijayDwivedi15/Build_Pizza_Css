using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PizzaCss.Startup))]
namespace PizzaCss
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
