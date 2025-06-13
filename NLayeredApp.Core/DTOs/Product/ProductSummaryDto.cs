namespace NLayeredApp.Core.DTOs.Product;

public record ProductSummaryDto
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public decimal Price { get; init; }
    public int Stock { get; init; }
    public bool InStock => Stock > 0;

    public ProductSummaryDto() { }

    public ProductSummaryDto(int id, string name, decimal price, int stock)
    {
        Id = id;
        Name = name;
        Price = price;
        Stock = stock;
    }
}