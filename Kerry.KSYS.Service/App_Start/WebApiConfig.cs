using Kerry.KSYS.Data;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;
using Kerry.KSYS.Service.Models;


namespace Kerry.KSYS.Service
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<JOB>("JOBs");
            builder.EntitySet<JOBOTHER>("JOBOTHERs");
            builder.EntitySet<JOBLINKsModel>("JOBLINKs");

            builder.EntitySet<ACTION_JOB>("ActionJob");
            config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());

            // Web API 配置和服务
            // Web API 路由
            config.MapHttpAttributeRoutes();

            //config.Routes.MapODataServiceRoute(
            //    routeName: "odata",
            //    routePrefix: "odata",
            //   model:builder.GetEdmModel()
            //);

            config.EnableQuerySupport();

        }
    }
}
