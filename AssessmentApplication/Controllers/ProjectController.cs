using AssessmentApplication.Models;
using AssessmentApplication.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProjectController : BaseController<Project>
    {
        public ProjectController(IProjectRepository projectRepository) : base(projectRepository)
        {

        }
    }
}
