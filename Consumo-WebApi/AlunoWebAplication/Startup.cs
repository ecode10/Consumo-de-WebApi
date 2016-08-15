using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlunoWebAplication.Startup))]
namespace AlunoWebAplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
