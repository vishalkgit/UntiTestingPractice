using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.MOQ;

namespace UnitTestingPractice.Services
{
    public class MOQ_ADD
    {

        private readonly IUserRepository _user;

        public MOQ_ADD(IUserRepository user)
        {
            _user = user;
        }

        public int Add(int a,int b)
        {
            return _user.Add(a,b);
        }
    }
}
