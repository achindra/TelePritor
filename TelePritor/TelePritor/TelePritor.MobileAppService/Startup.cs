using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TelePritor.MobileAppService.Startup))]

namespace TelePritor.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}