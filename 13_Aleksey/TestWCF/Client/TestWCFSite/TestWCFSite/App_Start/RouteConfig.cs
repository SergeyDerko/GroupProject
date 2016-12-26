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
                url: "{controller}/{action}/{x}/{y}",
                defaults: new { controller = "Calc", action = "Index", x=0, y=0 },
                constraints: new {controller="^Calc$", action="^Index$|^Sum$|^Sub$|^Mult$|^Div$", x="^\\d+$", y= "^\\d+$" }
            );
        }
    }
}
