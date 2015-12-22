using AspNetFeed.Web.Services.Contracts;
using System;
using AspNetFeed.Web.ViewModels;
using AspNetFeed.Web.ViewComponents;
using AspNetFeed.Web.Providers.Contracts;

namespace AspNetFeed.Web.Services
{
    public class FeedService : IFeedService
    {
        public FeedService(IRouteParamsProvider routeParamsProvider) {
            this.routeParamsProvider = routeParamsProvider;
        }

        public PageViewModel GetViewModel()
        {
            var pageViewModel = new PageViewModel();

            if (this.routeParamsProvider.Get()["routeName"] == "Default")
                pageViewModel.ViewComponents.Add(new VendorsViewComponent());


            if (this.routeParamsProvider.Get()["routeName"] == "Vendor")
                pageViewModel.ViewComponents.Add(new VendorViewComponent());


            pageViewModel.ViewComponents.Add(new HeaderViewComponent());
            pageViewModel.ViewComponents.Add(new FooterViewComponent());
            pageViewModel.Invoke();
            return pageViewModel;
        }

        protected readonly IRouteParamsProvider routeParamsProvider;
    }
}