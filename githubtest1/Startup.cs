using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(githubtest1.Startup))]
namespace githubtest1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
