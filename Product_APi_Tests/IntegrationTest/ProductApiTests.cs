using Azure;
using Product_APi_Tests.CustomWebfactory;
using ProductAPiTesting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Product_APi_Tests.IntegrationTest
{
    public class ProductApiTests:IClassFixture<CustomWebAppicationFactory>
    {

        private readonly HttpClient _client;

        public ProductApiTests(CustomWebAppicationFactory factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetAllProducts_returnsOk()
        {
            var res = await _client.GetAsync("/api/products");
            var body = await res.Content.ReadAsStringAsync();
            Console.WriteLine(body);
            Assert.Equal(HttpStatusCode.OK, res.StatusCode);
        }


        [Fact]
        public async Task CreateProduct_returnCreate()
        {
            var product = new Product
            {
                
                Name = "Pendrrive",
                Price = 550
            };

            var response = await _client.PostAsJsonAsync("/api/products", product);
            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }

        [Fact]
        public async Task GetProduct_ReturnsProduct()
        {
            var product = new Product
            {
                Name = "Phone",
                Price = 20000
            };

            await _client.PostAsJsonAsync("/api/products", product);

            var response = await _client.GetAsync("/api/products/1");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
