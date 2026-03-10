using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.MOQ;

namespace UnitTestingPractice.Services
{
    public class Moq_Pal
    {

        private readonly IUserRepository _user;

        public Moq_Pal(IUserRepository user)
        {
            _user = user;
        }

        public string Moq_PalName(string name)
        {
            return _user.Palindrome(name);
        }
    }
}
