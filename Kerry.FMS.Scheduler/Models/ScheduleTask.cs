using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Kerry.FMS.Scheduler.Services;

namespace Kerry.FMS.Scheduler.Models
{


    public class JobDetail
    {
        public string TaskName { get; set; }
        public string TaskType { get; set; }
    }


    [DataContract]
    public class ScheduleTask
    {
        [DataMember]
        public string TaskName { get; set; }
        [DataMember]
        public string CronString { get; set; }
        [DataMember]
        public string TaskType { get; set; }
        [DataMember]
        public JobKey TaskKey { get; set; }
        [DataMember]
        public JobDataMap TaskParameter { get; set; }
        [DataMember]
        public IJobDetail Job { get; set; }
        [DataMember]
        public ITrigger Trigger { get; set; }
        [DataMember]
        public string Status { get; set; }

        public ScheduleTask(string taskName, string taskType, string cronString, IDictionary<string, object> taskParameter)
        {
            TaskName = taskName;
            CronString = cronString;
            TaskType = taskType;

            TaskKey = new JobKey(TaskName + "Job", TaskType);
            TaskParameter = new JobDataMap(taskParameter);

            Job = JobBuilder.Create(Type.GetType(taskType))
                .WithIdentity(TaskName + "Job", TaskType).SetJobData(TaskParameter)
                .Build();

            Trigger = TriggerBuilder.Create()
                .WithIdentity(TaskName + "Trigger", TaskType).WithCronSchedule(cronString).Build();
        }
        public ScheduleTask(string taskName, string taskType, string cronString, IDictionary<string, object> taskParameter, string taskStatus)
        {
            TaskName = taskName;
            CronString = cronString;
            TaskType = taskType;
            Status = taskStatus;
            TaskKey = new JobKey(TaskName + "Job", TaskType);
            TaskParameter = new JobDataMap(taskParameter);
            Job = JobBuilder.Create(Type.GetType(taskType))
                .WithIdentity(TaskName + "Job", TaskType).SetJobData(TaskParameter)
                .Build();
            Trigger = TriggerBuilder.Create()
                .WithIdentity(TaskName + "Trigger", TaskType).WithCronSchedule(cronString).Build();
        }

        public ScheduleTask(string taskName, Type taskType, IDictionary<string, object> taskParameter, string cronString = "",
            CronScheduleBuilder cronBuilder = null)
        {
            TaskName = taskName;
            CronString = cronString;

            TaskKey = new JobKey(TaskName + "Job", TaskType);
            TaskParameter = new JobDataMap(taskParameter);

            Job = JobBuilder.Create(taskType)
                        .WithIdentity(TaskName + "Job", TaskType).SetJobData(TaskParameter)
                        .Build();

            // Trigger the job to run on the next round minute
            if (cronBuilder != null)
            {
                Trigger = TriggerBuilder.Create()
                    .WithIdentity(TaskName + "Trigger", TaskType)
                    .WithSchedule(cronBuilder)
                    .Build();
            }
            else if (cronString.IsStringNullOrEmpty() == false)
            {
                Trigger = TriggerBuilder.Create()
                        .WithIdentity(TaskName + "Trigger", TaskType)
                        .WithCronSchedule(cronString)
                        .Build();
            }
            else
            {
                Trigger = TriggerBuilder.Create()
                    .WithIdentity(TaskName + "Trigger", TaskType)
                    .StartNow()
                    .Build();
            }
        }


        public ScheduleTask(IScheduler Sched, JobKey Key)
        {
            IJobDetail Job = Sched.GetJobDetail(Key);
            IList<ITrigger> Triggers = Sched.GetTriggersOfJob(Key);
            ICronTrigger OnlyTrigger = (ICronTrigger)Triggers[0];

            TaskType = Key.Group;
            TaskKey = Key;
            TaskName = Key.Name.Substring(0, Key.Name.Length - 4);
            CronString = OnlyTrigger.CronExpressionString;
            TaskParameter = Job.JobDataMap;
        }

        public ScheduleTaskDisplay TaskToDisplay()
        {
            return new ScheduleTaskDisplay(TaskName, TaskType, CronString, Status);
        }
    }
}