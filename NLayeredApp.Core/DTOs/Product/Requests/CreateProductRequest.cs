namespace NLayeredApp.Core.DTOs.Product.Requests;

public record CreateProductRequest
{
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public decimal Price { get; init; }
    public int Stock { get; init; }
    public int CategoryId { get; init; }

    public CreateProductRequest() { }

    public CreateProductRequest(string name, string? description, decimal price, int stock, int categoryId)
    {
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        CategoryId = categoryId;
    }
}