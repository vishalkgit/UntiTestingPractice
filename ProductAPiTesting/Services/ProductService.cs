using ProductAPiTesting.Model;
using ProductAPiTesting.Repositories;

namespace ProductAPiTesting.Services
{


    public class ProductService : IProductService
    {

        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public Product Add(Product product)
        {
            return _repo.Add(product);
        }

        public List<Product> Getall()
        {
            return _repo.Getall();
        }

        public Product GetById(int id)
        {
            return _repo.GetById(id);
        }
    }
}
