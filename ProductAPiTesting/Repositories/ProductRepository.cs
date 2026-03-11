using ProductAPiTesting.Data;
using ProductAPiTesting.Model;

namespace ProductAPiTesting.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDBContext _context;

        public ProductRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public Product Add(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
            return product;
        }

        public List<Product> Getall()
        {
            var res = _context.products.ToList();
            return res;
        }

        public Product GetById(int id)
        {
            return _context.products.FirstOrDefault(x => x.Id == id);
            
        }
    }
}
