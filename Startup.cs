using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChanhThuStore.Startup))]
namespace ChanhThuStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
