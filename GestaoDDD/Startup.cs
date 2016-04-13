using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestaoDDD.Startup))]
namespace GestaoDDD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
