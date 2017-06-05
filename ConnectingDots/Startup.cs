using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConnectingDots.Startup))]
namespace ConnectingDots
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
