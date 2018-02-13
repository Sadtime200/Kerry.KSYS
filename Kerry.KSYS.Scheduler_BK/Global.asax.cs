using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using Quartz.Impl;

namespace Kerry.KSYS.Scheduler
{
    public class Global : HttpApplication
    {
        private Quartz.IScheduler scheduler = new StdSchedulerFactory().GetScheduler();
        //private ILog logger = LogManager.GetLogger(typeof(MvcApplication));

        protected void Application_Start()
        {
            //log4net.Config.XmlConfigurator.Configure();
            AreaRegistration.RegisterAllAreas();
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            JobSchedule JobSchedule = new JobSchedule();
            List<ScheduleTask> ScheduleTask = JobSchedule.ScheduleTaskInit();
            foreach (var ScheduleTaskItem in ScheduleTask)
            {
                if (ScheduleTaskItem.Status == "Enabled")
                    scheduler.ScheduleJob(ScheduleTaskItem.Job, ScheduleTaskItem.Trigger);
            }
            scheduler.Start();
        }
    }
}