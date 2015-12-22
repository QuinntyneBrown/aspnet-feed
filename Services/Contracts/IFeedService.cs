using AspNetFeed.Web.ViewModels;

namespace AspNetFeed.Web.Services.Contracts
{
    public interface IFeedService
    {
        PageViewModel GetViewModel();
    }
}
