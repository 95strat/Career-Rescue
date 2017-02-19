using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Career_Rescue.Startup))]
namespace Career_Rescue
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
