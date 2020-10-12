using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApiDay1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "myapi/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
