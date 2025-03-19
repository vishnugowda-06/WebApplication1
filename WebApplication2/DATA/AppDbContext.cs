using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.DATA
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Product> Products { get; set; }
    }
}
