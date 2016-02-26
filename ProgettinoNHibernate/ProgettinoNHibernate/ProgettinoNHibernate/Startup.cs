using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProgettinoNHibernate.Startup))]
namespace ProgettinoNHibernate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
