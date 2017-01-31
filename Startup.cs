using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(comp4976_lab3.Startup))]
namespace comp4976_lab3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
