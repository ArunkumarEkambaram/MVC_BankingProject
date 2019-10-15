using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_BankingProject.Startup))]
namespace MVC_BankingProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
