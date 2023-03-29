using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenGiaHuy_2080600024_BigSchool.Startup))]
namespace NguyenGiaHuy_2080600024_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
