using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.DataAccess.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.Description)
            .HasMaxLength(2000);

        builder.Property(p => p.Price)
            .HasPrecision(18, 2);

        builder.Property(p => p.IsActive)
            .HasDefaultValue(true);

        builder.Property(p => p.DeletedBy)
            .HasMaxLength(100);

        builder.Property(p => p.IsDeleted)
            .HasDefaultValue(false);
        
        builder.Property(e => e.CreatedBy)
            .HasMaxLength(100);

        builder.Property(e => e.LastModifiedBy)
            .HasMaxLength(100);

        builder.HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(p => p.Name);
        builder.HasIndex(p => p.CategoryId);
        builder.HasIndex(p => new { p.CategoryId, p.Price });
    }
}