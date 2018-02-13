using Quartz;
using Kerry.KSYS.Scheduler.JOBLINKsOperationService;


namespace Kerry.KSYS.Scheduler.Jobs
{
    public class JOBLINKsSupplymentScheduler : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            var client = new JOBLINKsOperationClient();
            try
            {
                client.Supplyment();
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