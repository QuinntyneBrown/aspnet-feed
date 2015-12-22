using AspNetFeed.Web.Clients.Contracts;
using AspNetFeed.Web.Data;
using AspNetFeed.Web.Models;
using AspNetFeed.Web.Providers.Contracts;
using AspNetFeed.Web.ViewComponents.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AspNetFeed.Web.ViewComponents
{
    public class VendorViewComponent : IViewComponent
    {
        public VendorViewComponent(IRouteParamsProvider routeParamsProvider)
        {
            this.Name = "Vendor";
            this.ViewLocation = "Components/Vendor/Default";
            this.routeParams = routeParamsProvider.Get();
        }

        public VendorViewComponent()
            :this(DependencyResolver.Current.GetService<IRouteParamsProvider>())
        {

        }

        public Task InvokeAsync()
        {
            return Task.Run(() => Invoke());
        }

        public void Invoke()
        {
            this.Vendor = VendorRepository.GetAll().Where(x => x.SnakeCaseName == (string)this.routeParams["vendorName"]).Single();
        }

        public string Name { get; set; }

        public string ViewLocation { get; set; }

        public Vendor Vendor { get; set; }

        protected IDictionary<string, object> routeParams;
    }


}