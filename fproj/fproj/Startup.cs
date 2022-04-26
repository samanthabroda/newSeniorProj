using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fproj.Startup))]
namespace fproj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
