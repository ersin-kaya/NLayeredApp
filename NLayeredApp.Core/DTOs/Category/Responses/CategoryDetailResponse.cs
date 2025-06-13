using NLayeredApp.Core.DTOs.Product.Responses;

namespace NLayeredApp.Core.DTOs.Category.Responses;

public record CategoryDetailResponse
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public bool IsActive { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
    public string? CreatedBy { get; init; }
    public DateTimeOffset? LastModifiedAt { get; init; }
    public string? LastModifiedBy { get; init; }
    public List<ProductSummaryDto> Products { get; init; } = new();
    public int ProductCount => Products.Count;

    public CategoryDetailResponse() { }

    public CategoryDetailResponse(int id, string name, string? description, bool isActive,
        DateTimeOffset createdAt, string? createdBy, 
        DateTimeOffset? lastModifiedAt, string? lastModifiedBy,
        List<ProductSummaryDto> products)
    {
        Id = id;
        Name = name;
        Description = description;
        IsActive = isActive;
        CreatedAt = createdAt;
        CreatedBy = createdBy;
        LastModifiedAt = lastModifiedAt;
        LastModifiedBy = lastModifiedBy;
        Products = products;
    }
}