using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.Infra.Service
{
   public class UserService: IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }

        public bool CreateUser(User user)
        {
           return userRepository.CreateUser(user);

        }

        public List<User> GetAllUser()
        {
            return userRepository.GetAllUser();
        }

        public bool UpdateUser(User user)
        {
            return userRepository.UpdateUser(user);
        }
        public bool DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }

        public List<User> GetUserById(int id)
        {
            return userRepository.GetUserById(id);
        }
    }
}
