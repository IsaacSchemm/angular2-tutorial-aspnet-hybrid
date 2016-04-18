using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetHybrid.Startup))]
namespace AspNetHybrid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
