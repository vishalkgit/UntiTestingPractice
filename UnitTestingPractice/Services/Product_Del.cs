using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Model;
using UnitTestingPractice.Repository;

namespace UnitTestingPractice.Services
{
    public class Product_Del
    {
        private readonly IProductRepository _repo;

        public Product_Del(IProductRepository repo)
        {
            _repo = repo;
        }

        public Product DeleteProduct(int id)
        {
            if (id <= 0)
                 throw new ArgumentException("Id is Invalid, Please Enter correct Id");
            return _repo.DelProduct(id);
        }
    }
}
