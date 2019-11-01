using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeWebApplication.Startup))]
namespace EmployeeWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
