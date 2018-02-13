using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kerry.FMS.Scheduler.Services
{
    public static class ExtensionMethods
    {
        public static string ToStringExtension(this object obj)
        {
            if (obj == null)
                return string.Empty;
            else
                return obj.ToString();
        }

        public static bool IsStringNullOrEmpty(this object str)
        {
            if (str == null)
                return true;
            else
                return string.IsNullOrEmpty(str.ToStringExtension());
        }
    }
}