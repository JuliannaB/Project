using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Grater.Startup))]
namespace Grater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
