using Common.Logging;
using Microsoft.Ajax.Utilities;
using Quartz;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Kerry.FMS.Scheduler.Jobs
{
    public class JobSyncScheduler : IJob
    {
        private ILog logger = LogManager.GetLogger("JobSyncScheduler");

        public void Execute(IJobExecutionContext context)
        {
            logger.Info("-------------:  AAAAAAAA :-------------");
            logger.Error("-------------: AAAAAAAA -------------");
            logger.Debug("-------------: SSSAAAAAAAA -------------");
            logger.Warn("-------------: SSSAAAAAAAA -------------");
        }
    }
}
