using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AbInition.Startup))]
namespace AbInition
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
