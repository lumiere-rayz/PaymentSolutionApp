using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaymentSolutionApp.Startup))]
namespace PaymentSolutionApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
