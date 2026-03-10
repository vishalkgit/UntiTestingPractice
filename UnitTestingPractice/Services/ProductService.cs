using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Model;
using UnitTestingPractice.Repository;

namespace UnitTestingPractice.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public Product GetproductById(int id)
        {
            if (id < 0)
                throw new ArgumentException("Invalid id");
            return _repo.GetProduct(id);
        }

    }
}
