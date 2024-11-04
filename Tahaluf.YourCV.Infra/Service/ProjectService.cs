using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.Infra.Service
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository ProjectRepository;

        public ProjectService(IProjectRepository _ProjectRepository)
        {
            ProjectRepository = _ProjectRepository;
        }

        public bool CreateProject(Project project)
        {
            return ProjectRepository.CreateProject(project);
        }

        public bool DeleteProject(int id)
        {
            return ProjectRepository.DeleteProject(id);
        }

        public List<Project> GetAllProject()
        {
            return ProjectRepository.GetAllProject();
        }

        public List<Project> GetProjectById(Project project)
        {
            return ProjectRepository.GetProjectById(project);
        }

        public bool UpdateProject(Project project)
        {
            return ProjectRepository.UpdateProject(project);
        }
    }
}
