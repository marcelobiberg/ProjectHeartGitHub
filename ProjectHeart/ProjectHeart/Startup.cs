using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectHeart.Startup))]
namespace ProjectHeart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
