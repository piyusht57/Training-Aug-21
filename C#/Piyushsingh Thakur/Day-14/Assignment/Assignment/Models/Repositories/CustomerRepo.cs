using Assignment.Models.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models.Repositories
{
    public class CustomerRepo : GenericRepository<Customers>, ICustomer
    {
        public CustomerRepo(ToyManufacturingContext context) : base(context)
        {

        }
    }
}
