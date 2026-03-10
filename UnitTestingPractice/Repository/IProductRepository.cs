using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPractice.Model;

namespace UnitTestingPractice.Repository
{
    public interface IProductRepository
    {
        Product GetProduct(int id);

        Product DelProduct(int id);
    }
}
