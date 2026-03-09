using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Interfaces;

namespace UnitTestingPractice.Services
{
    public class UserService
    {

        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public string GetUserName(int id)
        {
            return _repo.UserName(id);
        }
    }
}
