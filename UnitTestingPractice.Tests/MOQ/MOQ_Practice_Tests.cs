using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Model;
using UnitTestingPractice.MOQ;
using UnitTestingPractice.Services;
using UnitTestingPractice.Tests.Services;
using Xunit;

namespace UnitTestingPractice.Tests.MOQ
{
    public class MOQ_Practice_Tests
    {

        [Fact]
        public void GetUser_ReturnUser_WhenUserExists()
        {
            //arrange
            var mockrepo = new Mock<IUserRepository>();

            mockrepo.Setup(x => x.GetUserById(1))
                .Returns(new User { Id = 1, Name = "Vishal" });

            var service = new MOQ_UserService(mockrepo.Object);

            //act
            var res = service.getUser(1);

            //Assert
            Assert.Equal("Vishal", res.Name);
        }

        [Fact]
        public void Add_ReturnCorrectResult()
        {
            //arrange
            var mockrepo = new Mock<IUserRepository>();

            mockrepo.Setup(x => x.Add(2, 3)).Returns(5);

            var service = new MOQ_ADD(mockrepo.Object);
            //act
            var res = service.Add(2, 3);
            //assert
            Assert.Equal(5, res);
        }

        [Fact]
        public void Sub_ReturnCorrectResult()
        {
            //arrange
            var mockrepo = new Mock<IUserRepository>();

            mockrepo.Setup(x => x.Sub(5, 2)).Returns(3);

            var service = new MOQ_Sub(mockrepo.Object);
            //act
            var res = service.Sub(5, 2);
            //assert
            Assert.Equal(3, res);
        }

        [Fact]
        public void Mul_ReturnCorrectResult()
        {
            //arrange
            var mockrepo =new Mock<IUserRepository>();
            mockrepo.Setup(x => x.Mul(5, 4)).Returns(20);

            var service = new MUQ_Mul(mockrepo.Object);

            //act
            var test = service.Multiply(5, 4);
            //assert
            Assert.Equal(20, test);
        }
    }
}
