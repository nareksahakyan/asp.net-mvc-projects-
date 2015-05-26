using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(project_st.Startup))]
namespace project_st
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
