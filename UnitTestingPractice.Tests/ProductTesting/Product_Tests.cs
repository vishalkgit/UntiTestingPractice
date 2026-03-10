using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Model;
using UnitTestingPractice.Repository;
using UnitTestingPractice.Services;
using Xunit;

namespace UnitTestingPractice.Tests.ProductTesting
{
    public class Product_Tests
    {

        [Fact]
        public void GetProductById_ReturnCorrectResult()
        {
            //arrange
            var mockrepo = new Mock<IProductRepository>();
            mockrepo.Setup(x => x.GetProduct(2))
                .Returns(new Model.Product { Id = 2, Name = "Pendrive" });

            var service = new ProductService(mockrepo.Object);

            //act
            var test = service.GetproductById(2);
            //assert
            Assert.Equal(2, test.Id);

        }

        [Fact]
        public void DelProductById_ReturnCorrectResult()
        {
            //arrange
            var mockrepo = new Mock<IProductRepository>();

            mockrepo.Setup(x => x.DelProduct(2))
                .Returns(new Product { Id = 2, Name = "Penicl" });

            var service = new Product_Del(mockrepo.Object);

            //act
            var test = service.DeleteProduct(2);
            //assert
            Assert.Equal(2, test.Id);


        }

    }
}
