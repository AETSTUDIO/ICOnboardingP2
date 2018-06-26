using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ICOnboardingP2.Models;

namespace ICOnboardingP2.Models.ViewModel
{
    public class ProductSoldViewModel
    {
        public ProductSold ProductSold { get; set; }

        public IEnumerable<Customer> Customers { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public IEnumerable<Store> Stores { get; set; }
    }
}