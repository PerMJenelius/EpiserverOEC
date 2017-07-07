using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EpiserverOEC
{
    public class Global : EPiServer.Global
    {
        protected override void RegisterRoutes(RouteCollection routes)
        {
            base.RegisterRoutes(routes);

            routes.MapRoute(
            "epiRoute",
            "Blocks/{controller}/{action}",
            new { action = "Index" });

            RouteTable.Routes.MapRoute("defaultRoute", "{controller}/{action}");
        }
    }
}