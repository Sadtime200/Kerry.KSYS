using Kerry.KSYS.Scheduler.Models;
using Quartz;
using Quartz.Impl.Matchers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;

namespace Kerry.KSYS.Scheduler.Services
{
    public class JobSchedule
    {

        protected static IScheduler MasterScheduler;

        String quartz_jobs_Schedule_Path = HttpContext.Current.Server.MapPath("/quartz_jobs_Schedule.xml");
        public List<ScheduleTask> ScheduleTaskInit()
        {
            List<ScheduleTask> ScheduleTask = new List<ScheduleTask>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(quartz_jobs_Schedule_Path);
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("job-scheduling-data").ChildNodes;

            foreach (XmlNode xn in nodeList)
            {

                string taskName = String.Empty;
                string taskType = String.Empty;
                string cronString = String.Empty;
                string taskStatus = String.Empty;
                Dictionary<string, object> taskParameter = new Dictionary<string, object>();

                XmlElement xe = (XmlElement)xn;
                XmlNodeList nls = xe.ChildNodes;
                foreach (XmlNode xn1 in nls)
                {
                    if (xn1.Name == "name")
                    {
                        taskName = xn1.InnerText;
                        continue;
                    }
                    if (xn1.Name == "job-type")
                    {
                        taskType = xn1.InnerText.Split(',')[0];
                        continue;
                    }
                    if (xn1.Name == "status")
                    {
                        taskStatus = xn1.InnerText;
                        continue;
                    }
                    if (xn1.Name == "cron-expression")
                    {
                        cronString = xn1.InnerText;
                        continue;
                    }
                    taskParameter.Add(xn1.Name, xn1.InnerText);
                }
                if (ScheduleTask.Where(t => t.TaskName.Equals(taskName)) != null && ScheduleTask.Where(t => t.TaskName.Equals(taskName)).Count() > 0)
                    continue;
                ScheduleTask.Add(new ScheduleTask(taskName, taskType, cronString, taskParameter, taskStatus));
            }
            return ScheduleTask;
        }



        public List<SelectListItem> GetJobName()
        {
            List<SelectListItem> Jobs = new List<SelectListItem>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(quartz_jobs_Schedule_Path);
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("job-scheduling-data").ChildNodes;

            foreach (XmlNode xn in nodeList)
            {
                string taskName = String.Empty;
                string taskType = String.Empty;
                XmlElement xe = (XmlElement)xn;
                XmlNodeList nls = xe.ChildNodes;
                foreach (XmlNode xn1 in nls)
                {
                    if (xn1.Name == "name")
                    {
                        taskName = xn1.InnerText;
                        continue;
                    }
                    if (xn1.Name == "job-type")
                    {
                        taskType = xn1.InnerText.Split(',')[0];
                        continue;
                    }
                }
                if (Jobs.Where(t => t.Text.Equals(taskName)) != null && Jobs.Where(t => t.Text.Equals(taskName)).Count() > 0)
                    continue;
                Jobs.Add(new SelectListItem() { Text = taskName, Value = taskName });
            }
            return Jobs;
        }




        public List<ScheduleTask> ScheduleTask()
        {
            List<ScheduleTask> ScheduleTask = new List<ScheduleTask>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(quartz_jobs_Schedule_Path);
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("job-scheduling-data").ChildNodes;

            foreach (XmlNode xn in nodeList)
            {

                string taskName = String.Empty;
                string taskType = String.Empty;
                string cronString = String.Empty;
                string taskStatus = String.Empty;
                Dictionary<string, object> taskParameter = new Dictionary<string, object>();

                XmlElement xe = (XmlElement)xn;
                XmlNodeList nls = xe.ChildNodes;
                foreach (XmlNode xn1 in nls)
                {
                    if (xn1.Name == "name")
                    {
                        taskName = xn1.InnerText;
                        continue;
                    }
                    if (xn1.Name == "job-type")
                    {
                        taskType = xn1.InnerText.Split(',')[0];
                        continue;
                    }
                    if (xn1.Name == "status")
                    {
                        taskStatus = xn1.InnerText;
                        continue;
                    }
                    if (xn1.Name == "cron-expression")
                    {
                        cronString = xn1.InnerText;
                        continue;
                    }
                    taskParameter.Add(xn1.Name, xn1.InnerText);
                }
                if (ScheduleTask.Where(t => t.TaskName.Equals(taskName)) != null && ScheduleTask.Where(t => t.TaskName.Equals(taskName)).Count() > 0)
                    continue;
                ScheduleTask.Add(new ScheduleTask(taskName, taskType, cronString, taskParameter, taskStatus));
            }
            return ScheduleTask;
        }


