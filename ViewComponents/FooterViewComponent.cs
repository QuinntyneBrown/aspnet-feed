using AspNetFeed.Web.ViewComponents.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace AspNetFeed.Web.ViewComponents
{
    public class FooterViewComponent : IViewComponent
    {
        public FooterViewComponent()
        {
            this.Name = "Footer";
            this.ViewLocation = "Components/Footer/Default";
        }

        public Task InvokeAsync()
        {
            return Task.Run(() => { return new { }; });
        }

        public string Name { get; set; }

        public string ViewLocation { get; set; }
    }
}