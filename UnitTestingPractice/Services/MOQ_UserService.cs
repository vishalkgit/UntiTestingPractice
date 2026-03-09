using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Model;
using UnitTestingPractice.MOQ;

namespace UnitTestingPractice.Services
{
    public class MOQ_UserService
    {
        private readonly IUserRepository _user;

        public MOQ_UserService(IUserRepository user)
        {
            _user= user;
        }

        public User getUser(int id)
        {
            return _user.GetUserById(id);
        }

    }
}
