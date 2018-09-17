using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jqu_SP_Api.Startup))]
namespace Jqu_SP_Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
