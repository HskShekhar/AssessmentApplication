using AssessmentApplication.Authentication;
using AssessmentApplication.Models;
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
    public class AuthController : ControllerBase
    {
        private readonly IAuthenticationManager _authenticationmanager;

        public AuthController(IAuthenticationManager authenticationmanager)
        {
            _authenticationmanager = authenticationmanager;
        }

        [HttpPost]
        [Route("api/[controller]/login")]
        public IActionResult Login(UserAuth userAuth)
        {
            var token = _authenticationmanager.Authenticate(userAuth.UserName, userAuth.Password);
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }
    }
}
 