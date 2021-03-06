using AssessmentApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentApplication.Repository
{
    public interface IProjectRepository
    {
        List<Project> GetAllProjects();

        Project GetProjectById(int id);

        Project AddProject(Project project);

        void DeleteProject(int id);

        void UpdateProject(Project project);
    }
}
