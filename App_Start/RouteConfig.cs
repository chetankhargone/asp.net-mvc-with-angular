using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Angular_with_ASPNet
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*
             * imp route configuration, if user reloads or refresh(F5) or Ctrl+F5
             * Home controller will handle the server requst
             */
            routes.MapRoute(
                name: "Home",
                url: "{*anything}",
               defaults: new { controller = "Home", action = "Index", anything = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
