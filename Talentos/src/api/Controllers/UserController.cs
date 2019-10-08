using System.Collections.Generic;
using System.Linq;
using api.Models.EntityModel.Users;
using api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        // GET api/User/List
        [HttpGet, Route("list")]
        public IEnumerable<User> Get()
        {
            return _userRepository.GetAll().ToList();
        }

        // GET api/User/List/5
        [HttpGet, Route("list/{id}")]
        public IActionResult Get(int id)
        {
            var user = _userRepository.Find(id);

            if(user == null)
                return NotFound();

            return new ObjectResult(user);
        }

        // POST api/User/Create
        [HttpPost, Route("create")]
        public IActionResult Create([FromBody] User user)
        {
            if (user == null)
                return BadRequest();
            
            _userRepository.Add(user);

            return CreatedAtRoute("list", new {Id = user.Id}, user);
       }

       // PUT api/User/Edit/5
        [HttpPut, Route("edit/{id}")]
        public IActionResult Update(int id, [FromBody] User user)
        {
            if(user == null || user.Id != id)
                return BadRequest();

            var _user = _userRepository.Find(id);
            
            if(_user == null)
                return NotFound();

            _user.Name = user.Name;
            _user.Title = user.Title;
            _user.Graduation = user.Graduation;
            _user.Email = user.Email;
            _user.Expertise = user.Expertise;

            _userRepository.Update(_user);
            return new NoContentResult();
        }

        // DELETE api/User/Delete/5
        [HttpDelete, Route("delete/{id}")]
        public IActionResult Remove(int id)
        {
            var user = _userRepository.Find(id);

            if (user == null)
                return NotFound();

            _userRepository.Remove(id);

            return new NoContentResult();
        }
    }
}