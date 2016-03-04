using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DbFtw
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Enable CORS
            config.EnableCors();

            //XML default format - enables desktop Excel "Data Connection"
            //by returning XML with no HTTP "Accept" header is given
            config.Formatters.Clear();
			config.Formatters.Add(new System.Net.Http.Formatting.XmlMediaTypeFormatter());
			config.Formatters.Add(new System.Net.Http.Formatting.JsonMediaTypeFormatter());

            //Microsoft defaults
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
