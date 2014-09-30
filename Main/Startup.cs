using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Main.Startup))]
namespace Main
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
