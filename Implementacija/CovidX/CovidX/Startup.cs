using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CovidX.Startup))]
namespace CovidX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
