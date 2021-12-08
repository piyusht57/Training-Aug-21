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
    public class ToysController : ControllerBase
    {
        IToy toy;

        public ToysController(IToy toy)
        {
            this.toy = toy;
        }

        [HttpGet]
        public IEnumerable<Toys> GetToys()
        {
            return toy.GetAll();
        }

        [HttpGet("{id}")]
        public Toys GetToy(int id)
        {
            return toy.GetById(id);
        }

        [HttpPost]
        public void PostToy([FromBody] Toys toys)
        {
            toy.Create(toys);
        }

        [HttpPut("{id}")]
        public void PutToy(int id, [FromBody] Toys toys)
        {
            toy.Update(id, toys);
        }

        [HttpDelete("{id}")]
        public void DeleteToy(int id)
        {
            toy.Delete(id);
        }
    }
}
