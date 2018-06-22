using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ICOnboardingP2.Models;


namespace ICOnboardingP2.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private OnboardingP2Entities db;

        public CustomersController()
        {
            db = new OnboardingP2Entities();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return db.Customers.ToList();
        }

        //public string Get()
        //{ return "Hello"; }
    }
}
