using System.Collections.Generic;
using System.Linq;
using api.Models.EntityModel.Sports;
using api.Repository;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;
using System;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportController : Controller
    {
        private readonly ISportRepository _sportRepository;
        
        public SportController(ISportRepository sportRepository)
        {
            _sportRepository = sportRepository;
        }

        // GET api/Sport/List
        [HttpGet, Route("list")]
        public string Get()
        {
            string jsonFilePath = @"./Data/Sports.json";
            string json = System.IO.File.ReadAllText(jsonFilePath);
            return json;
        }
        // GET api/Sport/List/5
        [HttpGet, Route("list/{id}")]
        public IActionResult Get(int id)
        {
            var sport = _sportRepository.Find(id);

            if(sport == null)
                return NotFound();

            return new ObjectResult(sport);
        }

        // POST api/Sport/Create
        [HttpPost, Route("create")]
        public IActionResult Create([FromBody] Sport sport)
        {
            if (sport == null)
                return BadRequest();

            _sportRepository.Add(sport);
            return CreatedAtRoute("list", new {Id=sport.Id}, sport);
        }

        // POST api/Sport/Create-Range
        [HttpPost, Route("create-range")]
        public IActionResult CreateRange([FromBody] ICollection<Sport> sports)
        {
            if (sports == null)
                return BadRequest();

            _sportRepository.AddRange(sports);
            return new NoContentResult();
        }
        
        // PUT api/Sport/Edit/5
        [HttpPut, Route("edit/{id}")]
        public IActionResult Update(int id, [FromBody] Sport sport)
        {
            if(sport == null || sport.Id != id)
                return BadRequest();

            var _sport = _sportRepository.Find(id);
            
            if(_sport == null)
                return NotFound();

            _sport.Name = sport.Name;

            _sportRepository.Update(_sport);
            return new NoContentResult();
        }

        // DELETE api/Sport/Delete/5
        [HttpDelete, Route("delete/{id}")]
        public IActionResult Remove(int id)
        {
            var sport = _sportRepository.Find(id);

            if (sport == null)
                return NotFound();

            _sportRepository.Remove(id);

            return new NoContentResult();
        }
    }
}
