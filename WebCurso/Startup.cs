using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebCurso.Startup))]
namespace WebCurso
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
