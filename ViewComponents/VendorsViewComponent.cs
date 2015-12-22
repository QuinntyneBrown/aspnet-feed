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
    public class VendorsViewComponent: IViewComponent
    {
        public VendorsViewComponent()
        {
            this.Name = "Vendors";
            this.ViewLocation = "Components/Vendors/Default";
            this.Vendors = new HashSet<Vendor>();
        }

        public Task InvokeAsync()
        {
            return Task.Run(() => Invoke());
        }

        public void Invoke()
        {
            this.Vendors = VendorRepository.GetAll();
        }

        public string Name { get; set; }

        public string ViewLocation { get; set; }

        public ICollection<Vendor> Vendors { get; set; }
    }


}