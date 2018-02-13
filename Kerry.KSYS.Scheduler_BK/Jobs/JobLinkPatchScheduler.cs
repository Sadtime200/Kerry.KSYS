using Kerry.KSYS.Scheduler.JOBLINKsOperationService;
using Quartz;
using System.Threading.Tasks;

namespace Kerry.KSYS.Scheduler.Jobs
{
    public class JobLinkPatchScheduler:IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
           return Task.Factory.StartNew(() =>new JOBLINKsOperationClient().Supplyment());
        }
    }
}