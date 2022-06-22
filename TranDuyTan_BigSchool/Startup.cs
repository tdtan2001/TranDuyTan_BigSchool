using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranDuyTan_BigSchool.Startup))]
namespace TranDuyTan_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
