using LeMenu.Modules.Management.Core.Products.Domain.Entities;
using LeMenu.Shared.Abstractions.Kernel.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeMenu.Modules.Management.Core.Products.DAL.Configurations;

internal class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("products");

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(50);
        
        builder.Property(x => x.Description)
            .IsRequired()
            .HasMaxLength(100);
        
        builder.Property(x => x.Photo)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(x => x.Available)
            .IsRequired();
        
        builder.Property(x => x.Disabled)
            .IsRequired();

        builder.Property(x => x.Price)
            .IsRequired()
            .HasConversion(x => x.Value, x => new Price(x));
    }
}