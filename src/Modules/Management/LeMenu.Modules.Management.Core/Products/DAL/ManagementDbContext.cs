using LeMenu.Modules.Management.Core.Products.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeMenu.Modules.Management.Core.Products.DAL;

internal class ManagementDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Extra> Extras { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    public ManagementDbContext(DbContextOptions<ManagementDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("management");
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}