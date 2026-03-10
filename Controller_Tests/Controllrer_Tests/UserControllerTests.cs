using Controller_Testing_Proj.Controllers;
using Controller_Testing_Proj.Model;
using Controller_Testing_Proj.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller_Tests.Controllrer_Tests
{
    public class UserControllerTests
    {

        [Fact]
        public void GetUser_ReturnCorrectResult()
        {
            var mockservice = new Mock<IUserReposittory>();
            mockservice.Setup(x => x.GetUser(1))
                .Returns(new User { Id = 1, Name = "vishal" });

            var okres = new UserController(mockservice.Object);

            var test = Assert.IsType<OkObjectResult>(okres);
            var okr = Assert.IsType<User>(test.Value);

            Assert.Equal("vishal", okr.Name);
        }

    }
}
