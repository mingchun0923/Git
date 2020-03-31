using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test_web_code.Startup))]
namespace test_web_code
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
