using Kerry.FMS.Scheduler.CommonOperationServiceReference;
using Quartz;


namespace Kerry.FMS.Scheduler.Jobs
{
    public class JobLockSyncScheduler : IJob
    {
       // private ILog logger = LogManager.GetLogger("JobLockSyncScheduler");
        public void Execute(IJobExecutionContext context)
        {
             new CommonOperationServiceClient().AutoJobLock();
        }
    }
}