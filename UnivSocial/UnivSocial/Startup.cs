using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnivSocial.Startup))]
namespace UnivSocial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
