using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BTSCodeChallenge.MVC.Startup))]
namespace BTSCodeChallenge.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
