using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.Repository
{
   public interface IUserRepository
    {
        bool CreateUser(User user);
        List<User> GetAllUser();
        bool UpdateUser(User user);
        bool DeleteUser(int id);
        List<User> GetUserById(int id);
    }
}
