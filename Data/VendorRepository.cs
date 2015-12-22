using AspNetFeed.Web.Models;
using AspNetFeed.Web.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFeed.Web.Data
{
    public static class VendorRepository
    {
        public static ICollection<Vendor> GetAll()
        {
            var vendors = new List<Vendor>();

            vendors.Add(new Vendor()
            {
                Name = "Disc Jockey",
                ImageUrl = "/wwwroot/assets/wedding_1.jpg",
                Href = "/vendor/disc-jockey",
                SnakeCaseName = "disc-jockey"
            });

            vendors.Add(new Vendor()
            {
                Name = "Wedding Planner",
                ImageUrl = "/wwwroot/assets/wedding_2.jpg",
                Href = "/vendor/wedding-planner",
                SnakeCaseName = "wedding-planner"
            });

            vendors.Add(new Vendor()
            {
                Name = "Caterer",
                ImageUrl = "/wwwroot/assets/wedding_3.jpg",
                Href = "/vendor/caterer",
                SnakeCaseName = "caterer"
            });

            vendors.Add(new Vendor()
            {
                Name = "Make Up Artist",
                ImageUrl = "/wwwroot/assets/wedding_5.jpg",
                Href = "/vendor/make-up-artist",
                SnakeCaseName = "make-up-artist"
            });

            return vendors;
        }
    }
}