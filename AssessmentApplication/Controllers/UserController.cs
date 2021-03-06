using AssessmentApplication.Models;
using AssessmentApplication.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository userRepository)
        {
            _repository = userRepository;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            var users =_repository.GetAllUsers();
            return Ok(users);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult Get(int id)
        {
            var user = _repository.GetUserById(id);

            if (user == null)
                return NotFound("User does not exist.");

            return Ok(user);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post(User user)
        {
            var user1 = _repository.AddUser(user);

            if (user1 == null)
                return BadRequest("Unable to add user.");

            return Ok("User created");
        }

        [HttpDelete]
        [Route("api/[controller]")]
        public IActionResult Delete(int id)
        {
             _repository.DeleteUser(id);
             return Ok("User Deleted");
        }

        [HttpPatch]
        [Route("api/[controller]")]
        public IActionResult Update(User user)
        {
           _repository.UpdateUser(user);
            return Ok("User Data Updated");
        }
    }
}
