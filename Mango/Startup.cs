using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mango.Startup))]
namespace Mango
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
