using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pregunta2Landivar.Startup))]
namespace Pregunta2Landivar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
