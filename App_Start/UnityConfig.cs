using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using AspNetFeed.Web.Clients.Contracts;
using AspNetFeed.Web.Providers.Contracts;
using AspNetFeed.Web.Clients;
using AspNetFeed.Web.Providers;
using AspNetFeed.Web.Services.Contracts;
using AspNetFeed.Web.Services;

namespace AspNetFeed.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IClient, Client>();
            container.RegisterType<IRouteParamsProvider, RouteParamsProvider>();
            container.RegisterType<IFeedService, FeedService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}