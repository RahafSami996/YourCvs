using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.Infra.Service
{
    public class EducationService : IEducationService
    {
        private readonly IEducationRepository _educationService;

        public EducationService(IEducationRepository educationRepository)
        {
            _educationService = educationRepository;
        }

        public bool CreateEducation(Education education)
        {
            return _educationService.CreateEducation(education);
        }

        public bool DeleteEducation(int id)
        {
            return _educationService.DeleteEducation(id);
        }

        public bool DeleteEducationByResumeId(int resumeId)
        {
            return _educationService.DeleteEducationByResumeId(resumeId);
        }

        public IEnumerable<Education> GetAllEducation()
        {
            return _educationService.GetAllEducation();
        }

        public Education GetEducation(int id)
        {
            return _educationService.GetEducation(id);
        }

        public IEnumerable<Education> GetEducationByResumeId(int resumeId)
        {
            return _educationService.GetEducationByResumeId(resumeId);
        }

        public bool UpdateEducation(Education education)
        {
            return _educationService.UpdateEducation(education);
        }
    }
}
