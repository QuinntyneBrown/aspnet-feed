using System.Threading.Tasks;

namespace AspNetFeed.Web.ViewComponents.Contracts
{
    public interface IViewComponent
    {
        Task InvokeAsync();

        string Name { get; set; }

        string ViewLocation { get; set; }
    }
}
