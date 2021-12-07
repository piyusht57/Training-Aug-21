using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Day15Context : DbContext
    {
        public Day15Context()
        {

        }

        public Day15Context(DbContextOptions<Day15Context> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<Employees> Employee { get; set; }
        public DbSet<Assignments> Assignments { get; set; }

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
