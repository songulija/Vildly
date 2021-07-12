using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult Index()
        {
            var customers = GetCustomers();

            return Ok(customers);
        }

        

        //return List of customers
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{ Id = 1, Name = "Monica"},
                new Customer{ Id = 2, Name = "Fibi"},
                new Customer{ Id = 3, Name = "Ross"},
                new Customer{ Id = 4, Name = "Rachel"},
                new Customer{ Id = 5, Name = "Joey"},
                new Customer{ Id = 6, Name = "Chandler"}
            };
        }

    }
}
