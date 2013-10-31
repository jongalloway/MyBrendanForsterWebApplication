using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication24.Startup))]
namespace WebApplication24
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
