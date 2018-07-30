using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A_chan_website.Startup))]
namespace A_chan_website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
