using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SATProject.Startup))]
namespace SATProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
