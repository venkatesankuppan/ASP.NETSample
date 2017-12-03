using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GreenSampleMVC.Startup))]
namespace GreenSampleMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
