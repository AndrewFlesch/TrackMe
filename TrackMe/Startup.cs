using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrackMe.Startup))]
namespace TrackMe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
