using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.Repository
{
    public interface IExperienceRepository
    {
        bool CreateExperience(Experience experience);
        bool UpdateExperience(Experience experience);
        bool DeleteExperience(int id);
        List<Experience> GetExperienceByJobTitle(Experience experience);
        List<Experience> GetExperienceByStartDate(Experience experience);
        List<Experience> GetExperienceByEndDate(Experience experience);
        List<Experience> GetExperienceById(Experience experience);
        List<Experience> GetAllExperiences();
    }
}
