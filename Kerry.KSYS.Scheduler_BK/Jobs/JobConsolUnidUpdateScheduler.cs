using Kerry.KSYS.Scheduler.JOBOperationService;
using Quartz;
using System.Threading.Tasks;

namespace Kerry.KSYS.Scheduler.Jobs
{
    public class JobConsolUnidUpdateScheduler : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            return Task.Factory.StartNew(() => new JOBOperationClient().AddCONSOLUNID());
        }

    }
}