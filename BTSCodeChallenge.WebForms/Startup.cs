using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BTSCodeChallenge.WebForms.Startup))]
namespace BTSCodeChallenge.WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
