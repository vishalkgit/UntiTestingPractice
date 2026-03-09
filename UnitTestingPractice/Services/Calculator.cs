using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingPractice.Services
{
    public class Calculator
    {

        public int Add(int a,int b)
        {
            return a + b;
        }

        public int Divide(int a,int b)
        {
            if (b == 0)
                throw new Exception("cannot divide by zero");

            return a / b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Subtract(int a,int b)
        {
            return a - b;
        }

        public int IsEven(int a)
        {
            if (a % 2 == 0)
                return a;
            else
                return -1;
        }

        public int IsPositive(int a)
        {
            if (a < 0)
                return -1;
            else
                return a;
        }
    }
}
