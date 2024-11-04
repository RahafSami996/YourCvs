using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.ViewModel;

namespace Tahaluf.YourCV.Core.Repository
{
   public interface IResumeService
    {
        public bool CreateResume(Resume resume);
        public List<Resume> GetALLResume();
        public Resume GetResumeById(int id);
        public bool DeleteResume(int id);
        public bool UpdateResume(Resume resume);
        public List<Resume> GetResumeByUserId(int userId);
    }
}
