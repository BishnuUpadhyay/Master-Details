using Master.Models;
using Microsoft.EntityFrameworkCore;

namespace Master.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)   {   }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Item> Items { get; set; } 

        public DbSet<Master.Models.SaleInvoiceDTO> SaleInvoiceDTO { get; set; } = default!;
    }
}
