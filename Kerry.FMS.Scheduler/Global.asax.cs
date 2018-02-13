using Common.Logging;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Kerry.FMS.Scheduler.Jobs;
using System.Configuration;
using Kerry.FMS.Scheduler.Services;
using Kerry.FMS.Scheduler.Models;

namespace Kerry.FMS.Scheduler
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private Quartz.IScheduler scheduler = new StdSchedulerFactory().GetScheduler();
        private ILog logger = LogManager.GetLogger(typeof(MvcApplication));

        protected void Application_Start()
        {
            log4net.Config.XmlConfigurator.Configure();   
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
