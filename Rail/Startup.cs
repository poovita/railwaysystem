using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rail.Startup))]
namespace Rail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
