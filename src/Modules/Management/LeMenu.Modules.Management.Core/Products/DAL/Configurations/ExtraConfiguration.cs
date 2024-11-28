using LeMenu.Modules.Management.Core.Products.Domain.Entities;
using LeMenu.Shared.Abstractions.Kernel.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeMenu.Modules.Management.Core.Products.DAL.Configurations;

internal class ExtraConfiguration : IEntityTypeConfiguration<Extra>
{
    public void Configure(EntityTypeBuilder<Extra> builder)
    {
        builder.ToTable("extras");

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(30);
        
        builder.Property(x => x.Available)
            .IsRequired();
        
        builder.Property(x => x.Disabled)
            .IsRequired();

        builder.Property(x => x.Price)
            .IsRequired()
            .HasConversion(x => x.Value, x => new Price(x));
    }
}