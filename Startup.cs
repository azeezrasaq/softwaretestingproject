using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(softwareproject.Startup))]
namespace softwareproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
