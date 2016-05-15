using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Check_Out.Startup))]
namespace Check_Out
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
