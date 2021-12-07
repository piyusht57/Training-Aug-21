using Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class employeeController : ControllerBase
    {
        private readonly Day15Context context;

        public employeeController(Day15Context context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult get()
        {
            var Query = from data in context.Employee
                        select data;
            var Data = Query.ToList();
            return Ok(Data);
        }

        [HttpGet("{id}")]
        public IActionResult get(int id)
        {
            var Query1 = from data1 in context.Employee
                        where data1.EmpId == id
                        select data1;
            var Data = Query1.ToList();
            return Ok(Data);
        }

        [HttpPost]
        public IActionResult add(Employees employees)
        {
            context.Employee.Add(employees);
            context.SaveChanges();
            return Ok(employees);
        }

        [HttpPut]
        public IActionResult Update(Employees employees)
        {
            //var ObjEmployee = await context.Employees.FindAsync(model.Id);
            //ObjEmployee.Name = model.Name;
            //ObjEmployee.City = model.City;
            //await context.SaveChangesAsync();

            context.Attach(employees);
            context.Entry(employees).State = EntityState.Modified;
            context.SaveChanges();
            return Ok(employees);
        }
    }
}
