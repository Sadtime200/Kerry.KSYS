﻿using System.Runtime.Serialization;

namespace Kerry.KSYS.Scheduler.Models
{
    [DataContract]
    public class ScheduleTaskDisplay
    {
        [DataMember]
        public string TaskName { get; set; }
        [DataMember]
        public string CronString { get; set; }
        [DataMember]
        public string TaskType { get; set; }
        [DataMember]
        public string Status { get; set; }

        public ScheduleTaskDisplay(string taskName, string taskType, string cronString, string status)
        {
            TaskName = taskName;
            CronString = cronString;
            TaskType = taskType;
            Status = status;

        }

    }
}