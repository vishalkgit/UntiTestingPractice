using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingPractice.Services
{
    public class Theory_InlineData
    {

        public int Add(int a,int b)
        {
            return a + b;
        }

        public int Sub(int a,int b)
        {
            return a - b;
        }


        public bool IsPoitive(int a)
        {
            if(a>0)
                return true;
            else return false;
        }

        public bool isPalindrome(string name)
        {
            if(name is null)
                return false;
            if (name.Length == 0)
                return false;

            string res = new string(name.Reverse().ToArray());

            if(res==name)
                return true;
            return false;
        }
    }
}
