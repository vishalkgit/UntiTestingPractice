using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingPractice.Services
{
    public class StringTests
    {

        public string isPalindrome(string name)
        {
            if (name is null)
                return "Name should not be null";
          if(name.Length==0)
                    return "Name cannot be empty";

            string rev = new string(name.Reverse().ToArray());

         if (rev == name)
                return name;
            
                return "Name is not Palindrome";
        }

        public string isReversed(string name)
        {
            if (name.Length == 0)
                return "name cannot be empty";
            if (name is null)
                return "name cannot be null";

            string rev = new string(name.Reverse().ToArray());
            if (rev == name) return name;
            return "Not Palindrome";
        }

        public string EmailValidator(string email)
        {
            if (email is null)
                return "Email cannot be null";
            if (email.Length == 0)
                return "Email cannot be empty";
            if (!email.Contains("@"))
                return "Invalid Email";
            if (!email.Contains("."))
                return "Invalid Email";
            return email;

        }
    }
}
