using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.Infra.Service
{
  public  class ExperienceService: IExperienceService
    {
        private readonly IExperienceRepository experienceRepository;

        public ExperienceService(IExperienceRepository _experienceRepository)
        {
            experienceRepository = _experienceRepository;
        }
        public bool CreateExperience(Experience experience)
        {
            return experienceRepository.CreateExperience(experience);
        }
        public bool UpdateExperience(Experience experience)
        {
            return experienceRepository.UpdateExperience(experience);
        }
        public bool DeleteExperience(int id)
        {
            return experienceRepository.DeleteExperience(id);
        }
        public List<Experience> GetExperienceByJobTitle(Experience experience)
        {
            return experienceRepository.GetExperienceByJobTitle(experience);
        }
       public List<Experience> GetExperienceByStartDate(Experience experience)
        {
            return experienceRepository.GetExperienceByStartDate(experience);
        }
        public List<Experience> GetExperienceByEndDate(Experience experience)
        {
            return experienceRepository.GetExperienceByEndDate(experience);
        }
        public List<Experience> GetExperienceById(Experience experience)
        {
            return experienceRepository.GetExperienceById(experience);
        }
        public List<Experience> GetAllExperiences()
        {
            return experienceRepository.GetAllExperiences();
        }
    }
}