        public void UpdateScheduleStatus(String taskName, String taskStatus)
        {
            //XmlTextWriter xml = new XmlTextWriter(quartz_jobs_Schedule_Path, Encoding.UTF8);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(quartz_jobs_Schedule_Path);
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("job-scheduling-data").ChildNodes;


            foreach (XmlNode xn in nodeList)
            {
                XmlElement xe = (XmlElement)xn;
                XmlNodeList nls = xe.ChildNodes;
                foreach (XmlNode xn1 in nls)
                {
                    if (xn1.Name == "name" && xn1.InnerText != taskName)
                    {
                        break;
                    }
                    if (xn1.Name == "status")
                    {
                        xn1.InnerText = taskStatus;
                        continue;
                    }
                }
            }
            xmlDoc.Save(quartz_jobs_Schedule_Path);
        }

        public void UpdateScheduleCron(String taskName, String cronString)
        {
            //XmlTextWriter xml = new XmlTextWriter(quartz_jobs_Schedule_Path, Encoding.UTF8);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(quartz_jobs_Schedule_Path);
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("job-scheduling-data").ChildNodes;


            foreach (XmlNode xn in nodeList)
            {
                XmlElement xe = (XmlElement)xn;
                XmlNodeList nls = xe.ChildNodes;
                foreach (XmlNode xn1 in nls)
                {
                    if (xn1.Name == "name" && xn1.InnerText != taskName)
                    {
                        break;
                    }
                    if (xn1.Name == "cron-expression")
                    {
                        xn1.InnerText = cronString;
                        continue;
                    }
                }
            }
            xmlDoc.Save(quartz_jobs_Schedule_Path);
        }



        public bool CreateTask(ScheduleTask Task, IScheduler MasterScheduler)
        {
            if (!MasterScheduler.CheckExists(Task.Job.Key) && !MasterScheduler.CheckExists(Task.Trigger.Key))
            {
                MasterScheduler.ScheduleJob(Task.Job, Task.Trigger);

                MasterScheduler.PauseJob(Task.Job.Key);
                Task.Status = "Disabled";
                return true;
            }
            else return false;
        }




        public bool RemoveTask(ScheduleTask Task, IScheduler MasterScheduler)
        {
            string TriggerState = MasterScheduler.GetTriggerState(Task.Trigger.Key).ToString();
            if (MasterScheduler.GetTriggerState(Task.Trigger.Key).ToString() == "Paused")
            {
                MasterScheduler.DeleteJob(Task.Job.Key);
                return true;
            }
            else return false;
        }

        public bool RemoveTask(string taskType, string taskName, IScheduler MasterScheduler)
        {
            JobKey JKey = new JobKey(taskName + "Job", taskType);
            TriggerKey TKey = new TriggerKey(taskName + "Trigger", taskType);

            //Check Suspended
            string TriggerState = MasterScheduler.GetTriggerState(TKey).ToString();
            if (MasterScheduler.GetTriggerState(TKey).ToString() == "Paused")
            {
                MasterScheduler.DeleteJob(JKey);
                return true;
            }
            else return false;
        }



        public void SuspendTask(ScheduleTask Task)
        {
            MasterScheduler.PauseJob(Task.TaskKey);
            Task.Status = "Disabled";
        }


        public void SuspendTask(string taskType, string taskName)
        {
            JobKey JKey = new JobKey(taskName + "Job", taskType);
            MasterScheduler.PauseJob(JKey);
        }

        public void ResumeTask(ScheduleTask Task)
        {
            MasterScheduler.ResumeJob(Task.TaskKey);
            Task.Status = "Enabled";
        }

        public void ResumeTask(string taskType, string taskName)
        {
            JobKey JKey = new JobKey(taskName + "Job", taskType);
            MasterScheduler.ResumeJob(JKey);
        }


        public IList<ScheduleTaskDisplay> ListAllTasks()
        {
            IList<string> JobGroups = MasterScheduler.GetJobGroupNames();
            ScheduleTask Task;
            ScheduleTaskDisplay Display;
            IList<ScheduleTaskDisplay> DisplayTaskList = new List<ScheduleTaskDisplay>();

            foreach (string Group in JobGroups)
            {
                var GroupMatcher = GroupMatcher<JobKey>.GroupEquals(Group);
                var JobKeys = MasterScheduler.GetJobKeys(GroupMatcher);
                foreach (var JobKey in JobKeys)
                {
                    Task = new ScheduleTask(MasterScheduler, JobKey);
                    Display = Task.TaskToDisplay();
                    DisplayTaskList.Add(Display);
                }
            }

            return DisplayTaskList;
        }

    }
}