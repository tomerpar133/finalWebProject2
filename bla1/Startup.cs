using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bla1.Startup))]
namespace bla1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
