using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SsnDashBoard.Startup))]
namespace SsnDashBoard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
