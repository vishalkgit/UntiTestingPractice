using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Model;

namespace UnitTestingPractice.MOQ
{
    public interface IUserRepository
    {

        User GetUserById(int id);

        int Add(int a, int b);

        int Sub(int a, int b);

        int Mul(int a, int b);
    }
}
