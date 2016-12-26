using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstModelWebApplication.Startup))]
namespace FirstModelWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
