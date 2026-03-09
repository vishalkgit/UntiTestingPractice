using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.MOQ;

namespace UnitTestingPractice.Services
{
    public class MOQ_Sub
    {
        private readonly IUserRepository _user;

        public MOQ_Sub(IUserRepository user)
        {
            _user = user;
        }

        public int Sub(int a,int b)
        {
            return _user.Sub(a,b);
        }
    }
}
