using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.ViewModel
{
   public class UserResume
    {
        public User user { get; set; }
        public Resume resume { get; set; }
        public List<User> listUser { get; set; }
        public List<Resume> listResume { get; set; }
    }
}
