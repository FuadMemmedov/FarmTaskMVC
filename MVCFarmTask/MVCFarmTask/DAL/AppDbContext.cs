using Microsoft.EntityFrameworkCore;
using MVCFarmTask.Models;

namespace MVCFarmTask.DAL;

public class AppDbContext:DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Worker> Workers { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
            
    }

}
