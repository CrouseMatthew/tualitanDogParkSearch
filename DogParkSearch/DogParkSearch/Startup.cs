using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DogParkSearch.Startup))]
namespace DogParkSearch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
