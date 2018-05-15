using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsultancyBridge.Startup))]
namespace ConsultancyBridge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
