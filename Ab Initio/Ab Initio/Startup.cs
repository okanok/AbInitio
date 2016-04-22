using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ab_Initio.Startup))]
namespace Ab_Initio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
