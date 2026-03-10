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
    public class ProductControllerTests
    {

        [Fact]
        // Test method to verify that GetProduct returns the correct result
        public void GetProduct_ReturnCorrectResult()
        {
            // Create a mock (fake) implementation of IProductService using Moq
            var mockservice = new Mock<IProductService>();

            // Configure the mock: when GetProduct(1) is called, return a Product object
            mockservice.Setup(x => x.GetProduct(1))
                .Returns(new Product { Id = 0, Name = "Pendrive" });

            // Create an instance of ProductController and inject the mocked service
            // mockservice.Object gives the fake implementation of IProductService
            var controller = new ProductController(mockservice.Object);

            // Call the controller method we want to test
            // This internally calls the mocked service
            var resut = controller.GetProduct(1);

            // Verify that the result returned from the controller is of type OkObjectResult (HTTP 200 response)
            var okResult = Assert.IsType<OkObjectResult>(resut);

            // Extract the object stored inside the OkObjectResult
            // Also verify that the returned object is of type Product
            var product = Assert.IsType<Product>(okResult.Value);

            // Verify that the Name property of the returned product is "Pendrive"
            // If it is not, the test will fail
            Assert.Equal("Pendrive", product.Name);
        }
    }
}
