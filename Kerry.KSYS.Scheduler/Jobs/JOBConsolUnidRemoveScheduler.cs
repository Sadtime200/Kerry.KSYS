using Quartz;
using Kerry.KSYS.Scheduler.JOBOperationService;


namespace Kerry.KSYS.Scheduler.Jobs
{

    public class JOBConsolUnidRemoveScheduler : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            var client = new JOBOperationClient();
            try
            {
                client.RemoveCONSOLUNID();
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