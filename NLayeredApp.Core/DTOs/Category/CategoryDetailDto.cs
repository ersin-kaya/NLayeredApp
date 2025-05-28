namespace NLayeredApp.Core.DTOs.Category;

public record CategoryDetailDto
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

    public CategoryDetailDto() { }

    public CategoryDetailDto(int id, string name, string? description, bool isActive,
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