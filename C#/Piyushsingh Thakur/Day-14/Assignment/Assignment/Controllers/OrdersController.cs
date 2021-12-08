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
    public class OrdersController : ControllerBase
    {
        IOrder order;

        public OrdersController(IOrder order)
        {
            this.order = order;
        }

        [HttpGet]
        public IEnumerable<Orders> GetOrders()
        {
            return order.GetAll();
        }

        [HttpGet("{id}")]
        public Orders GetOrder(int id)
        {
            return order.GetById(id);
        }

        [HttpPost]
        public void PostOrder(int tid, [FromBody] IEnumerable<Orders> orders)
        {
            order.CreateOrder(tid, orders);
        }

        [HttpPut("{id}")]
        public void PutOrder(int id, [FromBody] Orders orders)
        {
            order.Update(id, orders);
        }

        [HttpDelete("{id}")]
        public void DeleteOrder(int id)
        {
            order.Delete(id);
        }
    }
}
