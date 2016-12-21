using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWcfSite.Startup))]
namespace TestWcfSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
