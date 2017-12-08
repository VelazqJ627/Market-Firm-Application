using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarketingFirm.Startup))]
namespace MarketingFirm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
