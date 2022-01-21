using AssessmentApplication.Models;
using AssessmentApplication.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTaskController : BaseController<UserTask>
    {
        private readonly IUserTaskRepository _repository;

        public UserTaskController(IUserTaskRepository userTaskRepo) : base(userTaskRepo)
        {
            _repository = userTaskRepo;
        }
    }
}
