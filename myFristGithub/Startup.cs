using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myFristGithub.Startup))]
namespace myFristGithub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
