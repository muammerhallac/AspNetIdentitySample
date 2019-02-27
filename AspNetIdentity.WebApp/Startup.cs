using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetIdentity.WebApp.Startup))]
namespace AspNetIdentity.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
