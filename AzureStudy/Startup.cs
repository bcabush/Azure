using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureStudy.Startup))]
namespace AzureStudy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
