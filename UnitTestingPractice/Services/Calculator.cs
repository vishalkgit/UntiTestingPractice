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

        public bool IsEven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }

        public bool IsOdd(int a)
        {
            if (a % 2 != 0)
                return true;
            else
                return false;
        }

        public bool IsPositive(int a)
        {
            if (a < 0)
                return false;
            else
                return true;
        }

        public bool IsNegative(int a)
        {
            if (a < 0)
                return true;
            else
                return false;
        }
    }
}
