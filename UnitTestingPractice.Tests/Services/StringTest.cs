using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Services;
using Xunit;

namespace UnitTestingPractice.Tests.Services
{
    public class StringTest
    {
        [Fact]
        public void IsPalindrome_ReturnCorrectResult()
        {
            string input = "madam";
            string output = "madam";
            //arrange
            var str = new StringTests();

            //act
            var res = str.isPalindrome(input);

            //assert
            Assert.Equal(output, res);
        }

        [Fact]
        public void IsReverse_ReturnCorrectResult()
        {
            string input = "madam";
            string rev = "madam";

            //arrange
            var str = new StringTests();
            //act
            var res = str.isReversed(input);
            //assert
            Assert.Equal(rev, res);
        }


        [Fact]
        public void IsEmailValid_ReturnCorrectResult()
        {
            //arrange
            var str = new StringTests();
            //act
            var res = str.EmailValidator("abc@g.com");
            //arrange
            Assert.Equal("abc@g.com", res);
        }

    }
}
