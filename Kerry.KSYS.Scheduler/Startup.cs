using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using System.Configuration;


[assembly: OwinStartupAttribute(typeof(Kerry.KSYS.Scheduler.Startup), "Configuration")]
namespace Kerry.KSYS.Scheduler
{

    public static class Startup
    {
        public static void ConfigureSignalR(IAppBuilder app)
        {
            app.MapSignalR();
        }

        public static void Configuration(IAppBuilder app)
        {
            Kerry.KSYS.Scheduler.Startup.ConfigureSignalR(app);
        }
    }
}
