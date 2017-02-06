using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_04WebAppSumator.Startup))]
namespace _04WebAppSumator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
