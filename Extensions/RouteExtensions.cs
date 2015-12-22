using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace AspNetFeed.Web.Extensions
{
    public static class RouteExtensions
    {
        public static string GetRouteName(this Route route)
        {
            if (route == null)
            {
                return null;
            }
            return route.DataTokens.GetRouteName();
        }

        public static string GetRouteName(this RouteData routeData)
        {
            if (routeData == null)
            {
                return null;
            }
            return routeData.DataTokens.GetRouteName();
        }

        public static string GetRouteName(this RouteValueDictionary routeValues)
        {
            if (routeValues == null)
            {
                return null;
            }
            object routeName = null;
            routeValues.TryGetValue("__RouteName", out routeName);
            return routeName as string;
        }

        public static Route SetRouteName(this Route route, string routeName)
        {
            if (route == null)
            {
                throw new ArgumentNullException("route");
            }
            if (route.DataTokens == null)
            {
                route.DataTokens = new RouteValueDictionary();
            }
            route.DataTokens["__RouteName"] = routeName;
            return route;
        }

        public static Route Map(this RouteCollection routes, string name,
            string url)
        {
            return routes.Map(name, url, null, null, null);
        }

        public static Route Map(this RouteCollection routes, string name,
            string url, object defaults)
        {
            return routes.Map(name, url, defaults, null, null);
        }

        public static Route Map(this RouteCollection routes, string name,
            string url, object defaults, object constraints)
        {
            return routes.Map(name, url, defaults, constraints, null);
        }

        public static Route Map(this RouteCollection routes, string name,
            string url, object defaults, object constraints, string[] namespaces)
        {
            return routes.MapRoute(name, url, defaults, constraints, namespaces)
              .SetRouteName(name);
        }
    }
}