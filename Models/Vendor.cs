using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFeed.Web.Models
{
    public class Vendor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Href { get; set; }

        public string SnakeCaseName { get; set; }
    }
}