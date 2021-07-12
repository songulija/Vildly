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
        /**
         * Http request to api/customers
         */
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var customers = GetCustomers();

            return Ok(customers);
        }
        /**
         * HTTP request to api/customers/{id} providing id which is int
         * it will look in our request and search for id
         */
        [HttpGet("{id}")]
        public IActionResult GetCustomerById(int id)
        {
            //getting single element in Customer list where customer.id is equal to given id
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return NotFound();

            return Ok(customer);
        }

        /**
         * Function to return list of customer objects
         */
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
