using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Services;
using Xunit;

namespace UnitTestingPractice.Tests.Services
{
    public class Thoery_InlineData
    {
        [Theory]
        [InlineData(2,3,5)]
        [InlineData(3,3,6)]
        [InlineData(4,5,9)]

        public void Add_ReturnCorrectResult(int a,int b,int expected)
        {
            //arrange
            var test = new Theory_InlineData();
            //act
            var res = test.Add(a, b);
            //assert
            Assert.Equal(expected, res);

        }

        [Theory]
        [InlineData(5,3,2)]
        [InlineData(4,2,2)]
        [InlineData(6,5,1)]
        public void Sub_Return(int a,int b,int expected)
        {
            //arrange
            var test = new Theory_InlineData();
            //act
            var res = test.Sub(a, b);
            //assert
            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData(3,true)]
        [InlineData(-2,false)]
        [InlineData(4,true)]
        public void IsPositive_ReturnCorrectResult(int a,bool expected)
        {
            //arrange
            var test = new Theory_InlineData();
            //act
            var res = test.IsPoitive(a);
            //assert
            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData("madam",true)]
        [InlineData("dts",false)]
        [InlineData("lol",true)]
        public void IsPalindrome_ReturnCorrectResult(string res,bool expected)
        {

            //arrange
            var test = new Theory_InlineData();
            //act
            var str = test.isPalindrome(res);
            //assert
            Assert.Equal(expected, str);
        }
    }
}
