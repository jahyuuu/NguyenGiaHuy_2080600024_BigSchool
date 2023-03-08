using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenGiaHuy_2080600024.Startup))]
namespace NguyenGiaHuy_2080600024
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
