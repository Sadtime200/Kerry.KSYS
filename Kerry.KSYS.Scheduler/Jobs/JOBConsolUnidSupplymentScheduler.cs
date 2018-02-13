using Quartz;
using Kerry.KSYS.Scheduler.JOBOperationService;

namespace Kerry.KSYS.Scheduler.Jobs
{
    public class JOBConsolUnidSupplymentScheduler:IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            var client = new JOBOperationClient();
            try
            {
                client.AddCONSOLUNID();
            }
            catch (System.Exception)
            {

                throw;
            }
            finally
            {
                client.Close();
            }
        }
    }
}