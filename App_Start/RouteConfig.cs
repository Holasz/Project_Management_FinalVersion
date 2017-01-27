using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectManagement
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // custom route
            routes.MapRoute(
                name: "Project", // route name
                url: "Project/doanaction", // url
                defaults: new
                {
                    controller = "Project",
                    action = "doanaction",
                    name = UrlParameter.Optional
                });

            // custom route search cities
            routes.MapRoute(
                name: "ProjectSearch", // route name
                url: "Project/HelloUser/{yourname}", // url
                defaults: new
                {
                    controller = "Project",
                    action = "HelloUser",
                    yourname = UrlParameter.Optional
                });

            // custom route search cities
            routes.MapRoute(
                name: "ProjectSearchNew", // route name
                url: "Project/{alpha}", // url
                defaults: new
                {
                    controller = "Project",
                    action = "searchCities",
                    // UrlParameter = ,
                    alpha = UrlParameter.Optional
                });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
