using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LinkoTest.Startup))]
namespace LinkoTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
