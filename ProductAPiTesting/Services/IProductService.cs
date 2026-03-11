using ProductAPiTesting.Model;

namespace ProductAPiTesting.Services
{
    public interface IProductService
    {
        List<Product> Getall();

        Product GetById(int id);

        Product Add(Product product);
    }
}
