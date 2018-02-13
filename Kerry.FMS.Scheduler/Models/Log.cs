using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kerry.FMS.Scheduler.Models
{
    public class Log
    {
        public decimal LineID { get; set; }
        public DateTime LogDate { get; set; }
        public string JobName { get; set; }
        public string Info { get; set; }
        public string Logtype { get; set; }
    }
    public class LogSearch
    {

        [DisplayName("LogDate")]
        [Required(ErrorMessageResourceName = "Validation_Required_Error", ErrorMessageResourceType = typeof(UI))]
        public DateTime LogDate_Search { get; set; }
        [DisplayName("JobName")]
        [Required(ErrorMessageResourceName = "Validation_Required_Error", ErrorMessageResourceType = typeof(UI))]
        public string JobName_Search { get; set; }
        public string JobType_Search { get; set; }
        public string Key_Search { get; set; }
        public List<SelectListItem> Jobs { get; set; }
        public List<SelectListItem> Types { get; set; }
    }
}