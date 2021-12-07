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
    public class assignmentController : ControllerBase
    {
        private readonly Day15Context context;

        public assignmentController(Day15Context context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult get()
        {
            var Query = from data in context.Assignments
                        select data;
            var Data = Query.ToList();
            return Ok(Data);
        }

        [HttpGet("{id}")]
        public IActionResult get(int id)
        {
            var Query1 = from data1 in context.Assignments
                         where data1.AssignmentId == id
                         select data1;
            var Data = Query1.ToList();
            return Ok(Data);
        }

        [HttpPost]
        public IActionResult add(Assignments assignments)
        {
            context.Assignments.Add(assignments);
            context.SaveChanges();
            return Ok(assignments);
        }

        [HttpPut]
        public IActionResult Update(Assignments assignments)
        {
            //var ObjEmployee = await context.Employees.FindAsync(model.Id);
            //ObjEmployee.Name = model.Name;
            //ObjEmployee.City = model.City;
            //await context.SaveChangesAsync();

            context.Attach(assignments);
            context.Entry(assignments).State = EntityState.Modified;
            context.SaveChanges();
            return Ok(assignments);
        }
    }
}
