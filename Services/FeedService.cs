using AspNetFeed.Web.Services.Contracts;
using System;
using AspNetFeed.Web.ViewModels;
using AspNetFeed.Web.ViewComponents;

namespace AspNetFeed.Web.Services
{
    public class FeedService : IFeedService
    {
        public FeedService() { }

        public PageViewModel GetViewModel()
        {
            var pageViewModel = new PageViewModel();
            pageViewModel.ViewComponents.Add(new FeedListViewComponent());
            pageViewModel.ViewComponents.Add(new HeaderViewComponent());
            pageViewModel.ViewComponents.Add(new FooterViewComponent());
            pageViewModel.Invoke();
            return pageViewModel;
        }
    }
}