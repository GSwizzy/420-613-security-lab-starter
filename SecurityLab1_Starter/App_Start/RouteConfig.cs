using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SecurityLab1_Starter
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


            /*            routes.MapRoute(
                            name: "Default",
                            url: "{controller}/{action}/{id}",
                            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                            new { controller = "Home|Inventory" }
                        );

                        routes.MapRoute(
                            "BlankURL",
                            "",
                            new { controller = "Home", action = "Index" }
                            );

                        routes.MapRoute(
                            "HomeRoute",
                            "Home/{action}",
                            new { controller = "Home", action = "Index" },
                            new { action = @"^Index$|^About$|^Contact$"}
                            );


                        routes.MapRoute(
                           "InventoryRoute",
                           "Inventory/{action}",
                           new { controller = "Inventory", action = "Index" },
                           new { action = @"^Index$" }
                           );

                        routes.MapRoute(
                           "ErrorRoute",
                           "Error/{action}",
                           new { controller = "Error", action = "ServerException" }
                           );*/

            /*            routes.MapRoute(
                            "NotFound",
                            "{*url}",
                            new { controller = "Error", action = "NotFound" }
                            );*/
        }
    }
}
