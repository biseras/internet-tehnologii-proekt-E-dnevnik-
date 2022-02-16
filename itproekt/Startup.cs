using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(itproekt.Startup))]
namespace itproekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
