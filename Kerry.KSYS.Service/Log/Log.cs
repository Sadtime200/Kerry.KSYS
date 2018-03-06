using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;
using System.Diagnostics;

namespace Kerry.KSYS.Service.Log
{
    public class Log
    {
        private Log() { }

        // singleton
        private static Log instance = null;
        public static Log Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Log();
                }
                return instance;
            }
        }

        private void WriteLog(LogEntry logEntry)
        {
            Logger.Write(logEntry);
        }

        private void WriteLog(LogCategory category, Guid activityId, TraceEventType severity, string title, string msg, params object[] arg)
        {
            try
            {
                if (Logger.IsLoggingEnabled())
                {
                    LogEntry logEntry = new LogEntry()
                    {
                        ActivityId = activityId,
                        Severity = severity,
                        Title = title,
                        Message = string.Format(msg, arg)
                    };
                    logEntry.Categories.Add(category.ToString());
                    Logger.Write(logEntry);
                }
            }
            catch (System.Exception ex)
            {
                // ignore any exception due to logging
            }
        }

        private void WriteLog(LogCategory category, TraceEventType severity, string title, string msg, params object[] arg)
        {
            WriteLog(category, Guid.NewGuid(), severity, title, msg, arg);
        }

        public static void Exception(TraceEventType severity, string title, string msg, params object[] arg)
        {
            Instance.WriteLog(LogCategory.Exception, severity, title, msg, arg);
        }

        public static void Security(TraceEventType severity, string title, string msg, params object[] arg)
        {
            Instance.WriteLog(LogCategory.Security, severity, title, msg, arg);
        }

        public static void Performance(TraceEventType severity, string title, string msg, params object[] arg)
        {
            Instance.WriteLog(LogCategory.Performance, severity, title, msg, arg);
        }

        public static void Debug(TraceEventType severity, string title, string msg, params object[] arg)
        {
            Instance.WriteLog(LogCategory.Debug, severity, title, msg, arg);
        }

        public static void Information(TraceEventType severity, string title, string msg, params object[] arg)
        {
            Instance.WriteLog(LogCategory.Information, severity, title, msg, arg);
        }

        public static void Write(object message)
        {
            Logger.Write(message);
        }
    }

}