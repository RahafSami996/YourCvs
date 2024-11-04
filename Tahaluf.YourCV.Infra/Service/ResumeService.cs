using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.ViewModel;

namespace Tahalut.YourCV.Infra.Service
{
   public class ResumeService : IResumeService
    {
        private readonly IResumeRepository resumeRepository;
        public ResumeService(IResumeRepository resumeRepository)
        {
            this.resumeRepository = resumeRepository;
        }
        public bool CreateResume(Resume resume)
        {
            return resumeRepository.CreateResume(resume);
        }

        public bool DeleteResume(int id)
        {
            return resumeRepository.DeleteResume(id);
        }

        public Resume GetResumeById(int id)
        {
            return resumeRepository.GetResumeById(id);
        }

        public List<Resume> GetALLResume()
        {
            return resumeRepository.GetALLResume();
        }

        public bool UpdateResume(Resume resume)
        {
            return resumeRepository.UpdateResume(resume);
        }

        public List<Resume> GetResumeByUserId(int userId)
        {
            return resumeRepository.GetResumeByUserId(userId);
        }
    }
}
