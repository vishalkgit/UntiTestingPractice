using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Services;
using Xunit;

namespace UnitTestingPractice.Tests.Services
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_ReturnCorrectSum()
        {
            //Arrange:Create Object or Prepare Object
            var calculator = new Calculator();

            //Act:Call Method
            var res = calculator.Add(2, 3);

            //Assert:Check Result
            Assert.Equal(5,res);

        }

        [Fact]
        public void Divide_ReturnCorrectResult()
        {
            //arrange
            var calculator = new Calculator();

            //act
            var res = calculator.Divide(4, 2);

            //assert
            Assert.Equal(2, res);
        }

        [Fact]
        public void Multiply_ReturnCorrectResult()
        {
            //arrange;
            var calculator = new Calculator();

            //act
            var res = calculator.Multiply(4, 2);

            //assert
            Assert.Equal(8, res);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            var calculator = new Calculator();

            Assert.Throws<Exception>(() => calculator.Divide(10, 0));
        }

        [Fact]
        public void Subtract_ReturnCorrectResult()
        {
            //arange
            var calculator = new Calculator();

            //act
            var res = calculator.Subtract(5, 3);

            //assert
            Assert.Equal(2, res);
        }

        [Fact]
        public void IsEven_ReturnCorrectResult()
        {
            //arrange
            var calculator = new Calculator();

            //act
            var res = calculator.IsEven(4);

            //assert
            Assert.Equal(4, res);
        }
    }
}
