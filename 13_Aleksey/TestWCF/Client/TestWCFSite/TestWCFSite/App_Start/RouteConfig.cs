using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestWCFSite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{a}",
                defaults: new { controller = "Home", action = "Index", a=UrlParameter.Optional}
            );

            routes.MapRoute(
              name: "Calc",
              url: "{controller}/{action}/{x}/{y}",
              defaults: new { controller = "Calc", action = "Sum|Sub|Div|Mult", x = 0, y = 0 }
          );
        }
    }
}
