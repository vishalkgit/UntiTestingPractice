using ProductAPiTesting.Model;

namespace ProductAPiTesting.Repositories
{
    public interface IProductRepository
    {

        List<Product> Getall();

        Product GetById(int id);

        Product Add(Product product);

    }
}
