using AspNetFeed.Web.Clients.Contracts;
using AspNetFeed.Web.Providers.Contracts;
using AspNetFeed.Web.ViewComponents.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AspNetFeed.Web.ViewComponents
{
    public class FeedListViewComponent : IViewComponent
    {
        public FeedListViewComponent(IClient client, IRouteParamsProvider routeParamsProvider)
        {
            this.routeParams = routeParamsProvider.Get();
            this.client = client;
            this.Name = "FeedList";
            this.ViewLocation = "Components/FeedList/Default";
        }

        public FeedListViewComponent()
            :this(DependencyResolver.Current.GetService<IClient>(), DependencyResolver.Current.GetService<IRouteParamsProvider>())
        {

        }

        public Task InvokeAsync()
        {
            return this.client.PlayersAsync();
        }

        public string Name { get; set; }

        public string ViewLocation { get; set; }

        protected readonly IClient client;

        protected readonly IDictionary<string, object> routeParams;
    }
}