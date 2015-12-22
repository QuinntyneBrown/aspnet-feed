using AspNetFeed.Web.Providers.Contracts;
using System.Collections.Generic;
using System.Web;

namespace AspNetFeed.Web.Providers
{
    public class RouteParamsProvider : IRouteParamsProvider
    {
        public IDictionary<string, object> Get()
        {
            return (HttpContext.Current.Items["RouteParams"] ??
                (HttpContext.Current.Items["RouteParams"] =
                new Dictionary<string, object>())) as Dictionary<string, object>;
        }

        public void Set(string key, object value)
        {
            var routeParams = Get();
            routeParams[key] = value;
            HttpContext.Current.Items["RouteParams"] = routeParams;
        }
    }
}