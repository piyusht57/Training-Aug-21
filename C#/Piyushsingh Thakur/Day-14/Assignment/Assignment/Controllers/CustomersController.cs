using Assignment.Models;
using Assignment.Models.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomer customer;

        public CustomersController(ICustomer customer)
        {
            this.customer = customer;
        }

        [HttpGet]
        public IEnumerable<Customers> GetCustomers()
        {
            return customer.GetAll();
        }

        [HttpGet("{id}")]
        public Customers GetCustomer(int id)
        {
            return customer.GetById(id);
        }

        [HttpPost]
        public void PostCustomer([FromBody] Customers customers)
        {
            customer.Create(customers);
        }

        [HttpPut("{id}")]
        public void PutCustomer(int id, [FromBody] Customers customers)
        {
            customer.Update(id, customers);
        }

        [HttpDelete("{id}")]
        public void DeleteCustomer(int id)
        {
            customer.Delete(id);
        }
    }
}
