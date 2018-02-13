using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Configuration;
using System;
using System.Collections.Specialized;

namespace Kerry.KSYS.Service.Exception
{
    [ConfigurationElementType(typeof(CustomHandlerData))]
    public class SystemTimeoutExceptionHandler : IExceptionHandler
    {
        public SystemTimeoutExceptionHandler(NameValueCollection ignore)
        {
        }

        public System.Exception HandleException(System.Exception ex, Guid handlingInstanceId)
        {
          
            /**/

            //To-do
            /**/
            return ex;
        }
    }
}