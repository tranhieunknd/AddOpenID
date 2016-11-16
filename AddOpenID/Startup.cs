using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AddOpenID.Startup))]
namespace AddOpenID
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
