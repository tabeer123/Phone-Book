using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Phone_Book.Startup))]
namespace Phone_Book
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
