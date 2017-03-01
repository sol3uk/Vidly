using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{   
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)       
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            

            ////Manual method for defining any custom route for any URLs that are entered
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    //New objects defined here are used as constraints as to 
            //    //what is allowed to be input and in what format
            //    new { controller = "Movies", action = "ByReleaseDate" },
            //    new { year = @"\d{4}", month = @"\d{2}" });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //routes.MapRoute(
            //    name: "Movies",
            //    url: "{controller}",
            //    defaults: new { Controller = "Movies" }
            //);
        }
    }
}
