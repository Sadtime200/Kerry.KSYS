using Kerry.KSYS.Service.Exception;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System.Data.Services.Client;
using System.Diagnostics;
using System.ServiceModel.Security;
using System.Web.Http;

namespace Kerry.KSYS.Service
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            ConfigureEntLib();
        }

        private void ConfigureEntLib()
        {
            var builder = new ConfigurationSourceBuilder();

            #region Logger
            builder.ConfigureLogging()
                .WithOptions
                .SpecialSources.AllEventsCategory
                    .SendTo
                    .RollingFile("AllEvent Listener")
                    .WithHeader(string.Empty)
                    .WithFooter(string.Empty)
                    .FormatWithSharedFormatter("Text Formatter")
                    .ToFile("%appdata%\\KSYSLOG\\All\\KSYS_all.log")
                    .RollAfterSize(10000)
                    .CleanUpArchivedFilesWhenMoreThan(5)
                    .SendTo
                    .Custom<Log.DebuggerTraceListener>("vs debug output")
                    .FormatWith(new FormatterBuilder()
                    .TextFormatterNamed("Text Formatter")
                    .UsingTemplate("{timestamp(local:yyyy-MM-dd HH:mm:ss.fff)} {win32ThreadId}{tab}{category}{tab}{severity}{tab}{title}{tab}{message}{tab}{threadName}{tab}{property(ActivityId)}{tab}{dictionary([{key} : {value}])}"))
                .LogToCategoryNamed("Notification.Server")
                    .SendTo
                    .RollingFile("Information Listener")
                .LogToCategoryNamed("Information")
                    .SendTo
                    .RollingFile("Informaiton Listener")
                    .WithHeader(string.Empty)
                    .WithFooter(string.Empty)
                    .FormatWithSharedFormatter("Text Formatter")
                    .ToFile("%appdata%\\Information\\KSYS_information.log")
                    .RollAfterSize(10000)
                    .CleanUpArchivedFilesWhenMoreThan(5)
                .LogToCategoryNamed("Debug")
                    .SendTo
                    .RollingFile("Debug Listener")
                    .WithHeader(string.Empty)
                    .WithFooter(string.Empty)
                    .FormatWithSharedFormatter("Text Formatter")
                    .ToFile("%appdata%\\Debug\\KSYS_debug.log")
                    .RollAfterSize(10000)
                    .CleanUpArchivedFilesWhenMoreThan(5)
                .LogToCategoryNamed("Performance")
                    .SendTo
                    .RollingFile("Performance Listener")
                    .WithHeader(string.Empty)
                    .WithFooter(string.Empty)
                    .FormatWithSharedFormatter("Text Formatter")
                    .ToFile("%appdata%\\Performance\\KSYS_performance.log")
                    .RollAfterSize(10000)
                    .CleanUpArchivedFilesWhenMoreThan(5)
                .LogToCategoryNamed("Security")
                    .SendTo
                    .RollingFile("Security Listener")
                    .WithHeader(string.Empty)
                    .WithFooter(string.Empty)
                    .FormatWithSharedFormatter("Text Formatter")
                    .ToFile("%appdata%\\Security\\KSYS_security.log")
                    .RollAfterSize(10000)
                    .CleanUpArchivedFilesWhenMoreThan(5)
                .LogToCategoryNamed("Exception")
                    .SendTo
                    .RollingFile("Exception Listener")
                    .WithHeader(string.Empty)
                    .WithFooter(string.Empty)
                    .FormatWithSharedFormatter("Text Formatter")
                    .ToFile("%appdata%\\Exception\\KSYS_exception.log")
                    .RollAfterSize(10000)
                    .CleanUpArchivedFilesWhenMoreThan(5)
                    ;

            #endregion
            //Exception handling
            builder.ConfigureExceptionHandling()
                .GivenPolicyWithName(ExceptionPolicyName.TaskManagerPolicy)
                  .ForExceptionType<System.Exception>().LogToCategory("Exception")
                  .ThenDoNothing();
                    ;


            //builder.ConfigureExceptionHandling()
            //       .GivenPolicyWithName(ExceptionPolicyName.TaskManagerPolicy)
            //           .ForExceptionType<System.TimeoutException>()
            //             .HandleCustom<SystemTimeoutExceptionHandler>()
            //             .LogToCategory("General")
            //               .WithSeverity(System.Diagnostics.TraceEventType.Error)
            //               .UsingEventId(9000)
            //             .ThenDoNothing()
            //           .ForExceptionType<DataServiceTransportException>()
            //             .HandleCustom<DataServiceTransportExceptionHandler>()
            //             .LogToCategory("General")
            //               .WithSeverity(System.Diagnostics.TraceEventType.Error)
            //               .UsingEventId(9000)
            //             .ThenDoNothing()
            //           .ForExceptionType<Exception>()
            //             .HandleCustom<GeneralExceptionHandler>()
            //             .LogToCategory("General")
            //               .WithSeverity(System.Diagnostics.TraceEventType.Error)
            //               .UsingEventId(9003)
            //             .ThenThrowNewException()
            //           ;


            #region ConfigSource
            var configSource = new DictionaryConfigurationSource();
            builder.UpdateConfigurationWithReplace(configSource);
            
            Logger.SetLogWriter(new LogWriterFactory(configSource).Create());
            Log.Log.Debug(TraceEventType.Information, "ConfigureEntLib", "Log manager is started.");

            ExceptionPolicy.SetExceptionManager(new ExceptionPolicyFactory(configSource).CreateManager());
            Log.Log.Debug(TraceEventType.Information, "ConfigureEntLib", "Exception manager is started.");
            #endregion
        }
    }
}
