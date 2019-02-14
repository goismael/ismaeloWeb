using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IsmaelOuedraogo.Web.Startup))]
namespace IsmaelOuedraogo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
