using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDoperations.Startup))]
namespace CRUDoperations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
