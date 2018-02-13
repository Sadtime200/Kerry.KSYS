using Quartz;
using Kerry.KSYS.Scheduler.JOBOperationService;


namespace Kerry.KSYS.Scheduler.Jobs
{
    public class JOBConsolUnidUpdateScheduler:IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            var client = new JOBOperationClient();
            try
            {
                client.UpdateCONSOLUNID();
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