using System.Web.Mvc;
using System.Web.Routing;
using AspNetFeed.Web.Extensions;

namespace AspNetFeed.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.Map(
                name: "Vendor",
                url: "vendor/{vendorName}",
                defaults: new { controller = "Default", action = "Index" }
            );

            routes.Map(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller="Default", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}

