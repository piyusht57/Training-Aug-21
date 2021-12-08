using Assignment.Models.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models.Repositories
{
    public class OrderRepo : GenericRepository<Orders>, IOrder
    {
        public OrderRepo(ToyManufacturingContext context) : base(context)
        {

        }

        public Orders CreateOrder(int tid, IEnumerable<Orders> order)
        {
            double totalPrice = 0.00;

            Orders newOrder = new Orders();
            var toy = context.Toys.Single(t => t.ToyId == tid).Amount;

            foreach (var item in order)
            {
                newOrder.Items = item.Items;
                newOrder.Price = item.Items * toy;
                newOrder.OrderDate = System.DateTime.Now;
                newOrder.AdId = item.AdId;
                newOrder.CustId = item.CustId;
                context.Orders.Add(new Orders() { Items = newOrder.Items, Price = newOrder.Price, OrderDate = newOrder.OrderDate, AdId = newOrder.AdId, CustId = newOrder.CustId });
            }
            return newOrder;
        }
    }
}
