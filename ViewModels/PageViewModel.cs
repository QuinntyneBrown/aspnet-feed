using AspNetFeed.Web.ViewComponents.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetFeed.Web.ViewModels
{
    public class PageViewModel
    {
        public PageViewModel()
        {
            this.ViewComponents = new HashSet<IViewComponent>();
        }

        public ICollection<IViewComponent> ViewComponents { get; set; }

        public IViewComponent GetByName(string name)
        {
            return this.ViewComponents.Single(x => x.Name == name);
        }

        public IViewComponent GetHeader()
        {
            return this.ViewComponents.Single(x => x.Name == "Header");
        }

        public IViewComponent GetFooter()
        {
            return this.ViewComponents.Single(x => x.Name == "Footer");
        }

        public ICollection<IViewComponent> GetBody()
        {
            return this.ViewComponents.Where(x => x.Name != "Header" && x.Name != "Footer").ToList();
        }

        public void Invoke()
        {
            List<Task> tasks = new List<Task>();

            foreach(var viewComponent in this.ViewComponents)
            {
                tasks.Add(viewComponent.InvokeAsync());
            }

            Task.WaitAll(tasks.ToArray());
        }
    }
}