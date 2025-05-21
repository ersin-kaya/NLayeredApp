using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredApp.Core.Common;

namespace NLayeredApp.Repository.Configurations;

public abstract class AuditableEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : AuditableEntity
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.Property(e => e.CreatedBy)
            .HasMaxLength(100);

        builder.Property(e => e.LastModifiedBy)
            .HasMaxLength(100);
    }
}