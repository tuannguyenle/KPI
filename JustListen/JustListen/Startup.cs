using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JustListen.Startup))]
namespace JustListen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
