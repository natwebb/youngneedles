﻿using System.Web.Http;

namespace YoungNeedlesGames
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { action = "index", id = RouteParameter.Optional }
            );
        }
    }
}
