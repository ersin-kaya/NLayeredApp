using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredApp.Core.Constants;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.DataAccess.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(ApplicationConstants.ProductNameMaxLength);

        builder.Property(p => p.Description)
            .HasMaxLength(ApplicationConstants.ProductDescriptionMaxLength);

        builder.Property(p => p.Price)
            .HasPrecision(ApplicationConstants.ProductPricePrecision, ApplicationConstants.ProductPriceScale);

        builder.Property(p => p.IsActive)
            .HasDefaultValue(ApplicationConstants.ProductIsActive);

        builder.Property(p => p.DeletedBy)
            .HasMaxLength(ApplicationConstants.DeletedByMaxLength);

        builder.Property(p => p.IsDeleted)
            .HasDefaultValue(ApplicationConstants.ProductIsDeleted);
        
        builder.Property(e => e.CreatedBy)
            .HasMaxLength(ApplicationConstants.CreatedByMaxLength);

        builder.Property(e => e.LastModifiedBy)
            .HasMaxLength(ApplicationConstants.LastModifiedByMaxLength);

        builder.HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(p => p.Name);
        builder.HasIndex(p => p.CategoryId);
        builder.HasIndex(p => new { p.CategoryId, p.Price });
    }
}