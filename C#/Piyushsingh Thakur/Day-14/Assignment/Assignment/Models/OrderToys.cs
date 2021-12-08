using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class OrderToys
    {
        [Key]
        public int ToyId { get; set; }
        public Toys Toys { get; set; }    // Composite PK for Customer Table

        public int OrderId { get; set; }
        public Orders Orders { get; set; }      // Composite PK for Order Table
    }
}
