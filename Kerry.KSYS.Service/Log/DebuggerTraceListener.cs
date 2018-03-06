using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Fluent;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging.Formatters;
using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;
using System.Diagnostics;

namespace Kerry.KSYS.Service.Log
{
    /// <summary>
    /// Implements a TraceListener which outputs to the attached debugger (e.g. VisualStudio, DebugView)
    /// </summary>
    /// <remarks>To obtain DebugView see: http://technet.microsoft.com/en-us/sysinternals/bb896647.aspx </remarks>
    [ConfigurationElementType(typeof(CustomTraceListenerData))]
    public class DebuggerTraceListener : CustomTraceListener
    {
        public DebuggerTraceListener()
            : this(null)
        { }

        public DebuggerTraceListener(ILogFormatter formatter)
            : this(string.Empty, string.Empty, formatter)
        { }

        public DebuggerTraceListener(string header, string footer, ILogFormatter formatter)
        {
            Header = header ?? string.Empty;
            Footer = footer ?? string.Empty;
            Formatter = formatter;
        }

        /// <summary>
        /// Declares "formatter", "header", and "footer" as a supported attribute names.
        /// </summary>
        protected override string[] GetSupportedAttributes()
        {
            return new[] { "formatter", "header", "footer" };
        }

        //The text of the Header to add to the log message.
        private string Header { get; set; }

        /// <summary>
        /// The text of the footer to add to the log message.
        /// </summary>
        private string Footer { get; set; }

        /// <summary>
        /// Delivers the trace data to attached debugger.
        /// </summary>
        /// <param name="eventCache">The context information provided by System.Diagnostics.</param>
        /// <param name="source">The name of the trace source that delivered the trace data.</param>
        /// <param name="eventType">The type of event.</param>
        /// <param name="id">The id of the event.</param>
        /// <param name="data">The data to trace.</param>
        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
        {
            if ((Filter == null) || Filter.ShouldTrace(eventCache, source, eventType, id, null, null, data, null))
            {
                if (Header.Length > 0)
                    WriteLine(Header);

                if (data is LogEntry)
                {
                    if (Formatter != null)
                        WriteLine(Formatter.Format(data as LogEntry));
                    else
                        base.TraceData(eventCache, source, eventType, id, data);
                }
                else
                    base.TraceData(eventCache, source, eventType, id, data);

                if (Footer.Length > 0)
                    WriteLine(Footer);
            }
        }

        public override void Write(string message)
        {
            Debug.Write(message);
        }

        public override void WriteLine(string message)
        {
            Debug.WriteLine(message);
        }
    }

    public static class DebuggerTraceListenerExtension
    {
        public static DebuggerTraceListener DebuggerTrace(
            this ILoggingConfigurationSendTo context, string listenerName)
        {
            return new DebuggerTraceListener
            {
                Name = listenerName,
            };
        }
    }
}