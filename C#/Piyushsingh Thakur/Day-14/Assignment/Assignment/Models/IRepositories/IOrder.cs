using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models.IRepositories
{
    public interface IOrder : GenericInterface<Orders>
    {
        Orders CreateOrder(int id, IEnumerable<Orders> order);
    }
}
