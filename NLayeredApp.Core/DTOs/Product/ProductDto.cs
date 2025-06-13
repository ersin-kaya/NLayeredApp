namespace NLayeredApp.Core.DTOs.Product;

public record ProductDto
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public decimal Price { get; init; }
    public int Stock { get; init; }
    public bool IsActive { get; init; }
    public int CategoryId { get; init; }
    public string CategoryName { get; init; } = string.Empty;
    public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset? LastModifiedAt { get; init; }
    public bool InStock => Stock > 0;
    
    public ProductDto() { }

    public ProductDto(int id, string name, string? description, decimal price,
        int stock, bool isActive, int categoryId, string categoryName,
        DateTimeOffset createdAt, DateTimeOffset? lastModifiedAt)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        IsActive = isActive;
        CategoryId = categoryId;
        CategoryName = categoryName;
        CreatedAt = createdAt;
        LastModifiedAt = lastModifiedAt;
    }
}