using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TruongTooo.Startup))]
namespace TruongTooo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
