using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iGlasses.Startup))]
namespace iGlasses
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
