using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Koolitusede.Startup))]
namespace Koolitusede
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
