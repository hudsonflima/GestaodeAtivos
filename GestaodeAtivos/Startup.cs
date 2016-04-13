using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestaodeAtivos.Startup))]
namespace GestaodeAtivos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
