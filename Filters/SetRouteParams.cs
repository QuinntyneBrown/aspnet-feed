using AspNetFeed.Web.Extensions;
using AspNetFeed.Web.Providers.Contracts;
using System.Web.Mvc;


namespace AspNetFeed.Web.Filters
{
    public class SetRouteParams : ActionFilterAttribute
    {
        public SetRouteParams()
        {
            this.routeParamsProvider = DependencyResolver.Current.GetService<IRouteParamsProvider>();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            this.routeParamsProvider.Set("routeName", filterContext.RouteData.GetRouteName());

            foreach (var item in filterContext.RouteData.Values)
            {
                this.routeParamsProvider.Set(item.Key, item.Value);
            }
            base.OnActionExecuting(filterContext);
        }

        protected readonly IRouteParamsProvider routeParamsProvider;
    }
}