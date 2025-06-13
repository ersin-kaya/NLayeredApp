using NLayeredApp.Core.DTOs.Category;

namespace NLayeredApp.Core.DTOs.Product.Responses;

public record ProductDetailDto
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public decimal Price { get; init; }
    public int Stock { get; init; }
    public bool IsActive { get; init; }
    public CategoryDto Category { get; init; } = null!;
    public DateTimeOffset CreatedAt { get; init; }
    public string? CreatedBy { get; init; }
    public DateTimeOffset? LastModifiedAt { get; init; }
    public string? LastModifiedBy { get; init; }
    public DateTimeOffset? DeletedAt { get; init; }
    public string? DeletedBy { get; init; }
    public bool IsDeleted { get; init; }
    public bool InStock => Stock > 0;

    public ProductDetailDto() { }

    public ProductDetailDto(int id, string name, string? description, decimal price,
        int stock, bool isActive, CategoryDto category, DateTimeOffset createdAt, string? createdBy,
        DateTimeOffset? lastModifiedAt, string? lastModifiedBy, 
        DateTimeOffset? deletedAt, string? deletedBy, bool isDeleted)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        IsActive = isActive;
        Category = category;
        CreatedAt = createdAt;
        CreatedBy = createdBy;
        LastModifiedAt = lastModifiedAt;
        LastModifiedBy = lastModifiedBy;
        DeletedAt = deletedAt;
        DeletedBy = deletedBy;
        IsDeleted = isDeleted;
    }
}