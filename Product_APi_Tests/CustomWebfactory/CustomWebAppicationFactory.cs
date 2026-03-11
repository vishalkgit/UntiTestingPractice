using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using ProductAPiTesting.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_APi_Tests.CustomWebfactory
{
    public class CustomWebAppicationFactory:WebApplicationFactory<Program>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(Services =>
            {
                var descriptor = Services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<ApplicationDBContext>));

                if (descriptor != null)
                    Services.Remove(descriptor);

                Services.AddDbContext<ApplicationDBContext>(options =>
                {
                    options.UseInMemoryDatabase("TestDb");
                });
            });
        }

    }
}
