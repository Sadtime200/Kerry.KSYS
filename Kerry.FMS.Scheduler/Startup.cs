using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using System.Configuration;


[assembly: OwinStartupAttribute(typeof(Kerry.FMS.Scheduler.Startup), "Configuration")]
namespace Kerry.FMS.Scheduler
{

    public static class Startup
    {
        public static void ConfigureSignalR(IAppBuilder app)
        {
            app.MapSignalR();
        }

        public static void Configuration(IAppBuilder app)
        {
            Kerry.FMS.Scheduler.Startup.ConfigureSignalR(app);
        }
    }
}
