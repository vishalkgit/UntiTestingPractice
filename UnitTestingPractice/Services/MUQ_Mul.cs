using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.MOQ;

namespace UnitTestingPractice.Services
{
    public class MUQ_Mul
    {

        private readonly IUserRepository _user;

        public MUQ_Mul(IUserRepository user)
        {
            _user = user;
        }

        public int Multiply(int a,int b)
        {
            return _user.Mul(a, b);
        }
    }
}
