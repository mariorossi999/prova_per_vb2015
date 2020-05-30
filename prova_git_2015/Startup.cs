using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prova_git_2015.Startup))]
namespace prova_git_2015
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
