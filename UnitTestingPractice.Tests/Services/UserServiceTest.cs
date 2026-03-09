using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Interfaces;
using UnitTestingPractice.Services;
using Xunit;

namespace UnitTestingPractice.Tests.Services
{
    public class UserServiceTest
    {
        [Fact]
        public void GetUserName_ReturnCorrectName()
        {
            //arrange
            var mockrepo = new Mock<IUserRepository>();

            mockrepo.Setup(x => x.UserName(1))
                .Returns("Vishal");

            var service = new UserService(mockrepo.Object);

            //act
            var res = service.GetUserName(1);

            //assert
            Assert.Equal("Vishal", res);
        }
    }
}
