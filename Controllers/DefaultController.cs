using AspNetFeed.Web.Filters;
using AspNetFeed.Web.Services.Contracts;
using System.Web.Mvc;

namespace AspNetFeed.Web.Controllers
{
    public class DefaultController : Controller
    {
        public DefaultController(IFeedService feedService)
        {
            this.feedService = feedService;
        }

        [SetRouteParams]
        public ActionResult Index()
        {
            return View(this.feedService.GetViewModel());
        }

        protected readonly IFeedService feedService;
    }
}