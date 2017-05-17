using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chastag_Project.Startup))]
namespace Chastag_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
