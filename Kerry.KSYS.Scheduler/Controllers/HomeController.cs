using Kerry.KSYS.Scheduler.Models;
using Kerry.KSYS.Scheduler.Services;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Kerry.KSYS.Scheduler.Controllers
{
    public class HomeController : Controller
    {
        private static ISchedulerFactory schFactory = new StdSchedulerFactory();
        protected static IScheduler MasterScheduler = schFactory.GetScheduler();

        public ActionResult Index()
        {
            JobSchedule JobSchedule = new JobSchedule();
            return View(new LogSearch()
            {
                LogDate_Search = DateTime.Now,
                Jobs = JobSchedule.GetJobName(),
                Types = new List<SelectListItem>() {
            new SelectListItem(){ Text="ALL Records",Value="ALL",Selected=true},
            new SelectListItem(){ Text="INFO",Value="INFO"},
            new SelectListItem(){ Text="DEBUG",Value="DEBUG"},
            new SelectListItem(){ Text="ERROR",Value="ERROR"},
            new SelectListItem(){ Text="Warning",Value="Warning"}
                }
            });
        }


        public ActionResult TaskList(String TaskName, string SubmitType)
        {
            JobSchedule JobSchedule = new JobSchedule();
            List<ScheduleTask> ScheduleTask = JobSchedule.ScheduleTask();
            if (SubmitType == "Run")
            {
                var ScheduleTask_Run = ScheduleTask.Where(t => t.TaskName.Equals(TaskName)).FirstOrDefault();
                if (ScheduleTask_Run != null)
                {
                    JobSchedule.CreateTask(ScheduleTask_Run, MasterScheduler);
                    MasterScheduler.ResumeJob(ScheduleTask_Run.TaskKey);
                    ScheduleTask_Run.Status = "Enabled";
                    JobSchedule.UpdateScheduleStatus(TaskName, "Enabled");
                }
            }
            else if (SubmitType == "Pause")
            {

                schFactory = new StdSchedulerFactory();
                MasterScheduler = schFactory.GetScheduler();
                var ScheduleTask_Pause = ScheduleTask.Where(t => t.TaskName.Equals(TaskName)).FirstOrDefault();
                if (ScheduleTask_Pause != null)
                {
                    MasterScheduler.PauseJob(ScheduleTask_Pause.TaskKey);
                    ScheduleTask_Pause.Status = "Disabled";

                    JobSchedule.UpdateScheduleStatus(TaskName, "Disabled");
                }
            }
            return PartialView(ScheduleTask);
        }



        public ActionResult LoGList(LogSearch LogSearch)
        {
            List<Log> LoGList = new List<Log>();
            string DirectoryLoGFile = ConfigurationManager.AppSettings["LoGFile"];

            if (!Directory.Exists(DirectoryLoGFile))
            {
                DirectoryLoGFile = Server.MapPath("/" + DirectoryLoGFile);
                if (!Directory.Exists(DirectoryLoGFile))
                {
                    return PartialView(LoGList);
                }
            }
            var Directory_LoGFile = Path.Combine(DirectoryLoGFile + LogSearch.JobName_Search + "/", String.Format("{0}.txt", LogSearch.LogDate_Search.ToString("yyyy-MM-dd")));
            if (!System.IO.File.Exists(Directory_LoGFile))
            {
                return PartialView(LoGList);
            }

            try
            {

                var fs = new FileStream(Directory_LoGFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("GB2312"));
                string strLine = sr.ReadLine();
                while (strLine != null)
                {
                    strLine = sr.ReadLine();
                    try
                    {
                        Regex rg = new Regex("\\{[^\\}]*\\}", RegexOptions.Multiline | RegexOptions.Singleline);
                        MatchCollection mc = rg.Matches(strLine);
                        //foreach (Match match in mc)
                        //{
                        //    GroupCollection groups = match.Groups;
                        //    var strMatch = groups[0].Value + ",";
                        //}
                        LoGList.Add(new Log()
                        {
                            LineID = 0,
                            JobName = getvalue(mc[2].Value, "{", "}"),
                            Logtype = getvalue(mc[1].Value, "{", "}"),
                            LogDate = DateTime.Parse(getvalue(mc[0].Value, "{", "}").Split(',')[0]),
                            Info = getvalue(mc[3].Value, "{", "}")
                        });
                    }
                    catch { }
                }
                sr.Dispose();
                sr.Close();
            }
            catch
            {
            }
            if (!String.IsNullOrWhiteSpace(LogSearch.Key_Search))
                LoGList = LoGList.Where(t => t.Info.Contains(LogSearch.Key_Search)).ToList();


            if (LogSearch.JobType_Search != "ALL")
                LoGList = LoGList.Where(t => t.Logtype.Contains(LogSearch.JobType_Search)).ToList();

            return PartialView(LoGList.OrderByDescending(t => t.LogDate).ToList());
        }


        private string getvalue(string str, string start, string end)
        {
            Regex rg = new Regex("(?<=(" + start + "))[.\\s\\S]*?(?=(" + end + "))", RegexOptions.Multiline | RegexOptions.Singleline);
            return rg.Match(str).Value;
        }


        [HttpPost]
        public JsonResult EditCronString(string TaskName, string CronString)
        {
            JobSchedule JobSchedule = new JobSchedule();
            try
            {
                var Trigger = TriggerBuilder.Create()
                      .WithIdentity(TaskName + "Trigger", TaskName + "TriggerGroup").WithCronSchedule(CronString).Build();
                JobSchedule.UpdateScheduleCron(TaskName, CronString);
                List<ScheduleTask> ScheduleTask = JobSchedule.ScheduleTask();
                var ScheduleTask_Run = ScheduleTask.Where(t => t.TaskName.Equals(TaskName)).FirstOrDefault();
                if (ScheduleTask_Run != null)
                {
                    var OldStatus = ScheduleTask_Run.Status;
                    MasterScheduler.PauseJob(ScheduleTask_Run.Job.Key);
                    JobSchedule.RemoveTask(ScheduleTask_Run, MasterScheduler);
                    JobSchedule.CreateTask(ScheduleTask_Run, MasterScheduler);
                    if (OldStatus == "Enabled")
                    {
                        MasterScheduler.ResumeJob(ScheduleTask_Run.TaskKey);
                        ScheduleTask_Run.Status = "Enabled";
                    }
                }
                return Json("Success");
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
    }
}