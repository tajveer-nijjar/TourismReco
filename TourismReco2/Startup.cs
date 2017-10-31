using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TourismReco2.Startup))]
namespace TourismReco2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
