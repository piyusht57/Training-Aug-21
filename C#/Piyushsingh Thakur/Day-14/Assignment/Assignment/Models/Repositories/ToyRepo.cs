using Assignment.Models.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models.Repositories
{
    public class ToyRepo : GenericRepository<Toys>, IToy
    {
        public ToyRepo(ToyManufacturingContext context) : base(context)
        {

        }
    }
}
