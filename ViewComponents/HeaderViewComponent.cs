using AspNetFeed.Web.ViewComponents.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AspNetFeed.Web.ViewComponents
{
    public class HeaderViewComponent: IViewComponent
    {
        public HeaderViewComponent()
        {
            this.Name = "Header";
            this.ViewLocation = "Components/Header/Default";
        }

        public Task InvokeAsync()
        {
            return Task.Run(() => { return new { }; });
        }

        public string Name { get; set; }

        public string ViewLocation { get; set; }
    }
}