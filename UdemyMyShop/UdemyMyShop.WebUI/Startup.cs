using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UdemyMyShop.WebUI.Startup))]
namespace UdemyMyShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
