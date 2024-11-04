using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.Service
{
    public interface IProjectService
    {
        bool CreateProject(Project project);
        List<Project> GetAllProject();
        bool UpdateProject(Project project);
        bool DeleteProject(int id);
        List<Project> GetProjectById(Project project);

    }
}
