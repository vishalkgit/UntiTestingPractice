using Microsoft.EntityFrameworkCore;
using ProductAPiTesting.Model;

namespace ProductAPiTesting.Data
{
    public class ApplicationDBContext:DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> op):base(op)
        {
            
        }

        public DbSet<Product> products { get; set; }
    }
}
