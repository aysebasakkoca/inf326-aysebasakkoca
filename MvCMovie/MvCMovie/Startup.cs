using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvCMovie.Startup))]
namespace MvCMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
