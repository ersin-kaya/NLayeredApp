namespace NLayeredApp.Core.DTOs.Product;

public record UpdateProductRequest
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public decimal Price { get; init; }
    public int Stock { get; init; }
    public bool IsActive { get; init; }
    public int CategoryId { get; init; }
    
    public UpdateProductRequest() { }

    public UpdateProductRequest(int id, string name, string? description, decimal price, 
        int stock, bool isActive, int categoryId)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        IsActive = isActive;
        CategoryId = categoryId;
    }
}