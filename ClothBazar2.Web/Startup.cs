using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClothBazar2.Web.Startup))]
namespace ClothBazar2.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
