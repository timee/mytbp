using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTBP.Startup))]
namespace MyTBP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
