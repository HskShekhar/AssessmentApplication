using AssessmentApplication.Models;
using AssessmentApplication.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController<User>
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository userRepository) : base(userRepository)
        {
            _repository = userRepository;
        }
    }
}
